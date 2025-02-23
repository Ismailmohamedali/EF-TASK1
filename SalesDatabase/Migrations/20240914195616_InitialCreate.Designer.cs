﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesDatabase.Data;

#nullable disable

namespace SalesDatabase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240914195616_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalesDatabase.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CreaditCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("SaleId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("SalesDatabase.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("SalesDatabase.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.HasKey("SaleId");

                    b.ToTable("sales");
                });

            modelBuilder.Entity("SalesDatabase.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("StoreId");

                    b.HasIndex("SaleId");

                    b.ToTable("stores");
                });

            modelBuilder.Entity("SalesDatabase.Models.Customer", b =>
                {
                    b.HasOne("SalesDatabase.Models.Sale", "sale")
                        .WithMany("customers")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sale");
                });

            modelBuilder.Entity("SalesDatabase.Models.Product", b =>
                {
                    b.HasOne("SalesDatabase.Models.Sale", "sale")
                        .WithMany("products")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sale");
                });

            modelBuilder.Entity("SalesDatabase.Models.Store", b =>
                {
                    b.HasOne("SalesDatabase.Models.Sale", "sale")
                        .WithMany("stores")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sale");
                });

            modelBuilder.Entity("SalesDatabase.Models.Sale", b =>
                {
                    b.Navigation("customers");

                    b.Navigation("products");

                    b.Navigation("stores");
                });
#pragma warning restore 612, 618
        }
    }
}
