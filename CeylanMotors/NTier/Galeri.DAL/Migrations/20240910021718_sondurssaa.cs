using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sondurssaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af25b863-484e-4406-9e69-fae366a9fee9", "AQAAAAIAAYagAAAAEKxCGoO+7MJ79oJ6bLTqhWfdsfBJ8Vdr6UF5CUBGQEYH0Vlx/BDiur9RBdKEbPL5nw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4bbdf11-7a61-4898-83eb-0ae58b997e51", "AQAAAAIAAYagAAAAEMCMiaGL9QIxeZPKcrG3fFACLD6lb/z+fJskR/AxqOpQZZbZmjmRJ9vLyvGSw/3MHg==" });
        }
    }
}
