using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.service
{
    public interface ICustomersService
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        Customer PostCustomer(Customer customer);
        void PutCustomer(int id, Customer customer);
        void DeleteCustomer(int id);
    }
}
