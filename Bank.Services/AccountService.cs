using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.Account_Models;

namespace Bank.Services
{
    public class AccountService : IAccount
    {
        public bool CreateAccount(AccountCreateModel model)
        {
            throw new NotImplementedException();
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
