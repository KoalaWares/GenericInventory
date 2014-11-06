namespace KoalaShop
{
    partial class FormInventory
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileMain = new DevExpress.XtraEditors.TileGroup();
            this.tileSales = new DevExpress.XtraEditors.TileItem();
            this.tilePos = new DevExpress.XtraEditors.TileItem();
            this.tileEmployee = new DevExpress.XtraEditors.TileItem();
            this.tileReport = new DevExpress.XtraEditors.TileItem();
            this.tileSupplier = new DevExpress.XtraEditors.TileItem();
            this.tileStock = new DevExpress.XtraEditors.TileItem();
            this.tileExpenses = new DevExpress.XtraEditors.TileItem();
            this.tileOptions = new DevExpress.XtraEditors.TileItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tileControl1);
            this.splitContainer1.Size = new System.Drawing.Size(655, 485);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 6;
            // 
            // tileControl1
            // 
            this.tileControl1.AppearanceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tileControl1.AppearanceText.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tileControl1.AppearanceText.Options.UseBackColor = true;
            this.tileControl1.BackColor = System.Drawing.Color.DarkKhaki;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileMain);
            this.tileControl1.ItemSize = 135;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 32;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(655, 370);
            this.tileControl1.TabIndex = 3;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileMain
            // 
            this.tileMain.Items.Add(this.tileSales);
            this.tileMain.Items.Add(this.tilePos);
            this.tileMain.Items.Add(this.tileEmployee);
            this.tileMain.Items.Add(this.tileReport);
            this.tileMain.Items.Add(this.tileSupplier);
            this.tileMain.Items.Add(this.tileStock);
            this.tileMain.Items.Add(this.tileExpenses);
            this.tileMain.Items.Add(this.tileOptions);
            this.tileMain.Name = "tileMain";
            this.tileMain.Text = null;
            // 
            // tileSales
            // 
            this.tileSales.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tileSales.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tileSales.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileSales.AppearanceItem.Normal.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileSales.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileSales.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileSales.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileSales.AppearanceItem.Normal.Options.UseFont = true;
            this.tileSales.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileSales.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileSales.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement1.Text = "Sales";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileSales.Elements.Add(tileItemElement1);
            this.tileSales.Id = 24;
            this.tileSales.Name = "tileSales";
            // 
            // tilePos
            // 
            this.tilePos.AppearanceItem.Normal.BackColor = System.Drawing.Color.Lime;
            this.tilePos.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Blue;
            this.tilePos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tilePos.AppearanceItem.Normal.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilePos.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tilePos.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tilePos.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tilePos.AppearanceItem.Normal.Options.UseFont = true;
            this.tilePos.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement2.Text = "POS";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tilePos.Elements.Add(tileItemElement2);
            this.tilePos.Id = 25;
            this.tilePos.Name = "tilePos";
            // 
            // tileEmployee
            // 
            this.tileEmployee.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tileEmployee.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tileEmployee.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileEmployee.AppearanceItem.Normal.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileEmployee.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileEmployee.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileEmployee.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileEmployee.AppearanceItem.Normal.Options.UseFont = true;
            this.tileEmployee.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement3.Text = "Employee";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileEmployee.Elements.Add(tileItemElement3);
            this.tileEmployee.Id = 26;
            this.tileEmployee.Name = "tileEmployee";
            // 
            // tileReport
            // 
            this.tileReport.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.tileReport.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tileReport.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileReport.AppearanceItem.Normal.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileReport.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileReport.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileReport.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileReport.AppearanceItem.Normal.Options.UseFont = true;
            this.tileReport.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement4.Text = "Report";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileReport.Elements.Add(tileItemElement4);
            this.tileReport.Id = 27;
            this.tileReport.Name = "tileReport";
            // 
            // tileSupplier
            // 
            this.tileSupplier.AppearanceItem.Normal.BackColor = System.Drawing.Color.Cyan;
            this.tileSupplier.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Fuchsia;
            this.tileSupplier.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileSupplier.AppearanceItem.Normal.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileSupplier.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileSupplier.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileSupplier.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileSupplier.AppearanceItem.Normal.Options.UseFont = true;
            this.tileSupplier.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement5.Text = "Supplier";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileSupplier.Elements.Add(tileItemElement5);
            this.tileSupplier.Id = 28;
            this.tileSupplier.Name = "tileSupplier";
            // 
            // tileStock
            // 
            this.tileStock.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileStock.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Yellow;
            this.tileStock.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileStock.AppearanceItem.Normal.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileStock.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileStock.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileStock.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileStock.AppearanceItem.Normal.Options.UseFont = true;
            this.tileStock.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement6.Text = "Stock";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileStock.Elements.Add(tileItemElement6);
            this.tileStock.Id = 29;
            this.tileStock.Name = "tileStock";
            // 
            // tileExpenses
            // 
            this.tileExpenses.AppearanceItem.Normal.BackColor = System.Drawing.Color.Fuchsia;
            this.tileExpenses.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Lime;
            this.tileExpenses.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileExpenses.AppearanceItem.Normal.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileExpenses.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileExpenses.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileExpenses.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileExpenses.AppearanceItem.Normal.Options.UseFont = true;
            this.tileExpenses.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement7.Text = "Expenses";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileExpenses.Elements.Add(tileItemElement7);
            this.tileExpenses.Id = 30;
            this.tileExpenses.Name = "tileExpenses";
            // 
            // tileOptions
            // 
            this.tileOptions.AppearanceItem.Normal.BackColor = System.Drawing.Color.Lime;
            this.tileOptions.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tileOptions.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileOptions.AppearanceItem.Normal.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileOptions.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileOptions.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileOptions.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileOptions.AppearanceItem.Normal.Options.UseFont = true;
            this.tileOptions.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement8.Text = "Options";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileOptions.Elements.Add(tileItemElement8);
            this.tileOptions.Id = 31;
            this.tileOptions.Name = "tileOptions";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(479, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Welcome User";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(88, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 18);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Date/Time";
            // 
            // FormInventory
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 485);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileMain;
        private DevExpress.XtraEditors.TileItem tileSales;
        private DevExpress.XtraEditors.TileItem tilePos;
        private DevExpress.XtraEditors.TileItem tileEmployee;
        private DevExpress.XtraEditors.TileItem tileReport;
        private DevExpress.XtraEditors.TileItem tileSupplier;
        private DevExpress.XtraEditors.TileItem tileStock;
        private DevExpress.XtraEditors.TileItem tileExpenses;
        private DevExpress.XtraEditors.TileItem tileOptions;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;


    }
}