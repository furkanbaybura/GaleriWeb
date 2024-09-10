using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class bb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc322577-5f85-421a-8080-d3fe3e89d785", "AQAAAAIAAYagAAAAECVQRcMWVFJoZuAnU0KxqYiia4LlAME9+rrYgeQVTTZBszFQpMCG3lUt3B+5UEJkwg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6a12957-dc7d-41cc-ab11-8981d0d274de", "AQAAAAIAAYagAAAAEAfvcMGEq5ifKbt72HIvygJiQCyYFvIblQjIGbQJEjkiEyN8tCULyJWaAdS7zgInpg==" });
        }
    }
}
