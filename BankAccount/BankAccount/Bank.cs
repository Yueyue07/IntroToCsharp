using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public enum AccountTypes // value type
    {
        Checking = 1,
        Savings = 2,
        CD = 3,
        Loan = 4
    }
    public static class Bank
    {

        #region Properties
        public static string Name { get; set; }
        #endregion


        #region Methods
        public static Customer CreateCustomer(string name, string emailAddress, string address)
        {
            var customer = new Customer {
                            Name = name, 
                            Address = address, 
                            EmailAdress = emailAddress
                            };
            // connect to databse
            var db = new BankModel();
            // add customer to Customers Table
            db.Customers.Add(customer);
            // Update Databse;
            db.SaveChanges();
            db.Dispose();
            CreateAccount("Default", AccountTypes.Checking, customer);
            return customer;
        }

        public static Account CreateAccount(string accountName, AccountTypes typeofAccount, Customer customer)
        {
            var account = new Account
            {
                Name = accountName,
                TypeOfAccount = typeofAccount,
                Customer = customer
            };

            var db = new BankModel();
            db.Accounts.Add(account);
            db.SaveChanges();
            db.Dispose();

            return account; 
        }

        public static IEnumerable<Account> GetAllAccountsByCustomerEmail(string emaillAddress)
        {
            var db = new BankModel();
            //var customer = db.Customers.Where(c => c.EmailAdress == emaillAddress).FirstOrDefault(); //  Lamda Expression
            //if (customer == null)
            //    return null;
            //db.Accounts.Where(a => a.Customer.Id == customer.Id);
            var accounts = db.Accounts.Where(a => a.Customer.EmailAdress == emaillAddress);
            return accounts;
        }
        #endregion


    }
}
