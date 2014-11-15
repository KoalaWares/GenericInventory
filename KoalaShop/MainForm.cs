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
using System.Linq;
namespace KoalaShop
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm, IMainForm
    {
        public Account CurrenUser { get; set; }
        public int empID { get; set; }

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
            
            
            //DRE ang checking unsa ng account den display sa form
            switch (this.CurrenUser.AccountType)
            {
                case AccountType.Admin:
                    ChildFormInitializer(FormTypes.Inventory);
                    break;
                case AccountType.Cashier:
                    ChildFormInitializer(FormTypes.POS);
                    break;
                case AccountType.Purchaser:
                    break;
            }


        }

        #region Defined Methods
        /// <summary>
        /// Dispose all child forms.
        /// </summary>
        private void KillChildren()
        {
            foreach (var i in this.MdiChildren)
            {
                //dre mg add sa form type dli ipa close
                if (i.GetType() != typeof(FormInventory) && i.GetType() != typeof(FormPOS))
                {
                    i.Dispose();
                }
            }
        }

        /// <summary>
        /// Initializes and displays specified child form.
        /// </summary>
        public void ChildFormInitializer(FormTypes formType)
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
                    form = new FormCustomer();
                    break;
                case FormTypes.Employee:
                    form = new FormEmployee();
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
                    form = new FormSupplier();
                    break;
                case FormTypes.Inventory:
                    form = new FormInventory(this);
                    break;
                case FormTypes.POS:
                    form = new FormPOS();
                    break;
                case FormTypes.Expenses:
                    form = new FormExpenses();
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

    }
}