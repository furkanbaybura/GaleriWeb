using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dssd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beygir",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Km",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Marka",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Vites",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3cc08a76-d79f-49c8-b251-4ad4503ca208", "AQAAAAIAAYagAAAAEHRqIsoXTW4QLdzkvLWswHGTzuo2AAZt5zKYGPqdLi31xAbP5X0FjUyKugH1Kr8exQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Beygir",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Km",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Marka",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Vites",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccbec6b4-f828-4bf6-8a5e-d1150ccf2c95", "AQAAAAIAAYagAAAAEJe67upTPZODIEPPwkAg5hd+JjfoZ2vYBAsKTqkXivhqZ+BlCJJ8rpQGc3MkvxBqjQ==" });
        }
    }
}
