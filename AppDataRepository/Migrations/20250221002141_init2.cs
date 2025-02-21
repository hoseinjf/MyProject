using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppDataRepository.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Customer", "CUSTOMER" },
                    { 3, null, "Expert", "EXPERT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountCode", "AccountNumber", "Address", "Balance", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "PhotoId", "ProvinceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, null, null, 0.0, "f11a9bb1-fbb0-445d-b281-af035ebbfac3", "Admin@gmail.com", false, null, null, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEH1AHQpheg88CfGTmxa9GH/y3YA9k8fbZs78es+uyUHoqJ1hJEK7Alr+Wyddt7XgCw==", "09121111111", null, false, 1, 1, "fe8134df-0202-45b5-9265-49240c7a1550", false, null },
                    { 2, 0, null, null, null, 0.0, "745119f2-ade7-4056-b0c2-d185a462f602", "expert@gmail.com", false, null, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEAg82t8DESQBKUABx7o5CTilm++d62brOxsozQcH+HCVSeqayx6eNTBBQOHdObS+8A==", "09121111112", null, false, 2, 2, "7db83336-dbc9-4a49-9a4d-e51c567127da", false, null },
                    { 3, 0, null, null, null, 0.0, "0645c710-4b94-474f-adf5-4910617060ef", "expert@gmail.com", false, null, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEHhhdwh1kPtScO1F3hZWkpQ3I4uNQQiREvi+Q5m3NfWuTGY9awLMJFgtP186rfEgtg==", "09121111112", null, false, 3, 3, "576fdf09-ad2c-4854-a157-468f2a259208", false, null },
                    { 4, 0, null, null, null, 0.0, "53a00731-0a4f-42bd-acce-8dfd4ada9c47", "expert@gmail.com", false, null, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEPyfSZQ5xX5sPV71I8RQrEjl87Yd6IVkG8uHYTyH0Qv6DWaETXi8MT+sb7nZY2RBlQ==", "09121111112", null, false, 4, 4, "b222e75e-04f1-4a84-b21f-dfa3d26c39d2", false, null },
                    { 5, 0, null, null, null, 0.0, "4bdb7caa-e399-4c7f-b711-c88b009b97c7", "customer@gmail.com", false, null, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEGQmkYU5TwoHvu++XB9sTr6+R6Yg8XuEtlAp0h4JeXGBq7hw8lQn/V3aYz1UNEq/6g==", "09121111112", null, false, 5, 5, "acd71094-03e1-471c-b7a0-5eb7c109e835", false, null },
                    { 6, 0, null, null, null, 0.0, "81f64289-01d3-41a4-9a81-42008952298a", "customer@gmail.com", false, null, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEB4Ehyb/KrGbNUR0pXQD4phDfUlTX+ULlN7qHqvgHHazyqCCmz7B8Zg425k+sZtVzQ==", "09121111112", null, false, 6, 6, "e721a8dc-c886-413f-80f7-acef03f673d0", false, null },
                    { 7, 0, null, null, null, 0.0, "43be1897-1038-43c1-96d4-065de91c5415", "customer@gmail.com", false, null, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEEmLJRvQf5uw0GMs04vZCxZoAdRIXv0V/x6rcQaP4QXsH/XBaX5GeXzRKELXGWo+Jw==", "09121111112", null, false, 7, 7, "5845a6e3-f73f-4873-974b-7a3d6a37b682", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1154), new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1158), new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1159), new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1160), new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1161), new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1163), new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1164), new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1165), new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1167), new DateTime(2025, 2, 21, 0, 21, 39, 919, DateTimeKind.Utc).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8426), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8430), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8431), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8433), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8441), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8443), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8444), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8445), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8469), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8471), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8472), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8474), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8475), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8476), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8478), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8479), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8480), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8482), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8483), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8485), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8486), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8488), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8489), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8491), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8492), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8493), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8495), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8496), new DateTime(2025, 2, 21, 0, 21, 39, 920, DateTimeKind.Utc).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1222), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1227), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1229), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1230), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1232), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1234), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1235), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1237), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1239), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1240), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1242), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1244), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1245), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1247), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1249), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1250), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1252), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1254), new DateTime(2025, 2, 21, 0, 21, 39, 921, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 3 },
                    { 3, 7 }
                });

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "Biography", "Score", "UserId" },
                values: new object[,]
                {
                    { 1, "asd", 0, 2 },
                    { 2, "ased", 0, 3 },
                    { 3, "asdsd", 0, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(212), new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(216), new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(217), new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(218), new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(220), new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(221), new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(223), new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(224), new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(225), new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4338), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4341), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4343), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4344), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4346), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4347), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4349), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4350), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4352), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4353), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4355), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4356), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4358), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4359), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4360), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4362), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4363), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4364), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4366), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4367), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4368), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4370), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4371), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4373), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4374), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4375), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4377), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4378), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6447), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6454), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6456), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6458), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6461), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6462), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6464), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6466), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6467), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6469), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6471), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6473), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6474), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6476), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6480), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6481), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6525), new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6525) });
        }
    }
}
