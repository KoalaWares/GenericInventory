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
    public partial class FormCustomer : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {

        //Declare DataGridFormController
        private DataGridFormController formController;


        public FormCustomer()
        {
            InitializeComponent();
            //para ma set ang data sa datgrid
            this.RefreshList();
            //para ma control sa formController ang button save,tbutton new ug datagrid
            this.formController = new DataGridFormController(this.simpleButtonSave, this.checkButtonIsNew, this.gridView1, this);
        }

        #region Defined Methods
        /// <summary>
        /// Refreshes/updates data list and grid view.
        /// </summary>
        public void RefreshList()
        {
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                this.gridControl1.DataSource = koala.CustomerRepo.GetAll();
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
                var selectedObject = koalaShop.CustomerRepo.GetAll().Where(c => c.ID == Int32.Parse(id)).SingleOrDefault();

                if (selectedObject != null)
                {
                    this.textEditName.Text = selectedObject.Name;
                    this.textEditAddress.Text = selectedObject.Address;
                    


                }
            }
        }

        /// <summary>
        /// Save sa object sa db.
        /// </summary>
        public void SaveObjectToDB()
        {
            Customer customer = new Customer();

            customer.Name = textEditName.Text;
            customer.Address = textEditAddress.Text;

            //Validation
            if (customer.Name == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                if (this.formController.IsNewObject)
                {
                    koala.CustomerRepo.Add(customer);
                }
                else
                {
                    try
                    {
                        customer.ID = int.Parse(this.formController.GetSelectedObjectID());
                        koala.CustomerRepo.Update(customer);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something Went Wrong");
                        //throw;
                    }

                }
            }
            //Refresh list to update view.
            RefreshList();
        }
        #endregion
       
        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            MapSelectedObjectToDetailsPane();
        }

        private void checkButtonIsNew_CheckedChanged_1(object sender, EventArgs e)
        {
            this.formController.ToggleNewObjectButton();
            this.textEditAddress.Text = "";
            this.textEditName.Text = "";
        }

        private void simpleButtonSave_Click_1(object sender, EventArgs e)
        {
            SaveObjectToDB();
        }
    }
}