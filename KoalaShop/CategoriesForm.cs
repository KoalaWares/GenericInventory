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
    public partial class CategoriesForm : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {
        private DataGridFormController controller;

        public CategoriesForm()
        {
            InitializeComponent();
            this.RefreshList();
            this.controller = new DataGridFormController(this.simpleButtonSave, this.checkButtonIsNew, this.gridView1, this);
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
            string id = this.controller.GetSelectedObjectID();

            using (IKoalaShop koalaShop = KoalaShopFactory.CreateKoalaShop())
            {
                var selectedObject = koalaShop.CategoryRepo.GetAll().Where(c => c.ID == Int32.Parse(id)).SingleOrDefault();

                if(selectedObject != null)
                {
                    this.textEditName.Text = selectedObject.Name;
                }
            }
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
                if (this.controller.IsNewObject)
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
            this.controller.ToggleNewObjectButton();
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            MapSelectedObjectToDetailsPane();
        }
    }
}