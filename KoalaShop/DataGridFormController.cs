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
        SimpleButton SaveButton { set; get; }
        CheckButton NewObjectToggleButton { set; get; }
        GridView GridView { set; get; }

        public DataGridFormController(SimpleButton saveButton, CheckButton newObjectToggle, GridView gridview, XtraForm form)
        {
            SaveButton = saveButton;
            NewObjectToggleButton = newObjectToggle;
            GridView = gridview;
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
            return this.GridView.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
