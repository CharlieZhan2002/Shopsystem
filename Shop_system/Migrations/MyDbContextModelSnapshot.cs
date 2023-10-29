﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop_system.Model;

#nullable disable

namespace Shop_system.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop_system.Model.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Shop_system.Model.CartProduct", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("Shop_system.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Shop_system.Model.OrderProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerUserId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("CustomerUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Shop_system.Model.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CardNum")
                        .HasColumnType("bigint");

                    b.Property<string>("ExpiryMonth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiryYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Shop_system.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2,
                            Price = 4.40m,
                            ProductName = "White Bread | 700g",
                            Stock = 99
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 3,
                            Price = 8.40m,
                            ProductName = "Chicken Breast | 600g",
                            Stock = 50
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Price = 2.50m,
                            ProductName = "Blueberries | 170g",
                            Stock = 45
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Price = 1.00m,
                            ProductName = "Bananas",
                            Stock = 60
                        });
                });

            modelBuilder.Entity("Shop_system.Model.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruit & Vegetables"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Bakery"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Meat & Fish"
                        });
                });

            modelBuilder.Entity("Shop_system.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Shop_system.Model.Admin", b =>
                {
                    b.HasBaseType("Shop_system.Model.User");

                    b.HasDiscriminator().HasValue("Admin");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "admin@example.com",
                            PasswordHash = "123",
                            Role = 0,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Shop_system.Model.Customer", b =>
                {
                    b.HasBaseType("Shop_system.Model.User");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Customer");

                    b.HasData(
                        new
                        {
                            UserId = 3,
                            Email = "customer@example.com",
                            PasswordHash = "000",
                            Role = 2,
                            Username = "customer",
                            ShippingAddress = "1234 Customer St."
                        });
                });

            modelBuilder.Entity("Shop_system.Model.Manager", b =>
                {
                    b.HasBaseType("Shop_system.Model.User");

                    b.HasDiscriminator().HasValue("Manager");

                    b.HasData(
                        new
                        {
                            UserId = 2,
                            Email = "manager@example.com",
                            PasswordHash = "111",
                            Role = 3,
                            Username = "manager"
                        });
                });

            modelBuilder.Entity("Shop_system.Model.CartProduct", b =>
                {
                    b.HasOne("Shop_system.Model.Cart", "Cart")
                        .WithMany("CartProducts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop_system.Model.Product", "Product")
                        .WithMany("CartProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop_system.Model.OrderProduct", b =>
                {
                    b.HasOne("Shop_system.Model.Customer", null)
                        .WithMany("OrderProducts")
                        .HasForeignKey("CustomerUserId");

                    b.HasOne("Shop_system.Model.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop_system.Model.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop_system.Model.Product", b =>
                {
                    b.HasOne("Shop_system.Model.ProductCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Shop_system.Model.Cart", b =>
                {
                    b.Navigation("CartProducts");
                });

            modelBuilder.Entity("Shop_system.Model.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Shop_system.Model.Product", b =>
                {
                    b.Navigation("CartProducts");

                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Shop_system.Model.Customer", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
