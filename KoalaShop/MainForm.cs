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

            switch (this.CurrenUser.AccountType)
            {
                case AccountType.Admin:
                    this.CreateInventoryForms();
                    break;
                case AccountType.Cashier:
                    break;
                case AccountType.Purchaser:
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
        }


        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }


    }
}