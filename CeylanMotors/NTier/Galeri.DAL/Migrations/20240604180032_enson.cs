using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class enson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Renk");

            migrationBuilder.AddColumn<int>(
                name: "Beygir",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Kategori",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "MotorHacmi",
                table: "Categories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Paket",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Tork",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Vites",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cac9cc9d-6b55-4c51-8fbb-72ddd461f76f", "AQAAAAIAAYagAAAAEMaKwEV42TXv8OadjzJSZa5e4ZkJTR4iWm4U21eI2+0J9xojYgFhFgOAoNJQ3p8ZXg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beygir",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Kategori",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Km",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Marka",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MotorHacmi",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Paket",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Tork",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Vites",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Renk",
                table: "Categories",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3cc08a76-d79f-49c8-b251-4ad4503ca208", "AQAAAAIAAYagAAAAEHRqIsoXTW4QLdzkvLWswHGTzuo2AAZt5zKYGPqdLi31xAbP5X0FjUyKugH1Kr8exQ==" });
        }
    }
}
