﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YeniProje.API.Models.data;

namespace YeniProje.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220512105719_n")]
    partial class n
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YeniProje.API.Models.Customer", b =>
                {
                    b.Property<int>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Card_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Card_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cvv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Expiration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postal_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Taksit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("YeniProje.API.Models.Order", b =>
                {
                    b.Property<int>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<string>("Order_Date")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Order_Id", "Customer_Id");

                    b.HasIndex("Customer_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("YeniProje.API.Models.OrderDetail", b =>
                {
                    b.Property<int>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int?>("OrderCustomer_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Order_Id1")
                        .HasColumnType("int");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Order_Id", "Product_Id");

                    b.HasIndex("Product_Id");

                    b.HasIndex("Order_Id1", "OrderCustomer_Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("YeniProje.API.Models.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Product_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Product_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("YeniProje.API.Models.Order", b =>
                {
                    b.HasOne("YeniProje.API.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("YeniProje.API.Models.OrderDetail", b =>
                {
                    b.HasOne("YeniProje.API.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YeniProje.API.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Order_Id1", "OrderCustomer_Id");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("YeniProje.API.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("YeniProje.API.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
