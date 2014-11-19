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
    public partial class FormCashCount : DevExpress.XtraEditors.XtraForm, IDataGridForm
    {
        public FormCashCount()
        {
            InitializeComponent();
            //para ma set ang data sa datgrid
            this.RefreshList();

        }


        #region Defined Methods
        /// <summary>
        /// Refreshes/updates data list and grid view.
        /// </summary>
        public void RefreshList()
        {
            using (var koala = KoalaShopFactory.CreateKoalaShop())
            {
                this.gridControl1.DataSource = koala.CashCountRepo.GetAll();
            }
        }

        /// <summary>
        /// Pakita sa details pane sa selected nga oject sa datagrid.
        /// </summary>
        public void MapSelectedObjectToDetailsPane()
        {
                //Not implemented.
        }

        /// <summary>
        /// Save sa object sa db.
        /// </summary>
        public void SaveObjectToDB()
        {
            //Not implemented.
        }



        public void UpdateObjectToDB()
        {
            //Not implemented.
        }

      


        #endregion

    }
}