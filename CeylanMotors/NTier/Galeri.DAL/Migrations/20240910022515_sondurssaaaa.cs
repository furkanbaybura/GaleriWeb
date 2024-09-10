using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sondurssaaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_AspNetUsers_AppUserId",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_AppUserId",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Guests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ff7e183-6da2-4ab5-b620-e60e21016f86", "AQAAAAIAAYagAAAAEHpPa6V7j9PIfw1j5RiJjjOJVc7iCSZ78JgrbpQfBU2UH1eJuHxavkJR8X4aoxu8eQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af25b863-484e-4406-9e69-fae366a9fee9", "AQAAAAIAAYagAAAAEKxCGoO+7MJ79oJ6bLTqhWfdsfBJ8Vdr6UF5CUBGQEYH0Vlx/BDiur9RBdKEbPL5nw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Guests_AppUserId",
                table: "Guests",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_AspNetUsers_AppUserId",
                table: "Guests",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
