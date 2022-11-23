using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __100 : Migration
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
                name: "StagePayments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StageDate = table.Column<DateTime>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StagePayments", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Systems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    GroupKey = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems", x => x.Id);
                });

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
                    DayOfBirth = table.Column<DateTime>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    IdentityNumber = table.Column<string>(maxLength: 10, nullable: true),
                    IdentityProvider = table.Column<string>(maxLength: 200, nullable: true),
                    IdentityDate = table.Column<string>(maxLength: 150, nullable: true),
                    Address = table.Column<string>(maxLength: 255, nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    AccountBankNumber = table.Column<string>(maxLength: 50, nullable: true),
                    BankName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
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
                    CityId = table.Column<Guid>(nullable: true),
                    IsNotLimitTime = table.Column<bool>(nullable: true),
                    IsSelfPayment = table.Column<bool>(nullable: true)
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
                    Location = table.Column<string>(nullable: true),
                    IsSelfContainer = table.Column<bool>(nullable: true),
                    Count = table.Column<int>(nullable: true)
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
                name: "AppContracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    ContractNo = table.Column<string>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    RoomId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ExpiredDate = table.Column<DateTime>(nullable: true),
                    DepositedAmount = table.Column<double>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    ContractDuration = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    AdvanceAmount = table.Column<double>(nullable: true)
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
                    IdFactory = table.Column<string>(maxLength: 255, nullable: true),
                    Address = table.Column<string>(maxLength: 255, nullable: true),
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
                    Note = table.Column<string>(maxLength: 150, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    IdentityNumber = table.Column<string>(nullable: true)
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
                name: "StageRooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    StagePaymentId = table.Column<Guid>(nullable: false),
                    RoomId = table.Column<Guid>(nullable: false),
                    PaymentStatus = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StageRooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StageRooms_StagePayments_StagePaymentId",
                        column: x => x.StagePaymentId,
                        principalTable: "StagePayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    StageRoomId = table.Column<Guid>(nullable: false),
                    ProvideId = table.Column<Guid>(nullable: true),
                    LastValue = table.Column<double>(nullable: true),
                    NewValue = table.Column<double>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Amount = table.Column<double>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Provides_ProvideId",
                        column: x => x.ProvideId,
                        principalTable: "Provides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_StageRooms_StageRoomId",
                        column: x => x.StageRoomId,
                        principalTable: "StageRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2ac8dd30-0755-4a10-a965-16a68350feef"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(1712), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(1746) },
                    { new Guid("1af84000-41ed-4dbf-b9ce-4742db0adce2"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2725), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2732) },
                    { new Guid("b9a82f9a-f84c-4085-b31f-2ab05aaa0e8e"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2811), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2813) },
                    { new Guid("4faa5050-e5af-4868-8173-bfcab7f3044b"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2816), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2817) },
                    { new Guid("5521261a-c89c-4c7f-a5d2-b396d8526340"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2819), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2820) },
                    { new Guid("bc1564b9-bdd9-4519-9c43-33939a2f0728"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2822), 50000.0, "Internet", 0, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2823) },
                    { new Guid("33bdb384-587d-4b83-b17a-41991c37ab54"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2837), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2838) },
                    { new Guid("bd3f5e31-baa9-42d0-8831-74df73743f16"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2840), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2841) },
                    { new Guid("93defe27-bdfe-4e2b-9d60-5ef5a26af99e"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2843), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2845) },
                    { new Guid("f1a7462f-9d9f-4c2b-be10-6c64dc8e9888"), new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2847), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 23, 16, 21, 49, 801, DateTimeKind.Local).AddTicks(2848) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("cd350997-a124-48bc-8800-fd9889f15bc3"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 23, 16, 21, 49, 799, DateTimeKind.Local).AddTicks(1572), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 23, 16, 21, 49, 800, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.CreateIndex(
                name: "IX_AppContracts_RoomId",
                table: "AppContracts",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_BoardingHouses_CityId",
                table: "BoardingHouses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractTerm_AppContractId",
                table: "ContractTerm",
                column: "AppContractId");

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
                name: "IX_Invoices_ProvideId",
                table: "Invoices",
                column: "ProvideId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_StageRoomId",
                table: "Invoices",
                column: "StageRoomId");

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
                name: "IX_StageRooms_RoomId",
                table: "StageRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_StageRooms_StagePaymentId",
                table: "StageRooms",
                column: "StagePaymentId");

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
                name: "ContractTerm");

            migrationBuilder.DropTable(
                name: "FitmentInRooms");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "RoomDepositeds");

            migrationBuilder.DropTable(
                name: "ServiceInBoardingHouses");

            migrationBuilder.DropTable(
                name: "SystemFiles");

            migrationBuilder.DropTable(
                name: "Systems");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AppContracts");

            migrationBuilder.DropTable(
                name: "Fitments");

            migrationBuilder.DropTable(
                name: "StageRooms");

            migrationBuilder.DropTable(
                name: "Provides");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "StagePayments");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "BoardingHouses");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
