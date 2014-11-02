namespace KoalaShop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barButtonItemProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barMdiChildrenListItem1,
            this.barButtonItemProducts,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barMdiChildrenListItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(690, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 3;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inventory";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemProducts);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Details";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "POS";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "CRM";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(690, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Stocks";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Reports";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Employee MGT";
            // 
            // barButtonItemProducts
            // 
            this.barButtonItemProducts.Caption = "Products";
            this.barButtonItemProducts.Id = 7;
            this.barButtonItemProducts.Name = "barButtonItemProducts";
            this.barButtonItemProducts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Categories";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Suppliers";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Stocks";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Account";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Koala Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProducts;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
    }
}