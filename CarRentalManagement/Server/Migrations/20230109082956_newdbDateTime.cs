using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newdbDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "66d707b7-7233-4627-9e07-4a1b0ca45de3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "5a9993ee-ad6c-4562-853d-ebf7c046d423");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adf24f0d-c105-4cd1-b715-848fa9d61f45", "AQAAAAEAACcQAAAAEFWhUScl1GNxl3C/UsYnpoVS52/DUGQQ+bglvbqK99feCdv16Jt1chuNRnEVmgZvYA==", "c20ac009-55a6-4ba7-a653-8d3114208322" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 56, 96, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 1, 9, 16, 29, 56, 98, DateTimeKind.Local).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 56, 98, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 1, 9, 16, 29, 56, 98, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 56, 99, DateTimeKind.Local).AddTicks(6779), new DateTime(2023, 1, 9, 16, 29, 56, 99, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 56, 99, DateTimeKind.Local).AddTicks(6794), new DateTime(2023, 1, 9, 16, 29, 56, 99, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 56, 100, DateTimeKind.Local).AddTicks(1372), new DateTime(2023, 1, 9, 16, 29, 56, 100, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 56, 100, DateTimeKind.Local).AddTicks(1384), new DateTime(2023, 1, 9, 16, 29, 56, 100, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 56, 100, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 1, 9, 16, 29, 56, 100, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 56, 100, DateTimeKind.Local).AddTicks(1391), new DateTime(2023, 1, 9, 16, 29, 56, 100, DateTimeKind.Local).AddTicks(1392) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "ab373499-168d-46cf-862b-94a5fc46732b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "47684141-ab09-4882-9a74-c7c92d9d12ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbc0ea0e-6674-4f05-bffd-94849d790dba", "AQAAAAEAACcQAAAAEN6uoIWRQhcu3QDGKSr9mxxTFDPspUHl+sWT2nOIO87+Ed91OSZZGoU7dXzOQ/ipTw==", "43cee779-70b8-4e62-bc9f-27339febf0a9" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 22, 13, 55, 767, DateTimeKind.Local).AddTicks(8202), new DateTime(2023, 1, 3, 22, 13, 55, 769, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 22, 13, 55, 770, DateTimeKind.Local).AddTicks(1262), new DateTime(2023, 1, 3, 22, 13, 55, 770, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 22, 13, 55, 772, DateTimeKind.Local).AddTicks(1769), new DateTime(2023, 1, 3, 22, 13, 55, 772, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 22, 13, 55, 772, DateTimeKind.Local).AddTicks(1808), new DateTime(2023, 1, 3, 22, 13, 55, 772, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 22, 13, 55, 773, DateTimeKind.Local).AddTicks(425), new DateTime(2023, 1, 3, 22, 13, 55, 773, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 22, 13, 55, 773, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 1, 3, 22, 13, 55, 773, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 22, 13, 55, 773, DateTimeKind.Local).AddTicks(455), new DateTime(2023, 1, 3, 22, 13, 55, 773, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 22, 13, 55, 773, DateTimeKind.Local).AddTicks(459), new DateTime(2023, 1, 3, 22, 13, 55, 773, DateTimeKind.Local).AddTicks(460) });
        }
    }
}
