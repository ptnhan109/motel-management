using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __107 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc087c21-6f3f-4617-bb1b-5021f71f29ed"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AppContracts",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "IsDeleted", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("f607ccb3-f194-439a-bbfb-569cea808aa2"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2024, 5, 25, 13, 51, 36, 317, DateTimeKind.Local).AddTicks(4192), 1, null, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2024, 5, 25, 13, 51, 36, 317, DateTimeKind.Local).AddTicks(8995) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f607ccb3-f194-439a-bbfb-569cea808aa2"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AppContracts");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "IsDeleted", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("dc087c21-6f3f-4617-bb1b-5021f71f29ed"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2024, 5, 21, 22, 39, 6, 71, DateTimeKind.Local).AddTicks(445), 1, null, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2024, 5, 21, 22, 39, 6, 71, DateTimeKind.Local).AddTicks(5490) });
        }
    }
}
