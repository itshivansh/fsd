using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly CustomerDbContext context;
        public CustomerRepo(CustomerDbContext customerDbContext)
        {
            context = customerDbContext;
        }
        public int CreateCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            return context.SaveChanges();
        }

        public Customer GetCustomerById(int customerId)
        {
            return context.Customers.Find(customerId);
        }

        public List<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }

        public int RemoveCustomer(int customerId)
        {
            var customer = context.Customers.Find(customerId);
            context.Customers.Remove(customer);
            return context.SaveChanges();
        }

        public int UpdateCustomer(Customer customer)
        {
            context.Entry<Customer>(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return context.SaveChanges();
        }
    }
}
