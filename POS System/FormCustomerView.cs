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
        }

        private void MenuUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCustomer a = new FormCustomer();
            this.Hide();
            a.Show();
        }
    }
}