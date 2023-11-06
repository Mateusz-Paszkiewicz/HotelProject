using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations.UserDb
{
    public partial class mergedbcontexts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fddde38-378d-4341-80e5-a19653d187a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3e19dcc-8549-41eb-8d7f-cec318f4db27");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "784734c0-03f2-40f5-a62f-3617c15037ed", "fa96e760-2c35-49b0-9461-a4d09ae36de9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2be4083-51be-4af8-bd63-dd6bc9eed03b", "02ea256e-3d4f-46aa-ae6e-24482cbe710f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "784734c0-03f2-40f5-a62f-3617c15037ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2be4083-51be-4af8-bd63-dd6bc9eed03b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fddde38-378d-4341-80e5-a19653d187a6", "0823338b-6fd6-481b-a271-85d20b84b6b2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3e19dcc-8549-41eb-8d7f-cec318f4db27", "2c6414e0-aa4a-49e2-9b36-4c5fd6ab939a", "Administrator", "ADMINISTRATOR" });
        }
    }
}
