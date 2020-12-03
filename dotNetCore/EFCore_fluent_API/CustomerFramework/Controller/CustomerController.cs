using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerFramework.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
         ICustomerRepo customerRepo;

        public CustomerController(ICustomerRepo _customerRepo)
        {
            customerRepo = _customerRepo;

        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(customerRepo.GetCustomers ());
        }
        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            customerRepo.CreateCustomer(customer);
            return Created("api/Building", 201);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetCustomer(int id)
        {
            return Ok(customerRepo.GetCustomerById(id));
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            customerRepo.RemoveCustomer(id);
            return Ok();
        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            customerRepo.UpdateCustomer(customer);
            return Ok();
        }
    }
}
