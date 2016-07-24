using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        #region Variables
        /// <summary>
        ///  private balance used for Account inside functions
        /// </summary>
        private decimal balance;
        /// <summary>
        /// static private LastId shared by all account instances
        /// </summary>
        #endregion

        #region Static

        //private static int lastId = 0;

        #endregion

        #region Properties


        /// <summary>
        /// Account Id
        /// </summary>

        /// this part code will not work interms of increasing id based on lastId 
        /// because set will not execute until set valuing to it
        /// Instead we will use constructor to override our constructor
        /// which will allows us to reset ID event before other properties set for this
        /// account
        /*public int Id
        {
            get
            {
                return id;
            }
           private set
           {
                id = lastId + 1;
           }
        }*/
        [Key]
        public int Id { get; private set; }



        /// <summary>
        /// Acount Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account Balance
        /// </summary>
        // auto properties - backing field varible behind your property
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set // only excecute set function when Balance += amount 
            {
                if (value >= 0)  // value from left hand side
                {
                    balance = value;
                }

            }
        }

        public AccountTypes TypeOfAccount { get; set; }
        public virtual Customer Customer { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        ///  Constructor to rest property Id
        ///  Will be executed first when constructing class
        /// </summary>
        //public Account()  // if private,you cannot call new outside this class
        //{ 
        /// Id from Account property
        //  Id = ++lastId;
        // }
        public Account()
        {
            Balance = 300;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Deposite money into account
        /// </summary>
        /// <param name="amount"> Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            Balance += amount; // Balance:set
        }
        /// <summary>
        /// Withdraw Money From Account
        /// </summary>
        /// <param name="amount"></param>
        public void WithDraw(decimal amount)
        {
            /// We Could Write if condition to check balance 
            /// but these same piece code will be repeated 
            /// for several places like in transation function
            /// Instead we will move if balance condition check to 
            /// Balance property set check
            Balance -= amount; // Balance:set
        }
        #endregion
    }
}
