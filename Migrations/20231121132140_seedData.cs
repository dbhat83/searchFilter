using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SearchPage.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "MfgDate", "Price", "ProductName", "Size" },
                values: new object[,]
                {
                    { 1, "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.99m, "Product1", "Small" },
                    { 2, "Clothing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.49m, "Product2", "Medium" },
                    { 3, "Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.99m, "Product3", "Large" },
                    { 4, "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.79m, "Product4", "Medium" },
                    { 5, "Clothing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.49m, "Product5", "Small" },
                    { 6, "Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.99m, "Product6", "Large" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
