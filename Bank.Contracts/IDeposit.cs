using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models.DepositModels;

namespace Bank.Contracts
{
    public interface IDeposit
    {
        bool CreateDeposit(DepositCreateModel model);
        DepositDetailModel GetDepositById(int id);
        IEnumerable<DepositListItemModel> GetDeposits();
    }
}
