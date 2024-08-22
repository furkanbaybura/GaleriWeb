using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SliderImage",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b0b009e-de2c-4a1e-964e-4bc8ac475482", "AQAAAAIAAYagAAAAEJ2T5IGCMKjz2rHaJKjhkiIEOJy7rlJ67NOHaFqeF8Iryh7yL9hXcCGmYwM4mB8tDg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SliderImage",
                table: "Sliders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07383fc3-f1d8-48a4-97a6-6196c662b64b", "AQAAAAIAAYagAAAAENDxUaqr0VpVFCWRuFagrB6L83XOmM9Q4ytpPVQOeQ34mKuct1QGlz1hamnmOiTlZQ==" });
        }
    }
}
