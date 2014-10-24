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
    public partial class FormInventory : DevExpress.XtraEditors.XtraForm
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormProduct a = new FormProduct();
            this.Hide();
            a.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FormUser a = new FormUser();
            this.Hide();
            a.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FormCustomer a = new FormCustomer();
            this.Hide();
            a.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FormSupplier a = new FormSupplier();
            this.Hide();
            a.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FormPOS a = new FormPOS();
            this.Hide();
            a.Show();
        }
    }
}