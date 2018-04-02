using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models.WithdrawalModels;

namespace Bank.Contracts
{
    public interface IWithdrawal
    {
        bool CreateWithdrawal(WithdrawalCreateModel model);
        WithdrawalDetailModel GetWithdrawalById(int id);
        IEnumerable<WithdrawalListItemModel> GetWithdrawals();
    }
}
