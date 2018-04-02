using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models.Account_Models
{
    public class AccountDetailModel
    {
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string Pin { get; set; }
        public int AccountType { get; set; }
        public decimal Balance { get; set; }
    }
}
