using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : DbContext

    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Your Server");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public DbSet<Shipment> Shipment { get; set; }








        //order--one to many with user
        //cart -- many to many with products
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //shipment has one to one  relationship with order
            modelBuilder.Entity<Shipment>()
                .HasOne(o => o.Order)
                 .WithOne(s => s.Shipment)
                .HasForeignKey<Order>(s => s.OrderId);

            //modelBuilder.Entity<Product>()
        }
    }
}