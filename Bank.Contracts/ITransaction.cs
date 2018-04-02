using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models.TransactionModels;

namespace Bank.Contracts
{
    public interface ITransaction
    {
        bool CreateTransaction(TransactionCreateModel model);
        TransactionDetailModel GetTransactionById(int id);
        IEnumerable<TransactionListItemModel> GetTransactions();
    }
}
