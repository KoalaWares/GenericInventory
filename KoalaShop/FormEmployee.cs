﻿using System;
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
    public partial class FormEmployee : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {

        //Declare DataGridFormController
        private DataGridFormController formController;


        public FormEmployee()
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
                
              //  this.gridControl1.DataSource = koala.EmployeeRepo.GetAll();

                
                // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.dataSet1.Employees);

                // TODO: This line of code loads data into the 'dataSet1.Accounts' table. You can move, or remove it, as needed.
                this.accountsTableAdapter.Fill(this.dataSet1.Accounts);


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
                var selectedObject = koalaShop.EmployeeRepo.GetAll().Where(c => c.ID == Int32.Parse(id)).SingleOrDefault();
                var selectedObjectAccount = koalaShop.AccountRepo.GetAll().Where(a => a.EmployeeID == Int32.Parse(id)).SingleOrDefault();

                if (selectedObject != null)
                {
                    this.textID.Text = selectedObject.ID.ToString();
                    this.textFName.Text = selectedObject.Fname;
                    this.textLname.Text = selectedObject.Lname;
                    this.textAddress.Text = selectedObject.Address;
                    this.textContact.Text = selectedObject.Contact;
                    this.textPosition.Text = selectedObjectAccount.AccountType.ToString();
                    this.textUsername.Text = selectedObjectAccount.Username;
                    this.formController.UpdateObjectButton();
                    this.textPassword.Text = selectedObjectAccount.Password;
                    this.txtAcct.Text = selectedObjectAccount.ID.ToString();
                    DisableTextbox();

                }
            }
        }

        /// <summary>
        /// Save sa object sa db.
        /// </summary>
        public void SaveObjectToDB()
        {
            Employee employee = new Employee();
            Account account = new Account();

            employee.Fname = textFName.Text;
            employee.Lname = textLname.Text;
            employee.Address = textAddress.Text;
            employee.Contact = textContact.Text;


            account.Password = textPassword.Text;
            account.Username = textUsername.Text;


            //set account type
            if (textPosition.Text == "Admin")
            {
                account.AccountType = AccountType.Admin;
            }
            else if (textPosition.Text == "Cashier")
            {
                account.AccountType = AccountType.Cashier;
            }
            else
            {
                account.AccountType = AccountType.Purchaser;
            }

            //Validation
            if (employee.Fname == "" || employee.Lname == "" || account.Password == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                //saving to employee table
                koala.EmployeeRepo.Add(employee);

                //set employee refrence to account kay ma update na eya ID kay refrence type ang class
                account.EmployeeID = employee.ID;

                //saving to account table
                koala.AccountRepo.Add(account);

                MessageBox.Show("Saved!");
                TextboxSetToNull();

            }
            //Refresh list to update view.
            RefreshList();
        }



        public void UpdateObjectToDB()
        {
            Employee employee = new Employee();
            Account account = new Account();

            employee.Fname = textFName.Text;
            employee.Lname = textLname.Text;
            employee.Address = textAddress.Text;
            employee.Contact = textContact.Text;


            account.Password = textPassword.Text;
            account.Username = textUsername.Text;
            account.ID = Int32.Parse(txtAcct.Text);

            //set account type
            if (textPosition.Text == "Admin")
            {
                account.AccountType = AccountType.Admin;
            }
            else if (textPosition.Text == "Cashier")
            {
                account.AccountType = AccountType.Cashier;
            }
            else
            {
                account.AccountType = AccountType.Purchaser;
            }

            //Validation
            if (employee.Fname == "" || employee.Lname == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }


            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {

                try
                {
                    employee.ID = int.Parse(this.formController.GetSelectedObjectID());
                    //saving to employee table
                    koala.EmployeeRepo.Update(employee);

                    //set employee refrence to account kay ma update na eya ID kay refrence type ang class
                    account.EmployeeID = employee.ID;


                    //saving to account table
                    koala.AccountRepo.Update(account);

                    MessageBox.Show("Updated!");
                    TextboxSetToNull();
                }
                catch (Exception)
                {
                    //MessageBox.Show(e.Exception);
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
            this.textID.Text = "";
            this.textFName.Text = "";
            this.textLname.Text = "";
            this.textAddress.Text = "";
            this.textContact.Text = "";
            this.textPosition.Text = "";
            this.textPassword.Text = "";
            this.textUsername.Text = "";
        }

        public void DisableTextbox()
        {
            this.textUsername.Enabled = false;
            this.textPassword.Enabled = false;
        }

        public void UpperCaseFname()
        {
            int TextLength = textFName.Text.Length;
            if (TextLength == 1)
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textFName.Text = textInfo.ToTitleCase(textFName.Text);
                textFName.SelectionStart = 1;
            }
            else if (TextLength > 1 && textFName.SelectionStart < TextLength)
            {
                int x = textFName.SelectionStart;
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textFName.Text = textInfo.ToTitleCase(textFName.Text);
                textFName.SelectionStart = x;
            }
            else if (TextLength > 1 && textFName.SelectionStart >= TextLength)
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textFName.Text = textInfo.ToTitleCase(textFName.Text);
                textFName.SelectionStart = TextLength;
            }
        }

        public void UpperCaseLname()
        {
            int TextLength = textLname.Text.Length;
            if (TextLength == 1)
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textLname.Text = textInfo.ToTitleCase(textLname.Text);
                textLname.SelectionStart = 1;
            }
            else if (TextLength > 1 && textLname.SelectionStart < TextLength)
            {
                int x = textLname.SelectionStart;
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textLname.Text = textInfo.ToTitleCase(textLname.Text);
                textLname.SelectionStart = x;
            }
            else if (TextLength > 1 && textLname.SelectionStart >= TextLength)
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                textLname.Text = textInfo.ToTitleCase(textLname.Text);
                textLname.SelectionStart = TextLength;
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

        private void checkButtonIsNew_CheckedChanged(object sender, EventArgs e)
        {
            this.formController.ToggleNewObjectButton();
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            SaveObjectToDB();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MapSelectedObjectToDetailsPane();
        }

        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateObjectToDB();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
           

        }

        private void textFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperCaseFname();
        }

        private void textLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperCaseLname();
        }

        private void textAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperCaseAddress();
        }

        private void textLname_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}