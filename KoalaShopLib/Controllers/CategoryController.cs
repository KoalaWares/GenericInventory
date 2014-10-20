using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KoalaShopLib.EFRepositories;
using KoalaShopLib.Models;
namespace KoalaShopLib.Controllers
{
    class CategoryController : AbstractRepository<Category>, ICategoryController 
    {
        public CategoryController(DataAppContext dbContext)
            :base(dbContext)
        {
                
        }
    }
}
