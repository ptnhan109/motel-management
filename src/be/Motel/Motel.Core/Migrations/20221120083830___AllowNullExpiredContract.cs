using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AllowNullExpiredContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("03025572-2a60-4ed9-8db0-b496142a2ed8"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("1e468685-0490-43c3-a903-2b9d8fe92ba7"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("3f06fe4c-2cc8-43fd-a107-3eacc496da2a"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("4bddd576-3658-4e5a-a563-12fcee2d92d4"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("8da744e4-2d6c-4a03-bbde-2b02dcec03df"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("95603de5-5363-4f70-adde-a74cb281b24b"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("9859fc01-61f6-4390-a302-729df363c5ed"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("dbd31770-bac9-48ea-9ad4-310d56fbff6a"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f27420a1-2523-484f-a82a-250ccbc8aa92"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("fc898971-88c0-4fda-a2c2-e1c9ad1101f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa3ca238-aeb2-4f30-a457-4a73fee6d75b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiredDate",
                table: "AppContracts",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2ebe3c4a-208f-4ec2-a59a-e337f8177b09"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(1407), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(1442) },
                    { new Guid("2e62adca-fefb-44fb-a19d-2565e192731c"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2418), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2423) },
                    { new Guid("9b43532b-aefd-46ef-97cd-7fea04069940"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2454), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2456) },
                    { new Guid("aae5a8f0-9da9-41c4-a270-3823aee19483"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2458), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2460) },
                    { new Guid("7da7f69a-6538-4b49-925c-f280cf4ab334"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2462), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2463) },
                    { new Guid("fc838e89-c1ca-4587-816b-faddd2fe9eed"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2465), 50000.0, "Internet", 0, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2466) },
                    { new Guid("12637560-5c17-4e25-8e23-e278af1e04fb"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2468), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2469) },
                    { new Guid("fb25cf79-afbd-4095-a666-031c30a93710"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2471), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2472) },
                    { new Guid("54885b7c-0520-4222-ac31-81424bacb772"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2482), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2483) },
                    { new Guid("e5424384-759b-478c-b054-f26fd9291c3f"), new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2486), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 20, 15, 38, 29, 758, DateTimeKind.Local).AddTicks(2487) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("009af0b9-d173-4b5a-a6c8-0949b673fbf1"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 20, 15, 38, 29, 756, DateTimeKind.Local).AddTicks(816), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 20, 15, 38, 29, 756, DateTimeKind.Local).AddTicks(9997) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("12637560-5c17-4e25-8e23-e278af1e04fb"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("2e62adca-fefb-44fb-a19d-2565e192731c"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("2ebe3c4a-208f-4ec2-a59a-e337f8177b09"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("54885b7c-0520-4222-ac31-81424bacb772"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("7da7f69a-6538-4b49-925c-f280cf4ab334"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("9b43532b-aefd-46ef-97cd-7fea04069940"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("aae5a8f0-9da9-41c4-a270-3823aee19483"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("e5424384-759b-478c-b054-f26fd9291c3f"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("fb25cf79-afbd-4095-a666-031c30a93710"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("fc838e89-c1ca-4587-816b-faddd2fe9eed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("009af0b9-d173-4b5a-a6c8-0949b673fbf1"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiredDate",
                table: "AppContracts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("95603de5-5363-4f70-adde-a74cb281b24b"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(6383), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(6417) },
                    { new Guid("8da744e4-2d6c-4a03-bbde-2b02dcec03df"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7427), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7433) },
                    { new Guid("9859fc01-61f6-4390-a302-729df363c5ed"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7462), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7463) },
                    { new Guid("dbd31770-bac9-48ea-9ad4-310d56fbff6a"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7466), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7467) },
                    { new Guid("03025572-2a60-4ed9-8db0-b496142a2ed8"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7469), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7470) },
                    { new Guid("4bddd576-3658-4e5a-a563-12fcee2d92d4"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7472), 50000.0, "Internet", 0, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7473) },
                    { new Guid("3f06fe4c-2cc8-43fd-a107-3eacc496da2a"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7486), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7487) },
                    { new Guid("1e468685-0490-43c3-a903-2b9d8fe92ba7"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7489), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7490) },
                    { new Guid("f27420a1-2523-484f-a82a-250ccbc8aa92"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7492), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7493) },
                    { new Guid("fc898971-88c0-4fda-a2c2-e1c9ad1101f7"), new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7496), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 10, 21, 12, 30, 757, DateTimeKind.Local).AddTicks(7497) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("fa3ca238-aeb2-4f30-a457-4a73fee6d75b"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 10, 21, 12, 30, 755, DateTimeKind.Local).AddTicks(5560), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 10, 21, 12, 30, 756, DateTimeKind.Local).AddTicks(4876) });
        }
    }
}
