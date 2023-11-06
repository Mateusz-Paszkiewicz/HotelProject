using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations.UserDb
{
    public partial class arrangingHotelForData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d798eb7-00a7-4f82-b7db-cbebae602cb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64c5690b-dfe7-48bc-8fa2-3db5acc95c4a");

            migrationBuilder.AlterColumn<double>(
                name: "Stars",
                table: "Hotels",
                type: "double",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "DistanceToPOI",
                table: "Hotels",
                type: "double",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "DistanceToCenter",
                table: "Hotels",
                type: "double",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f98b0253-4121-4fe1-8f77-3c5b15a21fed", "6b44c348-a9b9-454c-8262-da8a66216761", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f0acb9b-33fd-467e-8dd3-64a78363bfa6", "3c868dc2-5de2-46a0-93d9-2ab4d98ff43d", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f0acb9b-33fd-467e-8dd3-64a78363bfa6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f98b0253-4121-4fe1-8f77-3c5b15a21fed");

            migrationBuilder.AlterColumn<float>(
                name: "Stars",
                table: "Hotels",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<float>(
                name: "DistanceToPOI",
                table: "Hotels",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<float>(
                name: "DistanceToCenter",
                table: "Hotels",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64c5690b-dfe7-48bc-8fa2-3db5acc95c4a", "79ca9189-6550-4f74-9773-f31f6e9c6e59", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d798eb7-00a7-4f82-b7db-cbebae602cb0", "30216189-55b3-4c35-8b3f-e0fde8bbd309", "Administrator", "ADMINISTRATOR" });
        }
    }
}
