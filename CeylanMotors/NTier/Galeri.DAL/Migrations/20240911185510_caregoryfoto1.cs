using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class caregoryfoto1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d33b9b6-9605-4e60-987f-41f7657050a7", "AQAAAAIAAYagAAAAEOQCTX10H0QbrbTLRBC24kbt763KEr8kCrtKVkbuoSlUdIUGJQmoMbaKHwDbi0elLQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5158b2a1-3d8c-483b-8dee-177fe4eb1996", "AQAAAAIAAYagAAAAEKw/E/kiItnW23zdcNTznrJPqayZvOoUsdBOnEcCn/IDBL6YZD1L6ou7Qz3jJJ/N2w==" });
        }
    }
}
