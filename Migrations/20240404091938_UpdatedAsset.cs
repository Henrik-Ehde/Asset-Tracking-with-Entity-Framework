using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asset_Tracking_with_Entity_Framework.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAsset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Device",
                table: "Assets",
                newName: "Type");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Assets",
                newName: "Device");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Model", "PurchaseDate" },
                values: new object[] { "Iphone", new DateTime(2024, 4, 4, 10, 53, 25, 361, DateTimeKind.Local).AddTicks(820) });
        }
    }
}
