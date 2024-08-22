using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class rr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "faa1a346-7a8b-4a85-8600-81d033e1b9ed", "AQAAAAIAAYagAAAAEPSuz+yIOA25uz+NVJfv4HFSeJRC2y9LTjS5Y0BuvMKrl/xgEYbrNuCBfT8vuu7upg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b0b009e-de2c-4a1e-964e-4bc8ac475482", "AQAAAAIAAYagAAAAEJ2T5IGCMKjz2rHaJKjhkiIEOJy7rlJ67NOHaFqeF8Iryh7yL9hXcCGmYwM4mB8tDg==" });
        }
    }
}
