using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.CustomerModels;
using Bank.Data;

namespace Bank.Services
{
    public class CustomerService : ICustomer
    {
        private BankEntities db = new BankEntities();

        //Get Customer from DB
        private Customer GetCustomerIdBySSN(BankEntities context, int ssn)
        {
            return
                context
                    .Customers
                    .SingleOrDefault(c => c.SocialSecurityNumber == ssn);
        }

        public bool CreateCustomer(CustomerCreateModel model)
        {
            using (var ctx = new BankEntities())
            {
                //1 Collecting info from model
                //2 Storing in matching Entity Property
                var entity = new Customer
                {
                            //2                               //1
                    SocialSecurityNumber = model.SocialSecurityNumber,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CreatedUtc = DateTime.Now
                };

                ctx.Customers.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCustomer(CustomerDetailModel model)
        {
            throw new NotImplementedException();
        }

        public CustomerDetailModel GetCustomerById(int id)
        {
            Customer customer;
            using (var ctx = new BankEntities())
            {
                customer = GetCustomerIdBySSN(ctx, id);
            }

            if (customer == null) return new CustomerDetailModel();

            return
                new CustomerDetailModel
                {
                    CustomerId = customer.CustomerID,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    CreatedUtc = customer.CreatedUtc
                };
        }

        public IEnumerable<CustomerListItemModel> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(CustomerEditModel model)
        {
            throw new NotImplementedException();
        }
    }
}
