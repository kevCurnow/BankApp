using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.TransactionModels;

namespace Bank.Services
{
    public class TransactionService : ITransaction
    {
        public bool CreateTransaction(TransactionCreateModel model)
        {
            throw new NotImplementedException();
        }

        public TransactionDetailModel GetTransactionById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransactionListItemModel> GetTransactions()
        {
            throw new NotImplementedException();
        }
    }
}
