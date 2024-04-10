using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Asset_Tracking_with_Entity_Framework.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreAssets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2024, 4, 9, 10, 15, 7, 920, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Model", "OfficeId", "Price", "PurchaseDate", "Type" },
                values: new object[,]
                {
                    { 3, "OnePlus", 3, 200, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 4, "Asus TUF Dash F15", 2, 800, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2024, 4, 4, 11, 52, 48, 524, DateTimeKind.Local).AddTicks(3083));
        }
    }
}
