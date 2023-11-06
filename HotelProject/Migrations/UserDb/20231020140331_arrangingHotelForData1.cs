using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations.UserDb
{
    public partial class arrangingHotelForData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2cf459-3fde-41fc-95a2-5b72710cd2cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ba1761-971e-4608-b47a-1bb5ed25271c");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Amenities",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CheckInTime",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CheckOutTime",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Rooms",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Hotels");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e83b4cb8-d78f-4207-aee8-6d6b6cfe9037", "0b2e7600-a43f-4863-bba1-1dac4d04f0a7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f446e05b-110e-4c81-adbb-f714b513dfe2", "baa3d6b5-d199-47ad-bbc8-ae171622bc92", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e83b4cb8-d78f-4207-aee8-6d6b6cfe9037");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f446e05b-110e-4c81-adbb-f714b513dfe2");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Amenities",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "CheckInTime",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "CheckOutTime",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Hotels",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Hotels",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Hotels",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rooms",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stars",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f2cf459-3fde-41fc-95a2-5b72710cd2cc", "1418537d-77b6-49b1-a89d-1a6ac99384a9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4ba1761-971e-4608-b47a-1bb5ed25271c", "8bf2802c-4a2c-4145-aa7e-cb37982cdf88", "Administrator", "ADMINISTRATOR" });
        }
    }
}
