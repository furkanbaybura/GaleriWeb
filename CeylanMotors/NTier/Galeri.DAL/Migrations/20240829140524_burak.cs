using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Galeri.DAL.Migrations
{
    /// <inheritdoc />
    public partial class burak : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SliderFileName",
                table: "Sliders");

            migrationBuilder.RenameColumn(
                name: "SliderImage",
                table: "Sliders",
                newName: "SliderImageName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cafc316-2374-4197-ae71-de1e584f9a3e", "AQAAAAIAAYagAAAAEP/qhdH03k3QoFMSr86a6BC7C2+aMLzocPXLYwokdNz7SczGF9qmVRw8Sh7Beg2KOA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SliderImageName",
                table: "Sliders",
                newName: "SliderImage");

            migrationBuilder.AddColumn<string>(
                name: "SliderFileName",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "faa1a346-7a8b-4a85-8600-81d033e1b9ed", "AQAAAAIAAYagAAAAEPSuz+yIOA25uz+NVJfv4HFSeJRC2y9LTjS5Y0BuvMKrl/xgEYbrNuCBfT8vuu7upg==" });
        }
    }
}
