using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KoalaShopLib.Models.ViewModel;
using KoalaShopLib.Models;
using KoalaShopLib.EFRepositories;
namespace KoalaShopLib
{
    class KoalaShop:IKoalaShop
    {
        DataAppContext dbContext = null;
        //IControllerFactory controllerFactory = null;
        IRepositoryFactory repoFactory = null;
 
        public KoalaShop()
        {
            this.dbContext = ContextFactory.CraeteContext();
            //this.controllerFactory = new ControllerFactory(this.dbContext);
            this.repoFactory = new RepositoryFactory(this.dbContext);

            //Automapper
            AutoMapper.Mapper.CreateMap<Product, ProductView>();

            #region Seed
            //REMOVE ON DEPLOYMENT, THIS IS FOR SEEDING TEST DATA
            if (!(this.dbContext.Emloyees.Count() > 0))
            {
                this.dbContext.Emloyees.Add(new Employee()
                {
                    Fname = "root",
                    Lname = "root",
                    Contact = "1111",
                    Address = "root"
                });

                this.dbContext.SaveChanges();
            }

            if (!(this.dbContext.Accounts.Count() > 0))
            {
                this.dbContext.Accounts.Add(new Account()
                {
                    EmployeeID = 1,
                    Username = "root",
                    Password = "toor",
                    AccountType = AccountType.Admin
                });

                this.dbContext.Accounts.Add(new Account()
                {
                    EmployeeID = 1,
                    Username = "cashier",
                    Password = "cashier",
                    AccountType = AccountType.Cashier
                });

                this.dbContext.Accounts.Add(new Account()
                {
                    EmployeeID = 1,
                    Username = "purchaser",
                    Password = "purchaser",
                    AccountType = AccountType.Purchaser
                });
                this.dbContext.SaveChanges();
            }

            //SEED Category
            if (!(this.dbContext.Categories.Count() > 0))
            {
                this.dbContext.Categories.Add(new Category() { Name = "NA" });
                this.dbContext.Categories.Add(new Category() { Name = "Food" });
                this.dbContext.SaveChanges();
            }

            //seed Suppliers
            //SEED Category
            if (!(this.dbContext.Suppliers.Count() > 0))
            {
                this.dbContext.Suppliers.Add(new Supplier() { Name = "NA",Contact="NA" });
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
            #endregion
        }

        #region REPOS/CONTROLLERS

        public IRepository<Product> ProductRepo
        {
            get
            {
                return this.repoFactory.CreateProductRepo();
            }
        }

        public IRepository<Account> AccountRepo
        {
            get { return this.repoFactory.CreateRepo<Account>(); }
        }

        public IRepository<Category> CategoryRepo
        {
            get { return this.repoFactory.CreateRepo<Category>(); }
        }

        public IRepository<Customer> CustomerRepo
        {
            get { return this.repoFactory.CreateRepo<Customer>(); }
        }

        public IRepository<Employee> EmployeeRepo
        {
            get { return this.repoFactory.CreateRepo<Employee>(); }
        }

        public IRepository<Invoice> InvoiceRepo
        {
            get { return this.repoFactory.CreateRepo<Invoice>(); }
        }

        public IRepository<InvoiceItem> InvoiceItemRepo
        {
            get { return this.repoFactory.CreateRepo<InvoiceItem>(); }
        }

        public IRepository<Stock> StockRepo
        {
            get { return this.repoFactory.CreateRepo<Stock>(); }
        }

        public IRepository<StocksRequest> StocksRequestRepo
        {
            get { return this.repoFactory.CreateRepo<StocksRequest>(); }
        }

        public IRepository<Supplier> SupplierRepo
        {
            get { return this.repoFactory.CreateRepo<Supplier>(); }
        }
        #endregion


        #region IInventory Members

        public List<ProductView> GetProductsForView()
        {
            List<Models.ViewModel.ProductView> products = new List<Models.ViewModel.ProductView>();
            var rawProducts = this.ProductRepo.GetAll();

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

        #endregion

        #region IAuthentication Members

        public Account Login(string username, string password)
        {
            Account account = null;

            account = this.AccountRepo.GetAll(a => a.Username == username && a.Password == password).SingleOrDefault();

            return account;
        }

        #endregion

        public void Dispose()
        {
            this.dbContext.Dispose();
        }
    }
}
