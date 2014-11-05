using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

using KoalaShopLib;
using KoalaShopLib.Models;
namespace KoalaShop
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm, IMainForm
    {
        public Account CurrenUser { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.splashScreenManager1.ShowWaitForm();

            //display login form
            using (var loginForm = new LoginForm())
            {
                loginForm.MainForm = this;
                loginForm.ShowDialog();
            }

            //check if userAccount is null
            if (this.CurrenUser == null)
            {
                MessageBox.Show("Closing Application");
                Environment.Exit(0);
            }

            //hide all ribbon page
            foreach (DevExpress.XtraBars.Ribbon.RibbonPage item in this.ribbon.Pages)
            {
                item.Visible = false;
            }

            switch (this.CurrenUser.AccountType)
            {
                case AccountType.Admin:
                    //this.ribbon.Pages.GetPageByName("ribbonPageInventory").Visible = true;
                    //this.ribbon.Pages.GetPageByName("ribbonPageCRM").Visible = true;
                    //this.ribbon.Pages.GetPageByName("ribbonPageReports").Visible = true;
                    //this.ribbon.Pages.GetPageByName("ribbonPageEmployeeManagement").Visible = true;
                    //this.ribbon.Pages.GetPageByName("ribbonPageAccount").Visible = true;
                    ChildFormInitializer(FormTypes.Inventory);
                    break;
                case AccountType.Cashier:
                    this.ribbon.Pages.GetPageByName("ribbonPagePOS").Visible = true;
                    this.ribbon.Pages.GetPageByName("ribbonPageAccount").Visible = true;
                    break;
                case AccountType.Purchaser:
                    this.ribbon.Pages.GetPageByName("ribbonPageInventory").Visible = true;
                    this.ribbon.Pages.GetPageByName("ribbonPageAccount").Visible = true;
                    break;
            }


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

            
            //Add Inventory Form
            FormInventory inventory = new FormInventory();
            inventory.MdiParent = this;
            inventory.Show();
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
                case FormTypes.Inventory:
                    form = new FormInventory();
                    break;
                default:
                    form = new DevExpress.XtraEditors.XtraForm();
                    break;
                   
            }

            this.KillChildren();
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        //NOTE: Please Leave Event handlers here.
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItemSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Implement");
        }

        private void barButtonItemCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildFormInitializer(FormTypes.Category);
        }

        private void barButtonItemProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildFormInitializer(FormTypes.Product);
        }

        private void barButtonItemStocks_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Implement");
        }


    }
}