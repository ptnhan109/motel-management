using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class AddColumnCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("30e97134-b336-48e0-925f-4f2ae2495512"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("3b6283ab-b40a-4764-ab69-df4863cc2a49"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("6080791f-5efe-4910-b439-f027e03b6b66"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("7614dfe6-63d3-45b2-8cc5-376df2d2f5fd"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("78a450cd-42df-4eb5-86f4-c25597a6555f"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("78b8b0f3-05a2-433e-8e01-224dd76e4ac0"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("9f5b8dfd-672d-4ee3-8c2a-afb6f736b203"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("a09aba36-15fe-49b8-a5ac-430b109f5153"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("bd3da65b-06ab-4089-9b9c-23bd77640eaa"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("c82ab44f-a5f7-4e55-b7f4-920899c310f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d189eda-415c-411c-aff1-9b1fe5a8ed21"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdFactory",
                table: "Customers",
                maxLength: 255,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06deed36-dbb1-4cdb-9af1-65563f964c49"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(5837), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(5871) },
                    { new Guid("bc3a19f7-624e-4051-98d7-afeeb23a6374"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6844), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6851) },
                    { new Guid("dc2eae29-1dc2-4359-a489-c8b362bc6d99"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6878), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6879) },
                    { new Guid("be376a34-9615-4f93-89a3-8b125c0c3999"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6882), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6883) },
                    { new Guid("cd0cbed0-4454-49b7-9f7a-ba76679d6244"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6885), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6886) },
                    { new Guid("01aa3fb2-4bf8-4943-8599-62b16925cbce"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6888), 50000.0, "Internet", 0, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6889) },
                    { new Guid("48d6a71a-0243-4878-8cce-37fb19f15f23"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6891), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6893) },
                    { new Guid("e1ea3f65-7d3e-490a-a172-b78d1654f1ff"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6906), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6907) },
                    { new Guid("b02a08c8-e58f-4131-aef1-e4d571c381da"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6909), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6910) },
                    { new Guid("629a7567-fb21-4958-8a25-eab58d991152"), new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6912), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 4, 22, 2, 10, 42, DateTimeKind.Local).AddTicks(6913) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("805add86-5e2a-4ea8-8340-d8aa9a102db7"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 4, 22, 2, 10, 40, DateTimeKind.Local).AddTicks(5637), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 4, 22, 2, 10, 41, DateTimeKind.Local).AddTicks(4780) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("01aa3fb2-4bf8-4943-8599-62b16925cbce"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("06deed36-dbb1-4cdb-9af1-65563f964c49"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("48d6a71a-0243-4878-8cce-37fb19f15f23"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("629a7567-fb21-4958-8a25-eab58d991152"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("b02a08c8-e58f-4131-aef1-e4d571c381da"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("bc3a19f7-624e-4051-98d7-afeeb23a6374"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("be376a34-9615-4f93-89a3-8b125c0c3999"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("cd0cbed0-4454-49b7-9f7a-ba76679d6244"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("dc2eae29-1dc2-4359-a489-c8b362bc6d99"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("e1ea3f65-7d3e-490a-a172-b78d1654f1ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("805add86-5e2a-4ea8-8340-d8aa9a102db7"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IdFactory",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("30e97134-b336-48e0-925f-4f2ae2495512"), new DateTime(2022, 10, 30, 21, 41, 44, 462, DateTimeKind.Local).AddTicks(9891), 4000.0, "Tiền điện", 1, new DateTime(2022, 10, 30, 21, 41, 44, 462, DateTimeKind.Local).AddTicks(9924) },
                    { new Guid("7614dfe6-63d3-45b2-8cc5-376df2d2f5fd"), new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(889), 100000.0, "Tiền nước", 1, new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(896) },
                    { new Guid("78b8b0f3-05a2-433e-8e01-224dd76e4ac0"), new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(922), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(923) },
                    { new Guid("a09aba36-15fe-49b8-a5ac-430b109f5153"), new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(926), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(927) },
                    { new Guid("bd3da65b-06ab-4089-9b9c-23bd77640eaa"), new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(929), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(930) },
                    { new Guid("6080791f-5efe-4910-b439-f027e03b6b66"), new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(932), 50000.0, "Internet", 0, new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(933) },
                    { new Guid("c82ab44f-a5f7-4e55-b7f4-920899c310f0"), new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(935), 10000.0, "Bảo vệ", 0, new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(937) },
                    { new Guid("3b6283ab-b40a-4764-ab69-df4863cc2a49"), new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(950), 0.0, "Máy giặt", 0, new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(951) },
                    { new Guid("9f5b8dfd-672d-4ee3-8c2a-afb6f736b203"), new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(953), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(954) },
                    { new Guid("78a450cd-42df-4eb5-86f4-c25597a6555f"), new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(956), 50000.0, "Thang máy", 0, new DateTime(2022, 10, 30, 21, 41, 44, 463, DateTimeKind.Local).AddTicks(957) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("4d189eda-415c-411c-aff1-9b1fe5a8ed21"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 10, 30, 21, 41, 44, 460, DateTimeKind.Local).AddTicks(9162), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 10, 30, 21, 41, 44, 461, DateTimeKind.Local).AddTicks(8440) });
        }
    }
}
