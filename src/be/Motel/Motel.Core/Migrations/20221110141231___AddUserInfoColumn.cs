using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AddUserInfoColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("077dd83b-fc02-42f3-8848-33c148973d5e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("60755bb0-6540-4cf1-b921-8bfb16219826"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("91fee1ca-8961-4dfb-9375-67744a482674"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ad446cf8-8201-4eff-a5a6-d61768a2f793"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("b8605b58-343b-4dce-b5e9-621c835e72a5"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("b996f248-77b6-479a-bbba-69093f5b3683"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("be113a5f-fc71-4e62-9ae1-18895e759b88"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("cf688ad3-ac60-4dd3-9588-d2ab16bf61c5"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("e387d799-458c-4887-b8b8-f5b89598309d"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("e398e41e-2222-440d-a6f9-acd89e8b3364"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d4a26d2-ea25-4717-838e-99663d716a36"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "UserInfos",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserInfos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DayOfBirth",
                table: "UserInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityDate",
                table: "UserInfos",
                maxLength: 150,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Address",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "City",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "DayOfBirth",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "IdentityDate",
                table: "UserInfos");

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("91fee1ca-8961-4dfb-9375-67744a482674"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(1983), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(2020) },
                    { new Guid("b996f248-77b6-479a-bbba-69093f5b3683"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3049), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3054) },
                    { new Guid("cf688ad3-ac60-4dd3-9588-d2ab16bf61c5"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3101), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3103) },
                    { new Guid("e387d799-458c-4887-b8b8-f5b89598309d"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3105), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3106) },
                    { new Guid("be113a5f-fc71-4e62-9ae1-18895e759b88"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3108), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3109) },
                    { new Guid("077dd83b-fc02-42f3-8848-33c148973d5e"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3121), 50000.0, "Internet", 0, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3122) },
                    { new Guid("e398e41e-2222-440d-a6f9-acd89e8b3364"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3125), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3126) },
                    { new Guid("ad446cf8-8201-4eff-a5a6-d61768a2f793"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3128), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3129) },
                    { new Guid("b8605b58-343b-4dce-b5e9-621c835e72a5"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3131), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3132) },
                    { new Guid("60755bb0-6540-4cf1-b921-8bfb16219826"), new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3134), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 7, 21, 37, 49, 315, DateTimeKind.Local).AddTicks(3135) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("8d4a26d2-ea25-4717-838e-99663d716a36"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 7, 21, 37, 49, 313, DateTimeKind.Local).AddTicks(1480), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 7, 21, 37, 49, 314, DateTimeKind.Local).AddTicks(743) });
        }
    }
}
