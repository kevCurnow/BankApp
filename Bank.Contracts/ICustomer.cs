using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Data;
using Bank.Models.CustomerModels;

namespace Bank.Contracts
{
    public interface ICustomer
    {
        bool CreateCustomer(CustomerCreateModel model);
        bool UpdateCustomer(CustomerEditModel model);
        bool DeleteCustomer(CustomerDetailModel model);
        CustomerDetailModel GetCustomerById(int id);
        IEnumerable<CustomerListItemModel> GetCustomers();
    }
}
