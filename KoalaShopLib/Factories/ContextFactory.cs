using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KoalaShopLib.EFRepositories;
namespace KoalaShopLib
{
    class ContextFactory
    {
        public static DataAppContext CraeteContext()
        {
            return new DataAppContext();
        }
    }
}
