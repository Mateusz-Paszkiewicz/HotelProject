using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations.UserDb
{
    public partial class arrangingHotelForData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "AccommodationType",
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

            migrationBuilder.AddColumn<float>(
                name: "DistanceToCenter",
                table: "Hotels",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DistanceToPOI",
                table: "Hotels",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "IsOffer",
                table: "Hotels",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Offer",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "POI",
                table: "Hotels",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriceNight",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Stars",
                table: "Hotels",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64c5690b-dfe7-48bc-8fa2-3db5acc95c4a", "79ca9189-6550-4f74-9773-f31f6e9c6e59", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d798eb7-00a7-4f82-b7db-cbebae602cb0", "30216189-55b3-4c35-8b3f-e0fde8bbd309", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d798eb7-00a7-4f82-b7db-cbebae602cb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64c5690b-dfe7-48bc-8fa2-3db5acc95c4a");

            migrationBuilder.DropColumn(
                name: "AccommodationType",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "DistanceToCenter",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "DistanceToPOI",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "IsOffer",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Offer",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "POI",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "PriceNight",
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
    }
}
