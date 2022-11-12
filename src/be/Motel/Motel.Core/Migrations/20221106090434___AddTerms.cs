using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AddTerms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "ContractTerm",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AppContractId = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTerm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractTerm_AppContracts_AppContractId",
                        column: x => x.AppContractId,
                        principalTable: "AppContracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2f916063-f02b-44b7-a433-02b833deac81"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(4671), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(4704) },
                    { new Guid("9059e760-f314-443c-a249-c675d2dc1182"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5802), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5808) },
                    { new Guid("780fb380-4ec6-4c6f-afcd-15b8a58ae2b0"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5838), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5840) },
                    { new Guid("55a0f08e-f5b3-47e7-a14c-d8fb1f2191ee"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5843), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5844) },
                    { new Guid("a58934c3-27a5-4446-a34b-812f97dab38e"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5846), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5847) },
                    { new Guid("f0a6c7bc-3a88-41bc-99bb-2b299b665910"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5849), 50000.0, "Internet", 0, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5850) },
                    { new Guid("21e01858-2e93-4817-a349-8677b952ddb8"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5864), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5865) },
                    { new Guid("c017e05a-29f1-4d29-825d-1ad40909ab20"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5867), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5868) },
                    { new Guid("3aa72d90-14d8-4d3a-aa91-c3a9fc1c1cc9"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5870), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5871) },
                    { new Guid("e0f2deb8-9d9c-45b4-a34a-14298eec376b"), new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5874), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 6, 16, 4, 33, 773, DateTimeKind.Local).AddTicks(5875) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("1953b6bc-649b-410e-81b4-185bf01277bd"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 6, 16, 4, 33, 771, DateTimeKind.Local).AddTicks(4503), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 6, 16, 4, 33, 772, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.CreateIndex(
                name: "IX_ContractTerm_AppContractId",
                table: "ContractTerm",
                column: "AppContractId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractTerm");

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("21e01858-2e93-4817-a349-8677b952ddb8"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("2f916063-f02b-44b7-a433-02b833deac81"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("3aa72d90-14d8-4d3a-aa91-c3a9fc1c1cc9"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("55a0f08e-f5b3-47e7-a14c-d8fb1f2191ee"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("780fb380-4ec6-4c6f-afcd-15b8a58ae2b0"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("9059e760-f314-443c-a249-c675d2dc1182"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("a58934c3-27a5-4446-a34b-812f97dab38e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("c017e05a-29f1-4d29-825d-1ad40909ab20"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("e0f2deb8-9d9c-45b4-a34a-14298eec376b"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f0a6c7bc-3a88-41bc-99bb-2b299b665910"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1953b6bc-649b-410e-81b4-185bf01277bd"));

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
        }
    }
}
