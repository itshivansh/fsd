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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(k => new { k.CustomerId });
            modelBuilder.Entity<Customer>().Property(k => k.CustomerId).ValueGeneratedNever();
            modelBuilder.Entity<Customer>().Property(k => k.Name).IsRequired();
            modelBuilder.Entity<Customer>().Property(k => k.Contact).IsRequired();
            modelBuilder.Entity<Customer>().HasAlternateKey("Contact");
            modelBuilder.Entity<Customer>().Property(k => k.email).HasDefaultValue("abc@email.com");
            modelBuilder.Entity<Customer>().Property(k => k.RetirementYears).HasComputedColumnSql("65-Age");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
