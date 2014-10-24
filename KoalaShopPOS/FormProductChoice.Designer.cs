namespace KoalaShopPOS
{
    partial class FormProductChoice
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
            this.AddStock = new DevExpress.XtraEditors.SimpleButton();
            this.UpdateInfo = new DevExpress.XtraEditors.SimpleButton();
            this.ViewMore = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // AddStock
            // 
            this.AddStock.Location = new System.Drawing.Point(12, 15);
            this.AddStock.Name = "AddStock";
            this.AddStock.Size = new System.Drawing.Size(106, 48);
            this.AddStock.TabIndex = 0;
            this.AddStock.Text = "Add New Stock";
            this.AddStock.Click += new System.EventHandler(this.AddStock_Click);
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.Location = new System.Drawing.Point(130, 15);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(127, 48);
            this.UpdateInfo.TabIndex = 1;
            this.UpdateInfo.Text = "Update Product Info";
            this.UpdateInfo.Click += new System.EventHandler(this.UpdateInfo_Click);
            // 
            // ViewMore
            // 
            this.ViewMore.Location = new System.Drawing.Point(263, 15);
            this.ViewMore.Name = "ViewMore";
            this.ViewMore.Size = new System.Drawing.Size(119, 48);
            this.ViewMore.TabIndex = 2;
            this.ViewMore.Text = "View More Details";
            this.ViewMore.Click += new System.EventHandler(this.ViewMore_Click);
            // 
            // FormProductChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 85);
            this.Controls.Add(this.ViewMore);
            this.Controls.Add(this.UpdateInfo);
            this.Controls.Add(this.AddStock);
            this.Name = "FormProductChoice";
            this.Text = "FormProductChoice";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton AddStock;
        private DevExpress.XtraEditors.SimpleButton UpdateInfo;
        private DevExpress.XtraEditors.SimpleButton ViewMore;
    }
}