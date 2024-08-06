using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EFCoreMultipleModelsForTable.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<BankTransfer> BankTransfers { get; set; }
        public DbSet<Bank> Banks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration for Payment (Base Class)
            modelBuilder.Entity<Payment>()
                .ToTable("PaymentMethods")
                .HasDiscriminator<string>("PaymentType")
                .HasValue<Check>("Check")
                .HasValue<BankTransfer>("BankTransfer");

            // Configuration for Check
            modelBuilder.Entity<Check>()
                .Property(e => e.CheckNumber)
                .IsRequired(false);

            // Configuration for BankTransfer
            modelBuilder.Entity<BankTransfer>()
                .Property(e => e.AccountNumber)
                .IsRequired(false);

            // Configuration for Bank
            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.BankId);
                entity.Property(e => e.Name).IsRequired();
            });
        }

    }

}
