namespace KoalaShop
{
    partial class FormChangePass
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
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupChange = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtVerify = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNew = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtOld = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChange)).BeginInit();
            this.groupChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerify.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pictureEdit1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupChange);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(528, 377);
            this.splitContainerControl1.SplitterPosition = 139;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(528, 139);
            this.pictureEdit1.TabIndex = 2;
            // 
            // groupChange
            // 
            this.groupChange.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupChange.AppearanceCaption.Options.UseFont = true;
            this.groupChange.Controls.Add(this.simpleButtonCancel);
            this.groupChange.Controls.Add(this.simpleButtonSave);
            this.groupChange.Controls.Add(this.txtVerify);
            this.groupChange.Controls.Add(this.labelControl3);
            this.groupChange.Controls.Add(this.txtNew);
            this.groupChange.Controls.Add(this.labelControl2);
            this.groupChange.Controls.Add(this.txtOld);
            this.groupChange.Controls.Add(this.labelControl1);
            this.groupChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupChange.Location = new System.Drawing.Point(0, 0);
            this.groupChange.Name = "groupChange";
            this.groupChange.Size = new System.Drawing.Size(528, 233);
            this.groupChange.TabIndex = 3;
            this.groupChange.Text = "Change Password";
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButtonCancel.Location = new System.Drawing.Point(320, 159);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(80, 37);
            this.simpleButtonCancel.TabIndex = 7;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click_1);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButtonSave.Location = new System.Drawing.Point(236, 159);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(80, 37);
            this.simpleButtonSave.TabIndex = 6;
            this.simpleButtonSave.Text = "Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click_1);
            // 
            // txtVerify
            // 
            this.txtVerify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVerify.Location = new System.Drawing.Point(188, 119);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtVerify.Properties.PasswordChar = '*';
            this.txtVerify.Size = new System.Drawing.Size(255, 22);
            this.txtVerify.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Location = new System.Drawing.Point(86, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Verify Password:";
            // 
            // txtNew
            // 
            this.txtNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNew.Location = new System.Drawing.Point(188, 91);
            this.txtNew.Name = "txtNew";
            this.txtNew.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtNew.Properties.PasswordChar = '*';
            this.txtNew.Size = new System.Drawing.Size(255, 22);
            this.txtNew.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Location = new System.Drawing.Point(86, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "New Password:";
            // 
            // txtOld
            // 
            this.txtOld.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOld.Location = new System.Drawing.Point(188, 63);
            this.txtOld.Name = "txtOld";
            this.txtOld.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtOld.Properties.PasswordChar = '*';
            this.txtOld.Size = new System.Drawing.Size(255, 22);
            this.txtOld.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(86, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Old Password:";
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 377);
            this.Controls.Add(this.splitContainerControl1);
            this.MaximizeBox = false;
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Pass";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChange)).EndInit();
            this.groupChange.ResumeLayout(false);
            this.groupChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerify.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupChange;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.TextEdit txtVerify;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNew;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtOld;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}