using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaShopLib
{
    public class KoalaShopFactory
    {
        public static IKoalaShop CreateKoalaShop()
        {
            return new KoalaShop();
        }
    }
}
