using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asset_Tracking_with_Entity_Framework.Migrations
{
    /// <inheritdoc />
    public partial class testingAsset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Assets");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Model", "PurchaseDate" },
                values: new object[] { "Iphone 8", new DateTime(2024, 4, 4, 11, 52, 48, 524, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Model", "OfficeId", "Price", "PurchaseDate", "Type" },
                values: new object[] { 2, "Samsung Galaxy", 2, 300, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Model", "PurchaseDate" },
                values: new object[] { "Iphone", "8", new DateTime(2024, 4, 4, 11, 19, 37, 695, DateTimeKind.Local).AddTicks(8570) });
        }
    }
}
