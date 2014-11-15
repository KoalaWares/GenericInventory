using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using KoalaShopLib;
using KoalaShopLib.Models;
namespace KoalaShop
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public IMainForm MainForm { get; set; }
        IKoalaShop koalaShop = null;

        public LoginForm()
        {
            InitializeComponent();
            this.koalaShop = KoalaShopFactory.CreateKoalaShop();
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
                this.MainForm.CurrenUser = koalaShop.Login(textEditUsername.Text.ToString(), textEditPassword.Text.ToString());


                if (this.MainForm.CurrenUser == null)
                {
                    MessageBox.Show("Wrong Username or password");
                }
                else
                {
                    this.Close();
                    this.Dispose();
                }
        }
    }
}