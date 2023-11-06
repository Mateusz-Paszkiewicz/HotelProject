using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace HotelProject.Migrations.UserDb
{
    public partial class addingHotelsToIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "784734c0-03f2-40f5-a62f-3617c15037ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2be4083-51be-4af8-bd63-dd6bc9eed03b");

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    CheckInTime = table.Column<string>(type: "text", nullable: false),
                    CheckOutTime = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Amenities = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double", nullable: false),
                    Longitude = table.Column<double>(type: "double", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec33cbb5-d368-44fc-8e4e-c1f201971f94", "a36774c5-47c0-4bb8-9067-bc052acd99cb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4055870c-d875-42b1-a80b-d924843fa936", "e5d3868c-bc21-4af3-b600-9115168735e0", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4055870c-d875-42b1-a80b-d924843fa936");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec33cbb5-d368-44fc-8e4e-c1f201971f94");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "784734c0-03f2-40f5-a62f-3617c15037ed", "fa96e760-2c35-49b0-9461-a4d09ae36de9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2be4083-51be-4af8-bd63-dd6bc9eed03b", "02ea256e-3d4f-46aa-ae6e-24482cbe710f", "Administrator", "ADMINISTRATOR" });
        }
    }
}
