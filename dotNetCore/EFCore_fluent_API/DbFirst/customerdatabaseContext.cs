using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DbFirst
{
    public partial class customerdatabaseContext : DbContext
    {
        public customerdatabaseContext()
        {
        }

        public customerdatabaseContext(DbContextOptions<customerdatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=BHISHM;database=customerdatabase; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.Contact, "AK_Customers_Contact")
                    .IsUnique();

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasDefaultValueSql("(N'abc@email.com')");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.RetirementYears).HasComputedColumnSql("((65)-[Age])", false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_Orders_CustomerId");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
