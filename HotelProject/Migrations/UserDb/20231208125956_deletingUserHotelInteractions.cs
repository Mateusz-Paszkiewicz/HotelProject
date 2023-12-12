using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace HotelProject.Migrations.UserDb
{
    public partial class deletingUserHotelInteractions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHotelInteractions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f0acb9b-33fd-467e-8dd3-64a78363bfa6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f98b0253-4121-4fe1-8f77-3c5b15a21fed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "efeb2405-5565-459b-b126-f1027e7eb2d6", "8c928a04-6cfc-41ef-bffd-129fc582fbe0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57c6a5cd-5783-46fb-806d-f16078594349", "9072b78f-6a9e-4918-bd18-5ed34b234ce6", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57c6a5cd-5783-46fb-806d-f16078594349");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efeb2405-5565-459b-b126-f1027e7eb2d6");

            migrationBuilder.CreateTable(
                name: "UserHotelInteractions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "varchar(85)", nullable: false)
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
                values: new object[] { "f98b0253-4121-4fe1-8f77-3c5b15a21fed", "6b44c348-a9b9-454c-8262-da8a66216761", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f0acb9b-33fd-467e-8dd3-64a78363bfa6", "3c868dc2-5de2-46a0-93d9-2ab4d98ff43d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_UserHotelInteractions_HotelId",
                table: "UserHotelInteractions",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHotelInteractions_UserId",
                table: "UserHotelInteractions",
                column: "UserId");
        }
    }
}
