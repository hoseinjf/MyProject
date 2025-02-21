using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppDataRepository.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f1b7574-d0c6-4d0a-97e0-61f5823cf107", "AQAAAAIAAYagAAAAENGqqy1g4yamlORIeeOew9akZ9TR62PEqnYrAQ8GadBGNGu4YTeSXfqXVWYld34uzQ==", "21adccce-8f1e-4be4-b624-d3ff824b19c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bad0a422-1677-4610-9c8f-396d0b394303", "AQAAAAIAAYagAAAAEDA7vevYEQfN/AL2cKlmd4YpnsFycJIs6OtSe9/poiqgvtREYUbI6A3G9A1SrZrNaQ==", "d939a626-d6d4-42fb-82d1-9cfd6fc13295" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9686e79-6649-4d0b-b76f-3859c65ecab4", "AQAAAAIAAYagAAAAEJutUCOIEjFkEZGdWJP2+QKfYTCi6ZJ5zpt9MxSWFj3iWVo07wsqeazce9tDgszSFw==", "ea75dd5e-f528-443b-99ff-ac4ec17dc359" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5205283c-e65c-4f4f-a28c-79dbe7bbbcf3", "AQAAAAIAAYagAAAAEDiS8vpFMOEnpY4JeJGLY6NTtnYjwu6+qub6T1hi9xzB5vkwwAzUEWe266DFDCCq1Q==", "a5af52b7-a4ae-41fd-8d2f-7cd7e451acd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb2bb722-0b3a-4b6c-85a7-5b47f6f3da79", "AQAAAAIAAYagAAAAEC+wdWYU5VeCZ5ZgJcnQ7L4tv4xOY5nLs1GU9PJ5+VzbOcRSkL2hCEWNem9SjnnwYA==", "e53307bf-e9cc-43f7-9d4f-f71596e88197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a74af51-cf8a-452c-93e2-cb88571b2d3a", "AQAAAAIAAYagAAAAEDjDlNcnzR/S2B2gF7q/cL/D+EP5KA9MdrY/9UVHW3kL77kEaSc43oZsfRhCO3x98w==", "65010b2f-2ffb-4a9b-819d-6fc4a69d5f7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e20ef451-f6cb-4e9b-a33a-a60f6fbf7104", "AQAAAAIAAYagAAAAEAse+PXfgwo0bZmGLsUFyQ6Xh5+Alz8SZItJpYV+cVEM4JFlZVV8eObbEUax4jQlxA==", "e5684ce1-1ec5-413a-a7c5-aa43195f563c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3785), new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3790), new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3792), new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3793), new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3794), new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3795), new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3797), new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3798), new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3799), new DateTime(2025, 2, 21, 0, 27, 13, 728, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.InsertData(
                table: "CustomersRequests",
                columns: new[] { "Id", "CreateAt", "CustomerId", "DateWork", "Description", "IsDelete", "Status", "UpdateAt", "WorkId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4204), 1, new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4219), "Description", false, 3, new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4220), 1 },
                    { 2, new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4222), 2, new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4222), "Description", false, 4, new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4223), 2 },
                    { 3, new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4224), 3, new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4225), "Description", false, 1, new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4230), 3 }
                });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1083), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1087), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1120), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1122), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1123), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1125), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1126), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1127), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1129), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1130), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1131), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1133), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1134), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1135), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1137), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1138), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1140), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1141), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1143), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1144), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1145), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1147), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1149), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1151), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1152), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1153), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1155), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3543), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3548), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3550), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3552), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3554), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3555), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3557), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3559), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3560), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3562), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3564), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3565), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3567), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3569), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3570), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3572), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3575), new DateTime(2025, 2, 21, 0, 27, 13, 730, DateTimeKind.Utc).AddTicks(3575) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f11a9bb1-fbb0-445d-b281-af035ebbfac3", "AQAAAAIAAYagAAAAEH1AHQpheg88CfGTmxa9GH/y3YA9k8fbZs78es+uyUHoqJ1hJEK7Alr+Wyddt7XgCw==", "fe8134df-0202-45b5-9265-49240c7a1550" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "745119f2-ade7-4056-b0c2-d185a462f602", "AQAAAAIAAYagAAAAEAg82t8DESQBKUABx7o5CTilm++d62brOxsozQcH+HCVSeqayx6eNTBBQOHdObS+8A==", "7db83336-dbc9-4a49-9a4d-e51c567127da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0645c710-4b94-474f-adf5-4910617060ef", "AQAAAAIAAYagAAAAEHhhdwh1kPtScO1F3hZWkpQ3I4uNQQiREvi+Q5m3NfWuTGY9awLMJFgtP186rfEgtg==", "576fdf09-ad2c-4854-a157-468f2a259208" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53a00731-0a4f-42bd-acce-8dfd4ada9c47", "AQAAAAIAAYagAAAAEPyfSZQ5xX5sPV71I8RQrEjl87Yd6IVkG8uHYTyH0Qv6DWaETXi8MT+sb7nZY2RBlQ==", "b222e75e-04f1-4a84-b21f-dfa3d26c39d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bdb7caa-e399-4c7f-b711-c88b009b97c7", "AQAAAAIAAYagAAAAEGQmkYU5TwoHvu++XB9sTr6+R6Yg8XuEtlAp0h4JeXGBq7hw8lQn/V3aYz1UNEq/6g==", "acd71094-03e1-471c-b7a0-5eb7c109e835" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81f64289-01d3-41a4-9a81-42008952298a", "AQAAAAIAAYagAAAAEB4Ehyb/KrGbNUR0pXQD4phDfUlTX+ULlN7qHqvgHHazyqCCmz7B8Zg425k+sZtVzQ==", "e721a8dc-c886-413f-80f7-acef03f673d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43be1897-1038-43c1-96d4-065de91c5415", "AQAAAAIAAYagAAAAEEmLJRvQf5uw0GMs04vZCxZoAdRIXv0V/x6rcQaP4QXsH/XBaX5GeXzRKELXGWo+Jw==", "5845a6e3-f73f-4873-974b-7a3d6a37b682" });

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
        }
    }
}
