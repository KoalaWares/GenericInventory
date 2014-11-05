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
    public partial class FormSales : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormSales()
        {
            InitializeComponent();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormInventory a = new FormInventory();
            this.Close();
            a.Show();
        }
    }
}