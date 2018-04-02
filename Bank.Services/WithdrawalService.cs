using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.WithdrawalModels;

namespace Bank.Services
{
    public class WithdrawalService : IWithdrawal
    {
        public bool CreateWithdrawal(WithdrawalCreateModel model)
        {
            throw new NotImplementedException();
        }

        public WithdrawalDetailModel GetWithdrawalById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WithdrawalListItemModel> GetWithdrawals()
        {
            throw new NotImplementedException();
        }
    }
}
