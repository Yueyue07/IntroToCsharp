using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //// instance of the class -> objects
            //var account = new Account(); // constructing object
            //account.Name = "Yueyue";
            //account.Deposit(6000);
            //account.WithDraw(2000);
            //Console.WriteLine("Id: {0}, Name: {1}, Balance: {2:c}", account.Id, account.Name, account.Balance);

            //var account2 = new Account();
            //account2.Name = "Wenwei";
            //Console.WriteLine("Id: {0}, Name: {1}, Balance: {2:c}", account2.Id, account2.Name, account2.Balance);

            var c1 = Bank.CreateCustomer("Name1", "yueyue.qin1007@gmail.com", "Seattle,WA");

            var accounts = Bank.GetAllAccountsByCustomerEmail("yueyue.qin1007@gmail.com");
            foreach (var account in accounts)
            {
                Console.WriteLine("account name: {0}", account.Name);
            }
        }
    }
}
