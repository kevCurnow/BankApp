﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models.DepositModels
{
    public class DepositListItemModel
    {
        [Required]
        public int DepositID { get; set; }

        [Required]
        public int TransactionID { get; set; }
        public decimal Amount { get; set; }
    }
}
