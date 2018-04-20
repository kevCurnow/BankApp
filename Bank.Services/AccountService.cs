using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.Account_Models;
using Bank.Data;

namespace Bank.Services
{
    public class AccountService : IAccount
    {
        private BankEntities db = new BankEntities();

        public int GetAccountId(string accountNum)
        {
            BankEntities context = new BankEntities();
            var query = from a in context.Accounts
                        where a.AccountNumber == accountNum
                        select a;

            foreach(var account in query)
            {
                return account.AccountID;
            }
            return 0;
        }

        public string CreateRandomAccountNumber()
        {
            Random random = new Random();
            int acctNum = random.Next(1, 5000);
            string accountNum = acctNum.ToString();
            return accountNum;

        }

        public bool CreateAccount(AccountCreateModel model)
        {
            using (var ctx = new BankEntities())
            {
                var entity = new Account
                {
                    AccountNumber = model.AccountNumber,
                    AccountType = model.AccountType,
                    Balance = model.Balance,
                    Pin = model.Pin,
                    CustomerID = model.CustomerId,
                    CreatedUtc = DateTime.Now
                };
                ctx.Accounts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public decimal GetBalance(string accountID)
        {
            if (accountID == null)
            {
                throw new NotImplementedException();
            }
            Account account = db.Accounts.Single(accountNumber => accountNumber.AccountNumber == accountID);
            if (account == null)
            {
                throw new NotImplementedException();
            }
            decimal? nullableBalance = account.Balance;
            decimal balance = nullableBalance ?? 0M;
            return balance;
        }

        //TODO: refactor as one method
        public decimal AddDepositToBalance(string accountID, decimal deposit)
        {
            if (accountID == null)
            {
                throw new NotImplementedException();
            }
            Account account = db.Accounts.Single(accountNumber => accountNumber.AccountNumber == accountID);
            if (account == null)
            {
                throw new NotImplementedException();
            }
            decimal? nullableBalance = account.Balance;
            decimal currentBalance = nullableBalance ?? 0M;
            decimal newBalance = deposit + currentBalance;

            return newBalance;
        }
        public decimal SubtractWithdrawalFromBalance(string accountID, decimal withdrawal)
        {
            if (accountID == null)
            {
                throw new NotImplementedException();
            }
            Account account = db.Accounts.Single(accountNumber => accountNumber.AccountNumber == accountID);
            if (account == null)
            {
                throw new NotImplementedException();
            }
            decimal? nullableBalance = account.Balance;
            decimal currentBalance = nullableBalance ?? 0M;
            decimal newBalance = currentBalance - withdrawal;

            return newBalance;
        }

        public bool SaveNewBalanceToDatabase(string acctNum, decimal newBalance)
        {
            using (var ctx = new BankEntities())
            {
                var entity =
                    ctx
                        .Accounts
                        .Single(a => a.AccountNumber == acctNum);

                entity.AccountNumber = acctNum;
                entity.Balance = newBalance;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteAccount(AccountDetailModel model)
        {
            throw new NotImplementedException();
        }

        public AccountDetailModel GetAccountById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountListItemModel> GetAccounts()
        {
            throw new NotImplementedException();
        }

        public bool UpdateAccount(AccountEditModel model)
        {
            throw new NotImplementedException();
        }
    }
}
