namespace KoalaShop
{
    partial class FormExpensesAdd
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
            this.ProductCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ProductSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ProductAdd = new DevExpress.XtraEditors.GroupControl();
            this.smartPasteExtension1 = new DevExpress.CodeRush.Extensions.SmartPasteExtension(this.components);
            this.txtPurpose = new DevExpress.XtraEditors.MemoEdit();
            this.groupUpdate = new DevExpress.XtraEditors.GroupControl();
            this.txtNameU = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtIDU = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmountU = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPurposeU = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAdd)).BeginInit();
            this.ProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smartPasteExtension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurpose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUpdate)).BeginInit();
            this.groupUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurposeU.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCancel
            // 
            this.ProductCancel.Location = new System.Drawing.Point(251, 208);
            this.ProductCancel.Name = "ProductCancel";
            this.ProductCancel.Size = new System.Drawing.Size(98, 47);
            this.ProductCancel.TabIndex = 23;
            this.ProductCancel.Text = "CANCEL";
            // 
            // ProductSave
            // 
            this.ProductSave.Location = new System.Drawing.Point(141, 208);
            this.ProductSave.Name = "ProductSave";
            this.ProductSave.Size = new System.Drawing.Size(98, 47);
            this.ProductSave.TabIndex = 22;
            this.ProductSave.Text = "SAVE";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Purpose:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(110, 80);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtAmount.Size = new System.Drawing.Size(239, 22);
            this.txtAmount.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Amount";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 42);
            this.txtName.Name = "txtName";
            this.txtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtName.Size = new System.Drawing.Size(239, 22);
            this.txtName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Name:";
            // 
            // ProductAdd
            // 
            this.ProductAdd.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAdd.AppearanceCaption.Options.UseFont = true;
            this.ProductAdd.Controls.Add(this.groupUpdate);
            this.ProductAdd.Controls.Add(this.ProductCancel);
            this.ProductAdd.Controls.Add(this.ProductSave);
            this.ProductAdd.Controls.Add(this.labelControl3);
            this.ProductAdd.Controls.Add(this.txtAmount);
            this.ProductAdd.Controls.Add(this.labelControl4);
            this.ProductAdd.Controls.Add(this.txtName);
            this.ProductAdd.Controls.Add(this.labelControl2);
            this.ProductAdd.Controls.Add(this.txtPurpose);
            this.ProductAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductAdd.Location = new System.Drawing.Point(0, 0);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(363, 341);
            this.ProductAdd.TabIndex = 1;
            this.ProductAdd.Text = "Add Expenses";
            // 
            // smartPasteExtension1
            // 
            this.smartPasteExtension1.Description = "";
            this.smartPasteExtension1.ExtensionName = "";
            this.smartPasteExtension1.Register = true;
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(110, 115);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtPurpose.Size = new System.Drawing.Size(239, 74);
            this.txtPurpose.TabIndex = 7;
            // 
            // groupUpdate
            // 
            this.groupUpdate.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupUpdate.AppearanceCaption.Options.UseFont = true;
            this.groupUpdate.Controls.Add(this.buttonCancel);
            this.groupUpdate.Controls.Add(this.buttonUpdate);
            this.groupUpdate.Controls.Add(this.labelControl1);
            this.groupUpdate.Controls.Add(this.txtPurposeU);
            this.groupUpdate.Controls.Add(this.txtAmountU);
            this.groupUpdate.Controls.Add(this.labelControl7);
            this.groupUpdate.Controls.Add(this.txtNameU);
            this.groupUpdate.Controls.Add(this.labelControl5);
            this.groupUpdate.Controls.Add(this.txtIDU);
            this.groupUpdate.Controls.Add(this.labelControl6);
            this.groupUpdate.Location = new System.Drawing.Point(0, 0);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(363, 344);
            this.groupUpdate.TabIndex = 24;
            this.groupUpdate.Text = "Update Expenses";
            // 
            // txtNameU
            // 
            this.txtNameU.Location = new System.Drawing.Point(110, 80);
            this.txtNameU.Name = "txtNameU";
            this.txtNameU.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtNameU.Size = new System.Drawing.Size(239, 22);
            this.txtNameU.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Name:";
            // 
            // txtIDU
            // 
            this.txtIDU.Enabled = false;
            this.txtIDU.Location = new System.Drawing.Point(110, 42);
            this.txtIDU.Name = "txtIDU";
            this.txtIDU.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtIDU.Size = new System.Drawing.Size(239, 22);
            this.txtIDU.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(15, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "ID:";
            // 
            // txtAmountU
            // 
            this.txtAmountU.Location = new System.Drawing.Point(110, 114);
            this.txtAmountU.Name = "txtAmountU";
            this.txtAmountU.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtAmountU.Size = new System.Drawing.Size(239, 22);
            this.txtAmountU.TabIndex = 25;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 120);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Amount:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(251, 244);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 47);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "CANCEL";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(141, 244);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(98, 47);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "UPDATE";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 157);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Purpose:";
            // 
            // txtPurposeU
            // 
            this.txtPurposeU.Location = new System.Drawing.Point(110, 151);
            this.txtPurposeU.Name = "txtPurposeU";
            this.txtPurposeU.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtPurposeU.Size = new System.Drawing.Size(239, 74);
            this.txtPurposeU.TabIndex = 27;
            // 
            // FormExpensesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 341);
            this.Controls.Add(this.ProductAdd);
            this.Name = "FormExpensesAdd";
            this.Text = "FormExpensesAdd";
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAdd)).EndInit();
            this.ProductAdd.ResumeLayout(false);
            this.ProductAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smartPasteExtension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurpose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUpdate)).EndInit();
            this.groupUpdate.ResumeLayout(false);
            this.groupUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurposeU.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ProductCancel;
        private DevExpress.XtraEditors.SimpleButton ProductSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl ProductAdd;
        private DevExpress.XtraEditors.GroupControl groupUpdate;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtPurposeU;
        private DevExpress.XtraEditors.TextEdit txtAmountU;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtNameU;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtIDU;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtPurpose;
        private DevExpress.CodeRush.Extensions.SmartPasteExtension smartPasteExtension1;
    }
}