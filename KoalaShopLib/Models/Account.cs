namespace KoalaShopLib.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Account
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public AccountType AccountType { get; set; }
        public int EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }
    }

    public enum AccountType
    {
        Admin, Cashier, Purchaser
    }
}
