using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaShopLib.Models
{
    public class Expenses
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Purpose { get; set; }
        public System.DateTime Date { get; set; }
        public string Category { get; set; }

        public int EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
