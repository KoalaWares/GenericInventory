namespace KoalaShop
{
    partial class FormProductInfo
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
            this.ProductCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ProductSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtVariant = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtWeight = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ProductAdd = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtVariant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAdd)).BeginInit();
            this.ProductAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductCancel
            // 
            this.ProductCancel.Location = new System.Drawing.Point(251, 182);
            this.ProductCancel.Name = "ProductCancel";
            this.ProductCancel.Size = new System.Drawing.Size(98, 47);
            this.ProductCancel.TabIndex = 23;
            this.ProductCancel.Text = "CANCEL";
            this.ProductCancel.Click += new System.EventHandler(this.ProductCancel_Click);
            // 
            // ProductSave
            // 
            this.ProductSave.Location = new System.Drawing.Point(141, 182);
            this.ProductSave.Name = "ProductSave";
            this.ProductSave.Size = new System.Drawing.Size(98, 47);
            this.ProductSave.TabIndex = 22;
            this.ProductSave.Text = "SAVE";
            // 
            // txtVariant
            // 
            this.txtVariant.Location = new System.Drawing.Point(110, 141);
            this.txtVariant.Name = "txtVariant";
            this.txtVariant.Size = new System.Drawing.Size(239, 20);
            this.txtVariant.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Variant:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(110, 106);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(239, 20);
            this.txtWeight.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Weight:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 20);
            this.txtName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(239, 20);
            this.txtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // ProductAdd
            // 
            this.ProductAdd.Controls.Add(this.ProductCancel);
            this.ProductAdd.Controls.Add(this.ProductSave);
            this.ProductAdd.Controls.Add(this.txtVariant);
            this.ProductAdd.Controls.Add(this.labelControl3);
            this.ProductAdd.Controls.Add(this.txtWeight);
            this.ProductAdd.Controls.Add(this.labelControl4);
            this.ProductAdd.Controls.Add(this.txtName);
            this.ProductAdd.Controls.Add(this.labelControl2);
            this.ProductAdd.Controls.Add(this.txtID);
            this.ProductAdd.Controls.Add(this.labelControl1);
            this.ProductAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductAdd.Location = new System.Drawing.Point(0, 0);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(366, 247);
            this.ProductAdd.TabIndex = 1;
            // 
            // FormProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 247);
            this.Controls.Add(this.ProductAdd);
            this.MaximizeBox = false;
            this.Name = "FormProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product Info";
            ((System.ComponentModel.ISupportInitialize)(this.txtVariant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAdd)).EndInit();
            this.ProductAdd.ResumeLayout(false);
            this.ProductAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ProductCancel;
        private DevExpress.XtraEditors.SimpleButton ProductSave;
        private DevExpress.XtraEditors.TextEdit txtVariant;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtWeight;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl ProductAdd;
    }
}