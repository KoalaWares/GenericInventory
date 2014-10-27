using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using KoalaShopLib.Models;
using KoalaShopLib.Models.ViewModel;
using KoalaShopLib.EFRepositories;
using System.Linq.Expressions;
namespace KoalaShopLib.EFRepositories
{
    class ProductRepo: AbstractRepository<Product>//, IProductController
    {
        public ProductRepo(DataAppContext dbContext)
            : base(dbContext)
        {
            
        }

        public override List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            try
            {
                IQueryable<Product> entities = this.dbContext.Set<Product>();

                if (filter != null)
                {
                    entities = entities.Where(filter);
                }
                //Load related data
                return entities
                    .Include(p => p.Category)
                    .Include(p => p.Stocks)
                    .ToList();
            }
            catch
            {
                throw;
            }
        }

        public override Product GetByID(object id)
        {
            try
            {
                var entity = this.dbContext.Set<Product>()
                    .Include(p => p.Category)
                    .Include(p => p.Stocks)
                    .Where(p => (object)p.ID == id)
                    .SingleOrDefault();

                return entity;
            }
            catch
            {
                throw;
            }
        }

    }
}
