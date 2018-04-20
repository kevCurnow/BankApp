using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Services;
using Bank.Models.WithdrawalModels;

namespace Bank.Presentation.ATMConsole.Controllers
{
    public class WithdrawalATMController
    {
        private static WithdrawalService withdrawalService = new WithdrawalService();
        private static AccountService accountService = new AccountService();

        public static void ProcessWithdrawal(string accountNumber, int transactionType)
        {
            int transactionId = TransactionATMController.CreateTransactionConsole(accountNumber, transactionType);
            decimal amount = GetWithdrawalAmountFromUser();

            WithdrawalCreateModel newWithdrawal = new WithdrawalCreateModel
            {
                Amount = amount,
                TransactionID = transactionId
            };
            withdrawalService.CreateWithdrawal(newWithdrawal);

            decimal withdrawal = newWithdrawal.Amount;
            decimal newBalance = accountService.SubtractWithdrawalFromBalance(accountNumber, withdrawal);

            accountService.SaveNewBalanceToDatabase(accountNumber, newBalance);
        }

        private static decimal GetWithdrawalAmountFromUser()
        {
            Console.WriteLine("How much would you like to withdraw today?");
            string withdrawalString = Console.ReadLine();
            decimal withdrawal = Decimal.Parse(withdrawalString);
            return withdrawal;
        }
    }
}
