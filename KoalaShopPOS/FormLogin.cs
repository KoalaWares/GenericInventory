using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KoalaShopLib.Models;
using KoalaShopLib;
namespace KoalaShop
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        IKoalaShop koala = null;

        public FormLogin()
        {
            InitializeComponent();
            this.koala = KoalaShopFactory.CreateKoalaShop();
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            Account account = koala.Login(
                    textEditUsername.Text,
                    textEditPassword.Text);

            if (account == null)
            {
                MessageBox.Show("Wrong Username or Password.");
            }
            else
            {
                switch (account.AccountType)
                {
                    case AccountType.Admin:
                        FormInventory inventoryForm = new FormInventory();
                        this.Hide();
                        inventoryForm.Show();
                        break;
                    case AccountType.Cashier:
                        FormPOS POSForm = new FormPOS();
                        this.Hide();
                        POSForm.Show();
                        break;
                    case AccountType.Purchaser:
                        FormProduct productForm = new FormProduct();
                        this.Hide();
                        productForm.Show();
                        break;
                    //default:
                    //    break;
                }
            }
        }

    }
}