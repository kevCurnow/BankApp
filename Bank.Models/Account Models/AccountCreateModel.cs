using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models.Account_Models
{
    public class AccountCreateModel
    {
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string Pin { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public int AccountType { get; set; }
        public decimal Balance { get; set; }
    }
}
