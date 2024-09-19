using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class vitesduzeltildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Vites",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfab7543-2eca-40f9-8b49-f5f8fa6b02c5", "AQAAAAIAAYagAAAAEOKTaYZFKgzgWNmdhPCNVWaHag8360V5XJD+cpOPWsnjU6RbxqpV1ZWWYSj73KNKeQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Vites",
                table: "Categories",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f536c50-cbab-4d86-83da-682a8d5475d6", "AQAAAAIAAYagAAAAEIM2abHeNXfIa78qG/OsLd/yoNMT8Mb/RsTEMR0p4gq6X+r8jixy5aFhrVujKY204A==" });
        }
    }
}
