using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddApplicationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "001c7972-47b1-4b27-8b8b-67912486bd64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "b0733c17-a538-4c78-a4b2-95b3e4e229f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de95f27c-43ca-4766-af21-2a706617bf97", "AQAAAAEAACcQAAAAELPax6Iz+mD3gFHBv9CoHeczCJ4GupZ0q3NSe+i3QR5us5ZwwmNxWxgf5VNl7j4D4g==", "f88639c9-a1f4-45b3-9648-7e8565748b91" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 23, 41, 651, DateTimeKind.Local).AddTicks(6801), new DateTime(2022, 11, 24, 17, 23, 41, 655, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 23, 41, 655, DateTimeKind.Local).AddTicks(6788), new DateTime(2022, 11, 24, 17, 23, 41, 655, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 23, 41, 658, DateTimeKind.Local).AddTicks(6988), new DateTime(2022, 11, 24, 17, 23, 41, 658, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 23, 41, 658, DateTimeKind.Local).AddTicks(7019), new DateTime(2022, 11, 24, 17, 23, 41, 658, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 23, 41, 659, DateTimeKind.Local).AddTicks(8415), new DateTime(2022, 11, 24, 17, 23, 41, 659, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 23, 41, 659, DateTimeKind.Local).AddTicks(8457), new DateTime(2022, 11, 24, 17, 23, 41, 659, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 23, 41, 659, DateTimeKind.Local).AddTicks(8467), new DateTime(2022, 11, 24, 17, 23, 41, 659, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 24, 17, 23, 41, 659, DateTimeKind.Local).AddTicks(8476), new DateTime(2022, 11, 24, 17, 23, 41, 659, DateTimeKind.Local).AddTicks(8479) });
        }
    }
}
