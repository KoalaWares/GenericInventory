using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace KoalaShopPOS
{
    public partial class FormUser : RibbonForm
    {
        public FormUser()
        {
            InitializeComponent();
           

        }
   
       
     

        private void MenuUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            GroupUpdate.Visible = true;
            BtnUpdate.Visible = true;
        }

        private void MenuAdd_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            GroupAdd.Visible = true;
            BtnSave.Visible = true;
            GroupUpdate.Visible = false;
           // BtnUpdate.Visible = false;
        }

        private void MenuView_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormUserView a = new FormUserView();
            this.Hide();
            a.Show();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        public void GroupAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void MenuView_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FormUserView a = new FormUserView();
            this.Hide();
            a.Show();
        }

        private void MenuViewSched_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormUserSched a = new FormUserSched();
            this.Hide();
            a.Show();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormLogin a = new FormLogin();
            this.Close();
            a.Show();
        }

    }
}