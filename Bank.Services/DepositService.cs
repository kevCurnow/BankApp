using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.DepositModels;

namespace Bank.Services
{
    public class DepositService : IDeposit
    {
        public bool CreateDeposit(DepositCreateModel model)
        {
            throw new NotImplementedException();
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
