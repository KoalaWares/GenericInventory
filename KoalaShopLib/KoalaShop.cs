using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KoalaShopLib.Models.ViewModel;
using KoalaShopLib.Models;
using KoalaShopLib.Controllers;
using KoalaShopLib.EFRepositories;
namespace KoalaShopLib
{
    class KoalaShop:IKoalaShop
    {
        DataAppContext dbContext = null;
        IControllerFactory controllerFactory = null;

        public KoalaShop()
        {
            this.dbContext = ContextFactory.CraeteContext();
            this.controllerFactory = new ControllerFactory(this.dbContext);

            //REMOVE ON DEPLOYMENT, THIS IS FOR SEEDING TEST DATA
            //SEED Category
            if (!(this.dbContext.Categories.Count() > 0))
            {
                this.dbContext.Categories.Add(new Category() { Name = "Foods" });
                this.dbContext.Categories.Add(new Category() { Name = "Condoms" });
                this.dbContext.SaveChanges();
            }

            //SEED Product
            if (!(this.dbContext.Products.Count() > 0))
            {
                this.dbContext.Products.Add(new Product() { Name = "Canton Chili", Description = "Chili Falvor", CategoryID = 1 });
                this.dbContext.Products.Add(new Product() { Name = "Canton Calamansi", Description = "Calamansi Falvor", CategoryID = 1 });
                this.dbContext.Products.Add(new Product() { Name = "PUKA PORN Condom", Description = "Make PUKA PORN!", CategoryID = 1 });
                this.dbContext.SaveChanges();
            }
        }

        public IProductController ProductController
        {
            get 
            {
                return this.controllerFactory.CreateProductController(); 
            }
        }

        public ICategoryController CategoryController
        {
            get 
            { 
                return this.controllerFactory.CreateCategoryController(); 
            }
        }
    }
}
