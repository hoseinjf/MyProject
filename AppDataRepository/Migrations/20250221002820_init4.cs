using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppDataRepository.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ExpertsRequests",
                columns: new[] { "Id", "CreateAt", "CustomersRequestId", "DateWork", "Description", "ExpertId", "IsDelete", "Price", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5249), 1, new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5253), "Description", 1, false, 1000.0, new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5254) },
                    { 2, new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5257), 2, new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5257), "Description", 2, false, 1000.0, new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5258) },
                    { 3, new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5259), 3, new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5260), "Description", 3, false, 1000.0, new DateTime(2025, 2, 21, 3, 58, 18, 801, DateTimeKind.Local).AddTicks(5260) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4204), new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4219), new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4222), new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4222), new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4224), new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4225), new DateTime(2025, 2, 21, 3, 57, 13, 729, DateTimeKind.Local).AddTicks(4230) });

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
    }
}
