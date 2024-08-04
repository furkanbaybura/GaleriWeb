using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sliderint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "901b00ab-afd8-4175-a720-806a41fbb764", "AQAAAAIAAYagAAAAEEKh4URjn5rJj+5TOH8eraZjVZjNhSYBgrbl1UYgWqPOkUsAglVx7dZ83HfMuJRstA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d88aaa4-f7ab-4e35-9af5-75d0f1403498", "AQAAAAIAAYagAAAAEOXP4JebcCnES2A999oro8TD0TI0xyS2oPEpVwwlqvR/dJv6JfDcIMlfgG0hKC9UGw==" });
        }
    }
}
