using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Asset_Tracking_with_Entity_Framework.Migrations
{
    /// <inheritdoc />
    public partial class PopulatedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Model", "Price", "PurchaseDate", "Type" },
                values: new object[] { "Nokia 3310", 60, new DateTime(2002, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Model", "OfficeId", "Price", "PurchaseDate", "Type" },
                values: new object[,]
                {
                    { 5, "Macbooc Air", 3, 800, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" },
                    { 6, "Asus TUF Dash", 1, 800, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" },
                    { 7, "Lenovo Thinkpad", 2, 800, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2024, 4, 9, 10, 15, 7, 920, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Model", "Price", "PurchaseDate", "Type" },
                values: new object[] { "Asus TUF Dash F15", 800, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" });
        }
    }
}
