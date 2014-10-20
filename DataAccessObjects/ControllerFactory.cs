using KoalaShopLib.Controllers;
using KoalaShopLib.EFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaShopLib
{
    class ControllerFactory : IControllerFactory
    {
        DataAppContext dbContext = null;

        public ControllerFactory(DataAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IProductController CreateProductController()
        {
            return new ProductController(this.dbContext);
        }

        public ICategoryController CreateCategoryController()
        {
            return new CategoryController(this.dbContext);
        }
    }
}
