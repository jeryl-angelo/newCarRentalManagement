using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "207afebd-0542-45ff-bf1e-1414cd2d834a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "ba007d6d-9a9b-444d-b9a4-102342cc0036");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa8de363-ca08-4674-b01c-d07e973ccdf5", "AQAAAAEAACcQAAAAENkc2EnOCpniJ2dwUUVEyh5owC0Iv5209kq3ojtiDC49QLICw+D9pk/wI3dg1/ELLQ==", "0f71a8a3-e817-4cf2-9d0e-830dc35c0c74" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 26, 46, 994, DateTimeKind.Local).AddTicks(5440), new DateTime(2022, 11, 24, 17, 26, 46, 996, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 26, 46, 996, DateTimeKind.Local).AddTicks(2471), new DateTime(2022, 11, 24, 17, 26, 46, 996, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 26, 46, 997, DateTimeKind.Local).AddTicks(9345), new DateTime(2022, 11, 24, 17, 26, 46, 997, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 26, 46, 997, DateTimeKind.Local).AddTicks(9363), new DateTime(2022, 11, 24, 17, 26, 46, 997, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 26, 46, 998, DateTimeKind.Local).AddTicks(4711), new DateTime(2022, 11, 24, 17, 26, 46, 998, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 26, 46, 998, DateTimeKind.Local).AddTicks(4725), new DateTime(2022, 11, 24, 17, 26, 46, 998, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 26, 46, 998, DateTimeKind.Local).AddTicks(4729), new DateTime(2022, 11, 24, 17, 26, 46, 998, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 26, 46, 998, DateTimeKind.Local).AddTicks(4732), new DateTime(2022, 11, 24, 17, 26, 46, 998, DateTimeKind.Local).AddTicks(4733) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "c6944c94-66cb-4fa9-ae8f-6e4f089906a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "b524ef84-0820-4ad9-ab40-dab950dc4f11");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "586fd12e-3c8b-44e7-9a60-b0635cfe4192", "AQAAAAEAACcQAAAAEKvbMcIgAxJMHlRGu5khclIOOtbOgdpQup62ArmOAQk0xvFBK1axkyelpHWNXEif3w==", "1dcc7c37-bea0-4f83-ba6a-4b31f4a0b8a8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 25, 51, 504, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 11, 24, 17, 25, 51, 506, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 25, 51, 506, DateTimeKind.Local).AddTicks(6547), new DateTime(2022, 11, 24, 17, 25, 51, 506, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 25, 51, 508, DateTimeKind.Local).AddTicks(9085), new DateTime(2022, 11, 24, 17, 25, 51, 508, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 25, 51, 508, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 11, 24, 17, 25, 51, 508, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 25, 51, 509, DateTimeKind.Local).AddTicks(5954), new DateTime(2022, 11, 24, 17, 25, 51, 509, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 25, 51, 509, DateTimeKind.Local).AddTicks(5974), new DateTime(2022, 11, 24, 17, 25, 51, 509, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 25, 51, 509, DateTimeKind.Local).AddTicks(5979), new DateTime(2022, 11, 24, 17, 25, 51, 509, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 25, 51, 509, DateTimeKind.Local).AddTicks(5983), new DateTime(2022, 11, 24, 17, 25, 51, 509, DateTimeKind.Local).AddTicks(5984) });
        }
    }
}
