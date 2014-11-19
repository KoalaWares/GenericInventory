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
        private DataGridFormController formController;
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
            //using (var koala = KoalaShopFactory.CreateKoalaShop())
            //{
            //    this.gridControl1.DataSource = koala.EmployeeRepo.GetAll();
            //}
        }

        /// <summary>
        /// Pakita sa details pane sa selected nga oject sa datagrid.
        /// </summary>
        public void MapSelectedObjectToDetailsPane()
        {
            //string id = this.formController.GetSelectedObjectID();

            //using (IKoalaShop koalaShop = KoalaShopFactory.CreateKoalaShop())
            //{
            //    var selectedObject = koalaShop.EmployeeRepo.GetAll().Where(c => c.ID == Int32.Parse(id)).SingleOrDefault();
            //    var selectedObjectAccount = koalaShop.AccountRepo.GetAll().Where(a => a.ID == Int32.Parse(id)).SingleOrDefault();

            //    if (selectedObject != null)
            //    {
            //        this.textID.Text = selectedObject.ID.ToString();
            //        this.textFName.Text = selectedObject.Fname;
            //        this.textLname.Text = selectedObject.Lname;
            //        this.textAddress.Text = selectedObject.Address;
            //        this.textContact.Text = selectedObject.Contact;
            //        this.textPosition.Text = selectedObjectAccount.AccountType.ToString();
            //        this.textUsername.Text = selectedObjectAccount.Username;
            //        this.formController.UpdateObjectButton();

            //    }
            //}
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
            //Employee employee = new Employee();
            //Account account = new Account();

            //employee.Fname = textFName.Text;
            //employee.Lname = textLname.Text;
            //employee.Address = textAddress.Text;
            //employee.Contact = textContact.Text;


            //account.Password = textPassword.Text;
            //account.Username = textUsername.Text;


            ////set account type
            //if (textPosition.Text == "Admin")
            //{
            //    account.AccountType = AccountType.Admin;
            //}
            //else if (textPosition.Text == "Cashier")
            //{
            //    account.AccountType = AccountType.Cashier;
            //}
            //else
            //{
            //    account.AccountType = AccountType.Purchaser;
            //}

            ////Validation
            //if (employee.Fname == "" || employee.Lname == "")
            //{
            //    MessageBox.Show("Empty Name Field");
            //    return;
            //}


            ////DB access
            //using (var koala = KoalaShopFactory.CreateKoalaShop())
            //{

            //    try
            //    {
            //        employee.ID = int.Parse(this.formController.GetSelectedObjectID());
            //        koala.EmployeeRepo.Update(employee);
            //        koala.AccountRepo.Update(account);
            //        MessageBox.Show("Updated!");

            //        TextboxSetToNull();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Something Went Wrong");
            //        //throw;
            //    }


            //}

            ////Refresh list to update view.
            //RefreshList();
        }

        public void TextboxSetToNull()
        {
            //setting textboxes to null
            
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