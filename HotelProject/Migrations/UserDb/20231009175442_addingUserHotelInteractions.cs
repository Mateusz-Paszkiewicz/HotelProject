using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace HotelProject.Migrations.UserDb
{
    public partial class addingUserHotelInteractions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4055870c-d875-42b1-a80b-d924843fa936");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec33cbb5-d368-44fc-8e4e-c1f201971f94");

            migrationBuilder.CreateTable(
                name: "UserHotelInteractions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "varchar(85)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHotelInteractions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHotelInteractions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHotelInteractions_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04ce9491-40d1-49ca-9eed-d716e835d8f4", "43170387-8df7-4dcb-9874-e8336fc5bd97", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b385c51-9b5e-4634-9236-4ec1420d43b6", "f7221b9c-f186-4a95-a085-8cd431b211cc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_UserHotelInteractions_HotelId",
                table: "UserHotelInteractions",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHotelInteractions_UserId",
                table: "UserHotelInteractions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHotelInteractions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04ce9491-40d1-49ca-9eed-d716e835d8f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b385c51-9b5e-4634-9236-4ec1420d43b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec33cbb5-d368-44fc-8e4e-c1f201971f94", "a36774c5-47c0-4bb8-9067-bc052acd99cb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4055870c-d875-42b1-a80b-d924843fa936", "e5d3868c-bc21-4af3-b600-9115168735e0", "Administrator", "ADMINISTRATOR" });
        }
    }
}
