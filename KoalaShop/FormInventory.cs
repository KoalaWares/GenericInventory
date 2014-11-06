using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KoalaShop
{
    public partial class FormInventory : DevExpress.XtraEditors.XtraForm
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl1.Text = DateTime.Now.ToString();
        }

        private void tileItem4_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            FormProduct a = new FormProduct();
            this.Hide();
            a.Show();
        }

        private void tileItem6_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            FormUser a = new FormUser();
            this.Hide();
            a.Show();
        }

        private void tileItem3_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            FormSupplier a = new FormSupplier();
            this.Hide();
            a.Show();
        }

        private void tileItem2_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            FormPOS a = new FormPOS();
            this.Hide();
            a.Show();
        }

        private void tileSales_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            FormSales a = new FormSales();
            this.Hide();
            a.Show();
        }
    }
}