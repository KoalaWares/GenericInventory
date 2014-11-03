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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barButtonItemProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCategories = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSuppliers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemStocks = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageSales = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemPOS = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExpiredProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOrders = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPageSales,
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
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "POS";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "CRM";
            // 
            // ribbonPageSales
            // 
            this.ribbonPageSales.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPageSales.Name = "ribbonPageSales";
            this.ribbonPageSales.Text = "Reports";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Employee MGT";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Account";
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
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemPOS);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemCustomers);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItemExpiredProducts);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItemOrders);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
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
        private DevExpress.XtraBars.BarButtonItem barButtonItemCategories;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSuppliers;
        private DevExpress.XtraBars.BarButtonItem barButtonItemStocks;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSales;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPOS;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCustomers;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExpiredProducts;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOrders;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}