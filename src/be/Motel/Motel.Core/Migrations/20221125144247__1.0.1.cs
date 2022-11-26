using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class _101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("1af84000-41ed-4dbf-b9ce-4742db0adce2"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("2ac8dd30-0755-4a10-a965-16a68350feef"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("33bdb384-587d-4b83-b17a-41991c37ab54"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("4faa5050-e5af-4868-8173-bfcab7f3044b"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("5521261a-c89c-4c7f-a5d2-b396d8526340"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("93defe27-bdfe-4e2b-9d60-5ef5a26af99e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("b9a82f9a-f84c-4085-b31f-2ab05aaa0e8e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("bc1564b9-bdd9-4519-9c43-33939a2f0728"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("bd3f5e31-baa9-42d0-8831-74df73743f16"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f1a7462f-9d9f-4c2b-be10-6c64dc8e9888"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd350997-a124-48bc-8800-fd9889f15bc3"));

            migrationBuilder.AddColumn<double>(
                name: "AmountPaid",
                table: "StagePayments",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "StagePayments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RoomPaid",
                table: "StagePayments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TotalAmount",
                table: "StagePayments",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "TotalRooms",
                table: "StagePayments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Provides",
                columns: new[] { "Id", "CreatedAt", "DefaultPrice", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5f17e2f8-6188-4e68-b57d-189dc6d23113"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(8424), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(8457) },
                    { new Guid("11eef4eb-b466-442f-b2e3-e25b21a31ab1"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9426), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9431) },
                    { new Guid("04bf61d2-3887-48e2-94d9-2abaeeb41ee5"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9465), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9466) },
                    { new Guid("ca153865-27c1-4367-b081-9790d7d3422e"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9469), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9470) },
                    { new Guid("2feb101a-fb5f-4b3e-970a-128f878e45f6"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9472), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9473) },
                    { new Guid("73ce2217-f7be-440e-8d2a-cf6766b204b2"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9485), 50000.0, "Internet", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9486) },
                    { new Guid("037b4f21-34ee-440f-9143-914772773384"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9488), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9489) },
                    { new Guid("f1c9174e-885b-4923-91bb-5ae3d4606ea1"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9491), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9492) },
                    { new Guid("927f78d4-907a-4eca-b10e-3bcf028d443e"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9494), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9495) },
                    { new Guid("dad7fcc1-1be9-437c-8fee-3a3245a9a9ed"), new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9497), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 25, 21, 42, 46, 856, DateTimeKind.Local).AddTicks(9498) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("dbdb5940-9470-447c-b7e8-88d17148ba41"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 25, 21, 42, 46, 854, DateTimeKind.Local).AddTicks(8278), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 25, 21, 42, 46, 855, DateTimeKind.Local).AddTicks(7077) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("037b4f21-34ee-440f-9143-914772773384"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("04bf61d2-3887-48e2-94d9-2abaeeb41ee5"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("11eef4eb-b466-442f-b2e3-e25b21a31ab1"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("2feb101a-fb5f-4b3e-970a-128f878e45f6"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("5f17e2f8-6188-4e68-b57d-189dc6d23113"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("73ce2217-f7be-440e-8d2a-cf6766b204b2"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("927f78d4-907a-4eca-b10e-3bcf028d443e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ca153865-27c1-4367-b081-9790d7d3422e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("dad7fcc1-1be9-437c-8fee-3a3245a9a9ed"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f1c9174e-885b-4923-91bb-5ae3d4606ea1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbdb5940-9470-447c-b7e8-88d17148ba41"));

            migrationBuilder.DropColumn(
                name: "AmountPaid",
                table: "StagePayments");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "StagePayments");

            migrationBuilder.DropColumn(
                name: "RoomPaid",
                table: "StagePayments");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "StagePayments");

            migrationBuilder.DropColumn(
                name: "TotalRooms",
                table: "StagePayments");

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
        }
    }
}
