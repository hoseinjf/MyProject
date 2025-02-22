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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    PhotoId = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoId = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomersRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Src = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_CustomersRequests_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomersRequests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_SubCategories_Photo_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoId = table.Column<int>(type: "int", nullable: true),
                    Viwe = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Works_Photo_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Works_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
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
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsDelete", "PhotoId", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1296), false, null, "دکوراسیون ساختمان", new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1299) },
                    { 2, new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1301), false, null, "تاسیسات ساختمان", new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1301) },
                    { 3, new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1303), false, null, "وسیله نقلیه", new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1303) },
                    { 4, new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1304), false, null, "اسبابکشی و باربری", new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1305) },
                    { 5, new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1306), false, null, "لوازم خانگی", new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1306) },
                    { 6, new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1308), false, null, "خدمات اداری", new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1308) },
                    { 7, new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1309), false, null, "نظافت و بهداشت", new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1310) },
                    { 8, new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1311), false, null, "دیجیتال و نرم افزار", new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1311) },
                    { 9, new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1312), false, null, "پزشکی و سلامت", new DateTime(2025, 2, 22, 7, 21, 57, 478, DateTimeKind.Utc).AddTicks(1313) }
                });

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "Id", "CustomerId", "Src" },
                values: new object[,]
                {
                    { 1, null, "ss" },
                    { 2, null, "sqs" },
                    { 3, null, "ee" },
                    { 4, null, "rr" },
                    { 5, null, "tt" },
                    { 6, null, "yy" },
                    { 7, null, "uu" }
                });

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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountCode", "AccountNumber", "Address", "Balance", "ConcurrencyStamp", "CreateAt", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "PhotoId", "ProvinceId", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, null, null, 0.0, "0bee1d8d-58cc-4f5c-81c1-f5af9180622d", null, "Admin@gmail.com", false, null, false, null, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAENlXGwKUBtTRTJgbQ21zRrWZtCkDfOxfO55sObCdoV1hmyEymjegYRBJsFhaGAWeCg==", "09121111111", null, false, 1, 1, "ae5b9f8f-8470-47a3-8f49-313e35d0c364", false, null, null },
                    { 2, 0, null, null, null, 0.0, "e7968be2-6203-4767-a317-1bad1e046a2c", null, "expert@gmail.com", false, null, false, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEKO+DMtllsgHDhyLGEfY5YOxyUqSK2hTOO0m7zLF3Su5UiRgWSoiRjkIZU5Jdw437w==", "09121111112", null, false, 2, 2, "264d1d01-017e-4d1d-b2c4-3cd47ded6676", false, null, null },
                    { 3, 0, null, null, null, 0.0, "c3cdab0c-22b8-4307-bd8d-6fecb56e704a", null, "expert@gmail.com", false, null, false, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEPz1EFWPm6vErWgJFj1x014/GEcoBrU/vOjrgK8xiE/dk97Bd/IGTyvsftGHIdyuWQ==", "09121111112", null, false, 3, 3, "85c49356-6a5f-4256-8594-a682362c1c40", false, null, null },
                    { 4, 0, null, null, null, 0.0, "4cacdedf-ce93-4203-a369-cf23a8db5438", null, "expert@gmail.com", false, null, false, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEDd4A78pJaAXfLW1HZryylvyT4c9i+tFqqeUbUWsYKSwzxy5I0t3KfrgzNe/PRzmKA==", "09121111112", null, false, 4, 4, "0e145b4d-c4b1-4522-aec7-2186397c8441", false, null, null },
                    { 5, 0, null, null, null, 0.0, "39c1151b-6bc0-454b-8c97-5106688fa298", null, "customer@gmail.com", false, null, false, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEMHS4e20I7OltNnWeA9s8N+6aONtIZUxKlwT90XfR1uBlzzUyu7sBjeLco6sBLtkUw==", "09121111112", null, false, 5, 5, "b5259966-5632-465b-93e5-1a987183631b", false, null, null },
                    { 6, 0, null, null, null, 0.0, "75eedbd0-399e-4aea-8c5e-e41369a46795", null, "customer@gmail.com", false, null, false, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAELqQeMg32JdHmYqCNIgrTMl8vnOE0+L+4iTFootgzIXp5MjQdxi1nopXtKEvqJQH5Q==", "09121111112", null, false, 6, 6, "bcad91d2-93b4-4483-b3ad-00953e026088", false, null, null },
                    { 7, 0, null, null, null, 0.0, "78006326-ae0d-4e91-8ef6-84ab35ebd7e0", null, "customer@gmail.com", false, null, false, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAENZOkerEKBcX2AaJzMyJ4e3geg3SU3A/yzSRCgRj8rfqpAvv6NpbcHdODoyxPehoFg==", "09121111112", null, false, 7, 7, "9903d223-e908-46a2-a59b-6e624837bd64", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateAt", "IsDelete", "PhotoId", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(890), false, null, "بنایی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(892) },
                    { 2, 1, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(894), false, null, "دکوراسیون", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(895) },
                    { 3, 1, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(896), false, null, "نقاشی ساختمان", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(897) },
                    { 4, 1, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(937), false, null, "درب و پنجره", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(938) },
                    { 5, 1, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(939), false, null, "آهنگری و جوشکاری", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(940) },
                    { 6, 1, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(941), false, null, "باغبانی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(942) },
                    { 7, 2, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(943), false, null, "سرمایش و گرمایش", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(943) },
                    { 8, 2, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(944), false, null, "لوله کشی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(945) },
                    { 9, 2, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(946), false, null, "برقو الکترونیک", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(947) },
                    { 10, 2, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(948), false, null, "تلفن و سانترال", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(948) },
                    { 11, 3, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(949), false, null, "خودرو", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(950) },
                    { 12, 4, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(951), false, null, "اسبابکشی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(952) },
                    { 13, 4, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(953), false, null, "حمل بار", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(953) },
                    { 14, 5, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(954), false, null, "لوازم آشپزخانه", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(955) },
                    { 15, 5, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(956), false, null, "لوازم شست و شو", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(956) },
                    { 16, 5, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(957), false, null, "لوازم صوتی و تصویری", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(958) },
                    { 17, 6, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(959), false, null, "ماشین آلات اداری", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(960) },
                    { 18, 6, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(961), false, null, "مبلمان اداری", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(961) },
                    { 19, 7, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(962), false, null, "نظافت", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(963) },
                    { 20, 7, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(964), false, null, "خشک شویی و اتوشویی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(964) },
                    { 21, 7, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(966), false, null, "قالی شویی و مبل شویی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(966) },
                    { 22, 7, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(967), false, null, "سمپاشی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(968) },
                    { 23, 8, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(969), false, null, "موبایل و تبلت", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(969) },
                    { 24, 8, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(970), false, null, "خدمات کامپیوتری", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(971) },
                    { 25, 8, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(972), false, null, "امنیت و شبکه", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(973) },
                    { 26, 9, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(974), false, null, "معاینه پزشک", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(974) },
                    { 27, 9, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(975), false, null, "داروخانه", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(976) },
                    { 28, 9, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(977), false, null, "مشاوره", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(977) }
                });

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

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "CorePrice", "CreateAt", "Description", "IsDelete", "PhotoId", "SubCategoryId", "Title", "UpdateAt", "Viwe" },
                values: new object[,]
                {
                    { 1, 500.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3475), "انجام انواع امور پی ریزی", false, null, 1, "پی ریزی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3477), null },
                    { 2, 1000.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3482), "انجام انواع امور بلوک گذاری و دیوار چینی", false, null, 1, "بلوک گذاری و دیوار چینی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3482), null },
                    { 3, 600.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3484), "انجام انواع امور مرتبط با کف ساختمان", false, null, 1, "کف ساختمان", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3485), null },
                    { 4, 6000.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3486), "انجام انواع امور نوسازی ساختمان های قدیمی یا نیازمند تغییر", false, null, 1, "نوسازی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3487), null },
                    { 5, 500.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3488), "انجام انواع امور سیمان کاری", false, null, 1, "سیمان کاری", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3488), null },
                    { 6, 500.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3490), "انجام انواع امور دکور آشپزخانه", false, null, 2, "دکور آشپزخانه", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3490), null },
                    { 7, 580.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3492), "انجام انواع امور دکور حال و پذیرایی", false, null, 2, "دکور حال و پذیرایی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3492), null },
                    { 8, 400.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3494), "انجام انواع امور دکور اتاق خواب", false, null, 2, "دکور اتاق خواب", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3494), null },
                    { 9, 800.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3496), "انجام انواع امور طراحی و دیزاین ساختمان", false, null, 2, "طراحی و دیزاین ساختمان", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3496), null },
                    { 10, 1500.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3498), "انجام انواع امور معماری داخلی", false, null, 2, "معماری داخلی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3498), null },
                    { 11, 800.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3500), "انجام انواع امور نقاشی داخل ساختمان", false, null, 3, "نقاشی داخل ساختمان", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3500), null },
                    { 12, 300.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3502), "انجام انواع امور نقاشی خارج ساختمان", false, null, 3, "نقاشی خارج ساختمان", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3502), null },
                    { 13, 200.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3504), "انجام انواع امور تعمیرات درب و پنجره", false, null, 4, "تعمیرات درب و پنجره", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3504), null },
                    { 14, 800.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3505), "انجام انواع امور سفارش درب و پنجرهن", false, null, 4, "سفارش درب و پنجره", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3506), null },
                    { 15, 800.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3507), "انجام انواع امور آهنگری و جوشکاری لوازم و غیره", false, null, 5, "آهنگری و جوشکاری لوازم و غیره", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3508), null },
                    { 16, 800.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3509), "انجام انواع امور آهنگری و جوشکاری ساختمانی", false, null, 5, "آهنگری و جوشکاری ساختمانی", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3510), null },
                    { 17, 500.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3511), "انجام انواع امور باغبانی ساختمان ها ومجتمع ها", false, null, 6, "باغبانی ساختمان ها ومجتمع ها ", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3512), null },
                    { 18, 800.0, new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3513), "انجام انواع امور باغبانی فضای شهری و سازمان ها", false, null, 6, "باغبانی فضای شهری و سازمان ها", new DateTime(2025, 2, 22, 7, 21, 57, 480, DateTimeKind.Utc).AddTicks(3514), null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreateAt", "CustomersId", "Description", "ExpertId", "IsActive", "IsDelete", "Title", "UpdateAt", "WorkScore" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8342), 1, "Description", 1, true, false, "Title", new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8354), 4 },
                    { 2, new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8356), 2, "Description", 2, true, false, "Title", new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8357), 3 },
                    { 3, new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8359), 3, "Description", 3, true, false, "Title", new DateTime(2025, 2, 22, 10, 51, 57, 478, DateTimeKind.Local).AddTicks(8360), 5 }
                });

            migrationBuilder.InsertData(
                table: "CustomersRequests",
                columns: new[] { "Id", "CreateAt", "CustomerId", "DateWork", "Description", "IsDelete", "Status", "UpdateAt", "WorkId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2894), 1, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2898), "Description", false, 3, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2904), 1 },
                    { 2, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2908), 2, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2909), "Description", false, 4, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2910), 2 },
                    { 3, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2912), 3, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2912), "Description", false, 1, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(2913), 3 }
                });

            migrationBuilder.InsertData(
                table: "ExpertsRequests",
                columns: new[] { "Id", "CreateAt", "CustomersRequestId", "DateWork", "Description", "ExpertId", "IsDelete", "Price", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7623), 1, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7627), "Description", 1, false, 1000.0, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7629) },
                    { 2, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7632), 2, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7633), "Description", 2, false, 1000.0, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7634) },
                    { 3, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7636), 3, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7636), "Description", 3, false, 1000.0, new DateTime(2025, 2, 22, 10, 51, 57, 479, DateTimeKind.Local).AddTicks(7637) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhotoId",
                table: "AspNetUsers",
                column: "PhotoId",
                unique: true,
                filter: "[PhotoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProvinceId",
                table: "AspNetUsers",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PhotoId",
                table: "Categories",
                column: "PhotoId",
                unique: true,
                filter: "[PhotoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomersId",
                table: "Comments",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ExpertId",
                table: "Comments",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersRequests_CustomerId",
                table: "CustomersRequests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersRequests_WorkId",
                table: "CustomersRequests",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Experts_UserId",
                table: "Experts",
                column: "UserId",
                unique: true);

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
                name: "IX_Photo_CustomerId",
                table: "Photo",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_PhotoId",
                table: "SubCategories",
                column: "PhotoId",
                unique: true,
                filter: "[PhotoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Works_PhotoId",
                table: "Works",
                column: "PhotoId",
                unique: true,
                filter: "[PhotoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Works_SubCategoryId",
                table: "Works",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_AspNetUsers_UserId",
                table: "Admins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Photo_PhotoId",
                table: "AspNetUsers",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Photo_PhotoId",
                table: "Categories",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersRequests_Works_WorkId",
                table: "CustomersRequests",
                column: "WorkId",
                principalTable: "Works",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Photo_PhotoId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Photo_PhotoId",
                table: "SubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Photo_PhotoId",
                table: "Works");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ExpertsRequests");

            migrationBuilder.DropTable(
                name: "ExpertWork");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "CustomersRequests");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
