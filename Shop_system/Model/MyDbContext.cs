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
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Customer> Customers { get; set; }
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

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Admin>().HasData(
        new Admin
        {
            UserId = 1,
            Username = "admin",
            PasswordHash = "123",  
            Email = "admin@example.com"
        }
    );

            modelBuilder.Entity<Manager>().HasData(
                new Manager
                {
                    UserId = 2,
                    Username = "123",
                    PasswordHash = "123",
                    Email = "admin@example.com"
                }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    UserId = 3,
                    Username = "000",
                    PasswordHash = "000",  
                    Email = "customer@example.com",
                    ShippingAddress = "1234 Customer St."
                }
            );

            /* modelBuilder.Entity<User>()
                 .HasDiscriminator(u => u.Role)
                 .HasValue<User>(UserRole.User) 
                 .HasValue<Customer>(UserRole.Customer)
                 .HasValue<Admin>(UserRole.Admin)
                 .HasValue<Manager>(UserRole.Manager);*/



            modelBuilder.Entity<ProductCategory>()
            .HasKey(pc => pc.CategoryId);



            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "White Bread | 700g", Price = 4.40m, CategoryId = 2, Stock = 99},
                new Product { ProductId = 2, ProductName = "Chicken Breast | 600g", Price = 8.40m, CategoryId = 3, Stock = 50},
                new Product { ProductId = 3, ProductName = "Blueberries | 170g", Price = 2.50m, CategoryId = 1, Stock = 45}
                );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { CategoryId = 1, CategoryName = "Fruit & Vegetables"},
                new ProductCategory { CategoryId = 2, CategoryName = "Bakery"},
                new ProductCategory { CategoryId = 3, CategoryName = "Meat & Fish"}
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