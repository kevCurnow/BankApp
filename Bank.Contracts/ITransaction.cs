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
        int CreateTransaction(TransactionCreateModel model);
        IEnumerable<TransactionListItemModel> GetTransactions();
    }
}
