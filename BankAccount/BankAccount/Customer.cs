using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// This is Class defiens a customer
    /// </summary>
    public class Customer
    {
        #region Properies
        /// <summary>
        /// Customer Id
        /// </summary>
        
        //[Key] Primary Key
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Customer Name
        /// </summary>
        [StringLength(250)]
        public string Name { get; set; }

        /// <summary>
        /// Customer Email Address
        /// </summary>
        public string EmailAdress { get; set; }

        /// <summary>
        /// Customer Address
        /// </summary>
        public string Address { get; set; }
        #endregion
    }
}
