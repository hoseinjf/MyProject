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
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsDelete", "PhotoId", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(212), false, null, "دکوراسیون ساختمان", new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(214) },
                    { 2, new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(216), false, null, "تاسیسات ساختمان", new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(216) },
                    { 3, new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(217), false, null, "وسیله نقلیه", new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(218) },
                    { 4, new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(218), false, null, "اسبابکشی و باربری", new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(219) },
                    { 5, new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(220), false, null, "لوازم خانگی", new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(220) },
                    { 6, new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(221), false, null, "خدمات اداری", new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(222) },
                    { 7, new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(223), false, null, "نظافت و بهداشت", new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(223) },
                    { 8, new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(224), false, null, "دیجیتال و نرم افزار", new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(224) },
                    { 9, new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(225), false, null, "پزشکی و سلامت", new DateTime(2025, 2, 20, 23, 57, 16, 541, DateTimeKind.Utc).AddTicks(226) }
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
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateAt", "IsDelete", "PhotoId", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4338), false, null, "بنایی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4339) },
                    { 2, 1, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4341), false, null, "دکوراسیون", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4341) },
                    { 3, 1, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4343), false, null, "نقاشی ساختمان", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4343) },
                    { 4, 1, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4344), false, null, "درب و پنجره", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4345) },
                    { 5, 1, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4346), false, null, "آهنگری و جوشکاری", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4346) },
                    { 6, 1, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4347), false, null, "باغبانی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4348) },
                    { 7, 2, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4349), false, null, "سرمایش و گرمایش", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4349) },
                    { 8, 2, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4350), false, null, "لوله کشی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4351) },
                    { 9, 2, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4352), false, null, "برقو الکترونیک", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4352) },
                    { 10, 2, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4353), false, null, "تلفن و سانترال", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4354) },
                    { 11, 3, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4355), false, null, "خودرو", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4355) },
                    { 12, 4, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4356), false, null, "اسبابکشی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4357) },
                    { 13, 4, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4358), false, null, "حمل بار", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4358) },
                    { 14, 5, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4359), false, null, "لوازم آشپزخانه", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4359) },
                    { 15, 5, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4360), false, null, "لوازم شست و شو", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4361) },
                    { 16, 5, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4362), false, null, "لوازم صوتی و تصویری", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4362) },
                    { 17, 6, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4363), false, null, "ماشین آلات اداری", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4363) },
                    { 18, 6, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4364), false, null, "مبلمان اداری", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4365) },
                    { 19, 7, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4366), false, null, "نظافت", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4366) },
                    { 20, 7, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4367), false, null, "خشک شویی و اتوشویی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4367) },
                    { 21, 7, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4368), false, null, "قالی شویی و مبل شویی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4369) },
                    { 22, 7, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4370), false, null, "سمپاشی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4370) },
                    { 23, 8, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4371), false, null, "موبایل و تبلت", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4372) },
                    { 24, 8, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4373), false, null, "خدمات کامپیوتری", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4373) },
                    { 25, 8, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4374), false, null, "امنیت و شبکه", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4374) },
                    { 26, 9, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4375), false, null, "معاینه پزشک", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4376) },
                    { 27, 9, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4377), false, null, "داروخانه", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4377) },
                    { 28, 9, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4378), false, null, "مشاوره", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(4379) }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "CorePrice", "CreateAt", "Description", "IsDelete", "PhotoId", "SubCategoryId", "Title", "UpdateAt", "Viwe" },
                values: new object[,]
                {
                    { 1, 500.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6447), "انجام انواع امور پی ریزی", false, null, 1, "پی ریزی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6447), null },
                    { 2, 1000.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6454), "انجام انواع امور بلوک گذاری و دیوار چینی", false, null, 1, "بلوک گذاری و دیوار چینی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6455), null },
                    { 3, 600.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6456), "انجام انواع امور مرتبط با کف ساختمان", false, null, 1, "کف ساختمان", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6457), null },
                    { 4, 6000.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6458), "انجام انواع امور نوسازی ساختمان های قدیمی یا نیازمند تغییر", false, null, 1, "نوسازی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6459), null },
                    { 5, 500.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6461), "انجام انواع امور سیمان کاری", false, null, 1, "سیمان کاری", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6461), null },
                    { 6, 500.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6462), "انجام انواع امور دکور آشپزخانه", false, null, 2, "دکور آشپزخانه", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6463), null },
                    { 7, 580.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6464), "انجام انواع امور دکور حال و پذیرایی", false, null, 2, "دکور حال و پذیرایی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6464), null },
                    { 8, 400.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6466), "انجام انواع امور دکور اتاق خواب", false, null, 2, "دکور اتاق خواب", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6466), null },
                    { 9, 800.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6467), "انجام انواع امور طراحی و دیزاین ساختمان", false, null, 2, "طراحی و دیزاین ساختمان", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6468), null },
                    { 10, 1500.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6469), "انجام انواع امور معماری داخلی", false, null, 2, "معماری داخلی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6469), null },
                    { 11, 800.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6471), "انجام انواع امور نقاشی داخل ساختمان", false, null, 3, "نقاشی داخل ساختمان", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6471), null },
                    { 12, 300.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6473), "انجام انواع امور نقاشی خارج ساختمان", false, null, 3, "نقاشی خارج ساختمان", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6473), null },
                    { 13, 200.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6474), "انجام انواع امور تعمیرات درب و پنجره", false, null, 4, "تعمیرات درب و پنجره", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6475), null },
                    { 14, 800.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6476), "انجام انواع امور سفارش درب و پنجرهن", false, null, 4, "سفارش درب و پنجره", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6476), null },
                    { 15, 800.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6478), "انجام انواع امور آهنگری و جوشکاری لوازم و غیره", false, null, 5, "آهنگری و جوشکاری لوازم و غیره", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6478), null },
                    { 16, 800.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6480), "انجام انواع امور آهنگری و جوشکاری ساختمانی", false, null, 5, "آهنگری و جوشکاری ساختمانی", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6480), null },
                    { 17, 500.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6481), "انجام انواع امور باغبانی ساختمان ها ومجتمع ها", false, null, 6, "باغبانی ساختمان ها ومجتمع ها ", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6482), null },
                    { 18, 800.0, new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6525), "انجام انواع امور باغبانی فضای شهری و سازمان ها", false, null, 6, "باغبانی فضای شهری و سازمان ها", new DateTime(2025, 2, 20, 23, 57, 16, 542, DateTimeKind.Utc).AddTicks(6525), null }
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
