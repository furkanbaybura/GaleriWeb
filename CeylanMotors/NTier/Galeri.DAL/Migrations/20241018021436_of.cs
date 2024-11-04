using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class of : Migration
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
                values: new object[] { "c42e4828-863d-408a-80b8-a8f3e4a0aaa2", "ceylanmotors3@gmail.com", "ceylanmotors3", "CEYLANMOTORS3@GMAİL.COM", "CEYLANMOTORS3", "AQAAAAIAAYagAAAAEGzRSeqGCpvXt+RSHtPO0l0gAw0UmoYkJvlW1Yd8HEFGq4VfuGWRJbN/1fU2Qe6kHw==", "ceylanmotors3", "ceylanmotors3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
