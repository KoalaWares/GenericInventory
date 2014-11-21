using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KoalaShopLib;
using KoalaShopLib.Models;


using KoalaShopLib.Models.ViewModel;
using System.Linq;

namespace KoalaShop
{
    public partial class ProductsForm : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {

        //Declare DataGridFormController
        private DataGridFormController formController;

        public ProductsForm()
        {
            InitializeComponent();
            //para ma set ang data sa datgrid
            this.RefreshList();
            //para ma control sa formController ang button save,tbutton new ug datagrid
            this.formController = new DataGridFormController(this.simpleButtonUpdate, this.simpleButtonSave, this.checkButtonIsNew, this.gridView1, this);
            //para ma.display ang save button instead sa update button.
            this.formController.ToggleNewObjectButton();
        }

        #region IDataGridForm Members

        

        public void RefreshList()
        {
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                this.gridControl1.DataSource = koala.GetProductsForView();
                this.gridControl1.DataSource = koala.StocksRequestRepo.GetAll(); ;

                this.textEditCategory.Properties.DataSource = koala.CategoryRepo.GetAll();
                this.textEditCategory.Properties.DisplayMember = "Name";
                this.textEditCategory.Properties.ValueMember = "ID";

                this.textSupplier.Properties.DataSource = koala.SupplierRepo.GetAll();
                this.textSupplier.Properties.DisplayMember = "Name";
                this.textSupplier.Properties.ValueMember = "ID";
            }
        }

       
        /// <summary>
        /// Pakita sa details pane sa selected nga oject sa datagrid.
        /// </summary>
        public void MapSelectedObjectToDetailsPane()
        {
            string id = this.formController.GetSelectedObjectID();

            using (IKoalaShop koalaShop = KoalaShopFactory.CreateKoalaShop())
            {
                var selectedObject = koalaShop.ProductRepo.GetAll().Where(c => c.ID == Int32.Parse(id)).SingleOrDefault();
                var selectedObjectCategory = koalaShop.CategoryRepo.GetAll().Where(a => a.ID == Int32.Parse(id)).SingleOrDefault();

                if (selectedObject != null)
                {

                    //this.textID.Text = selectedObject.ID.ToString();
                    //this.textFName.Text = selectedObject.Fname;
                    //this.textLname.Text = selectedObject.Lname;
                    //this.textAddress.Text = selectedObject.Address;
                    //this.textContact.Text = selectedObject.Contact;
                    //this.textPosition.Text = selectedObjectAccount.AccountType.ToString();
                    this.formController.UpdateObjectButton();

                }
            }
        }

        /// <summary>
        /// Save sa object sa db.
        /// </summary>
        public void SaveObjectToDB()
        {
            Product product = new Product();
            Category category = new Category();
            Stock stock = new Stock();
            StocksRequest stockrequest = new StocksRequest();

            product.BarCode = textEditBarCode.Text;
            product.Name = textEditName.Text;
            product.Weight = Decimal.Parse(textEditWeight.Text);
            product.Variant = textEditVariant.Text;
            product.Description = textEditDescription.Text;
            // product.CategoryID = textEditCategory.Text; -- unsaon pagkuha sa ID sa category :D

            stock.Price = Decimal.Parse(textEditPrice.Text);
            stockrequest.Cost = Decimal.Parse(textCost.Text);
            stockrequest.Date = System.DateTime.Now;
            
            //convert to datetime
            DateTime dt = Convert.ToDateTime(dateExpires);  
                
            stockrequest.ExpiresOn = dt;
            stockrequest.Quantity = Int32.Parse(textQuantity.Text);
            stockrequest.TotalCost = Decimal.Parse(textTotal.Text);
          //  stockrequest.SuppliersID = textSupplier.Text; -- get supplierID
               
         



            //Validation
                if (product.BarCode == "" || product.Name == "" || stock.Price == 0)
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                //saving to product table
                koala.ProductRepo.Add(product);

                //saving to stocks table
                koala.StockRepo.Add(stock);

                //saving to StocksRequested table
                koala.StocksRequestRepo.Add(stockrequest);


                MessageBox.Show("Saved!");


                TextboxSetToNull();

            }
            //Refresh list to update view.
            RefreshList();
        }

        public void UpdateObjectToDB()
        {
            Product product = new Product();
            Category category = new Category();
            Stock stock = new Stock();
            StocksRequest stockrequest = new StocksRequest();

            product.BarCode = textEditBarCode.Text;
            product.Name = textEditName.Text;
            product.Weight = Decimal.Parse(textEditWeight.Text);
            product.Variant = textEditVariant.Text;
            product.Description = textEditDescription.Text;
            // product.CategoryID = textEditCategory.Text; -- unsaon pagkuha sa ID sa category :D

            stock.Price = Decimal.Parse(textEditPrice.Text);
            stockrequest.Cost = Decimal.Parse(textCost.Text);
            stockrequest.Date = System.DateTime.Now;

            //convert to datetime
            DateTime dt = Convert.ToDateTime(dateExpires);

            stockrequest.ExpiresOn = dt;
            stockrequest.Quantity = Int32.Parse(textQuantity.Text);
            stockrequest.TotalCost = Decimal.Parse(textTotal.Text);
            //  stockrequest.SuppliersID = textSupplier.Text; -- get supplierID





            //Validation
            if (product.BarCode == "" || product.Name == "" || stock.Price == 0)
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {

                try
                {
                    product.ID = int.Parse(this.formController.GetSelectedObjectID());
                    //saving to product table
                    koala.ProductRepo.Add(product);

                    //saving to stocks table
                    koala.StockRepo.Add(stock);

                    //saving to StocksRequested table
                    koala.StocksRequestRepo.Add(stockrequest);
                    MessageBox.Show("Updated!");

                    TextboxSetToNull();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something Went Wrong");
                    //throw;
                }


            }

            //Refresh list to update view.
            RefreshList();
        }

        public void TextboxSetToNull()
        {
            //setting textboxes to null
            textEditBarCode.Text = "";
            textEditName.Text  = "";
            textEditWeight.Text = "";
            textEditVariant.Text  = "";
            textEditDescription.Text = "";
           textEditCategory.Text = "";
           textEditPrice.Text = "";
            textCost.Text = "";
            dateExpires.Text  = "";
            textQuantity.Text  = "";
            textTotal.Text  = "";
            textSupplier.Text = "";
        }
        #endregion


 


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MapSelectedObjectToDetailsPane();
        }

        private void checkButtonIsNew_CheckedChanged_2(object sender, EventArgs e)
        {
            this.formController.ToggleNewObjectButton();
        }

        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateObjectToDB();
        }

        private void simpleButtonSave_Click_1(object sender, EventArgs e)
        {
            SaveObjectToDB();
        }

        #region IDataGridForm Members


        #endregion
    }
}