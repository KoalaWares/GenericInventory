using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using System.Threading;

using KoalaShopLib;
using KoalaShopLib.Models;
using KoalaShopLib.Models.ViewModel;
using System.Linq;

namespace KoalaShop
{
    public partial class FormSupplier : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {
        //Declare DataGridFormController
        private DataGridFormController formController;
       // MainForm mainform;
      


        public FormSupplier(MainForm form)
        {
            InitializeComponent();
            //para ma set ang data sa datgrid
            this.RefreshList();
            //para ma control sa formController ang button save,tbutton new ug datagrid
            this.formController = new DataGridFormController(this.simpleButtonUpdate, this.simpleButtonSave, this.checkButtonIsNew, this.gridView1, this);
            //para ma.display ang save button instead sa update button.
            this.formController.ToggleNewObjectButton();
        }


        #region Defined Methods
        /// <summary>
        /// Refreshes/updates data list and grid view.
        /// </summary>
        public void RefreshList()
        {
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                this.gridControl1.DataSource = koala.SupplierRepo.GetAll();
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
                var selectedObject = koalaShop.SupplierRepo.GetAll().Where(c => c.ID == Int32.Parse(id)).SingleOrDefault();

                if (selectedObject != null)
                {
                    this.textName.Text = selectedObject.Name;
                    this.textAddress.Text = selectedObject.Address;
                    this.textContact.Text = selectedObject.Contact;
                    this.formController.UpdateObjectButton();


                }
            }
        }

        /// <summary>
        /// Save sa object sa db.
        /// </summary>
        public void SaveObjectToDB()
        {
            Supplier supplier = new Supplier();

            supplier.Name = textName.Text;
            supplier.Address = textAddress.Text;
            supplier.Contact = textContact.Text;


            //Validation
            if (supplier.Name == "" || supplier.Address == "" || supplier.Contact == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {

                koala.SupplierRepo.Add(supplier);
                MessageBox.Show("Saved!");
             
                TextboxSetToNull();


            }
            //Refresh list to update view.
            RefreshList();
        }

        public void UpdateObjectToDB()
        {
            Supplier supplier = new Supplier();

            supplier.Name = textName.Text;
            supplier.Address = textAddress.Text;
            supplier.Contact = textContact.Text;


            //Validation
            if (supplier.Name == "" || supplier.Address == "" || supplier.Contact == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {

                try
                {
                    supplier.ID = int.Parse(this.formController.GetSelectedObjectID());
                    koala.SupplierRepo.Update(supplier);
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

            this.textName.Text = "";
            this.textContact.Text = "";
            this.textAddress.Text = "";

          

        }

        public void UpperCaseName()
        {
            int TextLength = textName.Text.Length;
            if (TextLength == 1)
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textName.Text = textInfo.ToTitleCase(textName.Text);
                textName.SelectionStart = 1;
            }
            else if (TextLength > 1 && textName.SelectionStart < TextLength)
            {
                int x = textName.SelectionStart;
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textName.Text = textInfo.ToTitleCase(textName.Text);
                textName.SelectionStart = x;
            }
            else if (TextLength > 1 && textName.SelectionStart >= TextLength)
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textName.Text = textInfo.ToTitleCase(textName.Text);
                textName.SelectionStart = TextLength;
            }
        }

        public void UpperCaseAddress()
        {
            int TextLength = textAddress.Text.Length;
            if (TextLength == 1)
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textAddress.Text = textInfo.ToTitleCase(textAddress.Text);
                textAddress.SelectionStart = 1;
            }
            else if (TextLength > 1 && textAddress.SelectionStart < TextLength)
            {
                int x = textAddress.SelectionStart;
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textAddress.Text = textInfo.ToTitleCase(textAddress.Text);
                textAddress.SelectionStart = x;
            }
            else if (TextLength > 1 && textAddress.SelectionStart >= TextLength)
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textAddress.Text = textInfo.ToTitleCase(textAddress.Text);
                textAddress.SelectionStart = TextLength;
            }
        }
        #endregion
   

     
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MapSelectedObjectToDetailsPane();
        }

        private void checkButtonIsNew_CheckedChanged_1(object sender, EventArgs e)
        {
            this.formController.ToggleNewObjectButton();
        }

        private void simpleButtonUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateObjectToDB();
        }

        private void simpleButtonSave_Click_1(object sender, EventArgs e)
        {
            SaveObjectToDB();
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperCaseName();
        }

        private void textAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperCaseAddress();
        }
    }
}