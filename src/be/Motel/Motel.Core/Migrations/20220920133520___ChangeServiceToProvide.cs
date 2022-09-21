using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __ChangeServiceToProvide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("46a913d7-8ed9-40ef-be96-736cfcdbbe62"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("49d352e7-002f-4291-a06e-d95064cc121c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("603dd2cf-6785-452a-92cf-75164d3dad22"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("73038b69-c7ee-4b9d-9c6a-72c02888f442"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8c29d6e1-7a96-4440-b1a3-c3229f3f3df5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9e83baee-15ea-43e1-92da-c26f036e5ed0"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a1c590c6-205d-442e-bfa9-39127a502227"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a2b43296-b69c-47ad-8763-40386a39dcf5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b0d8386f-48a7-4b64-909e-8b2c0f1a726d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("be009bae-e949-4f30-a571-14494bb40a93"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e71f8678-d11a-40bd-b256-b12502253b9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad26a393-c7df-4319-9f1c-784c8db79cf3"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedAt", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("603dd2cf-6785-452a-92cf-75164d3dad22"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(6820), "Tiền nhà", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(6841) },
                    { new Guid("a1c590c6-205d-442e-bfa9-39127a502227"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7374), "Tiền điện", 1, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7379) },
                    { new Guid("8c29d6e1-7a96-4440-b1a3-c3229f3f3df5"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7395), "Tiền nước", 1, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7396) },
                    { new Guid("73038b69-c7ee-4b9d-9c6a-72c02888f442"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7398), "Xe máy", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7398) },
                    { new Guid("49d352e7-002f-4291-a06e-d95064cc121c"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7400), "Tiền xe đạp", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7401) },
                    { new Guid("be009bae-e949-4f30-a571-14494bb40a93"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7402), "Tiền xe điện", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7403) },
                    { new Guid("46a913d7-8ed9-40ef-be96-736cfcdbbe62"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7404), "Internet", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7405) },
                    { new Guid("a2b43296-b69c-47ad-8763-40386a39dcf5"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7406), "Bảo vệ", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7407) },
                    { new Guid("9e83baee-15ea-43e1-92da-c26f036e5ed0"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7416), "Máy giặt", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7416) },
                    { new Guid("e71f8678-d11a-40bd-b256-b12502253b9a"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7418), "Truyền hình cáp", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7418) },
                    { new Guid("b0d8386f-48a7-4b64-909e-8b2c0f1a726d"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7420), "Thang máy", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7421) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("ad26a393-c7df-4319-9f1c-784c8db79cf3"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 9, 19, 10, 37, 8, 190, DateTimeKind.Local).AddTicks(9296), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 9, 19, 10, 37, 8, 191, DateTimeKind.Local).AddTicks(8027) });
        }
    }
}
