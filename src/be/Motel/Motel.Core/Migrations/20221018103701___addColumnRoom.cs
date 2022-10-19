using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __addColumnRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("086beef3-d6a0-4b7c-b300-de9ea30556a7"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("45a5e448-daf3-4735-bc78-105a0db9fce9"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("6fa6e1d1-a53c-4e3d-b331-f9d0503fa1e0"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("788eb017-11ec-4ec4-a82d-1a777523db55"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("84ba87c7-ba3c-48ad-b7e3-45bc2e7fff1d"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("88c4dcf8-30ef-49f2-806a-dd1c89559e3d"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("9712da2d-961f-4a2d-a63e-ea72f1ca08a6"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("cc4723da-8abf-4c5b-9b21-85b2c08622bc"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f3807d16-d8bf-4e1d-a3a9-8ea3f35b5867"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f808a050-94fc-45c8-a28c-6e8f5f2a5fde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f97e985-807e-4312-88c0-06754cb08fe3"));

            migrationBuilder.AddColumn<bool>(
                name: "IsSelfContainer",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNotLimitTime",
                table: "BoardingHouses",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelfPayment",
                table: "BoardingHouses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("804679b7-da23-449b-9935-1cd0a92cb6a8"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(3610), 4000.0, "Tiền điện", 1, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(3630) },
                    { new Guid("89506908-1608-48d4-bdec-82d07c1fbf75"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4234), 100000.0, "Tiền nước", 1, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4238) },
                    { new Guid("ad43f340-75b4-4f45-a44d-787e02fc8411"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4264), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4265) },
                    { new Guid("1def1838-9603-4d13-8955-f74d0256d653"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4267), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4268) },
                    { new Guid("32780181-97ad-4e3a-a3ee-54991e78b9a3"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4270), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4270) },
                    { new Guid("1e7d6826-6efd-4861-a586-a7bf98b190bd"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4272), 50000.0, "Internet", 0, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4273) },
                    { new Guid("38d55efd-0af8-49c4-bc67-149265f12e7d"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4274), 10000.0, "Bảo vệ", 0, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4275) },
                    { new Guid("d79fd593-bb1a-46a7-844c-797729d73793"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4276), 0.0, "Máy giặt", 0, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4277) },
                    { new Guid("c4a75521-88f5-458f-b460-7baf192ed99c"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4285), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4285) },
                    { new Guid("8288f7a7-02b6-4623-bfdb-ccd18b9e90d2"), new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4287), 50000.0, "Thang máy", 0, new DateTime(2022, 10, 18, 17, 37, 1, 406, DateTimeKind.Local).AddTicks(4287) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("d99e5848-b4f0-4717-a0aa-5de51df3e1de"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 10, 18, 17, 37, 1, 404, DateTimeKind.Local).AddTicks(9188), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 10, 18, 17, 37, 1, 405, DateTimeKind.Local).AddTicks(5972) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("1def1838-9603-4d13-8955-f74d0256d653"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("1e7d6826-6efd-4861-a586-a7bf98b190bd"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("32780181-97ad-4e3a-a3ee-54991e78b9a3"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("38d55efd-0af8-49c4-bc67-149265f12e7d"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("804679b7-da23-449b-9935-1cd0a92cb6a8"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("8288f7a7-02b6-4623-bfdb-ccd18b9e90d2"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("89506908-1608-48d4-bdec-82d07c1fbf75"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ad43f340-75b4-4f45-a44d-787e02fc8411"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("c4a75521-88f5-458f-b460-7baf192ed99c"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("d79fd593-bb1a-46a7-844c-797729d73793"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d99e5848-b4f0-4717-a0aa-5de51df3e1de"));

            migrationBuilder.DropColumn(
                name: "IsSelfContainer",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "IsNotLimitTime",
                table: "BoardingHouses");

            migrationBuilder.DropColumn(
                name: "IsSelfPayment",
                table: "BoardingHouses");

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6fa6e1d1-a53c-4e3d-b331-f9d0503fa1e0"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(792), 4000.0, "Tiền điện", 1, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(825) },
                    { new Guid("788eb017-11ec-4ec4-a82d-1a777523db55"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1795), 100000.0, "Tiền nước", 1, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1802) },
                    { new Guid("88c4dcf8-30ef-49f2-806a-dd1c89559e3d"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1830), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1832) },
                    { new Guid("45a5e448-daf3-4735-bc78-105a0db9fce9"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1834), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1835) },
                    { new Guid("f808a050-94fc-45c8-a28c-6e8f5f2a5fde"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1838), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1839) },
                    { new Guid("f3807d16-d8bf-4e1d-a3a9-8ea3f35b5867"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1841), 50000.0, "Internet", 0, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1842) },
                    { new Guid("086beef3-d6a0-4b7c-b300-de9ea30556a7"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1855), 10000.0, "Bảo vệ", 0, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1856) },
                    { new Guid("84ba87c7-ba3c-48ad-b7e3-45bc2e7fff1d"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1858), 0.0, "Máy giặt", 0, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1859) },
                    { new Guid("cc4723da-8abf-4c5b-9b21-85b2c08622bc"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1861), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1862) },
                    { new Guid("9712da2d-961f-4a2d-a63e-ea72f1ca08a6"), new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1864), 50000.0, "Thang máy", 0, new DateTime(2022, 9, 23, 21, 38, 47, 655, DateTimeKind.Local).AddTicks(1865) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("6f97e985-807e-4312-88c0-06754cb08fe3"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 9, 23, 21, 38, 47, 653, DateTimeKind.Local).AddTicks(285), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 9, 23, 21, 38, 47, 653, DateTimeKind.Local).AddTicks(9523) });
        }
    }
}
