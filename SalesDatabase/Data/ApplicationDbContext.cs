using Microsoft.EntityFrameworkCore;
using SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data
{
    internal class ApplicationDbContext : DbContext 
    {
        public DbSet<Product> products {  get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Sale> sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EF_Task1;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasColumnType("nvchar(50)");

            modelBuilder.Entity<Customer>()
               .Property(c => c.Name)
               .HasColumnType("nchar(100)");

            modelBuilder.Entity<Customer>()
               .Property(c => c.Email)
               .HasColumnType("varchar(80)");

            modelBuilder.Entity<Store>()
                .Property(s => s.Name)
                .HasColumnType("nchar(80)");



        }

    }
}
