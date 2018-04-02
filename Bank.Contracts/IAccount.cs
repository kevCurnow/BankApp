using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Data;
using Bank.Models.Account_Models;

namespace Bank.Contracts
{
    public interface IAccount
    {
        bool CreateAccount(AccountCreateModel model);
        bool UpdateAccount(AccountEditModel model);
        bool DeleteAccount(AccountDetailModel model);
        AccountDetailModel GetAccountById(int id);
        IEnumerable<AccountListItemModel> GetAccounts();
    }
}
