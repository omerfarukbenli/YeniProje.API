using System.Collections.Generic;
using YeniProje.API.Models;

namespace YeniProje.API.services
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();

        Customer GetCustomerById(int id);

        Customer CreateCustomer(Customer customer);

        Customer UpdateCustomer(Customer customer);

        void DeleteCustomer(int id);
    }
}
