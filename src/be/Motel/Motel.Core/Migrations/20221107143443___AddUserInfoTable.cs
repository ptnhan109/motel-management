using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motel.Core.Migrations
{
    public partial class __AddUserInfoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1f294653-3a3f-4a2a-a84a-2bd12f20d7c5"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(1707), 4000.0, "Tiền điện", 1, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(1740) },
                    { new Guid("f30e008e-7950-4f30-8be0-ed412340c661"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2686), 100000.0, "Tiền nước", 1, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2690) },
                    { new Guid("0452be70-1a85-4117-9d88-f7f4250fa19d"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2719), 50000.0, "Gửi Xe máy", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2721) },
                    { new Guid("f01102d4-f9c2-4bbe-9525-52b554f4f4fe"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2723), 0.0, "Tiền xe đạp", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2725) },
                    { new Guid("9253b054-54bc-4203-a793-d71fd2261bed"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2727), 100000.0, "Tiền xe điện", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2728) },
                    { new Guid("3dc41243-6472-48ed-b286-aba90555ed06"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2730), 50000.0, "Internet", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2731) },
                    { new Guid("1f23b275-6ae4-4d30-8466-01c91a971a80"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2746), 10000.0, "Bảo vệ", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2747) },
                    { new Guid("ef89160b-9eca-42f9-a0ff-7b6fa7aa427b"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2749), 0.0, "Máy giặt", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2750) },
                    { new Guid("4e1287d6-cf45-46cf-bdf4-e3d54bfa2cad"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2752), 0.0, "Truyền hình cáp", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2754) },
                    { new Guid("f9a27777-2d6f-4d60-bf80-f28a58ecc1c2"), new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2756), 50000.0, "Thang máy", 0, new DateTime(2022, 11, 7, 21, 34, 42, 764, DateTimeKind.Local).AddTicks(2757) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Gender", "Mail", "Name", "Password", "Phone", "role", "UpdatedAt" },
                values: new object[] { new Guid("6fc81a64-65af-411e-8108-4c0778b81b49"), "Cổ Nhuế, Từ Liêm", null, new DateTime(2022, 11, 7, 21, 34, 42, 762, DateTimeKind.Local).AddTicks(1432), 1, "trongnhan1110i@gmail.com", "Phạm Trọng Nhân", "T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=", "0775331777", 0, new DateTime(2022, 11, 7, 21, 34, 42, 763, DateTimeKind.Local).AddTicks(386) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("0452be70-1a85-4117-9d88-f7f4250fa19d"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("1f23b275-6ae4-4d30-8466-01c91a971a80"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("1f294653-3a3f-4a2a-a84a-2bd12f20d7c5"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("3dc41243-6472-48ed-b286-aba90555ed06"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("4e1287d6-cf45-46cf-bdf4-e3d54bfa2cad"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("9253b054-54bc-4203-a793-d71fd2261bed"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("ef89160b-9eca-42f9-a0ff-7b6fa7aa427b"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f01102d4-f9c2-4bbe-9525-52b554f4f4fe"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f30e008e-7950-4f30-8be0-ed412340c661"));

            migrationBuilder.DeleteData(
                table: "Provides",
                keyColumn: "Id",
                keyValue: new Guid("f9a27777-2d6f-4d60-bf80-f28a58ecc1c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fc81a64-65af-411e-8108-4c0778b81b49"));

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
    }
}
