using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newDBupdateCustoemr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "0710ae52-e58f-475a-8cc3-08b37c123171");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "41f78238-e284-4111-8216-78846ddf8ea8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ef05eb-7327-4e07-b9dc-64d7cf7b1b66", "AQAAAAEAACcQAAAAELEE58I4Q62hEYvoXP+UWz+wftTMJvLV5jCK+k7/PovI+BysOFSr7+jBKv8sCpAfiA==", "2a5a3050-92f7-403b-b7d3-f87423e867ea" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 39, 18, 776, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 1, 9, 16, 39, 18, 777, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 39, 18, 777, DateTimeKind.Local).AddTicks(6903), new DateTime(2023, 1, 9, 16, 39, 18, 777, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 39, 18, 779, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 1, 9, 16, 39, 18, 779, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 39, 18, 779, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 1, 9, 16, 39, 18, 779, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 39, 18, 780, DateTimeKind.Local).AddTicks(1380), new DateTime(2023, 1, 9, 16, 39, 18, 780, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 39, 18, 780, DateTimeKind.Local).AddTicks(1395), new DateTime(2023, 1, 9, 16, 39, 18, 780, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 39, 18, 780, DateTimeKind.Local).AddTicks(1399), new DateTime(2023, 1, 9, 16, 39, 18, 780, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 39, 18, 780, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 1, 9, 16, 39, 18, 780, DateTimeKind.Local).AddTicks(1404) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
