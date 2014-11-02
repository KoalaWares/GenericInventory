namespace KoalaShop
{
    partial class ProductsForm
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.checkButtonIsNew = new DevExpress.XtraEditors.CheckButton();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditWeight = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.textEditVariant = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.textEditBarCode = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textEditDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVariant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(784, 361);
            this.splitContainerControl1.SplitterPosition = 230;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.textEditBarCode);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.textEditVariant);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.textEditWeight);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.simpleButtonSave);
            this.groupControl1.Controls.Add(this.checkButtonIsNew);
            this.groupControl1.Controls.Add(this.textEditName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.textEditCategory);
            this.groupControl1.Controls.Add(this.textEditDescription);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(230, 361);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Product Details";
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSave.Location = new System.Drawing.Point(82, 329);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(143, 28);
            this.simpleButtonSave.TabIndex = 6;
            this.simpleButtonSave.Text = "Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // checkButtonIsNew
            // 
            this.checkButtonIsNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButtonIsNew.Location = new System.Drawing.Point(12, 329);
            this.checkButtonIsNew.Name = "checkButtonIsNew";
            this.checkButtonIsNew.Size = new System.Drawing.Size(64, 28);
            this.checkButtonIsNew.TabIndex = 5;
            this.checkButtonIsNew.Text = "New";
            this.checkButtonIsNew.CheckedChanged += new System.EventHandler(this.checkButtonIsNew_CheckedChanged);
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(12, 47);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(213, 20);
            this.textEditName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(549, 361);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category";
            // 
            // textEditWeight
            // 
            this.textEditWeight.Location = new System.Drawing.Point(12, 125);
            this.textEditWeight.Name = "textEditWeight";
            this.textEditWeight.Size = new System.Drawing.Size(213, 20);
            this.textEditWeight.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weight";
            // 
            // textEditCategory
            // 
            this.textEditCategory.Location = new System.Drawing.Point(12, 86);
            this.textEditCategory.Name = "textEditCategory";
            this.textEditCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditCategory.Properties.NullText = "";
            this.textEditCategory.Size = new System.Drawing.Size(213, 20);
            this.textEditCategory.TabIndex = 8;
            // 
            // textEditVariant
            // 
            this.textEditVariant.Location = new System.Drawing.Point(12, 164);
            this.textEditVariant.Name = "textEditVariant";
            this.textEditVariant.Size = new System.Drawing.Size(213, 20);
            this.textEditVariant.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Variant";
            // 
            // textEditBarCode
            // 
            this.textEditBarCode.Location = new System.Drawing.Point(12, 203);
            this.textEditBarCode.Name = "textEditBarCode";
            this.textEditBarCode.Size = new System.Drawing.Size(213, 20);
            this.textEditBarCode.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "BarCode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Description";
            // 
            // textEditDescription
            // 
            this.textEditDescription.Location = new System.Drawing.Point(12, 242);
            this.textEditDescription.Name = "textEditDescription";
            this.textEditDescription.Size = new System.Drawing.Size(213, 69);
            this.textEditDescription.TabIndex = 16;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVariant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.CheckButton checkButtonIsNew;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEditWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit textEditCategory;
        private DevExpress.XtraEditors.TextEdit textEditVariant;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEditBarCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.MemoEdit textEditDescription;
    }
}