using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaShop
{
    public interface IDataGridForm
    {
        bool IsNew { get; set; }
        void RefreshList();
        void MapSelectedObjectToDetailsPane();
        void ToggleNewObjectButton();
        void SaveObjectToDB();
    }
}
