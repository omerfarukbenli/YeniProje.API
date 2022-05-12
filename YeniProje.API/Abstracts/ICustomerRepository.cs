using System.Collections.Generic;
using YeniProje.API.Models;

namespace YeniProje.API.Abstracts
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomer();

        Customer GetCustomerById(int id);

        Customer CreateCustomer(Customer customer);

        Customer UpdateCustomer(Customer customer);

        void DeleteCustomer(int id);
    }
}
