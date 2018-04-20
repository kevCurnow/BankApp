using Bank.Data;
using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank.Presentation.ATMConsole.Controllers
{
    public class MenuATMController
    {
        
        public static void ShowStartMenu()
        {
            Console.Title = "ASCII Art";
            string art = @"
         _._._                       _._._
        _|   |_                     _|   |_
        | ... |_._._._._._._._._._._| ... |
        | ||| |  o NATIONAL BANK o  | ||| |
        | $$$ |  $$$    $$$    $$$  | $$$ |
   ())  |[-|-]| [-|-]  [-|-]  [-|-] |[-|-]|  ())
  (())) |     |---------------------|     | (()))
 (())())| $$$ |  $$$    $$$    $$$  | $$$ |(())())
 (()))()|[-|-]|  :::   .-*-.   :::  |[-|-]|(()))()
 ()))(()|     | |~|~|  |_|_|  |~|~| |     |()))(()
    ||  |_____|_|_|_|__|_|_|__|_|_|_|_____|  ||
 ~ ~^^ @@@@@@@@@@@@@@/=======\@@@@@@@@@@@@@@ ^^~ ~
      ^~^~                                ~^~^ 
            ";
            Console.WriteLine(art);
            Console.WriteLine("                                       Please press enter to begin        ");
            var key = Console.ReadKey();
            if (key.Key != ConsoleKey.Enter)
            {
                Console.WriteLine("                Please press enter to begin        ");
            }
            else
            {
                Console.WriteLine("Please press enter to move on.");
                Console.Clear();
            }
        }
        public static void GetCardAndPinMenu()
        {
            Console.Title = "Login Menu";

            string art = @"
                           __-----__
                      ..;;;--'~~~`--;;;..
                    /;-~IN GOD WE TRUST~-.\
                   //      ,;;;;;;;;      \\
                 .//      ;;;;;    \       \\
                 ||       ;;;;(   /.|       ||
                 ||       ;;;;;;;   _\      ||
                 ||       ';;  ;;;;=        ||
                 ||LIBERTY | ''\;;;;;;      ||
                  \\     ,| '\  '|><| 1995 //
                   \\   |     |      \  A //
                    `;.,|.    |      '\.-'/
                      ~~;;;,._|___.,-;;;~'
                          ''=--'
        ";

            Console.WriteLine(art);
        }
        public static void ShowError()
        {
            Console.Title = "Error";

            string art = @"
                          ___ _ __ _ __ ___  _ __
                         / _ \ '__| '__/ _ \| '__|
                        |  __/ |  | | | (_) | |   
                         \___|_|  |_|  \___/|_|   
        ";

            Console.WriteLine(art);
        }

        //Account Menu Methods
        private static ConsoleKeyInfo ShowAuthorizedAccountMenu()
        {
            Console.Title = "ASCII Art";

            string art = @"
            Main Menu
            Make a Deposit...................................1
            Make a Withdrawal................................2
            Check Account Balance............................3
            Request Assistance...............................4
            Change Pin.......................................5
            Enter our Sweepstakes............................6
            ";
            Console.WriteLine(art);
            Console.WriteLine("Please choose an option from the menu: ");
            var key = Console.ReadKey();
            return key;
        }

        //Transaction Methods
        private static int GetKeyFromConsole(ConsoleKeyInfo key)
        {
            if (char.IsDigit(key.KeyChar))
            {
                int keyNumber = int.Parse(key.KeyChar.ToString()); //Parse if digit
                return keyNumber;
            }
            return 0;
        }

        //ATM Program Method(Authorized)
        public static void ShowLoggedInMenu(bool isVerified, string accountNumber, string pinNumber)
        {
            while (true)
            {
                if (isVerified)
                {
                    Console.Clear();
                    var key = ShowAuthorizedAccountMenu();
                    int convertedKey = GetKeyFromConsole(key);
                    int transactionType = convertedKey;
                    AccountService accountService = new AccountService();
                    //Menu Switch
                    switch (transactionType)
                    {
                        case 1:
                            DepositATMController.ProcessDeposit(accountNumber, transactionType);
                            break;
                        case 2:
                            WithdrawalATMController.ProcessWithdrawal(accountNumber, transactionType);
                            break;
                        case 3:
                            Console.WriteLine($"Your balance is: {accountService.GetBalance(accountNumber)}");
                            break;
                        case 4:
                            Console.WriteLine("Assistance");
                            break;
                        case 5:
                            Console.WriteLine("Change Pin");
                            break;
                        default:
                            Console.WriteLine("Broken");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    ShowError();
                    Thread.Sleep(200);
                    Console.WriteLine("Something went wrong. How about we start over...");
                    Thread.Sleep(200);
                    ShowError();
                    Console.Clear();
                    ShowStartMenu();
                    ShowLoggedInMenu(isVerified, accountNumber, pinNumber);
                }
                Console.ReadLine();
            }
        }
    }
}
