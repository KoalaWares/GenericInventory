using System;
using System.Data.Entity;
using System.Linq;
using KoalaShopLib.Models;

namespace KoalaShopLib.EFRepositories
{

    internal class DataAppContext : DbContext
    {
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Emloyees { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StocksRequest> StockRequests { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<CashCount> CashCount { get; set; }
        
        public DataAppContext()
            : base("name=DataAppContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }


    }

}