using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models.Account_Models
{
    public class AccountListItemModel
    {
        [Required]
        public int AccountId { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        public string Pin { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}
