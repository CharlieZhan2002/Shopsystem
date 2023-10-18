﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system.Model
{
    internal class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AssUserDb1;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "test@mail.com", PasswordHash = "test", Email="test", Role = UserRole.Customer },
                new User { UserId = 2, Username = "admin@admin.com", PasswordHash = "admin", Email = "test", Role = UserRole.Admin }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "White Bread | 700g", Price = 4.40, Category= "Bakery"},
                new Product { ProductId = 2, Name = "Chicken Breast | 600g", Price = 8.40, Category = "Meat/Seafood"},
                new Product { ProductId = 3, Name = "Blueberries | 170g", Price = 2.50, Category = "Fruit & Vegetables"}
                );
        }
    }
}
