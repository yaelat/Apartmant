using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class CustomersRepository: ICustomersRepository
    {
        private readonly DataContext _context;
        public CustomersRepository(DataContext context)
        {
            _context = context;
        }

        public void DeleteCustomer(int id)
        {
            _context.customers.Remove(_context.customers.Find(cus => cus.Id == id));
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.customers;
        }

        public Customer GetCustomerById(int id)
        {
            return _context.customers.Find(cus=>cus.Id==id);
        }

        public Customer PostCustomer(Customer customer)
        {
            customer.Id=_context.customers.Count()+1;
            _context.customers.Add(customer);
            return customer;
        }

        public void PutCustomer(int id, Customer customer)
        {
            var cus= _context.customers.Find(cus=>cus.Id==id);
            cus.Name=customer.Name;           
        }
    }
}
