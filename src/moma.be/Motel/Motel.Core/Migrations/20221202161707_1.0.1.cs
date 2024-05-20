using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class _101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0255d37c-bdbf-478a-affc-37952c8ba79a"));

            migrationBuilder.AddColumn<int>(
                name: "Area",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("7d9f57f3-3658-4d4a-9d66-795f9e31fabe"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 12, 2, 23, 17, 7, 520, DateTimeKind.Local).AddTicks(3840), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 12, 2, 23, 17, 7, 521, DateTimeKind.Local).AddTicks(3125) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d9f57f3-3658-4d4a-9d66-795f9e31fabe"));

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Rooms");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("0255d37c-bdbf-478a-affc-37952c8ba79a"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 27, 14, 20, 47, 135, DateTimeKind.Local).AddTicks(7162), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 27, 14, 20, 47, 136, DateTimeKind.Local).AddTicks(6478) });
        }
    }
}
