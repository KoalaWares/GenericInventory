namespace KoalaShop
{
    partial class FormEmployee
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
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.imageEdit1 = new DevExpress.XtraEditors.ImageEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.textContact = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.textAddress = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.checkButtonIsNew = new DevExpress.XtraEditors.CheckButton();
            this.textLname = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textFName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textUsername = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(831, 352);
            this.splitContainerControl1.SplitterPosition = 337;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.textUsername);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.simpleButtonUpdate);
            this.groupControl1.Controls.Add(this.imageEdit1);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.textPassword);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.textContact);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.textAddress);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.simpleButtonSave);
            this.groupControl1.Controls.Add(this.checkButtonIsNew);
            this.groupControl1.Controls.Add(this.textLname);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.textFName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.textPosition);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(333, 348);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Employee Details";
            // 
            // simpleButtonUpdate
            // 
            this.simpleButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonUpdate.Location = new System.Drawing.Point(185, 315);
            this.simpleButtonUpdate.Name = "simpleButtonUpdate";
            this.simpleButtonUpdate.Size = new System.Drawing.Size(143, 28);
            this.simpleButtonUpdate.TabIndex = 23;
            this.simpleButtonUpdate.Text = "Update";
            this.simpleButtonUpdate.Click += new System.EventHandler(this.simpleButtonUpdate_Click_1);
            // 
            // imageEdit1
            // 
            this.imageEdit1.Location = new System.Drawing.Point(115, 266);
            this.imageEdit1.Name = "imageEdit1";
            this.imageEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageEdit1.Size = new System.Drawing.Size(198, 20);
            this.imageEdit1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Image:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Position:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(115, 90);
            this.textPassword.Name = "textPassword";
            this.textPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textPassword.Size = new System.Drawing.Size(198, 22);
            this.textPassword.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Password:";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(115, 31);
            this.textID.Name = "textID";
            this.textID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textID.Size = new System.Drawing.Size(198, 22);
            this.textID.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID:";
            // 
            // textContact
            // 
            this.textContact.Location = new System.Drawing.Point(115, 201);
            this.textContact.Name = "textContact";
            this.textContact.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textContact.Properties.Mask.EditMask = "(\\d?\\d?\\d?)\\d\\d\\d-\\d\\d\\d\\d";
            this.textContact.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textContact.Size = new System.Drawing.Size(198, 22);
            this.textContact.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contact Number:";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(115, 173);
            this.textAddress.Name = "textAddress";
            this.textAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textAddress.Size = new System.Drawing.Size(198, 22);
            this.textAddress.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address:";
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSave.Location = new System.Drawing.Point(185, 315);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(143, 28);
            this.simpleButtonSave.TabIndex = 10;
            this.simpleButtonSave.Text = "Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // checkButtonIsNew
            // 
            this.checkButtonIsNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButtonIsNew.Location = new System.Drawing.Point(115, 315);
            this.checkButtonIsNew.Name = "checkButtonIsNew";
            this.checkButtonIsNew.Size = new System.Drawing.Size(64, 28);
            this.checkButtonIsNew.TabIndex = 9;
            this.checkButtonIsNew.Text = "New";
            this.checkButtonIsNew.CheckedChanged += new System.EventHandler(this.checkButtonIsNew_CheckedChanged);
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(115, 145);
            this.textLname.Name = "textLname";
            this.textLname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textLname.Size = new System.Drawing.Size(198, 22);
            this.textLname.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(115, 118);
            this.textFName.Name = "textFName";
            this.textFName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textFName.Size = new System.Drawing.Size(198, 22);
            this.textFName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // textPosition
            // 
            this.textPosition.Location = new System.Drawing.Point(115, 229);
            this.textPosition.Name = "textPosition";
            this.textPosition.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textPosition.Properties.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Purchaser"});
            this.textPosition.Properties.PopupSizeable = true;
            this.textPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.textPosition.Size = new System.Drawing.Size(198, 22);
            this.textPosition.TabIndex = 20;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(489, 352);
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(115, 59);
            this.textUsername.Name = "textUsername";
            this.textUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textUsername.Size = new System.Drawing.Size(198, 22);
            this.textUsername.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Username:";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 352);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.CheckButton checkButtonIsNew;
        private DevExpress.XtraEditors.TextEdit textLname;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textFName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textAddress;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ImageEdit imageEdit1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textID;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit textContact;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit textPosition;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdate;
        private DevExpress.XtraEditors.TextEdit textUsername;
        private System.Windows.Forms.Label label9;
    }
}