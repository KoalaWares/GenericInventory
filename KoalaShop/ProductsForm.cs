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
    /// <summary>
    /// Para display ra sa list sa products, dli para edit sa dsata
    /// </summary>
    public partial class ProductsForm : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {

        //Declare DataGridFormController
        private DataGridFormController formController;
        MainForm mainform;

        public ProductsForm(MainForm form)
        {
            InitializeComponent();
            //para ma set ang data sa datgrid
            this.RefreshList();
            //para ma control sa formController ang button save,tbutton new ug datagrid
            this.formController = new DataGridFormController(this.simpleButtonUpdate, this.simpleButtonSave, this.checkButtonIsNew, this.gridView1, this);
            //para ma.display ang save button instead sa update button.
            this.formController.ToggleNewObjectButton();
            this.mainform = form;

           

            
        }

        #region IDataGridForm Members

        

        public void RefreshList()
        {
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                this.gridControl1.DataSource = koala.GetProductsForView();
                this.gridControl1.DataSource = koala.StocksRequestRepo.GetAll(); ;

                //// TODO: This line of code loads data into the 'dataSet6.Categories' table. You can move, or remove it, as needed.
                //this.categoriesTableAdapter1.Fill(this.dataSet6.Categories);
                // TODO: This line of code loads data into the 'dataSet5.Suppliers' table. You can move, or remove it, as needed.
                //this.suppliersTableAdapter1.Fill(this.dataSet5.Suppliers);

                //Mas simple way, kay kung mg data set maypa wala ga EF.lantaw lage Tutorial sa EF Basics
                //http://www.codeproject.com/Articles/363040/An-Introduction-to-Entity-Framework-for-Absolute-B
                this.comboboxCategory.Properties.DataSource = koala.CategoryRepo.GetAll();
                this.comboboxCategory.Properties.DisplayMember = "Name";
                this.comboboxCategory.Properties.ValueMember = "ID";

                //
                this.comboBoxSupplier.Properties.DataSource = koala.SupplierRepo.GetAll();
                this.comboBoxSupplier.Properties.DisplayMember = "Name";
                this.comboBoxSupplier.Properties.ValueMember = "ID";
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

            string id = this.comboboxCategory.Text;
            string supplierID = this.comboBoxSupplier.Text;

            using (IKoalaShop koalaShop = KoalaShopFactory.CreateKoalaShop())
            {
                 var selectedObjectCategory = koalaShop.CategoryRepo.GetAll().Where(a => a.Name == id).SingleOrDefault();
                 var selectedObjectSupplier = koalaShop.SupplierRepo.GetAll().Where(a => a.Name == supplierID).SingleOrDefault();

                
                 

                if (selectedObjectCategory != null)
                {
                  
                    product.CategoryID = selectedObjectCategory.ID;
                }
                
                if (selectedObjectSupplier != null)
                {
                    stockrequest.SuppliersID = selectedObjectSupplier.ID;
                }

            }
            
           
            //Product
            product.BarCode = textEditBarCode.Text;
            product.Name = textEditName.Text;
            product.Weight = textEditWeight.Text;
            product.Variant = textEditVariant.Text;


            //Stocks
            stock.Quantity = stock.Quantity + Int32.Parse(textQuantity.Text);
      

            decimal price;
            Decimal.TryParse(textEditPrice.Text, out price);
            stock.Price = price;
         

            //StocksRequest
           
            stockrequest.Date = System.DateTime.Now;
            decimal costs;
            Decimal.TryParse(textCost.Text, out costs);
            stockrequest.Cost = costs;
            
            //convert to datetime
            DateTime dt = Convert.ToDateTime(dateExpires.Text);  
                
            stockrequest.ExpiresOn = dt;
            stockrequest.Quantity = Int32.Parse(textQuantity.Text);
            

            
            decimal total;
            Decimal.TryParse(textTotal.Text, out total);
            stockrequest.TotalCost = total;



            stockrequest.IsRecieved = true;

            stockrequest.QuantityRecieved = true;
         



            //Validation
                if (product.BarCode == "" || product.Name == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //    DB access
                using (var koala = KoalaShopFactory.CreateKoalaShop())
                {
                    //saving to product table
                    koala.ProductRepo.Add(product);

                    //adding ProductID to stock
                    stockrequest.ProductID = product.ID;
                    //adding employeeID to StockRequest
                    stockrequest.EmployeeID = this.mainform.CurrenUser.EmployeeID;

                    //saving to StocksRequested table
                    koala.StocksRequestRepo.Add(stockrequest);

                    //adding stocksrequestID to stock
                    stock.StocksRequestID = stockrequest.ID;
                    //adding ProductID to stock
                    stock.ProductID = product.ID;

                    //saving to stocks table
                    koala.StockRepo.Add(stock);

                    


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
            product.Weight = textEditWeight.Text;
            product.Variant = textEditVariant.Text;
           
         

            stock.Price = Decimal.Parse(textEditPrice.Text);
            stockrequest.Cost = Decimal.Parse(textCost.Text);
            stockrequest.Date = System.DateTime.Now;

            //convert to datetime
            DateTime dt = Convert.ToDateTime(dateExpires);

            //stockrequest.ExpiresOn = dt;
            stockrequest.Quantity = Int32.Parse(textQuantity.Text);
            stockrequest.TotalCost = Decimal.Parse(textTotal.Text);
         





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
           
           comboboxCategory.Text = "";
           textEditPrice.Text = "";
            textCost.Text = "";
            dateExpires.Text  = "";
            textQuantity.Text  = "";
            textTotal.Text  = "";
            comboBoxSupplier.Text = "";
        }

        public void getTotal()
        {

            double a, b;
            Double.TryParse(textQuantity.Text, out a);
            Double.TryParse(textCost.Text, out b);
            double textTotals = a * b;
            textTotal.Text = textTotals.ToString();
          
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            this.mainform.ChildFormInitializer(FormTypes.Supplier);
            
            
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            this.mainform.ChildFormInitializer(FormTypes.Category);
        }

        private void textCost_EditValueChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet7.Stocks' table. You can move, or remove it, as needed.
            //this.stocksTableAdapter.Fill(this.dataSet7.Stocks); TRY THIS


        }

      

       

       

       

       
    }
}