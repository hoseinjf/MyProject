using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppDataRepository.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cafb687-3afa-4f48-b547-821179010039", "AQAAAAIAAYagAAAAEJXdRx5DHTJsv8+M64MYsQK5O0NiMX56pHA6I5Yc5u6fs8KapFHKs8SxLKX5Sz/96Q==", "58752422-9d30-4fad-a404-308f42b6ceb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a0db814-d2a1-49d3-bae7-f0fc074dd186", "AQAAAAIAAYagAAAAEN6L3KmM/8mEvS8A4v6N+FbiAwodJbeQfa+Lzuu/+4fQ1rdwmacCs26j6LV1LeRzEQ==", "01ae5ed7-656a-4ed0-a608-4ca64964b2c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cff2f8ac-a3d6-4799-bf95-79129bc481c6", "AQAAAAIAAYagAAAAENo+pJxlXyJRGcEylYiw/sBBtPPl0nT23q3ylh+5sR3/8M074XJMItn8ksNxxl4kUQ==", "80619345-6796-4225-879b-ea0ed637343f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd63eac8-f32d-4a98-bb92-38d9b36864a3", "AQAAAAIAAYagAAAAEN08VjXgF7vfsWWL7DQvnJkTkfztagxTcXZX1wcqb6DypRUGWUqwYWdOx8EeheNfkw==", "7f9ac583-3766-444a-9989-67149dec48ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d0b0959-39d1-460e-bedf-9b564c7a59b4", "AQAAAAIAAYagAAAAEBaZTVEXhj6MSQGbGMCVEANHoQo/99DJHSNTgzYhKsm7PNZa+rVGZcaK+knINVEVrA==", "f8ace04f-9cda-4849-8f2f-5d06285c533f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8dc160d-bde5-4edf-b13f-9dc7e3bc04cd", "AQAAAAIAAYagAAAAEEGSooY/buq87fRvBZhB6xE6YaYLDrrsA47VBe7O2HlyyNuNrB0Ci09mCvCr8ubStg==", "84c2b52d-943a-44a6-a609-03f52f2db76a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a84c9802-8ce6-43e0-93ba-ff5468e3fcc4", "AQAAAAIAAYagAAAAEDel7ZaKl4vrS2PZaZVLGBM6SyJ3yAH2y3LZF477VeheHbZep5tOUMjjacq9YaYvHQ==", "ed765035-24fd-44f0-9ddd-86e6e540d63a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5253), new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5257), new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5259), new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5260), new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5261), new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5263), new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5264), new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5265), new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5266), new DateTime(2025, 2, 21, 0, 29, 45, 83, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreateAt", "CustomersId", "Description", "ExpertId", "IsActive", "IsDelete", "Title", "UpdateAt", "WorkScore" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(2314), 1, "Description", 1, true, false, "Title", new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(2329), 4 },
                    { 2, new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(2330), 2, "Description", 2, true, false, "Title", new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(2331), 3 },
                    { 3, new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(2333), 3, "Description", 3, true, false, "Title", new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(2333), 5 }
                });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(6250), new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(6253), new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(6265), new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(6265), new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(6267), new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(6268), new DateTime(2025, 2, 21, 3, 59, 45, 84, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 59, 45, 85, DateTimeKind.Local).AddTicks(880), new DateTime(2025, 2, 21, 3, 59, 45, 85, DateTimeKind.Local).AddTicks(885), new DateTime(2025, 2, 21, 3, 59, 45, 85, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 59, 45, 85, DateTimeKind.Local).AddTicks(889), new DateTime(2025, 2, 21, 3, 59, 45, 85, DateTimeKind.Local).AddTicks(889), new DateTime(2025, 2, 21, 3, 59, 45, 85, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 59, 45, 85, DateTimeKind.Local).AddTicks(891), new DateTime(2025, 2, 21, 3, 59, 45, 85, DateTimeKind.Local).AddTicks(892), new DateTime(2025, 2, 21, 3, 59, 45, 85, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3332), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3335), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3337), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3338), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3339), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3341), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3342), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3343), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3345), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3346), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3348), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3349), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3350), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3352), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3354), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3356), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3357), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3358), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3407), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3409), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3411), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3412), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3415), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3416), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3417), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3419), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3420), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5880), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5885), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5887), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5930), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5932), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5934), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5935), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5939), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5940), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5942), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5944), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5946), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5947), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5951), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5952), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5954), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5955), new DateTime(2025, 2, 21, 0, 29, 45, 85, DateTimeKind.Utc).AddTicks(5956) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395d1048-488d-44f5-a4ce-470916216422", "AQAAAAIAAYagAAAAEAGwB9pdXBpJgENg9HOXUUP1u0Ldgcy9lf8GSa+6fcBS+q+w/uHQ/BuRhZebfKxavA==", "8e5ee217-f87e-4177-8916-d888c7896fdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dc56973-f093-47a1-9790-b69a699aee96", "AQAAAAIAAYagAAAAECokUPywE5OelsAxyS//EVXt3u0+pSwmyOBedNc0pXOmxDGdMbynx00w+OZNsbm78Q==", "d91f579a-c0a0-42e8-8c08-cdcd3cf982d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c509307b-4e18-4bac-85af-70a09069b25a", "AQAAAAIAAYagAAAAEAtqjQ1sBLIRVIzY8rmDDzArGFtcJLoaPWxViZoecsglHPuU7NeKWm1A9Mz6ryyxRw==", "1de25517-1af8-4b12-a549-5c3de11bd2f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae936dd7-c3e3-4c5e-bec3-4929255207e0", "AQAAAAIAAYagAAAAEG6iPmxhC5F8cvtTVPaipzqg9KYHkubOgifMJttarDVB3c+BAlhIaf3u2ykezkloMA==", "6e241502-5666-4ba7-b108-b164aca6fb97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "313af4a4-26bd-4f53-8683-4a12935518b3", "AQAAAAIAAYagAAAAELCTxvhmQwqDUUUKWDItWMeUUqnHC/3Xd27rRsdOR8VefKyL12sJuZvlXNFnk5G6XA==", "f6bf42c3-b720-4cf3-9166-9b505f1bf3f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "587f22e9-6dc8-4b7e-bf95-c3e12009a774", "AQAAAAIAAYagAAAAEOrfAZJdWFqTc8HgFXxOH9PcqRCeWHzZxKsKjJedjbQPSXSpnV2vVMyNtGkiUvhaTA==", "30f21493-3c1c-475e-a737-a56a4e1a6b3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07b65613-e3ed-4bd1-b08b-46c1d2cdebfa", "AQAAAAIAAYagAAAAEAr6fYPm6csCI4fTqRYeMErB81hFjEBoAVzHMkyFn/kp92AaK6n/ZyvIzZhpRSoJxg==", "52dc20ec-620d-460d-ae44-962ae763569d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(264), new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(269), new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(270), new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(272), new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(273), new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(274), new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(275), new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(277), new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(278), new DateTime(2025, 2, 21, 0, 28, 18, 800, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(770), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(782), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(786), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(787), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(789), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(790), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5249), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5253), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5257), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5257), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5259), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5260), new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7674), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7678), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7681), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7682), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7684), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7685), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7688), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7689), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7692), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7693), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7695), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7697), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7699), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7701), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7703), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7704), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7705), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7708), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7709), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 2, 21, 0, 28, 18, 801, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(93), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(98), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(100), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(102), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(103), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(105), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(107), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(108), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(110), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(141), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(143), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(145), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(146), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(148), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(149), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(151), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(152), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 2, 21, 0, 28, 18, 802, DateTimeKind.Utc).AddTicks(154) });
        }
    }
}
