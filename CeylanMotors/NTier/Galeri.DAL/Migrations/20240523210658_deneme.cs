using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0cdf3c9-d5ce-44b7-9b12-61d7aa151ca4", "AQAAAAIAAYagAAAAEMW3kvtPt1muobaBeDYXzya2Isfo2W6i5ZzJdWI3eYxykn+9zHs+lTElAgaeslcitw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "144e7028-2f74-40fd-80c3-c1598ee33650", "AQAAAAIAAYagAAAAED7MTmYpuzCIInvJQZnvJJ2qfebq2omLez1lO1sdZ+XY2teyUSfmY9n5hE3EyZA3LQ==" });
        }
    }
}
