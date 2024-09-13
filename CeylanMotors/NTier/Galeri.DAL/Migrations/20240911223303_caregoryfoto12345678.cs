using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class caregoryfoto12345678 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.AddColumn<byte[]>(
                name: "PictureFile",
                table: "Categories",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "PictureName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf828beb-d6e2-4c05-b823-f5cd554e900f", "AQAAAAIAAYagAAAAEGDtSn/AoOqQTvVIBHiQ/aNNswNBko+yyamiKwrUdD2QmtujmjKaBwbx33R2WZyh6w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureFile",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PictureName",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PictureData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PictureName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Picture_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53a137c4-1007-447d-80d0-2d96208a475c", "AQAAAAIAAYagAAAAEOR5yH7UwC0nO/WHjEELI1HMyfMZfcgW3zZ5/cV9nK/4dxH6KF4vpinmTsLHuGnKtw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Picture_CategoryId",
                table: "Picture",
                column: "CategoryId");
        }
    }
}
