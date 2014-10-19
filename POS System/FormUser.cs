﻿using System;
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


namespace POS_System
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

    }
}