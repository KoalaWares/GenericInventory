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
    public partial class FormChangePass : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {
        //Declare DataGridFormController
     
        MainForm form;
        string pass;
    
  
        

        public FormChangePass(MainForm mainform)
        {
            InitializeComponent();
            this.form = mainform;

           
        }

    

        #region Defined Methods
        /// <summary>
        /// Refreshes/updates data list and grid view.
        /// </summary>
        public void RefreshList()
        {
            //Not yet implemented.
        }

        /// <summary>
        /// Pakita sa details pane sa selected nga oject sa datagrid.
        /// </summary>
        public void MapSelectedObjectToDetailsPane()
        {
            //Not yet implemented.
        }

        /// <summary>
        /// Save sa object sa db.
        /// </summary>
        public void SaveObjectToDB()
        {
            
            Account account = new Account();

            account.Password = txtVerify.Text;


            //Validation
            if (account.Password == "" || txtOld.Text == "" || txtNew.Text == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }
            

            //searching for the username
            string id = this.form.CurrenUser.Username;

            using (IKoalaShop koalaShop = KoalaShopFactory.CreateKoalaShop())
            {
                var selectedObject = koalaShop.AccountRepo.GetAll().Where(c => c.Username == (id)).SingleOrDefault();
              

                if (selectedObject != null)
                {
                    pass = selectedObject.Password;
                    account.ID = selectedObject.ID;
                    account.EmployeeID = selectedObject.EmployeeID;
                    account.Username = selectedObject.Username;
                    MessageBox.Show(pass);

                    if (txtOld.Text != pass)
                    {
                        MessageBox.Show("Invalid Password!");
                    }
                    else if (txtNew.Text != txtVerify.Text)
                    {
                        MessageBox.Show("Mismatch Password!");
                    }
                    else{
                        //saving to account table
                        koalaShop.AccountRepo.Update(account);

                        MessageBox.Show("Updated!");
                        this.Dispose();
                        TextboxSetToNull();
                    }

                }
            }

            
  
               



              


            //Refresh list to update view.
            RefreshList();
        }



        public void UpdateObjectToDB()
        {
            //Not yet implemented.
        }

        public void TextboxSetToNull()
        {
            //Not yet implemented.
            
        }


        #endregion
     


        

        private void simpleButtonSave_Click_1(object sender, EventArgs e)
        {
            SaveObjectToDB();
        }

        private void simpleButtonCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}