using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class caregoryfoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "PictureFile",
                table: "Categories",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5158b2a1-3d8c-483b-8dee-177fe4eb1996", "AQAAAAIAAYagAAAAEKw/E/kiItnW23zdcNTznrJPqayZvOoUsdBOnEcCn/IDBL6YZD1L6ou7Qz3jJJ/N2w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PictureFile",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ff7e183-6da2-4ab5-b620-e60e21016f86", "AQAAAAIAAYagAAAAEHpPa6V7j9PIfw1j5RiJjjOJVc7iCSZ78JgrbpQfBU2UH1eJuHxavkJR8X4aoxu8eQ==" });
        }
    }
}
