using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ICustomersRepository
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        Customer PostCustomer(Customer customer);   
        void PutCustomer(int id,Customer customer);
        void DeleteCustomer(int id);

    }
}
