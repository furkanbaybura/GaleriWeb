using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class caregoryfoto1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Categories",
                newName: "PictureImageName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ab73486-c2ae-42b8-b1d9-daa7bb3ebf55", "AQAAAAIAAYagAAAAED0tGyl6vk08WkRUxQN+nKbhMskcT+CdGMgHXnsMqcdqADnmTsyraJnDjfV71Dd7Yw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureImageName",
                table: "Categories",
                newName: "Picture");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63213fc6-2b7d-4601-be00-c6126128adeb", "AQAAAAIAAYagAAAAEKP5WhNCjUXhotwBvl8IiMz913oCAhZVA8UyfyVKp0Hr4z1MdbMH65xJF2DvGqmWVw==" });
        }
    }
}
