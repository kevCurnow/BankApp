using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Presentation.ATMConsole.Controllers;
using Bank.Services;

namespace Bank.Presentation.ATMConsole
{
    class BankController
    {
        public static void RunATM()
        {
            Console.WriteLine("Do you have an account? Y for yes, N for no");
            string signUp = Console.ReadLine();

            if (signUp.ToUpper() == "N")
            { 
            //Create Customer from Console
            int ssn = CustomerATMController.NewCustomerSignUpQuestions();
            int customerId = CustomerATMController.GetCustomerIdSSNConsole(ssn);
            AccountATMController.CreateAccountConsole(customerId);
            }

            //Start up
            Console.Clear();
            MenuATMController.ShowStartMenu();
            Console.Clear();

            //Login and Verify
            MenuATMController.GetCardAndPinMenu();
            string accountNumber = AuthATMController.RequestAccountNumberDialogue();
            string pinNumber = AuthATMController.RequestPinNumberDialogue();
            AuthService auth = new AuthService();
            bool isVerified = auth.ValidatePin(pinNumber);
            MenuATMController.ShowLoggedInMenu(isVerified, accountNumber, pinNumber);

            Console.ReadLine();
        }
    }
}
