using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoalaShopLib.Models;
namespace KoalaShop
{
    public interface IMainForm
    {
        Account CurrenUser { get; set; }
    }
}
