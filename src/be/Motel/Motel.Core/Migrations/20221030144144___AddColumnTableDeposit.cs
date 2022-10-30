using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AddColumnTableDeposit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("00f6e09a-2028-4ed3-a1cb-73bc6206062a"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("0308722b-cab8-4458-bb81-0000d3d7c910"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("3600a382-eccc-4b47-96b1-0bc3902163ac"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("8b96b8f4-e6df-4b74-8176-9d264f55c926"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ae325a3a-21d6-4a06-bb00-b3739c772091"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ba181e13-4d9d-443f-b357-0adc52428dea"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ba5108e5-35d1-4b46-b149-666fe560e600"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("cb95c72c-b0bd-4f89-97e6-d5a6da7ed593"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("e9e658c3-5557-4475-82fe-26a506b2c14d"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f5e155a9-741e-4ae2-9383-2e6bb2943e4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("331a5cc0-e669-4f3a-a4bf-36d1a46de8aa"));

            migrationBuilder.AddColumn<string>(
                name: "IdentityNumber",
                table: "RoomDepositeds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RoomDepositeds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "RoomDepositeds",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "RoomDepositeds");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RoomDepositeds");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "RoomDepositeds");

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("cb95c72c-b0bd-4f89-97e6-d5a6da7ed593"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(1027), 4000.0, "Tiền điện", 1, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(1060) },
                    { new Guid("ba5108e5-35d1-4b46-b149-666fe560e600"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2036), 100000.0, "Tiền nước", 1, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2041) },
                    { new Guid("ba181e13-4d9d-443f-b357-0adc52428dea"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2068), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2069) },
                    { new Guid("8b96b8f4-e6df-4b74-8176-9d264f55c926"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2072), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2073) },
                    { new Guid("f5e155a9-741e-4ae2-9383-2e6bb2943e4b"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2075), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2076) },
                    { new Guid("0308722b-cab8-4458-bb81-0000d3d7c910"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2078), 50000.0, "Internet", 0, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2079) },
                    { new Guid("00f6e09a-2028-4ed3-a1cb-73bc6206062a"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2095), 10000.0, "Bảo vệ", 0, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2096) },
                    { new Guid("ae325a3a-21d6-4a06-bb00-b3739c772091"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2099), 0.0, "Máy giặt", 0, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2100) },
                    { new Guid("3600a382-eccc-4b47-96b1-0bc3902163ac"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2102), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2103) },
                    { new Guid("e9e658c3-5557-4475-82fe-26a506b2c14d"), new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2105), 50000.0, "Thang máy", 0, new DateTime(2022, 10, 22, 21, 36, 40, 667, DateTimeKind.Local).AddTicks(2106) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("331a5cc0-e669-4f3a-a4bf-36d1a46de8aa"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 10, 22, 21, 36, 40, 665, DateTimeKind.Local).AddTicks(376), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 10, 22, 21, 36, 40, 665, DateTimeKind.Local).AddTicks(9418) });
        }
    }
}
