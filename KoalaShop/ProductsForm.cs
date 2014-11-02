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

namespace KoalaShop
{
    public partial class ProductsForm : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {
        public ProductsForm()
        {
            InitializeComponent();

            RefreshList();
        }

        #region IDataGridForm Members

        public bool IsNew
        {
            get;
            set;
        }

        public void RefreshList()
        {
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                this.gridControl1.DataSource = koala.GetProductsForView();

                this.textEditCategory.Properties.DataSource = koala.CategoryRepo.GetAll();
                this.textEditCategory.Properties.DisplayMember = "Name";
                this.textEditCategory.Properties.ValueMember = "ID";
            }
        }

        public void MapSelectedObjectToDetailsPane()
        {
            var selectedObject = (Category)gridView1.GetFocusedRow();
            this.textEditName.Text = selectedObject.Name;
        }

        public void ToggleNewObjectButton()
        {
            string saveButtonText = "Update";

            IsNew = !IsNew;

            if (IsNew)
            {
                saveButtonText = "Save";
                //Reset fields
                textEditName.Text = "";
            }

            simpleButtonSave.Text = saveButtonText;
        }

        public void SaveObjectToDB()
        {
            Category category = (Category)gridView1.GetFocusedRow();
            category.Name = textEditName.Text;

            //Validation
            if (category.Name == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                if (IsNew)
                {
                    koala.CategoryRepo.Add(category);
                }
                else
                {
                    MessageBox.Show("Naa pa problem");
                    //koala.CategoryRepo.Update(category);
                }
            }
            //Refresh list to update view.
            RefreshList();
        }

        #endregion


        private void simpleButtonSave_Click(object sender, EventArgs e)
        {

            RefreshList();
        }

        private void checkButtonIsNew_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            RefreshList();
        }
    }
}