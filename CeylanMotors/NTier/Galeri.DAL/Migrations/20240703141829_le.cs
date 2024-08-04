using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class le : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sliderad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sliders_AspNetUsers_AppUserId",
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
                values: new object[] { "09b4d143-4fb6-4aea-a6bd-ac3833a770c1", "AQAAAAIAAYagAAAAEP7TlOLt19EsEgBhGoP+ul7ga2mRsZHqmDQlo1ty+eBGc0xynCkHPzFeL8MT3/ORZg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_AppUserId",
                table: "Sliders",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87a1a445-286e-4983-8365-734fa97e0a91", "AQAAAAIAAYagAAAAECAgX1Q4ZgP4beIBOaFdY0mMcKIUjcFnOpMFpgrns13lSzF51I+pVvtCogvBLPu4lQ==" });
        }
    }
}
