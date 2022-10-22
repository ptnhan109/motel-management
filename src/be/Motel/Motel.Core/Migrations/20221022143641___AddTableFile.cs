using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AddTableFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Rooms",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SystemFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    MapId = table.Column<Guid>(nullable: false),
                    FileType = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemFiles", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemFiles");

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

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Rooms");

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
    }
}
