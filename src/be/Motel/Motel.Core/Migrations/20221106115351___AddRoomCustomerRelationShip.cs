using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AddRoomCustomerRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("e87279cb-3c4b-4ec8-85b5-a0f0fbcc3d44"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(7967), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(8019) },
                    { new Guid("ea5bc19c-ee6d-42e5-bc07-e5d31c1a3105"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9067), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9072) },
                    { new Guid("cdff1179-d2f1-4090-a21b-128246a455c2"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9101), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9102) },
                    { new Guid("d8ea6cc0-424a-4541-8817-9c7333da292c"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9106), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9107) },
                    { new Guid("d79903f8-a628-4c8f-b13f-cf467bdad918"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9119), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9120) },
                    { new Guid("ded329d6-13f6-4d97-9577-43308a030dac"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9124), 50000.0, "Internet", 0, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9125) },
                    { new Guid("b9661718-dd30-4775-9cfa-fbc5e63a8f0f"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9140), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9141) },
                    { new Guid("c1c0fff5-d041-412b-a214-9dd68d2a67b9"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9143), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9144) },
                    { new Guid("3b499a11-1f42-4595-ad07-42a62bdcc57e"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9146), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9147) },
                    { new Guid("38ea6069-6743-424c-a5bf-063482a8a755"), new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9149), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 6, 18, 53, 50, 934, DateTimeKind.Local).AddTicks(9150) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("977ffb76-46f3-4f87-a6d7-6154372c277a"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 6, 18, 53, 50, 932, DateTimeKind.Local).AddTicks(3491), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 6, 18, 53, 50, 933, DateTimeKind.Local).AddTicks(2754) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("38ea6069-6743-424c-a5bf-063482a8a755"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("3b499a11-1f42-4595-ad07-42a62bdcc57e"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("b9661718-dd30-4775-9cfa-fbc5e63a8f0f"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("c1c0fff5-d041-412b-a214-9dd68d2a67b9"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("cdff1179-d2f1-4090-a21b-128246a455c2"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("d79903f8-a628-4c8f-b13f-cf467bdad918"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("d8ea6cc0-424a-4541-8817-9c7333da292c"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ded329d6-13f6-4d97-9577-43308a030dac"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("e87279cb-3c4b-4ec8-85b5-a0f0fbcc3d44"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ea5bc19c-ee6d-42e5-bc07-e5d31c1a3105"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("977ffb76-46f3-4f87-a6d7-6154372c277a"));

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
        }
    }
}
