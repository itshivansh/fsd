using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface ICustomerRepo
    {
        Customer GetCustomerById(int customerId);
        List<Customer> GetCustomers();
        int CreateCustomer(Customer customer);
        int RemoveCustomer(int customerId);
        int UpdateCustomer(Customer customer);
    }
}
