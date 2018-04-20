using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models.DepositModels;
using Bank.Services;

namespace Bank.Presentation.ATMConsole.Controllers
{
    public class DepositATMController
    {
        private static DepositService depositService = new DepositService();
        private static AccountService accountService = new AccountService();

        public static void ProcessDeposit(string accountNumber, int transactionType)
        {
            int transactionId = TransactionATMController.CreateTransactionConsole(accountNumber, transactionType);
            decimal amount = GetDepositAmountFromUser();

            DepositCreateModel newDeposit = new DepositCreateModel
            {
                Amount = amount,
                TransactionID = transactionId
            };
            depositService.CreateDeposit(newDeposit);

            decimal deposit = newDeposit.Amount;
            decimal newBalance = accountService.AddDepositToBalance(accountNumber, deposit);

            accountService.SaveNewBalanceToDatabase(accountNumber, newBalance);
        }

        private static decimal GetDepositAmountFromUser()
        {
            Console.WriteLine("How much would you like to deposit today?");
            string depositString = Console.ReadLine();
            decimal deposit = Decimal.Parse(depositString);
            return deposit;
        }
    }
}
