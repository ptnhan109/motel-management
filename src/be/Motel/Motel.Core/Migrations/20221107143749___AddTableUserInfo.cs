using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AddTableUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("0452be70-1a85-4117-9d88-f7f4250fa19d"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("1f23b275-6ae4-4d30-8466-01c91a971a80"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("1f294653-3a3f-4a2a-a84a-2bd12f20d7c5"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("3dc41243-6472-48ed-b286-aba90555ed06"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("4e1287d6-cf45-46cf-bdf4-e3d54bfa2cad"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("9253b054-54bc-4203-a793-d71fd2261bed"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ef89160b-9eca-42f9-a0ff-7b6fa7aa427b"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f01102d4-f9c2-4bbe-9525-52b554f4f4fe"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f30e008e-7950-4f30-8be0-ed412340c661"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f9a27777-2d6f-4d60-bf80-f28a58ecc1c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fc81a64-65af-411e-8108-4c0778b81b49"));

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 10, nullable: true),
                    IdentityNumber = table.Column<string>(maxLength: 10, nullable: true),
                    IdentityProvider = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    AccountBankNumber = table.Column<string>(maxLength: 50, nullable: true),
                    BankName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInfos");

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

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1f294653-3a3f-4a2a-a84a-2bd12f20d7c5"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(1707), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(1740) },
                    { new Guid("f30e008e-7950-4f30-8be0-ed412340c661"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2686), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2690) },
                    { new Guid("0452be70-1a85-4117-9d88-f7f4250fa19d"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2719), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2721) },
                    { new Guid("f01102d4-f9c2-4bbe-9525-52b554f4f4fe"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2723), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2725) },
                    { new Guid("9253b054-54bc-4203-a793-d71fd2261bed"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2727), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2728) },
                    { new Guid("3dc41243-6472-48ed-b286-aba90555ed06"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2730), 50000.0, "Internet", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2731) },
                    { new Guid("1f23b275-6ae4-4d30-8466-01c91a971a80"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2746), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2747) },
                    { new Guid("ef89160b-9eca-42f9-a0ff-7b6fa7aa427b"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2749), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2750) },
                    { new Guid("4e1287d6-cf45-46cf-bdf4-e3d54bfa2cad"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2752), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2754) },
                    { new Guid("f9a27777-2d6f-4d60-bf80-f28a58ecc1c2"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2756), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2757) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("6fc81a64-65af-411e-8108-4c0778b81b49"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 7, 21, 34, 42, 762, DateTimeKind.Local).AddTicks(1432), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 7, 21, 34, 42, 763, DateTimeKind.Local).AddTicks(386) });
        }
    }
}
