using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AddContractTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AppContracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    RoomId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ExpiredDate = table.Column<DateTime>(nullable: false),
                    DepositedAmount = table.Column<double>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    ContractDuration = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppContracts_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("81724b92-6c86-4662-abc4-39da36931497"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(4073), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(4105) },
                    { new Guid("5d56fe23-efa9-4e08-905d-95747e89496c"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5060), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5065) },
                    { new Guid("4deb4de7-6092-424c-a68d-167453c18226"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5094), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5096) },
                    { new Guid("b7fe52a1-7ed7-47d3-bdf1-d3dc1746638e"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5098), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5099) },
                    { new Guid("6de090bb-0d75-4a37-9132-8e88145b4b44"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5102), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5103) },
                    { new Guid("171208e1-aa79-441f-a949-c3a5661f9882"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5105), 50000.0, "Internet", 0, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5106) },
                    { new Guid("2e15c828-e3eb-4cc1-bd53-c3368b9e88b4"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5120), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5122) },
                    { new Guid("de1cff96-ae13-4670-95de-3b74159b1497"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5125), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5126) },
                    { new Guid("28a7c19b-3894-4bba-94dc-0f51cd0be829"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5128), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5129) },
                    { new Guid("8d200cf6-8976-4e65-84c7-e1de3ab99a87"), new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5131), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 6, 14, 16, 7, 36, DateTimeKind.Local).AddTicks(5132) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("c2bb92e8-0909-4ef9-9271-3399532c9d35"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 6, 14, 16, 7, 34, DateTimeKind.Local).AddTicks(3137), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 6, 14, 16, 7, 35, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.CreateIndex(
                name: "IX_AppContracts_RoomId",
                table: "AppContracts",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppContracts");

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("171208e1-aa79-441f-a949-c3a5661f9882"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("28a7c19b-3894-4bba-94dc-0f51cd0be829"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("2e15c828-e3eb-4cc1-bd53-c3368b9e88b4"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("4deb4de7-6092-424c-a68d-167453c18226"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("5d56fe23-efa9-4e08-905d-95747e89496c"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("6de090bb-0d75-4a37-9132-8e88145b4b44"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("81724b92-6c86-4662-abc4-39da36931497"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("8d200cf6-8976-4e65-84c7-e1de3ab99a87"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("b7fe52a1-7ed7-47d3-bdf1-d3dc1746638e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("de1cff96-ae13-4670-95de-3b74159b1497"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2bb92e8-0909-4ef9-9271-3399532c9d35"));

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
    }
}
