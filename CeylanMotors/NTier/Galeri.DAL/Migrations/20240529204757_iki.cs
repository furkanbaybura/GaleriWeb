using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class iki : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Yil",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Yil",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0cdf3c9-d5ce-44b7-9b12-61d7aa151ca4", "AQAAAAIAAYagAAAAEMW3kvtPt1muobaBeDYXzya2Isfo2W6i5ZzJdWI3eYxykn+9zHs+lTElAgaeslcitw==" });
        }
    }
}
