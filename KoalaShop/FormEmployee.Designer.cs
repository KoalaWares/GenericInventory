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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new KoalaShop.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.checkButtonIsNew = new DevExpress.XtraEditors.CheckButton();
            this.simpleButtonBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.textPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textContact = new DevExpress.XtraEditors.TextEdit();
            this.textAddress = new DevExpress.XtraEditors.TextEdit();
            this.textLname = new DevExpress.XtraEditors.TextEdit();
            this.textFName = new DevExpress.XtraEditors.TextEdit();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.textUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new KoalaShop.DataSet1TableAdapters.EmployeesTableAdapter();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new KoalaShop.DataSet1TableAdapters.AccountsTableAdapter();
            this.accountsTableAdapter1 = new KoalaShop.DataSet1TableAdapters.AccountsTableAdapter();
            this.txtAcct = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.employeesBindingSource2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView3;
            gridLevelNode1.RelationName = "Account";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(648, 420);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3,
            this.gridView2});
            // 
            // employeesBindingSource2
            // 
            this.employeesBindingSource2.DataMember = "Employees";
            this.employeesBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFname,
            this.colLname,
            this.colAddress,
            this.colContact});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colFname
            // 
            this.colFname.Caption = "First Name";
            this.colFname.FieldName = "Fname";
            this.colFname.Name = "colFname";
            this.colFname.Visible = true;
            this.colFname.VisibleIndex = 1;
            // 
            // colLname
            // 
            this.colLname.Caption = "Last Name";
            this.colLname.FieldName = "Lname";
            this.colLname.Name = "colLname";
            this.colLname.Visible = true;
            this.colLname.VisibleIndex = 2;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            // 
            // colContact
            // 
            this.colContact.Caption = "Contact Number";
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 4;
            // 
            // gridView3
            // 
            this.gridView3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView3.GroupPanelText = "Account";
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
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
            this.splitContainerControl1.Size = new System.Drawing.Size(990, 420);
            this.splitContainerControl1.SplitterPosition = 337;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.simpleButtonUpdate);
            this.groupControl1.Controls.Add(this.simpleButtonSave);
            this.groupControl1.Controls.Add(this.checkButtonIsNew);
            this.groupControl1.Controls.Add(this.simpleButtonBrowse);
            this.groupControl1.Controls.Add(this.textPosition);
            this.groupControl1.Controls.Add(this.textContact);
            this.groupControl1.Controls.Add(this.textAddress);
            this.groupControl1.Controls.Add(this.textLname);
            this.groupControl1.Controls.Add(this.textFName);
            this.groupControl1.Controls.Add(this.textPassword);
            this.groupControl1.Controls.Add(this.textUsername);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtAcct);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(333, 416);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Employee Details";
            // 
            // simpleButtonUpdate
            // 
            this.simpleButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonUpdate.Location = new System.Drawing.Point(185, 378);
            this.simpleButtonUpdate.Name = "simpleButtonUpdate";
            this.simpleButtonUpdate.Size = new System.Drawing.Size(143, 28);
            this.simpleButtonUpdate.TabIndex = 58;
            this.simpleButtonUpdate.Text = "Update";
            this.simpleButtonUpdate.Click += new System.EventHandler(this.simpleButtonUpdate_Click);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSave.Location = new System.Drawing.Point(185, 378);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(143, 28);
            this.simpleButtonSave.TabIndex = 57;
            this.simpleButtonSave.Text = "Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click_1);
            // 
            // checkButtonIsNew
            // 
            this.checkButtonIsNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButtonIsNew.Location = new System.Drawing.Point(115, 378);
            this.checkButtonIsNew.Name = "checkButtonIsNew";
            this.checkButtonIsNew.Size = new System.Drawing.Size(64, 28);
            this.checkButtonIsNew.TabIndex = 56;
            this.checkButtonIsNew.Text = "New";
            this.checkButtonIsNew.CheckedChanged += new System.EventHandler(this.checkButtonIsNew_CheckedChanged_1);
            // 
            // simpleButtonBrowse
            // 
            this.simpleButtonBrowse.Location = new System.Drawing.Point(120, 266);
            this.simpleButtonBrowse.Name = "simpleButtonBrowse";
            this.simpleButtonBrowse.Size = new System.Drawing.Size(96, 23);
            this.simpleButtonBrowse.TabIndex = 55;
            this.simpleButtonBrowse.Text = "Browse";
            // 
            // textPosition
            // 
            this.textPosition.Location = new System.Drawing.Point(120, 240);
            this.textPosition.Name = "textPosition";
            this.textPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textPosition.Properties.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Purchaser"});
            this.textPosition.Size = new System.Drawing.Size(198, 20);
            this.textPosition.TabIndex = 54;
            // 
            // textContact
            // 
            this.textContact.Location = new System.Drawing.Point(120, 207);
            this.textContact.Name = "textContact";
            this.textContact.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textContact.Size = new System.Drawing.Size(198, 22);
            this.textContact.TabIndex = 53;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(120, 180);
            this.textAddress.Name = "textAddress";
            this.textAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textAddress.Size = new System.Drawing.Size(198, 22);
            this.textAddress.TabIndex = 52;
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(120, 148);
            this.textLname.Name = "textLname";
            this.textLname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textLname.Size = new System.Drawing.Size(198, 22);
            this.textLname.TabIndex = 51;
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(120, 121);
            this.textFName.Name = "textFName";
            this.textFName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textFName.Size = new System.Drawing.Size(198, 22);
            this.textFName.TabIndex = 50;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(120, 89);
            this.textPassword.Name = "textPassword";
            this.textPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textPassword.Properties.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(198, 22);
            this.textPassword.TabIndex = 49;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(120, 62);
            this.textUsername.Name = "textUsername";
            this.textUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textUsername.Size = new System.Drawing.Size(198, 22);
            this.textUsername.TabIndex = 48;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Image:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Password:";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(120, 34);
            this.textID.Name = "textID";
            this.textID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textID.Size = new System.Drawing.Size(198, 22);
            this.textID.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "First Name:";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.dataSet1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.dataSet1;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // accountsTableAdapter1
            // 
            this.accountsTableAdapter1.ClearBeforeFill = true;
            // 
            // txtAcct
            // 
            this.txtAcct.Location = new System.Drawing.Point(120, 268);
            this.txtAcct.Name = "txtAcct";
            this.txtAcct.Size = new System.Drawing.Size(63, 13);
            this.txtAcct.TabIndex = 59;
            this.txtAcct.Text = "labelControl2";
            this.txtAcct.Visible = false;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 420);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.TextEdit textUsername;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textContact;
        private DevExpress.XtraEditors.TextEdit textAddress;
        private DevExpress.XtraEditors.TextEdit textLname;
        private DevExpress.XtraEditors.TextEdit textFName;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBrowse;
        private DevExpress.XtraEditors.ComboBoxEdit textPosition;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.CheckButton checkButtonIsNew;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFname;
        private DevExpress.XtraGrid.Columns.GridColumn colLname;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DataSet1TableAdapters.AccountsTableAdapter accountsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource employeesBindingSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DataSet1TableAdapters.AccountsTableAdapter accountsTableAdapter1;
        private DevExpress.XtraEditors.LabelControl txtAcct;
    }
}