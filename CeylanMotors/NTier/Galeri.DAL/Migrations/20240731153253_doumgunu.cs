using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class doumgunu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Yakindas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YakindaAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YakindaFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YakindaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YakindaBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yakindas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yakindas_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc8eb312-096e-455c-8054-d3a81ddcf5dc", "AQAAAAIAAYagAAAAECa43iq3svJcIw7649mUSL6mHT7d5eDBHl6ezxHSnePWKXuHQr9sQ+ejhhumnRDQpA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Yakindas_AppUserId",
                table: "Yakindas",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yakindas");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09b4d143-4fb6-4aea-a6bd-ac3833a770c1", "AQAAAAIAAYagAAAAEP7TlOLt19EsEgBhGoP+ul7ga2mRsZHqmDQlo1ty+eBGc0xynCkHPzFeL8MT3/ORZg==" });
        }
    }
}
