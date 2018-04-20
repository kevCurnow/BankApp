using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models.Account_Models;
using Bank.Services;

namespace Bank.Presentation.ATMConsole.Controllers
{
    public class AccountATMController
    {
        private static AccountService accountService = new AccountService();

        /// <summary>
        /// Account Create Methods
        /// </summary>
        /// <param name="id"></param>
        public static void CreateAccountConsole(int id)
        {
            string accountNum = CreateRandomAccountDialogue();
            string pin = CreateAccountDialogue();
            int accountType = CreateAccountTypeDialogue();
            decimal startingBalance = CreateStartingBalanceDialogue();

            AccountCreateModel newAccount = new AccountCreateModel
            {
                AccountNumber = accountNum,
                Pin = pin,
                AccountType = accountType,
                Balance = startingBalance,
                CustomerId = id
            };
            accountService.CreateAccount(newAccount);
        }


        /// <summary>
        /// Account Create Dialogue Methods
        /// </summary>
        /// <returns></returns>
        private static string CreateRandomAccountDialogue()
        {
            string accountNum = accountService.CreateRandomAccountNumber();
            Console.WriteLine("Your account number is:{0}", accountNum);
            return accountNum;
            
        }

        private static string CreateAccountDialogue()
        {
            Console.WriteLine("What would you like your pin to be?");
            string pin = Console.ReadLine();
            return pin;
        }

        private static decimal CreateStartingBalanceDialogue()
        {
            Console.WriteLine("What is your starting balance?");
            string startingBalanceString = Console.ReadLine();
            decimal startingBalance = Decimal.Parse(startingBalanceString);
            return startingBalance;
        }

        private static int CreateAccountTypeDialogue()
        {
            Console.WriteLine("What type of account would you like? 1 for Checking. 2 for savings");
            string accTypeString = Console.ReadLine();
            int accountType = Int32.Parse(accTypeString);
            return accountType;
        }

        private static int GetAccountIdFromAccountNumberForConsole(string accountNum)
        {
            int accountId = accountService.GetAccountId(accountNum);
            return accountId;
        }
    }
}
