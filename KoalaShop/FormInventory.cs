using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


//Import sa KoalaShop
using KoalaShopLib;
using KoalaShopLib.Models;

namespace KoalaShop
{
    public partial class FormInventory : DevExpress.XtraEditors.XtraForm
    {
        //declare ug main form para ma access ang main form dre
        MainForm mainForm;

        /// <summary>
        /// Naay mainform nga parameter para ma inject ang main form
        /// </summary>
        public FormInventory( MainForm form)
        {
            InitializeComponent();
            //set sa Mainform
            this.mainForm = form;
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl1.Text = DateTime.Now.ToString();
        }

        private void tileItemCategory_ItemClick(object sender, TileItemEventArgs e)
        {
            this.mainForm.ChildFormInitializer(FormTypes.Category);
        }

        private void tileCustomer_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            this.mainForm.ChildFormInitializer(FormTypes.Customer);
        }

        private void tileExpenses_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            this.mainForm.ChildFormInitializer(FormTypes.Expenses);
        }

        private void tileEmployee_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            this.mainForm.ChildFormInitializer(FormTypes.Employee);
        }

        private void tilePos_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            this.mainForm.ChildFormInitializer(FormTypes.POS);
        }

        private void tileEmployee_ItemClick(object sender, TileItemEventArgs e)
        {
            this.mainForm.ChildFormInitializer(FormTypes.Employee);
        }

        private void tileSupplier_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            this.mainForm.ChildFormInitializer(FormTypes.Supplier);
        }

        private void tileOptions_ItemDoubleClick(object sender, TileItemEventArgs e)
        {

        }
    }
}