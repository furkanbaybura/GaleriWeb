using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class caregoryfoto123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "PictureFile",
                table: "Categories",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63213fc6-2b7d-4601-be00-c6126128adeb", "AQAAAAIAAYagAAAAEKP5WhNCjUXhotwBvl8IiMz913oCAhZVA8UyfyVKp0Hr4z1MdbMH65xJF2DvGqmWVw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "PictureFile",
                table: "Categories",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4d508de-1ac6-4ffc-bd83-e81eaa554828", "AQAAAAIAAYagAAAAENlhdWzJ23fAP59Jei9nse5GIzu4yHtVMS4a6361I9W3orjmugw8SZ77WDyaSz+sBQ==" });
        }
    }
}
