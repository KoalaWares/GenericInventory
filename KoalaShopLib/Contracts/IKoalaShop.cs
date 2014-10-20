using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KoalaShopLib.Models;
namespace KoalaShopLib
{
    public interface IKoalaShop
    {
        IProductController ProductController { get; }
        ICategoryController CategoryController { get;}

        //TODO: add more if needed
    }

    public interface IProductController:IRepository<Product>
    {
        List<Models.ViewModel.ProductView> GetAllProductViews();
        //TODO: add more if needed
    }

    public interface ICategoryController:IRepository<Category>
    {
        //TODO: add more if needed
    }
}
