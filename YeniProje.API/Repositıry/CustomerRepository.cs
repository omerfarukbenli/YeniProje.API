using System.Collections.Generic;
using System.Linq;
using YeniProje.API.Abstracts;
using YeniProje.API.Models;
using YeniProje.API.Models.data;

namespace YeniProje.API.Repositıry
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer CreateCustomer(Customer customer)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Customers.Add(customer);
                dataContext.SaveChanges();
                return customer;
            }
        }
         
        public void DeleteCustomer(int id)
        {
            using (var dataContext = new DataContext())
            {
                var deleteCustomer = GetCustomerById(id);
                dataContext.Customers.Remove(deleteCustomer);
                dataContext.SaveChanges();
            }
        }

        public List<Customer> GetAllCustomer()
        {
            using(var dataContext = new DataContext())
            {
                return dataContext.Customers.ToList();
            }
        }

        public Customer GetCustomerById(int id)
        {
            using(var dataContext = new DataContext())
            {
                return dataContext.Customers.Find(id);
            }
        }

        public Customer UpdateCustomer(Customer customer)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Customers.Update(customer);
                dataContext.SaveChanges();
                return customer;
            }
        }
    }
}
