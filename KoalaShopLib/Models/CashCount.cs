using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaShopLib.Models
{
    public partial class CashCount
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime TimeIn { get; set; }
        public System.DateTime TimeOut { get; set; }
        public decimal Count { get; set; }

        public int EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
