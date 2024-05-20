using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6b21b8b-9263-457d-b806-9d585ff93feb"));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("b99b7606-ab4c-4950-a21c-ad011711fedd"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2023, 2, 12, 20, 6, 59, 435, DateTimeKind.Local).AddTicks(7344), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2023, 2, 12, 20, 6, 59, 437, DateTimeKind.Local).AddTicks(1314) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b99b7606-ab4c-4950-a21c-ad011711fedd"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("e6b21b8b-9263-457d-b806-9d585ff93feb"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 12, 11, 12, 23, 1, 80, DateTimeKind.Local).AddTicks(3060), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 12, 11, 12, 23, 1, 81, DateTimeKind.Local).AddTicks(2254) });
        }
    }
}
