using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
           // Database.EnsureCreated();
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
