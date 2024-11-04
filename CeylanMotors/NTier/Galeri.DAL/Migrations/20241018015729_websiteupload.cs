using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class websiteupload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "admin", "ADMİN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Surname", "UserName" },
                values: new object[] { "b92569c6-61cb-425d-a80e-46600de12354", "admin@mail.com", "admin", "ADMİN@MAİL.COM", "ADMİN", "AQAAAAIAAYagAAAAEJ1qT72vdQWLBWmyAT7kVwv/DeBREasFWVi3o3kDB7hqtBUZh9TLQgG1CFHyo9pV4Q==", "admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
