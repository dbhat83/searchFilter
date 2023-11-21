using System;
using Microsoft.EntityFrameworkCore;
using SearchPage.Migrations;

namespace SearchPage.Models;

public class SearchDbContext : DbContext
{
	public SearchDbContext(DbContextOptions<SearchDbContext> options): base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Products>().HasData(
            new Products { Id = 1, ProductName = "Product1", Price = 10.99m, Size = "Small", Category = "Electronics" },
            new Products { Id = 2, ProductName = "Product2", Price = 25.49m, Size = "Medium", Category = "Clothing" },
            new Products { Id = 3, ProductName = "Product3", Price = 5.99m, Size = "Large", Category = "Home" },
            new Products { Id = 4, ProductName = "Product4", Price = 15.79m, Size = "Medium", Category = "Electronics" },
            new Products { Id = 5, ProductName = "Product5", Price = 8.49m, Size = "Small", Category = "Clothing" },
            new Products { Id = 6, ProductName = "Product6", Price = 12.99m, Size = "Large", Category = "Home" }
        );

        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Products> Products { get; set; }
}

