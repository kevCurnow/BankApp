using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models.TransactionModels;
using Bank.Services;

namespace Bank.Presentation.ATMConsole.Controllers
{
    public class TransactionATMController
    {
        private static TransactionService CreateTransactionService()
        {
            var svc = new TransactionService();
            return svc;
        }
        private static AccountService CreateAccountService()
        {
            var svc = new AccountService();
            return svc;
        }

        public static int CreateTransactionConsole(string accountNum, int transactionType)
        {
            int accountId = GetAccountIdFromAccountNumberForConsole(accountNum);

            TransactionCreateModel transaction = new TransactionCreateModel
            {
                AccountID = accountId,
                TransactionType = transactionType,
                CreatedUtc = DateTime.Now
            };
            int transactionId = CreateTransactionService().CreateTransaction(transaction);
            return transactionId;
        }

        private static int GetAccountIdFromAccountNumberForConsole(string accountNum)
        {
            CreateAccountService().GetAccountId(accountNum);
            int accountId = CreateAccountService().GetAccountId(accountNum);
            return accountId;
        }
    }
}
