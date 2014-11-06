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
    public partial class FormInventory : DevExpress.XtraEditors.XtraForm
    {
        public FormInventory()
        {
            InitializeComponent();

           
        }
        #region Defined Methods
        /// <summary>
        /// Creates Child forms for inventory users
        /// </summary>
        private void CreateInventoryForms()
        {
            ProductsForm products = new ProductsForm();
            products.MdiParent = this;
            products.Show();

            //Add Category form
            CategoriesForm category = new CategoriesForm();
            category.MdiParent = this;
            category.Show();




            //Add POS Form
            FormPOS POS = new FormPOS();
            POS.MdiParent = this;
            POS.Show();


        }

        /// <summary>
        /// Dispose all child forms.
        /// </summary>
        void KillChildren()
        {
            foreach (var i in this.MdiChildren)
            {
                i.Dispose();
            }
        }

        /// <summary>
        /// Initializes and displays specified child form.
        /// </summary>
        private void ChildFormInitializer(FormTypes formType)
        {
            DevExpress.XtraEditors.XtraForm form = null;

            switch (formType)
            {
                case FormTypes.Category:
                    form = new CategoriesForm();
                    break;
                case FormTypes.Account:
                    break;
                case FormTypes.Customer:
                    break;
                case FormTypes.Employee:
                    break;
                case FormTypes.Invoice:
                    break;
                case FormTypes.InvoiceItem:
                    break;
                case FormTypes.Product:
                    form = new ProductsForm();
                    break;
                case FormTypes.Stock:
                    break;
                case FormTypes.StockRequest:
                    break;
                case FormTypes.Supplier:
                    break;
                
                case FormTypes.POS:
                    form = new FormPOS();
                    break;
                default:
                    form = new DevExpress.XtraEditors.XtraForm();
                    break;

            }

            this.KillChildren();
          
            form.Show();
        }
        #endregion

        private void FormInventory_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //FormProduct a = new FormProduct();
            //this.Hide();
            //a.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //FormUser a = new FormUser();
            //this.Hide();
            //a.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //FormCustomer a = new FormCustomer();
            //this.Hide();
            //a.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //FormSupplier a = new FormSupplier();
            //this.Hide();
            //a.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //FormPOS a = new FormPOS();
            //this.Hide();
            //a.Show();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl1.Text = DateTime.Now.ToString();
        }

        private void tileItem4_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            //FormProduct a = new FormProduct();
            //this.Hide();
            //a.Show();
        }

        private void tileItem6_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            //FormUser a = new FormUser();
            //this.Hide();
            //a.Show();
        }

        private void tileItem3_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            //FormSupplier a = new FormSupplier();
            //this.Hide();
            //a.Show();
        }

        private void tileItem2_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            //FormPOS a = new FormPOS();
            //this.Hide();
            //a.Show();
        }

        private void tileSales_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            //FormSales a = new FormSales();
            //this.Hide();
            //a.Show();
        }

        private void tilePos_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            ChildFormInitializer(FormTypes.POS);
        }
    }
}