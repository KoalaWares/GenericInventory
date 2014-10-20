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
namespace KoalaShopLib.Controllers
{
    class ProductController: AbstractRepository<Product>, IProductController
    {
        public ProductController(DataAppContext dbContext)
            : base(dbContext)
        {
            AutoMapper.Mapper.CreateMap<Product, ProductView>();
        }

        public List<Models.ViewModel.ProductView> GetAllProductViews()
        {
            List<Models.ViewModel.ProductView> products = new List<Models.ViewModel.ProductView>();
            var rawProducts = this.GetAll();

            foreach (Product i in rawProducts)
            {
                ProductView p = AutoMapper.Mapper.Map<ProductView>(i);
                p.Category = i.Category.Name;

                if (i.Stocks.Count > 0)
                {
                    int quantity = 0;

                    foreach (var item in i.Stocks)
                    {
                        quantity = quantity + item.Quantity;
                    }

                    p.Quantity = quantity;
                }

                products.Add(p);
            }

            return products;
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
