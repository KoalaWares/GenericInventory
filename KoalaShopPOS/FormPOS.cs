using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KoalaShopPOS
{
    public partial class FormPOS : DevExpress.XtraEditors.XtraForm
    {
        public FormPOS()
        {
            InitializeComponent();
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit8_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            FormChangePass a = new FormChangePass();
            a.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormLogin a = new FormLogin();
            this.Close();
            a.Show();
        }
    }
}