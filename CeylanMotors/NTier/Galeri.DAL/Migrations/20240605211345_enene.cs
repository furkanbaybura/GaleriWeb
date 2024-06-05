using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class enene : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fiyat",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d88aaa4-f7ab-4e35-9af5-75d0f1403498", "AQAAAAIAAYagAAAAEOXP4JebcCnES2A999oro8TD0TI0xyS2oPEpVwwlqvR/dJv6JfDcIMlfgG0hKC9UGw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dba4f329-2989-4d50-a1f7-6ea987db85df", "AQAAAAIAAYagAAAAEDID8R6TNvLPudL1yFfzOqJyaI9Bw/zyI49dcWVkfs3G6A9PSnadSZ8AEaLDw0+CJg==" });
        }
    }
}
