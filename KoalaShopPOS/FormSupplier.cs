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
    public partial class FormSupplier : DevExpress.XtraEditors.XtraForm
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

        private void MenuAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GroupAdd.Visible = true;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void MenuUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GroupUpdate.Visible = true;
        }

        private void MenuView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSupplier a = new FormSupplier();
            this.Hide();
            a.Show();
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormInventory a = new FormInventory();
            this.Close();
            a.Show();
        }
    }
}