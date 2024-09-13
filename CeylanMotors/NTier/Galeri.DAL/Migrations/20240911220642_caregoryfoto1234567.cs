using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class caregoryfoto1234567 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53a137c4-1007-447d-80d0-2d96208a475c", "AQAAAAIAAYagAAAAEOR5yH7UwC0nO/WHjEELI1HMyfMZfcgW3zZ5/cV9nK/4dxH6KF4vpinmTsLHuGnKtw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "421de5e9-0900-4b74-ac44-b7014a379fdf", "AQAAAAIAAYagAAAAEFYhVztz928N8cntFw15ZVyddpIjCzb+TthkJ/tq0yZGSbpz3zDSh5AFKs0EBEZIQQ==" });
        }
    }
}
