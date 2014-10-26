using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoalaShopLib;
using KoalaShopLib.Models;
using KoalaShopLib.EFRepositories;
namespace KoalaShopLib
{
    internal class RepositoryFactory : IRepositoryFactory
    {
        DataAppContext dbContext = null;

        public RepositoryFactory( DataAppContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        #region IRepositoryFactory Members

        public IRepository<T> CreateRepo<T>() where T:class
        {
            //return new GenericRepo<T>(this.dbContext);
            return new GenericRepo<T>(ContextFactory.CraeteContext());
        }

        public IRepository<Product> CreateProductRepo()
        {
            //return new ProductRepo(this.dbContext);
            return new ProductRepo(ContextFactory.CraeteContext());
        }

        #endregion
    }
}
