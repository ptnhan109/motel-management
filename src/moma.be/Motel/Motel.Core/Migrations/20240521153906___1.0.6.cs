using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __106 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("634e65c2-ea3e-4647-8024-584fc979cbd6"));

            migrationBuilder.AddColumn<bool>(
                name: "IsCheckout",
                table: "StageRooms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "IsDeleted", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("dc087c21-6f3f-4617-bb1b-5021f71f29ed"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2024, 5, 21, 22, 39, 6, 71, DateTimeKind.Local).AddTicks(445), 1, null, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2024, 5, 21, 22, 39, 6, 71, DateTimeKind.Local).AddTicks(5490) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc087c21-6f3f-4617-bb1b-5021f71f29ed"));

            migrationBuilder.DropColumn(
                name: "IsCheckout",
                table: "StageRooms");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "IsDeleted", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("634e65c2-ea3e-4647-8024-584fc979cbd6"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2023, 10, 10, 20, 25, 29, 263, DateTimeKind.Local).AddTicks(9976), 1, null, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2023, 10, 10, 20, 25, 29, 264, DateTimeKind.Local).AddTicks(4854) });
        }
    }
}
