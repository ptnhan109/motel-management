using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceInMotels");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3720b019-6a94-40c6-94fb-2e32bb1fca3b"));

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Services");

            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "BoardingHouses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ServiceInBoardingHouses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    BoardingHouseId = table.Column<Guid>(nullable: false),
                    ServiceId = table.Column<Guid>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceInBoardingHouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceInBoardingHouses_BoardingHouses_BoardingHouseId",
                        column: x => x.BoardingHouseId,
                        principalTable: "BoardingHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceInBoardingHouses_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedAt", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("603dd2cf-6785-452a-92cf-75164d3dad22"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(6820), "Tiền nhà", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(6841) },
                    { new Guid("a1c590c6-205d-442e-bfa9-39127a502227"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7374), "Tiền điện", 1, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7379) },
                    { new Guid("8c29d6e1-7a96-4440-b1a3-c3229f3f3df5"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7395), "Tiền nước", 1, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7396) },
                    { new Guid("73038b69-c7ee-4b9d-9c6a-72c02888f442"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7398), "Xe máy", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7398) },
                    { new Guid("49d352e7-002f-4291-a06e-d95064cc121c"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7400), "Tiền xe đạp", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7401) },
                    { new Guid("be009bae-e949-4f30-a571-14494bb40a93"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7402), "Tiền xe điện", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7403) },
                    { new Guid("46a913d7-8ed9-40ef-be96-736cfcdbbe62"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7404), "Internet", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7405) },
                    { new Guid("a2b43296-b69c-47ad-8763-40386a39dcf5"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7406), "Bảo vệ", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7407) },
                    { new Guid("9e83baee-15ea-43e1-92da-c26f036e5ed0"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7416), "Máy giặt", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7416) },
                    { new Guid("e71f8678-d11a-40bd-b256-b12502253b9a"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7418), "Truyền hình cáp", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7418) },
                    { new Guid("b0d8386f-48a7-4b64-909e-8b2c0f1a726d"), new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7420), "Thang máy", 0, new DateTime(2022, 9, 19, 10, 37, 8, 192, DateTimeKind.Local).AddTicks(7421) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("ad26a393-c7df-4319-9f1c-784c8db79cf3"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 9, 19, 10, 37, 8, 190, DateTimeKind.Local).AddTicks(9296), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 9, 19, 10, 37, 8, 191, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.CreateIndex(
                name: "IX_BoardingHouses_CityId",
                table: "BoardingHouses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInBoardingHouses_BoardingHouseId",
                table: "ServiceInBoardingHouses",
                column: "BoardingHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInBoardingHouses_ServiceId",
                table: "ServiceInBoardingHouses",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoardingHouses_Cities_CityId",
                table: "BoardingHouses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardingHouses_Cities_CityId",
                table: "BoardingHouses");

            migrationBuilder.DropTable(
                name: "ServiceInBoardingHouses");

            migrationBuilder.DropIndex(
                name: "IX_BoardingHouses_CityId",
                table: "BoardingHouses");

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("46a913d7-8ed9-40ef-be96-736cfcdbbe62"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("49d352e7-002f-4291-a06e-d95064cc121c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("603dd2cf-6785-452a-92cf-75164d3dad22"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("73038b69-c7ee-4b9d-9c6a-72c02888f442"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8c29d6e1-7a96-4440-b1a3-c3229f3f3df5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9e83baee-15ea-43e1-92da-c26f036e5ed0"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a1c590c6-205d-442e-bfa9-39127a502227"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a2b43296-b69c-47ad-8763-40386a39dcf5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b0d8386f-48a7-4b64-909e-8b2c0f1a726d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("be009bae-e949-4f30-a571-14494bb40a93"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e71f8678-d11a-40bd-b256-b12502253b9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad26a393-c7df-4319-9f1c-784c8db79cf3"));

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "BoardingHouses");

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ServiceInMotels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoardingHouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceInMotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceInMotels_BoardingHouses_BoardingHouseId",
                        column: x => x.BoardingHouseId,
                        principalTable: "BoardingHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceInMotels_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("3720b019-6a94-40c6-94fb-2e32bb1fca3b"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 9, 17, 21, 55, 50, 158, DateTimeKind.Local).AddTicks(933), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 9, 17, 21, 55, 50, 158, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInMotels_BoardingHouseId",
                table: "ServiceInMotels",
                column: "BoardingHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInMotels_ServiceId",
                table: "ServiceInMotels",
                column: "ServiceId");
        }
    }
}
