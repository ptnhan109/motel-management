using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fitments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    IsCanUse = table.Column<bool>(nullable: false),
                    RecoupPrice = table.Column<double>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fitments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provides",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    DefaultPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardingHouses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    Months = table.Column<int>(nullable: false),
                    StartDatePayment = table.Column<int>(nullable: true),
                    EndDatePayment = table.Column<int>(nullable: true),
                    CityId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardingHouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoardingHouses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(maxLength: 255, nullable: true),
                    role = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Mail = table.Column<string>(maxLength: 255, nullable: true),
                    Phone = table.Column<string>(maxLength: 10, nullable: true),
                    CityId = table.Column<Guid>(nullable: true),
                    Address = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    BoardingHouseId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Floor = table.Column<int>(nullable: true),
                    MaxHuman = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_BoardingHouses_BoardingHouseId",
                        column: x => x.BoardingHouseId,
                        principalTable: "BoardingHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceInBoardingHouses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    BoardingHouseId = table.Column<Guid>(nullable: false),
                    ProvideId = table.Column<Guid>(nullable: false),
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
                        name: "FK_ServiceInBoardingHouses_Provides_ProvideId",
                        column: x => x.ProvideId,
                        principalTable: "Provides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Phone = table.Column<string>(maxLength: 10, nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    IdentificationCitizen = table.Column<string>(maxLength: 13, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Career = table.Column<int>(nullable: true),
                    Gender = table.Column<int>(nullable: true),
                    AvatarPath = table.Column<string>(maxLength: 150, nullable: true),
                    FontIdentityPath = table.Column<string>(maxLength: 150, nullable: true),
                    BackIdentityPath = table.Column<string>(maxLength: 150, nullable: true),
                    RoomId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FitmentInRooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    RoomId = table.Column<Guid>(nullable: false),
                    FitmentId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitmentInRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FitmentInRooms_Fitments_FitmentId",
                        column: x => x.FitmentId,
                        principalTable: "Fitments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FitmentInRooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomDepositeds",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    RoomId = table.Column<Guid>(nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    DespositedValue = table.Column<double>(nullable: false),
                    Note = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomDepositeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomDepositeds_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    LicensePlate = table.Column<string>(maxLength: 255, nullable: true),
                    Color = table.Column<string>(maxLength: 255, nullable: true),
                    CustomerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BoardingHouses_CityId",
                table: "BoardingHouses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoomId",
                table: "Customers",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_FitmentInRooms_FitmentId",
                table: "FitmentInRooms",
                column: "FitmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FitmentInRooms_RoomId",
                table: "FitmentInRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDepositeds_RoomId",
                table: "RoomDepositeds",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BoardingHouseId",
                table: "Rooms",
                column: "BoardingHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInBoardingHouses_BoardingHouseId",
                table: "ServiceInBoardingHouses",
                column: "BoardingHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInBoardingHouses_ProvideId",
                table: "ServiceInBoardingHouses",
                column: "ProvideId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FitmentInRooms");

            migrationBuilder.DropTable(
                name: "RoomDepositeds");

            migrationBuilder.DropTable(
                name: "ServiceInBoardingHouses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Fitments");

            migrationBuilder.DropTable(
                name: "Provides");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "BoardingHouses");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
