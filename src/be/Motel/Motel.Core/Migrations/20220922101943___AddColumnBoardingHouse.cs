using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AddColumnBoardingHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2021a9c7-1ad6-43a5-9469-d5da9474d875"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2a225b33-ecc6-42c9-9384-b2400c79dfff"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("55a4dfe7-5835-4944-9c01-cf101d307525"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6df76815-8c80-4b1d-a7ef-7de8b8174d0a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("74dd7f4c-9fee-40fb-bdf8-2d4ea6137c2f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8357e8c3-66c6-4df7-bd36-b3f67c32d07d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8a0767c5-07f5-442c-8ba0-401a3e7e6672"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9f2823d6-9935-4107-8a63-a6fe19e19145"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c3a9f072-0f42-4e50-b01d-001ff5be11ac"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ef978e71-c04b-4f18-af66-4f14db789655"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("efa202b7-579f-4a2a-a380-248b920429d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("099857d0-b948-450d-bf98-f17f778b36dc"));

            migrationBuilder.DropColumn(
                name: "DateRetalPayment",
                table: "BoardingHouses");

            migrationBuilder.AddColumn<int>(
                name: "EndDatePayment",
                table: "BoardingHouses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Months",
                table: "BoardingHouses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartDatePayment",
                table: "BoardingHouses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedAt", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("93e43d85-c157-4fda-8339-9f7fd73cda52"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(845), "Tiền nhà", 0, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(865) },
                    { new Guid("190f3dda-f254-4f35-b5a2-60b0dad2dc26"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1296), "Tiền điện", 1, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1299) },
                    { new Guid("faed9af1-61a9-48c3-afe1-f5b0a0ac7f56"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1312), "Tiền nước", 1, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1313) },
                    { new Guid("2dce07fd-34e0-479f-85aa-3a221796da92"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1315), "Xe máy", 0, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1315) },
                    { new Guid("966234f2-c787-4722-9928-be1a8fe04451"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1317), "Tiền xe đạp", 0, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1318) },
                    { new Guid("749c43db-21e4-414f-8115-c6b9459b086d"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1319), "Tiền xe điện", 0, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1320) },
                    { new Guid("25f463a9-9543-4fc8-a2e9-b703be9041fc"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1332), "Internet", 0, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1332) },
                    { new Guid("1b4e2b0e-e82e-4c79-9723-2e99b2608ca5"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1334), "Bảo vệ", 0, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1335) },
                    { new Guid("85fd94c7-fcfb-4144-b0b8-b861dcbc2612"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1336), "Máy giặt", 0, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1337) },
                    { new Guid("5759984b-1c63-4564-a3d7-2a388b2d0b45"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1338), "Truyền hình cáp", 0, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1339) },
                    { new Guid("c56d29ad-39b3-4263-92f6-3a515f341efa"), new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1340), "Thang máy", 0, new DateTime(2022, 9, 22, 17, 19, 42, 940, DateTimeKind.Local).AddTicks(1341) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("ff7da8ac-b4f8-46be-b724-1eda088117c8"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 9, 22, 17, 19, 42, 938, DateTimeKind.Local).AddTicks(6344), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 9, 22, 17, 19, 42, 939, DateTimeKind.Local).AddTicks(3151) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("190f3dda-f254-4f35-b5a2-60b0dad2dc26"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("1b4e2b0e-e82e-4c79-9723-2e99b2608ca5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("25f463a9-9543-4fc8-a2e9-b703be9041fc"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2dce07fd-34e0-479f-85aa-3a221796da92"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("5759984b-1c63-4564-a3d7-2a388b2d0b45"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("749c43db-21e4-414f-8115-c6b9459b086d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("85fd94c7-fcfb-4144-b0b8-b861dcbc2612"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("93e43d85-c157-4fda-8339-9f7fd73cda52"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("966234f2-c787-4722-9928-be1a8fe04451"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c56d29ad-39b3-4263-92f6-3a515f341efa"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("faed9af1-61a9-48c3-afe1-f5b0a0ac7f56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff7da8ac-b4f8-46be-b724-1eda088117c8"));

            migrationBuilder.DropColumn(
                name: "EndDatePayment",
                table: "BoardingHouses");

            migrationBuilder.DropColumn(
                name: "Months",
                table: "BoardingHouses");

            migrationBuilder.DropColumn(
                name: "StartDatePayment",
                table: "BoardingHouses");

            migrationBuilder.AddColumn<int>(
                name: "DateRetalPayment",
                table: "BoardingHouses",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedAt", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("74dd7f4c-9fee-40fb-bdf8-2d4ea6137c2f"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(4478), "Tiền nhà", 0, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(4540) },
                    { new Guid("ef978e71-c04b-4f18-af66-4f14db789655"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5476), "Tiền điện", 1, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5483) },
                    { new Guid("2021a9c7-1ad6-43a5-9469-d5da9474d875"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5514), "Tiền nước", 1, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5516) },
                    { new Guid("2a225b33-ecc6-42c9-9384-b2400c79dfff"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5520), "Xe máy", 0, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5521) },
                    { new Guid("8a0767c5-07f5-442c-8ba0-401a3e7e6672"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5524), "Tiền xe đạp", 0, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5526) },
                    { new Guid("55a4dfe7-5835-4944-9c01-cf101d307525"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5530), "Tiền xe điện", 0, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5531) },
                    { new Guid("c3a9f072-0f42-4e50-b01d-001ff5be11ac"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5533), "Internet", 0, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5535) },
                    { new Guid("9f2823d6-9935-4107-8a63-a6fe19e19145"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5538), "Bảo vệ", 0, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5540) },
                    { new Guid("efa202b7-579f-4a2a-a380-248b920429d9"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5553), "Máy giặt", 0, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5555) },
                    { new Guid("6df76815-8c80-4b1d-a7ef-7de8b8174d0a"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5557), "Truyền hình cáp", 0, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5559) },
                    { new Guid("8357e8c3-66c6-4df7-bd36-b3f67c32d07d"), new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5561), "Thang máy", 0, new DateTime(2022, 9, 20, 20, 35, 19, 793, DateTimeKind.Local).AddTicks(5562) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("099857d0-b948-450d-bf98-f17f778b36dc"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 9, 20, 20, 35, 19, 790, DateTimeKind.Local).AddTicks(6671), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 9, 20, 20, 35, 19, 791, DateTimeKind.Local).AddTicks(9027) });
        }
    }
}
