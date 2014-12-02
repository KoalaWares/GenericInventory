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
    public partial class FormPOS : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {

        //Declare DataGridFormController
        //private DataGridFormController formController;
        MainForm mainForm;

        public FormPOS(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        #region Defined Methods
        /// <summary>
        /// Refreshes/updates data list and grid view.
        /// </summary>
        public void RefreshList()
        {
            //Not Yet Implemented.
        }

        /// <summary>
        /// Pakita sa details pane sa selected nga oject sa datagrid.
        /// </summary>
        public void MapSelectedObjectToDetailsPane()
        {
            //Not Yet Implemented.
        }

        /// <summary>
        /// Save sa object sa db.
        /// </summary>
        public void SaveObjectToDB()
        {
            //Not Yet Implemented.
        }



        public void UpdateObjectToDB()
        {
            //Not Yet Implemented.
        }

        public void TextboxSetToNull()
        {
          //Not Yet Implemented.
        }


        #endregion
     

       
        private void BtnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChangePass_Click_1(object sender, EventArgs e)
        {
            this.mainForm.ChildFormInitializer(FormTypes.ChangePass);
        }


    }
}