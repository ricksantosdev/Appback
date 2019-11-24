using App.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace App.Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Client> ClientDB { get; set; }
        public DbSet<Order> OrderDB { get; set; }
        public DbSet<Price> PriceDB { get; set; }
        public DbSet<Product> ProductDB { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Price>().ToTable("Price");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<OrderProducts>().ToTable("OrderProduct");

            modelBuilder.Entity<OrderProducts>().HasKey(op => new { op.OrderId, op.ProductId });

        }


       
    }

}
