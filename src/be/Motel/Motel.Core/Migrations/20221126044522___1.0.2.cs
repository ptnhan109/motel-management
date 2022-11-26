using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("037b4f21-34ee-440f-9143-914772773384"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("04bf61d2-3887-48e2-94d9-2abaeeb41ee5"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("11eef4eb-b466-442f-b2e3-e25b21a31ab1"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("2feb101a-fb5f-4b3e-970a-128f878e45f6"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("5f17e2f8-6188-4e68-b57d-189dc6d23113"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("73ce2217-f7be-440e-8d2a-cf6766b204b2"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("927f78d4-907a-4eca-b10e-3bcf028d443e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ca153865-27c1-4367-b081-9790d7d3422e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("dad7fcc1-1be9-437c-8fee-3a3245a9a9ed"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f1c9174e-885b-4923-91bb-5ae3d4606ea1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbdb5940-9470-447c-b7e8-88d17148ba41"));

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("71966447-34d7-44af-8455-31a69b899d8c"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(6746), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(6781) },
                    { new Guid("7eefc752-5ce1-4a02-a6ad-c88d6a1cdf4d"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7782), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7787) },
                    { new Guid("c08b3fe6-2190-4722-b51a-aacd53cdbb02"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7814), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7815) },
                    { new Guid("9d954725-31b1-4646-aa2e-6209aa0aa4f7"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7818), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7819) },
                    { new Guid("08339eaa-98f3-46b6-ab8f-5135bbc869d5"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7821), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7822) },
                    { new Guid("ca506956-c33c-48a1-8734-94206855a99d"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7824), 50000.0, "Internet", 0, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7825) },
                    { new Guid("f1fedc0d-c9ec-4254-a2d3-eaf087bff0fd"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7828), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7829) },
                    { new Guid("a9634515-08e5-4b2a-8d9d-ec2cb1426a5e"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7831), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7832) },
                    { new Guid("66b7513f-bdb7-4a27-abba-24f49368a015"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7844), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7845) },
                    { new Guid("1c57f686-a7d1-40ee-a419-193ef79f79a9"), new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7847), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 26, 11, 45, 21, 689, DateTimeKind.Local).AddTicks(7848) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("793dbc45-b344-4091-a940-276d5ba34582"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 26, 11, 45, 21, 687, DateTimeKind.Local).AddTicks(3768), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 26, 11, 45, 21, 688, DateTimeKind.Local).AddTicks(4430) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("08339eaa-98f3-46b6-ab8f-5135bbc869d5"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("1c57f686-a7d1-40ee-a419-193ef79f79a9"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("66b7513f-bdb7-4a27-abba-24f49368a015"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("71966447-34d7-44af-8455-31a69b899d8c"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("7eefc752-5ce1-4a02-a6ad-c88d6a1cdf4d"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("9d954725-31b1-4646-aa2e-6209aa0aa4f7"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("a9634515-08e5-4b2a-8d9d-ec2cb1426a5e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("c08b3fe6-2190-4722-b51a-aacd53cdbb02"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ca506956-c33c-48a1-8734-94206855a99d"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f1fedc0d-c9ec-4254-a2d3-eaf087bff0fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("793dbc45-b344-4091-a940-276d5ba34582"));

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5f17e2f8-6188-4e68-b57d-189dc6d23113"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(8424), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(8457) },
                    { new Guid("11eef4eb-b466-442f-b2e3-e25b21a31ab1"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9426), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9431) },
                    { new Guid("04bf61d2-3887-48e2-94d9-2abaeeb41ee5"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9465), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9466) },
                    { new Guid("ca153865-27c1-4367-b081-9790d7d3422e"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9469), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9470) },
                    { new Guid("2feb101a-fb5f-4b3e-970a-128f878e45f6"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9472), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9473) },
                    { new Guid("73ce2217-f7be-440e-8d2a-cf6766b204b2"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9485), 50000.0, "Internet", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9486) },
                    { new Guid("037b4f21-34ee-440f-9143-914772773384"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9488), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9489) },
                    { new Guid("f1c9174e-885b-4923-91bb-5ae3d4606ea1"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9491), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9492) },
                    { new Guid("927f78d4-907a-4eca-b10e-3bcf028d443e"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9494), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9495) },
                    { new Guid("dad7fcc1-1be9-437c-8fee-3a3245a9a9ed"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9497), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9498) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("dbdb5940-9470-447c-b7e8-88d17148ba41"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 25, 21, 42, 46, 854, DateTimeKind.Local).AddTicks(8278), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 25, 21, 42, 46, 855, DateTimeKind.Local).AddTicks(7077) });
        }
    }
}
