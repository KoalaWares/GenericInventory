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
    public partial class FormProductAdd : DevExpress.XtraEditors.XtraForm
    {
        public FormProductAdd()
        {
            InitializeComponent();
        }

        private void ProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}