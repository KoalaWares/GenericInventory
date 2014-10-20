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
    public partial class FormSupplierView : DevExpress.XtraEditors.XtraForm
    {
        public FormSupplierView()
        {
            InitializeComponent();
        }

        private void MenuView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void MenuAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSupplier a = new FormSupplier();
            this.Hide();
            a.Show();
            a.GroupAdd.Visible = true;
            a.GroupUpdate.Visible = false;
        }

        private void MenuUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSupplier a = new FormSupplier();
            this.Hide();
            a.Show();
           
        }
    }
}