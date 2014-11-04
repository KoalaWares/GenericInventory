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
namespace KoalaShop
{
    public partial class CategoriesForm : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {
        public bool IsNew { get; set; }

        public CategoriesForm()
        {
            InitializeComponent();
            this.RefreshList();
            this.IsNew = false;
        }

        #region Defined Methods
        /// <summary>
        /// Refreshes/updates data list and grid view.
        /// </summary>
        public void RefreshList()
        {
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                this.gridControl1.DataSource = koala.CategoryRepo.GetAll();
            }
        }

        /// <summary>
        /// Pakita sa details pane sa selected nga oject sa datagrid.
        /// </summary>
        public void MapSelectedObjectToDetailsPane()
        {
            var selectedObject = (Category)gridView1.GetFocusedRow();
            this.textEditName.Text = selectedObject.Name;
        }

        /// <summary>
        /// Pag e click ang new nga button tapad sa save sa object details pane.
        /// </summary>
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

        public string GetSelectedObjectID()
        {
            return gridView1.GetFocusedDataRow()["ID"].ToString();
        }

        /// <summary>
        /// Save sa object sa db.
        /// </summary>
        public void SaveObjectToDB()
        {
            Category category = new Category();
            category.ID = int.Parse(gridView1.GetFocusedDataRow()["ID"].ToString());
            category.Name = textEditName.Text;

            //Validation
            if( category.Name == "")
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
                    koala.CategoryRepo.Update(category);
                }
            }
            //Refresh list to update view.
            RefreshList();
        }
        #endregion

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            SaveObjectToDB();
        }

        private void checkButtonIsNew_CheckedChanged(object sender, EventArgs e)
        {
            ToggleNewObjectButton();
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            MapSelectedObjectToDetailsPane();
        }
    }
}