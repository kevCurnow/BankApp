using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Data;
using Bank.Models.CustomerModels;
using Bank.Services;

namespace Bank.Presentation.ATMConsole.Controllers
{
    public class CustomerATMController
    {
        private static CustomerService CreateCustomerService()
        {
            var svc = new CustomerService();
            return svc;
        }

        public static int NewCustomerSignUpQuestions()
        {
            Console.WriteLine("What is your SSN?");
            string ssnString = Console.ReadLine();
            int ssn = Int32.Parse(ssnString);

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            CustomerCreateModel user = new CustomerCreateModel
            {
                SocialSecurityNumber = ssn,
                FirstName = firstName,
                LastName = lastName
            };
            CreateCustomerService().CreateCustomer(user);
            return user.SocialSecurityNumber;
        }

        public static int GetCustomerIdSSNConsole(int ssn)
        {
            var cid = CreateCustomerService().GetCustomerById(ssn);
            int customerId = cid.CustomerId;
            return customerId;
        }
    }
}
