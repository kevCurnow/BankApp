using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Data;
using Bank.Services;

namespace Bank.Presentation.ATMConsole.Controllers
{
    public class AuthATMController
    {
        private static AuthService CreateAuthService()
        {
            var svc = new AuthService();

            return svc;
        }

        public static string RequestAccountNumberDialogue()
        {
            Console.WriteLine("Please enter your unique account number: ");
            string accountNumber = Console.ReadLine();

            return accountNumber;
        }
        public static string RequestPinNumberDialogue()
        {
            Console.WriteLine("Please enter your pin");
            string pinNumber = Console.ReadLine();

            return pinNumber;
        }

        public static bool VerifyUser(string account, string pin)
        {
            var authService = CreateAuthService().VerifyUser(account, pin);

            if (authService)
            {
                Console.WriteLine("You are successfully logged in.");
                return true;
            }
            Console.WriteLine("Something went wrong with the log in.");

            return false;
        }
    }
}
