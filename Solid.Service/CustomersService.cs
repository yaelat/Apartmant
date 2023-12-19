using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.service;
using Solid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class CustomersService: ICustomersService
    {
        public readonly ICustomersRepository _customersRepository;
        public CustomersService(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository; 
        }
        public List<Customer> GetAllCustomers()
        {
            return _customersRepository.GetAllCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            return _customersRepository.GetCustomerById(id);
        }

        public Customer PostCustomer(Customer customer)
        {
            return _customersRepository.PostCustomer(customer);
        }

        public void PutCustomer(int id, Customer customer)
        {
            _customersRepository.PutCustomer(id, customer);
        }

        public void DeleteCustomer(int id)
        {
            _customersRepository.DeleteCustomer(id);
        }

       
    }
}
