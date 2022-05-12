using System.Collections.Generic;
using YeniProje.API.Abstracts;
using YeniProje.API.Models;
using YeniProje.API.services;

namespace YeniProje.API.managers
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Customer CreateCustomer(Customer customer)
        {
            return _customerRepository.CreateCustomer(customer);    
        }

        public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }

        public List<Customer> GetAllCustomer()
        {
            return _customerRepository.GetAllCustomer();
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
    }
}
