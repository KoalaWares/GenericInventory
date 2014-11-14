using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
namespace KoalaShop
{
    public class DataGridFormController
    {
        public bool IsNewObject = false;
        SimpleButton SaveButton { set; get; }
        SimpleButton UpdateButton { set; get; }
        CheckButton NewObjectToggleButton { set; get; }
        GridView GridView { set; get; }

        public DataGridFormController(SimpleButton updateButton, SimpleButton saveButton, CheckButton newObjectToggle, GridView gridview, XtraForm form)
        {
            SaveButton = saveButton;
            UpdateButton = updateButton;
            NewObjectToggleButton = newObjectToggle;
            GridView = gridview;
        }



        public void ToggleNewObjectButton()
        {
          ////  string saveButtonText = "Update";

          //  IsNewObject = !IsNewObject;

          //  if (IsNewObject)
          //  {
          //    //  saveButtonText = "Save";
               
          //  }

          ////  SaveButton.Text = saveButtonText;
            SaveButton.Visible = true;
            UpdateButton.Visible = false;
        }

        public void UpdateObjectButton()
        {
            UpdateButton.Visible = true;
            SaveButton.Visible = false;
        }

        public string GetSelectedObjectID()
        {
            return this.GridView.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
