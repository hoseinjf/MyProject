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
                    { 1, new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1269), false, null, "دکوراسیون ساختمان", new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1271) },
                    { 2, new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1277), false, null, "تاسیسات ساختمان", new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1277) },
                    { 3, new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1278), false, null, "وسیله نقلیه", new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1279) },
                    { 4, new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1280), false, null, "اسبابکشی و باربری", new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1280) },
                    { 5, new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1281), false, null, "لوازم خانگی", new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1282) },
                    { 6, new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1283), false, null, "خدمات اداری", new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1283) },
                    { 7, new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1284), false, null, "نظافت و بهداشت", new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1284) },
                    { 8, new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1285), false, null, "دیجیتال و نرم افزار", new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1285) },
                    { 9, new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1286), false, null, "پزشکی و سلامت", new DateTime(2025, 3, 18, 10, 44, 51, 779, DateTimeKind.Utc).AddTicks(1287) }
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
                    { 1, 0, null, null, null, 0.0, "fba862ca-3609-48b9-9021-0306c0519016", null, "Admin@gmail.com", false, null, false, null, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEJDz09IMe7HjCfIN6n4t+F3jL5YECBJkDJW7braGYGz28zl1Jvr1sZWXvBP6TM6cXg==", "09121111111", null, false, 1, 1, "27bf475f-55c2-4aff-a5ad-0fb9f1ad5cfa", false, null, null },
                    { 2, 0, null, null, null, 0.0, "9213edad-c0b1-41bc-865e-7e1ad7242a9b", null, "expert@gmail.com", false, null, false, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEFH8uCA/85xME+dcL+VSqtVsv5NM3iIdylu2bRVp7UsOKHuIMU86xPiWJhpkM0whFA==", "09121111112", null, false, 2, 2, "fa4d263b-48ff-456c-a126-4878380b50d5", false, null, null },
                    { 3, 0, null, null, null, 0.0, "2b981a29-105f-4e41-91a6-969f20241eee", null, "expert@gmail.com", false, null, false, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEM/nEpnvAUBnhuWtOSv3gO7uXwstYO/i7Ry4H1kOV/xNA0lNa7o+WJ/07kCUwz0bEg==", "09121111112", null, false, 3, 3, "131fe233-1fc6-480e-bf06-c40a54a4421c", false, null, null },
                    { 4, 0, null, null, null, 0.0, "e3550a34-61a8-4bb2-8d57-2818151e129c", null, "expert@gmail.com", false, null, false, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAELS1r3hGKZDxgozN/tP+3PTSKT/Acdt+BFv+NDVy8zF88bRPwIPLeTT/KLtHICUXUg==", "09121111112", null, false, 4, 4, "fc2a272c-47d7-4ed3-9f88-e62a271dbdda", false, null, null },
                    { 5, 0, null, null, null, 0.0, "978d5147-85e9-4d61-8d5f-680bc3bb6cba", null, "customer@gmail.com", false, null, false, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEJAIOhM9WTmOnW3qYvfEiHogseNhliRx78/qr0abY85HwD7euISlp/XPZEOl5Jzi/w==", "09121111112", null, false, 5, 5, "c378d83b-9ae0-49fe-aca9-2799d46ebc8a", false, null, null },
                    { 6, 0, null, null, null, 0.0, "edf251e4-5c3a-4c0a-8faa-957e8e9e59b4", null, "customer@gmail.com", false, null, false, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEBrkPye/tQIpur5VHO8ZtGdds4X3ZtYY2BgIdUFG1tCeU9jitx2StETfYU8dy+pYxg==", "09121111112", null, false, 6, 6, "41e8d5a6-b09c-4d02-955e-e0d7f8ecc888", false, null, null },
                    { 7, 0, null, null, null, 0.0, "42ac76b9-901e-4fbd-8f1e-07553d9a21c8", null, "customer@gmail.com", false, null, false, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEKByspQc0zCpWJpgDdcRF/3Xox1wkSRu6OwmDn4UiqBng/zoQfZfUKe5LlbWvB8wXA==", "09121111112", null, false, 7, 7, "19608c20-d837-4b03-9b79-b5f357360f11", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateAt", "IsDelete", "PhotoId", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9613), false, null, "بنایی", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9615) },
                    { 2, 1, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9617), false, null, "دکوراسیون", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9617) },
                    { 3, 1, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9619), false, null, "نقاشی ساختمان", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9619) },
                    { 4, 1, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9620), false, null, "درب و پنجره", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9621) },
                    { 5, 1, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9623), false, null, "آهنگری و جوشکاری", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9623) },
                    { 6, 1, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9624), false, null, "باغبانی", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9624) },
                    { 7, 2, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9625), false, null, "سرمایش و گرمایش", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9626) },
                    { 8, 2, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9627), false, null, "لوله کشی", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9627) },
                    { 9, 2, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9628), false, null, "برقو الکترونیک", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9628) },
                    { 10, 2, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9629), false, null, "تلفن و سانترال", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9630) },
                    { 11, 3, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9631), false, null, "خودرو", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9631) },
                    { 12, 4, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9632), false, null, "اسبابکشی", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9632) },
                    { 13, 4, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9634), false, null, "حمل بار", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9634) },
                    { 14, 5, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9635), false, null, "لوازم آشپزخانه", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9636) },
                    { 15, 5, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9637), false, null, "لوازم شست و شو", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9637) },
                    { 16, 5, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9638), false, null, "لوازم صوتی و تصویری", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9639) },
                    { 17, 6, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9639), false, null, "ماشین آلات اداری", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9640) },
                    { 18, 6, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9641), false, null, "مبلمان اداری", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9641) },
                    { 19, 7, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9643), false, null, "نظافت", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9643) },
                    { 20, 7, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9644), false, null, "خشک شویی و اتوشویی", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9644) },
                    { 21, 7, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9645), false, null, "قالی شویی و مبل شویی", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9646) },
                    { 22, 7, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9647), false, null, "سمپاشی", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9647) },
                    { 23, 8, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9649), false, null, "موبایل و تبلت", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9649) },
                    { 24, 8, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9650), false, null, "خدمات کامپیوتری", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9651) },
                    { 25, 8, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9653), false, null, "امنیت و شبکه", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9653) },
                    { 26, 9, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9654), false, null, "معاینه پزشک", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9654) },
                    { 27, 9, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9655), false, null, "داروخانه", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9655) },
                    { 28, 9, new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9656), false, null, "مشاوره", new DateTime(2025, 3, 18, 10, 44, 51, 780, DateTimeKind.Utc).AddTicks(9657) }
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
                    { 1, 500.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2139), "انجام انواع امور پی ریزی", false, null, 1, "پی ریزی", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2140), null },
                    { 2, 1000.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2143), "انجام انواع امور بلوک گذاری و دیوار چینی", false, null, 1, "بلوک گذاری و دیوار چینی", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2144), null },
                    { 3, 600.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2149), "انجام انواع امور مرتبط با کف ساختمان", false, null, 1, "کف ساختمان", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2150), null },
                    { 4, 6000.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2151), "انجام انواع امور نوسازی ساختمان های قدیمی یا نیازمند تغییر", false, null, 1, "نوسازی", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2151), null },
                    { 5, 500.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2153), "انجام انواع امور سیمان کاری", false, null, 1, "سیمان کاری", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2153), null },
                    { 6, 500.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2154), "انجام انواع امور دکور آشپزخانه", false, null, 2, "دکور آشپزخانه", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2155), null },
                    { 7, 580.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2156), "انجام انواع امور دکور حال و پذیرایی", false, null, 2, "دکور حال و پذیرایی", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2156), null },
                    { 8, 400.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2158), "انجام انواع امور دکور اتاق خواب", false, null, 2, "دکور اتاق خواب", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2158), null },
                    { 9, 800.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2160), "انجام انواع امور طراحی و دیزاین ساختمان", false, null, 2, "طراحی و دیزاین ساختمان", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2160), null },
                    { 10, 1500.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2161), "انجام انواع امور معماری داخلی", false, null, 2, "معماری داخلی", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2162), null },
                    { 11, 800.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2163), "انجام انواع امور نقاشی داخل ساختمان", false, null, 3, "نقاشی داخل ساختمان", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2163), null },
                    { 12, 300.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2165), "انجام انواع امور نقاشی خارج ساختمان", false, null, 3, "نقاشی خارج ساختمان", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2165), null },
                    { 13, 200.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2166), "انجام انواع امور تعمیرات درب و پنجره", false, null, 4, "تعمیرات درب و پنجره", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2167), null },
                    { 14, 800.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2168), "انجام انواع امور سفارش درب و پنجرهن", false, null, 4, "سفارش درب و پنجره", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2168), null },
                    { 15, 800.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2169), "انجام انواع امور آهنگری و جوشکاری لوازم و غیره", false, null, 5, "آهنگری و جوشکاری لوازم و غیره", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2170), null },
                    { 16, 800.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2206), "انجام انواع امور آهنگری و جوشکاری ساختمانی", false, null, 5, "آهنگری و جوشکاری ساختمانی", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2207), null },
                    { 17, 500.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2208), "انجام انواع امور باغبانی ساختمان ها ومجتمع ها", false, null, 6, "باغبانی ساختمان ها ومجتمع ها ", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2209), null },
                    { 18, 800.0, new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2211), "انجام انواع امور باغبانی فضای شهری و سازمان ها", false, null, 6, "باغبانی فضای شهری و سازمان ها", new DateTime(2025, 3, 18, 10, 44, 51, 781, DateTimeKind.Utc).AddTicks(2211), null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreateAt", "CustomersId", "Description", "ExpertId", "IsActive", "IsDelete", "Title", "UpdateAt", "WorkScore" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 18, 14, 14, 51, 779, DateTimeKind.Local).AddTicks(8367), 1, "Description", 1, true, false, "Title", new DateTime(2025, 3, 18, 14, 14, 51, 779, DateTimeKind.Local).AddTicks(8379), 4 },
                    { 2, new DateTime(2025, 3, 18, 14, 14, 51, 779, DateTimeKind.Local).AddTicks(8380), 2, "Description", 2, true, false, "Title", new DateTime(2025, 3, 18, 14, 14, 51, 779, DateTimeKind.Local).AddTicks(8381), 3 },
                    { 3, new DateTime(2025, 3, 18, 14, 14, 51, 779, DateTimeKind.Local).AddTicks(8382), 3, "Description", 3, true, false, "Title", new DateTime(2025, 3, 18, 14, 14, 51, 779, DateTimeKind.Local).AddTicks(8383), 5 }
                });

            migrationBuilder.InsertData(
                table: "CustomersRequests",
                columns: new[] { "Id", "CreateAt", "CustomerId", "DateWork", "Description", "IsDelete", "Status", "UpdateAt", "WorkId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(2133), 1, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(2138), "Description", false, 3, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(2151), 1 },
                    { 2, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(2153), 2, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(2154), "Description", false, 4, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(2155), 2 },
                    { 3, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(2156), 3, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(2157), "Description", false, 1, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(2158), 3 }
                });

            migrationBuilder.InsertData(
                table: "ExpertsRequests",
                columns: new[] { "Id", "CreateAt", "CustomersRequestId", "DateWork", "Description", "ExpertId", "IsDelete", "Price", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(7080), 1, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(7084), "Description", 1, false, 1000.0, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(7086) },
                    { 2, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(7088), 2, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(7088), "Description", 2, false, 1000.0, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(7089) },
                    { 3, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(7090), 3, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(7091), "Description", 3, false, 1000.0, new DateTime(2025, 3, 18, 14, 14, 51, 780, DateTimeKind.Local).AddTicks(7092) }
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
