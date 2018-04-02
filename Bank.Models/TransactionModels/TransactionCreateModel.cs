using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models.TransactionModels
{
    public class TransactionCreateModel
    {
        [Required]
        public int TransactionType { get; set; }

        [Required]
        public int AccountID { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}
