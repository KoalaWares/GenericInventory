using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KoalaShopLib.Models;
using KoalaShopLib.Models.ViewModel;
using KoalaShopLib.EFRepositories;
namespace KoalaShopLib
{
    public interface IKoalaShop : IInventory, IAuthentication
    {
        IRepository<Account> AccountRepo { get;}
        IRepository<Category> CategoryRepo { get; }
        IRepository<Customer> CustomerRepo { get; }
        IRepository<Employee> EmployeeRepo { get; }
        IRepository<Invoice> InvoiceRepo { get; }
        IRepository<InvoiceItem> InvoiceItemRepo { get; }
        IRepository<Stock> StockRepo { get; }
        IRepository<StocksRequest> StocksRequestRepo { get; }
        IRepository<Supplier> SupplierRepo { get; }

        IRepository<Product> ProductRepo { get; }
        //TODO: add more if needed

    }

    public interface IProductController : IRepository<Product>
    {
        List<ProductView> GetAllProductViews();
        //TODO: add more if needed
    }

    public interface IInventory
    {
        //product
        List<ProductView> GetProductsForView();


        //category

        //vendor
    }

    public interface IAuthentication
    {
        Account Login(string username, string password);
    }
}
