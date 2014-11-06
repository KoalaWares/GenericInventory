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
    public partial class FormProductChoice : DevExpress.XtraEditors.XtraForm
    {
        public FormProductChoice()
        {
            InitializeComponent();
        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            FormProductStocks a = new FormProductStocks();
            this.Hide();
            a.ShowDialog();
        }

        private void UpdateInfo_Click(object sender, EventArgs e)
        {
            FormProductInfo a = new FormProductInfo();
            this.Hide();
            a.ShowDialog();
        }

        private void ViewMore_Click(object sender, EventArgs e)
        {
            FormProductMore a = new FormProductMore();
            this.Hide();
            a.ShowDialog();
        }
    }
}