using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations.UserDb
{
    public partial class addingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fddde38-378d-4341-80e5-a19653d187a6", "0823338b-6fd6-481b-a271-85d20b84b6b2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3e19dcc-8549-41eb-8d7f-cec318f4db27", "2c6414e0-aa4a-49e2-9b36-4c5fd6ab939a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fddde38-378d-4341-80e5-a19653d187a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3e19dcc-8549-41eb-8d7f-cec318f4db27");
        }
    }
}
