using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaShopLib
{
    interface IControllerFactory
    {
        IProductController CreateProductController();
        ICategoryController CreateCategoryController();

    }
}
