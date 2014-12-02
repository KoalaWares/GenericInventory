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
    public partial class FormExpenses : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {
        //Declare DataGridFormController
        private DataGridFormController formController;
        private MainForm form;

        public FormExpenses(MainForm mainform)
        {
            InitializeComponent();
            //para ma set ang data sa datgrid
            this.RefreshList();
            //para ma control sa formController ang button save,tbutton new ug datagrid
            this.formController = new DataGridFormController(this.simpleButtonUpdate, this.simpleButtonSave, this.checkButtonIsNew, this.gridView1, this);
            //para ma.display ang save button instead sa update button.
            this.formController.ToggleNewObjectButton();

            this.form = mainform;
            
        }

        #region Defined Methods
        /// <summary>
        /// Refreshes/updates data list and grid view.
        /// </summary>
        public void RefreshList()
        {
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                this.gridControl1.DataSource = koala.ExpensesRepo.GetAll();
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
                var selectedObject = koalaShop.ExpensesRepo.GetAll().Where(c => c.ID == Int32.Parse(id)).SingleOrDefault();

                if (selectedObject != null)
                {
                    this.textName.Text = selectedObject.Name;
                    this.textAmount.Text = selectedObject.Amount.ToString();
                    this.textPurpose.Text = selectedObject.Purpose;
                   

                }
            }
        }

      
        /// <summary>
        /// Save sa object sa db.
        /// </summary>
        public void SaveObjectToDB()
        {
            
            Expenses expenses = new Expenses();

            expenses.Name = textName.Text;
            expenses.Amount = Decimal.Parse(textAmount.Text);
            expenses.Purpose = textPurpose.Text;
          expenses.EmployeeID = this.form.CurrenUser.EmployeeID;
          expenses.Date = DateTime.Now;
          expenses.Category = "Petty Cash Fund";
          
            

            //Validation
            if (expenses.Name == "" || expenses.Amount == 0 || expenses.Purpose == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {

                koala.ExpensesRepo.Add(expenses);
                MessageBox.Show("Saved!");
                
                TextboxSetToNull();


            }
            //Refresh list to update view.
            RefreshList();
        }

        public void UpdateObjectToDB()
        {
            Expenses expenses = new Expenses();

            expenses.Name = textName.Text;
            expenses.Amount = Decimal.Parse(textAmount.Text);
            expenses.Purpose = textPurpose.Text;
            expenses.EmployeeID = this.form.CurrenUser.EmployeeID;
            expenses.Date = DateTime.Now;

            //Validation
            if (expenses.Name == "" || expenses.Amount == 0 || expenses.Purpose == "")
            {
                MessageBox.Show("Empty Name Field");
                return;
            }

            //DB access
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {

                try
                {
                    expenses.ID = int.Parse(this.formController.GetSelectedObjectID());
                    koala.ExpensesRepo.Update(expenses);
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
            this.textAmount.Text = "";
            this.textPurpose.Text = "";

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

        #endregion
    
       

        private void checkButtonIsNew_CheckedChanged_1(object sender, EventArgs e)
        {
            this.formController.ToggleNewObjectButton();
        }

        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateObjectToDB();

        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            SaveObjectToDB();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MapSelectedObjectToDetailsPane();
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperCaseName();
        }
    }
}