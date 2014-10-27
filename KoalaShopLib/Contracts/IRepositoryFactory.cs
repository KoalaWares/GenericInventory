using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KoalaShopLib.Models;
using KoalaShopLib.EFRepositories;
namespace KoalaShopLib
{
    public interface IRepositoryFactory
    {
        IRepository<T> CreateRepo<T>() where T : class;

        IRepository<Product> CreateProductRepo();
    }
}
