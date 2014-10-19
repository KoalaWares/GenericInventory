using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace POS_System
{
    public partial class FormUserView : DevExpress.XtraEditors.XtraForm
    {
        public FormUserView()
        {
            InitializeComponent();
        }

        private void MenuAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormUser a = new FormUser();
            this.Hide();
            a.Show();
        }

        private void MenuView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridEmployee.Refresh();
        }

        private void MenuView_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridEmployee.Refresh();
        }
    }
}