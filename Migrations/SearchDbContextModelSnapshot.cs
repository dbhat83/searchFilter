﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SearchPage.Models;

#nullable disable

namespace SearchPage.Migrations
{
    [DbContext(typeof(SearchDbContext))]
    partial class SearchDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SearchPage.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MfgDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Electronics",
                            MfgDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 10.99m,
                            ProductName = "Product1",
                            Size = "Small"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Clothing",
                            MfgDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 25.49m,
                            ProductName = "Product2",
                            Size = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Home",
                            MfgDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 5.99m,
                            ProductName = "Product3",
                            Size = "Large"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Electronics",
                            MfgDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 15.79m,
                            ProductName = "Product4",
                            Size = "Medium"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Clothing",
                            MfgDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 8.49m,
                            ProductName = "Product5",
                            Size = "Small"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Home",
                            MfgDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 12.99m,
                            ProductName = "Product6",
                            Size = "Large"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
