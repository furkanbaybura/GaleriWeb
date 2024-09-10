using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sondurssa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4bbdf11-7a61-4898-83eb-0ae58b997e51", "AQAAAAIAAYagAAAAEMCMiaGL9QIxeZPKcrG3fFACLD6lb/z+fJskR/AxqOpQZZbZmjmRJ9vLyvGSw/3MHg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27e35500-2862-42a4-acae-5a26c52e0293", "AQAAAAIAAYagAAAAEK1WdQNckrFgmudGDwQ5bmVX1GH/2tDIMgcx2wYFHQuZVywAjCsIOwW8VgwcPHAKFw==" });
        }
    }
}
