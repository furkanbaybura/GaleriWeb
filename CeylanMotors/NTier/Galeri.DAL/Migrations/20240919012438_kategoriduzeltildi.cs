using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class kategoriduzeltildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Kategori",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3488a3c-3a3f-4219-9762-866f5ec9b764", "AQAAAAIAAYagAAAAEIBXoJ6yxVNZxC8omwt6qvP6SncsbE7rWrOsAghY9FIYaDJhq0++/JBAl4T1T2Ox9A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Kategori",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfab7543-2eca-40f9-8b49-f5f8fa6b02c5", "AQAAAAIAAYagAAAAEOKTaYZFKgzgWNmdhPCNVWaHag8360V5XJD+cpOPWsnjU6RbxqpV1ZWWYSj73KNKeQ==" });
        }
    }
}
