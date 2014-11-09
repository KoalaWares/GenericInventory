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
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupChange = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOld = new DevExpress.XtraEditors.TextEdit();
            this.txtNew = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtVerify = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChange)).BeginInit();
            this.groupChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerify.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(0, -2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(390, 129);
            this.pictureEdit1.TabIndex = 0;
            // 
            // groupChange
            // 
            this.groupChange.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupChange.AppearanceCaption.Options.UseFont = true;
            this.groupChange.Controls.Add(this.buttonSave);
            this.groupChange.Controls.Add(this.txtVerify);
            this.groupChange.Controls.Add(this.labelControl3);
            this.groupChange.Controls.Add(this.txtNew);
            this.groupChange.Controls.Add(this.labelControl2);
            this.groupChange.Controls.Add(this.txtOld);
            this.groupChange.Controls.Add(this.labelControl1);
            this.groupChange.Location = new System.Drawing.Point(0, 133);
            this.groupChange.Name = "groupChange";
            this.groupChange.Size = new System.Drawing.Size(390, 178);
            this.groupChange.TabIndex = 1;
            this.groupChange.Text = "Change Password";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Old Password:";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(132, 43);
            this.txtOld.Name = "txtOld";
            this.txtOld.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtOld.Properties.PasswordChar = '*';
            this.txtOld.Size = new System.Drawing.Size(217, 22);
            this.txtOld.TabIndex = 1;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(132, 71);
            this.txtNew.Name = "txtNew";
            this.txtNew.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtNew.Properties.PasswordChar = '*';
            this.txtNew.Size = new System.Drawing.Size(217, 22);
            this.txtNew.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "New Password:";
            // 
            // txtVerify
            // 
            this.txtVerify.Location = new System.Drawing.Point(132, 99);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtVerify.Properties.PasswordChar = '*';
            this.txtVerify.Size = new System.Drawing.Size(217, 22);
            this.txtVerify.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Verify Password:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(269, 127);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 37);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "SAVE";
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 309);
            this.Controls.Add(this.groupChange);
            this.Controls.Add(this.pictureEdit1);
            this.MaximizeBox = false;
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Pass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChange)).EndInit();
            this.groupChange.ResumeLayout(false);
            this.groupChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerify.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupChange;
        private DevExpress.XtraEditors.TextEdit txtOld;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNew;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtVerify;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
    }
}