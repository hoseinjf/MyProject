using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppDataRepository.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experts_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Viwe = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorePrice = table.Column<double>(type: "float", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    WorkScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersRequests_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersRequests_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpertWork",
                columns: table => new
                {
                    ExpertsId = table.Column<int>(type: "int", nullable: false),
                    WorksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertWork", x => new { x.ExpertsId, x.WorksId });
                    table.ForeignKey(
                        name: "FK_ExpertWork_Experts_ExpertsId",
                        column: x => x.ExpertsId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertWork_Works_WorksId",
                        column: x => x.WorksId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpertsRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersRequestId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertsRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpertsRequests_CustomersRequests_CustomersRequestId",
                        column: x => x.CustomersRequestId,
                        principalTable: "CustomersRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertsRequests_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AccountCode", "AccountNumber", "Address", "Balance", "Email", "FirstName", "LastName", "Password", "Photo", "ProvinceId" },
                values: new object[] { 1, null, null, null, null, "admin@admin.com", null, null, "admin", null, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsDelete", "Photo", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(388), false, "", "دکوراسیون ساختمان", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(391) },
                    { 2, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(393), false, "", "تاسیسات ساختمان", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(393) },
                    { 3, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(394), false, "", "وسیله نقلیه", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(395) },
                    { 4, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(396), false, "", "اسبابکشی و باربری", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(396) },
                    { 5, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(397), false, "", "لوازم خانگی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(398) },
                    { 6, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(399), false, "", "خدمات اداری", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(399) },
                    { 7, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(400), false, "", "نظافت و بهداشت", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(400) },
                    { 8, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(401), false, "", "دیجیتال و نرم افزار", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(402) },
                    { 9, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(403), false, "", "پزشکی و سلامت", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(403) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountCode", "AccountNumber", "Address", "Balance", "Email", "FirstName", "LastName", "Password", "Phone", "Photo", "ProvinceId" },
                values: new object[] { 1, null, null, null, 0.0, "ali@ali.com", null, null, "ali", null, null, null });

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "AccountCode", "AccountNumber", "Address", "Balance", "Biography", "Email", "FirstName", "LastName", "Password", "Phone", "Photo", "ProvinceId", "Score" },
                values: new object[] { 1, null, null, null, 0.0, null, "hasn@hasan.com", null, null, "hasan", null, null, null, null });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "آذربایجان شرقی" },
                    { 2, "آذربایجان غربی" },
                    { 3, "اردبیل" },
                    { 4, "اصفهان" },
                    { 5, "البرز" },
                    { 6, "ایلام" },
                    { 7, "بوشهر" },
                    { 8, "تهران" },
                    { 9, "چهارمحال و بختیاری" },
                    { 10, "خراسان جنوبی" },
                    { 11, "خراسان رضوی" },
                    { 12, "خراسان شمالی" },
                    { 13, "خوزستان" },
                    { 14, "زنجان" },
                    { 15, "سمنان" },
                    { 16, "سیستان و بلوچستان" },
                    { 17, "فارس" },
                    { 18, "قزوین" },
                    { 19, "قم" },
                    { 20, "کردستان" },
                    { 21, "کرمان" },
                    { 22, "کرمانشاه" },
                    { 23, "کهگیلویه و بویراحمد" },
                    { 24, "گلستان" },
                    { 25, "گیلان" },
                    { 26, "لرستان" },
                    { 27, "مازندران" },
                    { 28, "مرکزی" },
                    { 29, "هرمزگان" },
                    { 30, "همدان" },
                    { 31, "یزد" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateAt", "IsDelete", "Photo", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(432), false, "", "بنایی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(432) },
                    { 2, 1, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(434), false, "", "دکوراسیون", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(435) },
                    { 3, 1, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(436), false, "", "نقاشی ساختمان", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(436) },
                    { 4, 1, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(437), false, "", "درب و پنجره", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(438) },
                    { 5, 1, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(439), false, "", "آهنگری و جوشکاری", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(439) },
                    { 6, 1, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(440), false, "", "باغبانی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(440) },
                    { 7, 2, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(441), false, "", "سرمایش و گرمایش", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(442) },
                    { 8, 2, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(443), false, "", "لوله کشی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(443) },
                    { 9, 2, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(444), false, "", "برقو الکترونیک", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(445) },
                    { 10, 2, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(446), false, "", "تلفن و سانترال", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(446) },
                    { 11, 3, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(447), false, "", "خودرو", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(447) },
                    { 12, 4, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(448), false, "", "اسبابکشی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(449) },
                    { 13, 4, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(450), false, "", "حمل بار", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(450) },
                    { 14, 5, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(451), false, "", "لوازم آشپزخانه", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(452) },
                    { 15, 5, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(453), false, "", "لوازم شست و شو", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(453) },
                    { 16, 5, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(454), false, "", "لوازم صوتی و تصویری", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(454) },
                    { 17, 6, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(455), false, "", "ماشین آلات اداری", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(456) },
                    { 18, 6, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(457), false, "", "مبلمان اداری", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(457) },
                    { 19, 7, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(458), false, "", "نظافت", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(458) },
                    { 20, 7, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(459), false, "", "خشک شویی و اتوشویی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(460) },
                    { 21, 7, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(461), false, "", "قالی شویی و مبل شویی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(461) },
                    { 22, 7, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(462), false, "", "سمپاشی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(462) },
                    { 23, 8, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(463), false, "", "موبایل و تبلت", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(464) },
                    { 24, 8, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(465), false, "", "خدمات کامپیوتری", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(465) },
                    { 25, 8, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(466), false, "", "امنیت و شبکه", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(467) },
                    { 26, 9, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(468), false, "", "معاینه پزشک", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(468) },
                    { 27, 9, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(469), false, "", "داروخانه", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(469) },
                    { 28, 9, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(470), false, "", "مشاوره", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(471) }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "CorePrice", "CreateAt", "Description", "IsDelete", "Photo", "SubCategoryId", "Title", "UpdateAt", "Viwe" },
                values: new object[,]
                {
                    { 1, 500.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(539), "انجام انواع امور پی ریزی", false, "", 1, "پی ریزی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(540), 0 },
                    { 2, 1000.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(544), "انجام انواع امور بلوک گذاری و دیوار چینی", false, "", 1, "بلوک گذاری و دیوار چینی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(544), 0 },
                    { 3, 600.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(545), "انجام انواع امور مرتبط با کف ساختمان", false, "", 1, "کف ساختمان", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(546), 0 },
                    { 4, 6000.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(547), "انجام انواع امور نوسازی ساختمان های قدیمی یا نیازمند تغییر", false, "", 1, "نوسازی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(547), 0 },
                    { 5, 500.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(548), "انجام انواع امور سیمان کاری", false, "", 1, "سیمان کاری", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(549), 0 },
                    { 6, 500.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(550), "انجام انواع امور دکور آشپزخانه", false, "", 2, "دکور آشپزخانه", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(550), 0 },
                    { 7, 580.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(552), "انجام انواع امور دکور حال و پذیرایی", false, "", 2, "دکور حال و پذیرایی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(552), 0 },
                    { 8, 400.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(553), "انجام انواع امور دکور اتاق خواب", false, "", 2, "دکور اتاق خواب", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(554), 0 },
                    { 9, 800.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(555), "انجام انواع امور طراحی و دیزاین ساختمان", false, "", 2, "طراحی و دیزاین ساختمان", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(555), 0 },
                    { 10, 1500.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(557), "انجام انواع امور معماری داخلی", false, "", 2, "معماری داخلی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(557), 0 },
                    { 11, 800.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(558), "انجام انواع امور نقاشی داخل ساختمان", false, "", 3, "نقاشی داخل ساختمان", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(559), 0 },
                    { 12, 300.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(560), "انجام انواع امور نقاشی خارج ساختمان", false, "", 3, "نقاشی خارج ساختمان", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(560), 0 },
                    { 13, 200.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(561), "انجام انواع امور تعمیرات درب و پنجره", false, "", 4, "تعمیرات درب و پنجره", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(562), 0 },
                    { 14, 800.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(563), "انجام انواع امور سفارش درب و پنجرهن", false, "", 4, "سفارش درب و پنجره", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(564), 0 },
                    { 15, 800.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(565), "انجام انواع امور آهنگری و جوشکاری لوازم و غیره", false, "", 5, "آهنگری و جوشکاری لوازم و غیره", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(565), 0 },
                    { 16, 800.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(566), "انجام انواع امور آهنگری و جوشکاری ساختمانی", false, "", 5, "آهنگری و جوشکاری ساختمانی", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(567), 0 },
                    { 17, 500.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(568), "انجام انواع امور باغبانی ساختمان ها ومجتمع ها", false, "", 6, "باغبانی ساختمان ها ومجتمع ها ", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(568), 0 },
                    { 18, 800.0, new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(570), "انجام انواع امور باغبانی فضای شهری و سازمان ها", false, "", 6, "باغبانی فضای شهری و سازمان ها", new DateTime(2025, 2, 13, 14, 21, 4, 569, DateTimeKind.Utc).AddTicks(570), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ProvinceId",
                table: "Admins",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomersId",
                table: "Comments",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ExpertId",
                table: "Comments",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProvinceId",
                table: "Customers",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersRequests_CustomerId",
                table: "CustomersRequests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersRequests_WorkId",
                table: "CustomersRequests",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Experts_ProvinceId",
                table: "Experts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertsRequests_CustomersRequestId",
                table: "ExpertsRequests",
                column: "CustomersRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertsRequests_ExpertId",
                table: "ExpertsRequests",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertWork_WorksId",
                table: "ExpertWork",
                column: "WorksId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProvinceId",
                table: "Users",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_SubCategoryId",
                table: "Works",
                column: "SubCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ExpertsRequests");

            migrationBuilder.DropTable(
                name: "ExpertWork");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CustomersRequests");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
