using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class _102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d9f57f3-3658-4d4a-9d66-795f9e31fabe"));

            migrationBuilder.AddColumn<bool>(
                name: "IsSubtractToDeposited",
                table: "StageRooms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("e6b21b8b-9263-457d-b806-9d585ff93feb"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 12, 11, 12, 23, 1, 80, DateTimeKind.Local).AddTicks(3060), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 12, 11, 12, 23, 1, 81, DateTimeKind.Local).AddTicks(2254) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6b21b8b-9263-457d-b806-9d585ff93feb"));

            migrationBuilder.DropColumn(
                name: "IsSubtractToDeposited",
                table: "StageRooms");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("7d9f57f3-3658-4d4a-9d66-795f9e31fabe"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 12, 2, 23, 17, 7, 520, DateTimeKind.Local).AddTicks(3840), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 12, 2, 23, 17, 7, 521, DateTimeKind.Local).AddTicks(3125) });
        }
    }
}
