using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sonmu3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YakindaFileName",
                table: "Yakindas");

            migrationBuilder.AlterColumn<string>(
                name: "YakindaAd",
                table: "Yakindas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "YakindaImageName",
                table: "Yakindas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6a12957-dc7d-41cc-ab11-8981d0d274de", "AQAAAAIAAYagAAAAEAfvcMGEq5ifKbt72HIvygJiQCyYFvIblQjIGbQJEjkiEyN8tCULyJWaAdS7zgInpg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YakindaImageName",
                table: "Yakindas");

            migrationBuilder.AlterColumn<string>(
                name: "YakindaAd",
                table: "Yakindas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YakindaFileName",
                table: "Yakindas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cafc316-2374-4197-ae71-de1e584f9a3e", "AQAAAAIAAYagAAAAEP/qhdH03k3QoFMSr86a6BC7C2+aMLzocPXLYwokdNz7SczGF9qmVRw8Sh7Beg2KOA==" });
        }
    }
}
