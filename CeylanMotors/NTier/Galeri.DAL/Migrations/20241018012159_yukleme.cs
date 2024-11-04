using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class yukleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "ceylanmotors3", "CEYLANMOTORS3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Surname", "UserName" },
                values: new object[] { "c6722f7a-06cd-47ea-a6ac-d7361a540011", "ceylanmotors3@gmail.com", "ceylanmotors3", "CEYLANMOTORS3@GMAİL.COM", "CEYLANMOTORS3", "AQAAAAIAAYagAAAAEFbjNHfLNKDXPTzNXPW3S5yK+kWePilxz4LyqJMGHVdkJpt2HX/lbLHr/dQmmnCgeA==", "ceylanmotors3", "ceylanmotors3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Admin", "ADMİN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Surname", "UserName" },
                values: new object[] { "a3488a3c-3a3f-4219-9762-866f5ec9b764", "Admin@mail.com", "Admin", "ADMİN@MAİL.COM", "ADMİN", "AQAAAAIAAYagAAAAEIBXoJ6yxVNZxC8omwt6qvP6SncsbE7rWrOsAghY9FIYaDJhq0++/JBAl4T1T2Ox9A==", "Admin", "Admin" });
        }
    }
}
