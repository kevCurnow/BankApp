using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.DepositModels;
using Bank.Data;

namespace Bank.Services
{
    public class DepositService : IDeposit
    {
        public bool CreateDeposit(DepositCreateModel model)
        {
            using (var ctx = new BankEntities())
            {
                var entity = new Deposit
                {
                    TransactionID = model.TransactionID,
                    Amount = model.Amount
                };
                ctx.Deposits.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public DepositDetailModel GetDepositById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepositListItemModel> GetDeposits()
        {
            throw new NotImplementedException();
        }
    }
}
