using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
namespace KoalaShop
{
    public class DataGridFormController
    {
        public bool IsNewObject = false;
        SimpleButton SaveButton { set;get; }
        CheckButton NewObjectToggleButton { set; get; }
        GridView GridView { set; get; }


        public DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        public DevExpress.XtraEditors.CheckButton checkButtonIsNewToggle;

        public DataGridFormController(SimpleButton saveButton, CheckButton newObjectToggle, GridView gridview, XtraForm form)
        {
            SaveButton = saveButton;
            NewObjectToggleButton = newObjectToggle;
            GridView = gridview;
        }

        public DataGridFormController(XtraForm form)
        {
            this.AddComponentsToForm(form);
        }

        public void ToggleNewObjectButton()
        {
            string saveButtonText = "Update";

            IsNewObject = !IsNewObject;

            if (IsNewObject)
            {
                saveButtonText = "Save";
            }

            SaveButton.Text = saveButtonText;
        }

        public string GetSelectedObjectID()
        {
            return GridView.GetFocusedRowCellValue("Id").ToString();
        }

        void AddComponentsToForm(XtraForm form)
        {


            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.checkButtonIsNewToggle = new DevExpress.XtraEditors.CheckButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            form.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(784, 362);
            this.splitContainerControl1.SplitterPosition = 230;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButtonSave);
            this.groupControl1.Controls.Add(this.checkButtonIsNewToggle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(230, 362);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Object Details";
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSave.Location = new System.Drawing.Point(65, 322);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(160, 28);
            this.simpleButtonSave.TabIndex = 6;
            this.simpleButtonSave.Text = "Update";

            // 
            // checkButtonIsNewToggle
            // 
            this.checkButtonIsNewToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButtonIsNewToggle.Location = new System.Drawing.Point(5, 322);
            this.checkButtonIsNewToggle.Name = "checkButtonIsNewToggle";
            this.checkButtonIsNewToggle.Size = new System.Drawing.Size(54, 28);
            this.checkButtonIsNewToggle.TabIndex = 5;
            this.checkButtonIsNewToggle.Text = "New";

            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(549, 362);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // BaseDataGridForm
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(784, 362);
            form.Controls.Add(this.splitContainerControl1);
            //form.Name = "BaseDataGridForm";
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.Text = "XtraFormBasicGrid";
            form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            form.ResumeLayout(false);

        }
        
    }
}
