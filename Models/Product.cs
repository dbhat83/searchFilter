using System;
namespace SearchPage.Models;

public class Products
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Size { get; set; }
    public decimal Price { get; set; }
    public DateTime MfgDate { get; set; }
    public string Category { get; set; }
}

