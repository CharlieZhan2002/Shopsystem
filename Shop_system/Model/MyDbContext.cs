using Microsoft.EntityFrameworkCore;
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
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AssUserDb1;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductCategory>()
            .HasKey(pc => pc.CategoryId);
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "test@mail.com", ShippingAddress = "111 Test Street", PasswordHash = "test", Email = "test", Role = UserRole.Customer },
                new User { UserId = 2, Username = "admin@admin.com", ShippingAddress = "N/A", PasswordHash = "admin", Email = "test", Role = UserRole.Admin }

                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "White Bread | 700g", Price = 4.40, Category = "Bakery" },
                new Product { ProductId = 2, Name = "Chicken Breast | 600g", Price = 8.40, Category = "Meat/Seafood" },
                new Product { ProductId = 3, Name = "Blueberries | 170g", Price = 2.50, Category = "Fruit & Vegetables" }
                );
            
            // For specifying the relatiionships in associative tables

            // Order-product
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId });

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(op => op.ProductId);

            // Cart-product
            modelBuilder.Entity<CartProduct>()
                .HasKey(cp => new { cp.CartId, cp.ProductId });

            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.Cart)
                .WithMany(c => c.CartProducts)
                .HasForeignKey(cp => cp.CartId);

            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.Product)
                .WithMany(p => p.CartProducts)
                .HasForeignKey(cp => cp.ProductId);
        }
    }
}