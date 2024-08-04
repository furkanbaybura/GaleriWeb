using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sliderson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87a1a445-286e-4983-8365-734fa97e0a91", "AQAAAAIAAYagAAAAECAgX1Q4ZgP4beIBOaFdY0mMcKIUjcFnOpMFpgrns13lSzF51I+pVvtCogvBLPu4lQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "901b00ab-afd8-4175-a720-806a41fbb764", "AQAAAAIAAYagAAAAEEKh4URjn5rJj+5TOH8eraZjVZjNhSYBgrbl1UYgWqPOkUsAglVx7dZ83HfMuJRstA==" });
        }
    }
}
