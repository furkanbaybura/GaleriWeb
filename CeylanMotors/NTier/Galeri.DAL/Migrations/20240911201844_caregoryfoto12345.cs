using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class caregoryfoto12345 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureFile",
                table: "Categories",
                newName: "PictureFormFile");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a6066d2-3551-4db5-8ec6-9e6da112f9ac", "AQAAAAIAAYagAAAAEJvvlI8R/Z6xpxqh8EM5lXvINTQ6iJ1HZsjYdpvXZHU5vIMu+y4WIe4WttTlWyP5Aw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureFormFile",
                table: "Categories",
                newName: "PictureFile");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ab73486-c2ae-42b8-b1d9-daa7bb3ebf55", "AQAAAAIAAYagAAAAED0tGyl6vk08WkRUxQN+nKbhMskcT+CdGMgHXnsMqcdqADnmTsyraJnDjfV71Dd7Yw==" });
        }
    }
}
