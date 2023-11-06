using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace HotelProject.Migrations.UserDb
{
    public partial class addingHotelRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04ce9491-40d1-49ca-9eed-d716e835d8f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b385c51-9b5e-4634-9236-4ec1420d43b6");

            migrationBuilder.CreateTable(
                name: "HotelRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "varchar(85)", nullable: false),
                    RatingValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelRatings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelRatings_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f2cf459-3fde-41fc-95a2-5b72710cd2cc", "1418537d-77b6-49b1-a89d-1a6ac99384a9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4ba1761-971e-4608-b47a-1bb5ed25271c", "8bf2802c-4a2c-4145-aa7e-cb37982cdf88", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_HotelRatings_HotelId",
                table: "HotelRatings",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRatings_UserId",
                table: "HotelRatings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelRatings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2cf459-3fde-41fc-95a2-5b72710cd2cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ba1761-971e-4608-b47a-1bb5ed25271c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04ce9491-40d1-49ca-9eed-d716e835d8f4", "43170387-8df7-4dcb-9874-e8336fc5bd97", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b385c51-9b5e-4634-9236-4ec1420d43b6", "f7221b9c-f186-4a95-a085-8cd431b211cc", "Administrator", "ADMINISTRATOR" });
        }
    }
}
