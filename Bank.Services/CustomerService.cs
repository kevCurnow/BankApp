using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Models.CustomerModels;

namespace Bank.Services
{
    public class CustomerService : ICustomer
    {
        public bool CreateCustomer(CustomerCreateModel model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(CustomerDetailModel model)
        {
            throw new NotImplementedException();
        }

        public CustomerDetailModel GetCustomerById(int id)
        {
            throw new NotImplementedException();
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
