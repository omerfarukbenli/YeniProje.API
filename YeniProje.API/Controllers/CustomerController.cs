using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using YeniProje.API.Models;
using YeniProje.API.services;

namespace YeniProje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public List<Customer> Get()
        {
            return _customerService.GetAllCustomer();
        }
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerService.GetCustomerById(id);
        }
        [HttpPost]
        public Customer Post([FromBody] Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }
        [HttpPut]
        public Customer Put([FromBody] Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }
        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            _customerService.DeleteCustomer(id);
        }

    }
}
