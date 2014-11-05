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
    public partial class FormCustomerView : DevExpress.XtraEditors.XtraForm
    {
        public FormCustomerView()
        {
            InitializeComponent();
        }

        private void MenuAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCustomer a = new FormCustomer();
            this.Hide();
            a.Show();
            a.GroupUpdate.Visible = false;
        }

        private void MenuUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCustomer a = new FormCustomer();
            this.Hide();
            a.Show();
        }

        private void MenuView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridCustView.Refresh();
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormInventory a = new FormInventory();
            this.Close();
            a.Show();
        }
    }
}