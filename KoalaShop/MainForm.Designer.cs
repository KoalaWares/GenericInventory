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
            this.components = new System.ComponentModel.Container();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::KoalaShop.WaitForm1), true, true);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barButtonItemProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCategories = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSuppliers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemStocks = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPOS = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpiredProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOrders = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageInventory = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPagePOS = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCRM = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageEmployeeManagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageAccount = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.barButtonItemCategories,
            this.barButtonItemSuppliers,
            this.barButtonItemStocks,
            this.barButtonItemPOS,
            this.barButtonItemCustomers,
            this.barButtonItemExpiredProducts,
            this.barButtonItemOrders});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barMdiChildrenListItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageInventory,
            this.ribbonPagePOS,
            this.ribbonPageCRM,
            this.ribbonPageReports,
            this.ribbonPageEmployeeManagement,
            this.ribbonPageAccount});
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
            // barButtonItemProducts
            // 
            this.barButtonItemProducts.Caption = "Products";
            this.barButtonItemProducts.Id = 7;
            this.barButtonItemProducts.Name = "barButtonItemProducts";
            this.barButtonItemProducts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemProducts_ItemClick);
            // 
            // barButtonItemCategories
            // 
            this.barButtonItemCategories.Caption = "Categories";
            this.barButtonItemCategories.Id = 8;
            this.barButtonItemCategories.Name = "barButtonItemCategories";
            this.barButtonItemCategories.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCategories_ItemClick);
            // 
            // barButtonItemSuppliers
            // 
            this.barButtonItemSuppliers.Caption = "Suppliers";
            this.barButtonItemSuppliers.Id = 9;
            this.barButtonItemSuppliers.Name = "barButtonItemSuppliers";
            this.barButtonItemSuppliers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemSuppliers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSuppliers_ItemClick);
            // 
            // barButtonItemStocks
            // 
            this.barButtonItemStocks.Caption = "Stocks";
            this.barButtonItemStocks.Id = 10;
            this.barButtonItemStocks.Name = "barButtonItemStocks";
            this.barButtonItemStocks.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemStocks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemStocks_ItemClick);
            // 
            // barButtonItemPOS
            // 
            this.barButtonItemPOS.Caption = "POS";
            this.barButtonItemPOS.Id = 11;
            this.barButtonItemPOS.Name = "barButtonItemPOS";
            // 
            // barButtonItemCustomers
            // 
            this.barButtonItemCustomers.Caption = "Customers";
            this.barButtonItemCustomers.Id = 12;
            this.barButtonItemCustomers.Name = "barButtonItemCustomers";
            // 
            // barButtonItemExpiredProducts
            // 
            this.barButtonItemExpiredProducts.Caption = "Expired Products";
            this.barButtonItemExpiredProducts.Id = 13;
            this.barButtonItemExpiredProducts.Name = "barButtonItemExpiredProducts";
            // 
            // barButtonItemOrders
            // 
            this.barButtonItemOrders.Caption = "Orders";
            this.barButtonItemOrders.Id = 14;
            this.barButtonItemOrders.Name = "barButtonItemOrders";
            // 
            // ribbonPageInventory
            // 
            this.ribbonPageInventory.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPageInventory.Name = "ribbonPageInventory";
            this.ribbonPageInventory.Text = "Inventory";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemSuppliers);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCategories);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemProducts);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Details";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemStocks);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Stocks";
            // 
            // ribbonPagePOS
            // 
            this.ribbonPagePOS.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPagePOS.Name = "ribbonPagePOS";
            this.ribbonPagePOS.Text = "POS";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemPOS);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageCRM
            // 
            this.ribbonPageCRM.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPageCRM.Name = "ribbonPageCRM";
            this.ribbonPageCRM.Text = "CRM";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemCustomers);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageReports
            // 
            this.ribbonPageReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPageReports.Name = "ribbonPageReports";
            this.ribbonPageReports.Text = "Reports";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItemExpiredProducts);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItemOrders);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPageEmployeeManagement
            // 
            this.ribbonPageEmployeeManagement.Name = "ribbonPageEmployeeManagement";
            this.ribbonPageEmployeeManagement.Text = "Employee MGT";
            // 
            // ribbonPageAccount
            // 
            this.ribbonPageAccount.Name = "ribbonPageAccount";
            this.ribbonPageAccount.Text = "Account";
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageInventory;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPagePOS;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCRM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProducts;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCategories;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSuppliers;
        private DevExpress.XtraBars.BarButtonItem barButtonItemStocks;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageReports;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageEmployeeManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPOS;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCustomers;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpiredProducts;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOrders;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}