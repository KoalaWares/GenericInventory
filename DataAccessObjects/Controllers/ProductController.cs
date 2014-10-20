using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KoalaShopLib.Models;
using KoalaShopLib.Models.ViewModel;
using KoalaShopLib.EFRepositories;
namespace KoalaShopLib.Controllers
{
    class ProductController: EFRepositories.GenericRepo<Product>, IProductController
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
    }
}
