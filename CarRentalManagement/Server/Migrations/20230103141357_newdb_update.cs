using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newdb_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "f6c2a319-bff5-4337-8f31-3a068770de3e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "1d148f34-0292-4318-82f7-ebf1ac143d56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c6dcfcb-4cf8-4254-a9b4-56c5f4a9169b", "AQAAAAEAACcQAAAAEJHCPZXZVwKxgQy9kP18C8tDmDofD22Nc5PJiPvo50lSW47Z0IwiRggpV5RNx9EUAA==", "8ca897b4-8937-4af6-a144-a06ef5a77f40" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 16, 34, 51, 552, DateTimeKind.Local).AddTicks(4367), new DateTime(2023, 1, 3, 16, 34, 51, 555, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 16, 34, 51, 555, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 1, 3, 16, 34, 51, 555, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 16, 34, 51, 560, DateTimeKind.Local).AddTicks(639), new DateTime(2023, 1, 3, 16, 34, 51, 560, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 16, 34, 51, 560, DateTimeKind.Local).AddTicks(714), new DateTime(2023, 1, 3, 16, 34, 51, 560, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 16, 34, 51, 561, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 1, 3, 16, 34, 51, 561, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 16, 34, 51, 561, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 1, 3, 16, 34, 51, 561, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 16, 34, 51, 561, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 1, 3, 16, 34, 51, 561, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 16, 34, 51, 561, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 1, 3, 16, 34, 51, 561, DateTimeKind.Local).AddTicks(8852) });
        }
    }
}
