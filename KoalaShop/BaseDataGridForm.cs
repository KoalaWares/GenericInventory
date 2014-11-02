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
    public partial class BaseDataGridForm<T> : DevExpress.XtraEditors.XtraForm
    {
        public IKoalaShop koalaShop = null;
        public bool isNew = false;
        public List<T> objectList = new List<T>();
        public T selectedObjectOnGrid;

        public BaseDataGridForm()
        {
            InitializeComponent();
        }

        private void checkButtonIsNewToggle_CheckedChanged(object sender, EventArgs e)
        {
            string saveButtonText = "Update";

            isNew = !isNew;

            if (isNew)
            {
                saveButtonText = "Save";
            }

            simpleButtonSave.Text = saveButtonText;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {

        }


    }
}