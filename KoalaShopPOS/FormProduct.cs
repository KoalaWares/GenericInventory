using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace KoalaShop
{
    public partial class FormProduct : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormProductAdd a = new FormProductAdd();
            a.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormProductChoice a = new FormProductChoice();
            a.ShowDialog();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }

        private void Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormInventory a = new FormInventory();
            this.Hide();
            a.Show();
        }
    }
}