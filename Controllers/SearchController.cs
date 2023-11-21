using System;
using System.Data;
using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SearchPage.Models;
namespace SearchPage.Controllers;


public class SearchController : Controller
{
    private readonly SearchDbContext _dbContext;

    public SearchController(SearchDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public ActionResult Index()
    {
        return View(_dbContext.Products.ToList());
    }


    [HttpPost]
    public ActionResult Search(string productName, string size, decimal? price, DateTime? mfgDate, string category, string conjunction)
    {
        List<Products> filteredProducts = ApplySearchFilters( productName, size, price, mfgDate, category, conjunction);

        return View("Index", filteredProducts);
    }

    private List<Products> ApplySearchFilters(string productName, string size, decimal? price, DateTime? mfgDate, string category, string conjunction = "OR")
    {

        var filteredProducts = _dbContext.Products.FromSqlRaw(
            "EXEC GetFilteredProducts @Conjunction, @ProductName, @Price, @Size, @Category",
            new SqlParameter("@Conjunction", conjunction),
            new SqlParameter("@ProductName", productName ?? (object)DBNull.Value),
            new SqlParameter("@Price", price ?? (object)DBNull.Value),
            new SqlParameter("@Size", size ?? (object)DBNull.Value),
            new SqlParameter("@Category", category ?? (object)DBNull.Value)
        ).ToList();

        return filteredProducts;
    }

  
}
