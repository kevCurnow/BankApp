using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.WithdrawalModels;
using Bank.Data;

namespace Bank.Services
{
    public class WithdrawalService : IWithdrawal
    {
        public bool CreateWithdrawal(WithdrawalCreateModel model)
        {
            using (var ctx = new BankEntities())
            {
                var entity = new Withdrawal
                {
                    TransactionID = model.TransactionID,
                    Amount = model.Amount
                };

                ctx.Withdrawals.Add(entity);
                return ctx.SaveChanges() == 1;
            }
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
