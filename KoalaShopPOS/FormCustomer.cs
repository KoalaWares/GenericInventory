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
    public partial class FormCustomer : DevExpress.XtraEditors.XtraForm
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void MenuAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GroupAdd.Visible = true;
            GroupUpdate.Visible = false;
        }

        private void MenuUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GroupUpdate.Visible = true;
            GroupAdd.Visible = false;
        }

        private void MenuView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCustomerView a = new FormCustomerView();
            this.Hide();
            a.Show();
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLogin a = new FormLogin();
            this.Hide();
            a.Show();
        }
    }
}