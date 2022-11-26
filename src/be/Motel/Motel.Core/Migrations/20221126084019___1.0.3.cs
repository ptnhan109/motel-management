using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "StageRooms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9a4f8104-1f18-4a94-9df5-a866522c1652"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(6440), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(6473) },
                    { new Guid("d75529fa-f51c-432f-b85d-47a709a82170"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7460), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7466) },
                    { new Guid("8d15a063-4e2d-44d0-a125-5ee1d182c39a"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7492), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7493) },
                    { new Guid("849e51af-61f3-4d99-82d0-8494c3a1c2e0"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7496), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7497) },
                    { new Guid("e3eb3239-9857-45d3-b1ef-c1645d7903a1"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7499), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7500) },
                    { new Guid("e8008684-ed07-4878-8272-5938d922d83c"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7502), 50000.0, "Internet", 0, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7503) },
                    { new Guid("597323c0-5c8c-4b74-98b0-19ee4b68b9f8"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7505), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7506) },
                    { new Guid("40275e18-1212-4861-95d8-becd996423f2"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7520), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7521) },
                    { new Guid("bb0c0be1-abe6-42ac-9f75-7976c30d0d4f"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7523), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7524) },
                    { new Guid("d24acc40-3a5b-4b9c-9ca6-0d82cf0fbb3c"), new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7526), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 26, 15, 40, 18, 644, DateTimeKind.Local).AddTicks(7527) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("e0765e3f-3d48-4682-8c56-3abb183a9ddb"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 26, 15, 40, 18, 642, DateTimeKind.Local).AddTicks(6211), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 26, 15, 40, 18, 643, DateTimeKind.Local).AddTicks(5095) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("40275e18-1212-4861-95d8-becd996423f2"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("597323c0-5c8c-4b74-98b0-19ee4b68b9f8"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("849e51af-61f3-4d99-82d0-8494c3a1c2e0"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("8d15a063-4e2d-44d0-a125-5ee1d182c39a"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("9a4f8104-1f18-4a94-9df5-a866522c1652"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("bb0c0be1-abe6-42ac-9f75-7976c30d0d4f"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("d24acc40-3a5b-4b9c-9ca6-0d82cf0fbb3c"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("d75529fa-f51c-432f-b85d-47a709a82170"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("e3eb3239-9857-45d3-b1ef-c1645d7903a1"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("e8008684-ed07-4878-8272-5938d922d83c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0765e3f-3d48-4682-8c56-3abb183a9ddb"));

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "StageRooms");

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
    }
}
