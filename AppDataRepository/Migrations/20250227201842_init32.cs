using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDataRepository.Migrations
{
    /// <inheritdoc />
    public partial class init32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2cf4ac8-276d-4e1c-9833-0ccd93d94f79", "AQAAAAIAAYagAAAAEKwfr7ALCXc9DvZBLD7Nwk8J32TD4cmla7jwcfiurVQzuFhNjPYc6GqyiZct5wQblw==", "7613295f-6850-460d-8ce8-62802a3f1274" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b69eeea-56fc-4f53-a7e6-8eadce0e3b53", "AQAAAAIAAYagAAAAEIqDHPXTZA3KZfbjaQbB+3IdVhijzVw9Dw/74BteAPK9gwjC9Tx4Ik5m52sbHHp0GQ==", "c5bd7c30-2ea1-4a56-a74f-f6bda3bd99c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19b21084-43b5-4675-867f-38c9a6464659", "AQAAAAIAAYagAAAAELHOwtoNnjty3nKIU1AQy6uOD+oJjmK9YHrJ3m1yyEe7qVO0SinaOfQzy88smhxpBQ==", "a8d34ea0-019b-4b58-b05d-dd39e304e903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49692897-e032-412a-a639-d131605c4d7c", "AQAAAAIAAYagAAAAEN2KjOZwfEfoWsZQlnqE8+yV8Rdb/mNIpuQCCFQOq2sr0O3/QYZNoUUQgBrZLIviCg==", "77d6b4d8-ccc7-4fb2-ba8d-986f0b045596" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "affda5b1-c6dc-4805-a7c7-eba94fde8e60", "AQAAAAIAAYagAAAAEJc77uH+Bv5Z88XgcJ2KT5HpteF26SyxQrPh/ko+v361p6eneAsiqRpDPHsYmrA2eg==", "107c99f3-ff3d-473d-b3d4-bb50ab9ba0d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8c64fc2-8d38-45e4-adb5-4b6306952bdf", "AQAAAAIAAYagAAAAEMaOVkyF/k88G3QfYaJD7qk3jOqmWd9HEvuS4APSpY21oZkKH/9dwkESydlJ9kUQrg==", "9354e168-af52-4cc2-bfef-ac1c24d5b781" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72047964-bb1c-4947-98fa-cbd1e8cf7a55", "AQAAAAIAAYagAAAAEOUpfxyfcc0UD7xaQvpmqBmWL7xMNdd67jlWBuFYrfV8Fwf+46kCcoPlGvC27AdqNQ==", "4e622001-b197-4be2-8484-6e54186e99e9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4988), new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4995), new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4996), new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4997), new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4999), new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(5000), new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(5001), new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(5003), new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(5004), new DateTime(2025, 2, 27, 20, 18, 40, 672, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(2082), new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(2100), new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(2102), new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(5812), new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(5817), new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(5824), new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(5825), new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(5827), new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(5828), new DateTime(2025, 2, 27, 23, 48, 40, 673, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 48, 40, 674, DateTimeKind.Local).AddTicks(512), new DateTime(2025, 2, 27, 23, 48, 40, 674, DateTimeKind.Local).AddTicks(517), new DateTime(2025, 2, 27, 23, 48, 40, 674, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 48, 40, 674, DateTimeKind.Local).AddTicks(520), new DateTime(2025, 2, 27, 23, 48, 40, 674, DateTimeKind.Local).AddTicks(521), new DateTime(2025, 2, 27, 23, 48, 40, 674, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 48, 40, 674, DateTimeKind.Local).AddTicks(523), new DateTime(2025, 2, 27, 23, 48, 40, 674, DateTimeKind.Local).AddTicks(524), new DateTime(2025, 2, 27, 23, 48, 40, 674, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2884), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2888), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2889), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2891), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2892), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2893), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2895), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2896), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2898), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2899), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2901), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2902), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2904), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2905), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2906), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2908), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2909), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2910), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2912), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2913), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2914), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2916), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2917), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2918), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2920), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2921), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2923), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2924), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5369), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5373), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5375), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5377), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5379), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5380), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5382), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5383), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5385), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5387), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5388), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5390), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5392), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5393), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5395), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5397), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5427), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5429), new DateTime(2025, 2, 27, 20, 18, 40, 674, DateTimeKind.Utc).AddTicks(5429) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bee1d8d-58cc-4f5c-81c1-f5af9180622d", "AQAAAAIAAYagAAAAENlXGwKUBtTRTJgbQ21zRrWZtCkDfOxfO55sObCdoV1hmyEymjegYRBJsFhaGAWeCg==", "ae5b9f8f-8470-47a3-8f49-313e35d0c364" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7968be2-6203-4767-a317-1bad1e046a2c", "AQAAAAIAAYagAAAAEKO+DMtllsgHDhyLGEfY5YOxyUqSK2hTOO0m7zLF3Su5UiRgWSoiRjkIZU5Jdw437w==", "264d1d01-017e-4d1d-b2c4-3cd47ded6676" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3cdab0c-22b8-4307-bd8d-6fecb56e704a", "AQAAAAIAAYagAAAAEPz1EFWPm6vErWgJFj1x014/GEcoBrU/vOjrgK8xiE/dk97Bd/IGTyvsftGHIdyuWQ==", "85c49356-6a5f-4256-8594-a682362c1c40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cacdedf-ce93-4203-a369-cf23a8db5438", "AQAAAAIAAYagAAAAEDd4A78pJaAXfLW1HZryylvyT4c9i+tFqqeUbUWsYKSwzxy5I0t3KfrgzNe/PRzmKA==", "0e145b4d-c4b1-4522-aec7-2186397c8441" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39c1151b-6bc0-454b-8c97-5106688fa298", "AQAAAAIAAYagAAAAEMHS4e20I7OltNnWeA9s8N+6aONtIZUxKlwT90XfR1uBlzzUyu7sBjeLco6sBLtkUw==", "b5259966-5632-465b-93e5-1a987183631b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75eedbd0-399e-4aea-8c5e-e41369a46795", "AQAAAAIAAYagAAAAELqQeMg32JdHmYqCNIgrTMl8vnOE0+L+4iTFootgzIXp5MjQdxi1nopXtKEvqJQH5Q==", "bcad91d2-93b4-4483-b3ad-00953e026088" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78006326-ae0d-4e91-8ef6-84ab35ebd7e0", "AQAAAAIAAYagAAAAENZOkerEKBcX2AaJzMyJ4e3geg3SU3A/yzSRCgRj8rfqpAvv6NpbcHdODoyxPehoFg==", "9903d223-e908-46a2-a59b-6e624837bd64" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1296), new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1301), new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1303), new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1304), new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1306), new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1308), new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1309), new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1311), new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1312), new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8342), new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8356), new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8359), new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2894), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2898), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2908), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2909), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "CustomersRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2912), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2912), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7623), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7627), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7632), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7633), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "ExpertsRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DateWork", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7636), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7636), new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(890), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(894), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(896), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(937), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(939), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(941), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(943), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(944), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(946), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(948), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(949), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(951), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(953), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(954), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(956), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(957), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(959), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(961), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(962), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(964), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(966), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(967), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(969), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(970), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(972), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(974), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(975), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(977), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3475), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3482), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3484), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3486), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3488), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3490), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3492), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3496), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3498), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3500), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3502), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3504), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3505), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3509), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3511), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3513), new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3514) });
        }
    }
}
