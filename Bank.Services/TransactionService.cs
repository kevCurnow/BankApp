using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.TransactionModels;
using Bank.Data;

namespace Bank.Services
{
    public class TransactionService : ITransaction
    {
        private BankEntities db = new BankEntities();

        public int CreateTransaction(TransactionCreateModel model)
        {
            using (var ctx = new BankEntities())
            {
                var entity = new Transaction
                {
                    TransactionType = model.TransactionType,
                    AccountID = model.AccountID
                };
                ctx.Transactions.Add(entity);
                ctx.SaveChanges();

                return entity.TransactionID;
            }
        }

        public Transaction GetTransactionById(int id)
        {
            Transaction transactionId = db.Transactions.Find(id);
            if (transactionId == null)
            {
                Console.WriteLine("Sorry, we couldn't find that id.");
            }
            return transactionId;
        }

        public IEnumerable<TransactionListItemModel> GetTransactions()
        {
            throw new NotImplementedException();
        }
    }
}
