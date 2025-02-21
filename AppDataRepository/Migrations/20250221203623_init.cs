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
                    { 1, new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7576), false, null, "دکوراسیون ساختمان", new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7580) },
                    { 2, new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7582), false, null, "تاسیسات ساختمان", new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7583) },
                    { 3, new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7584), false, null, "وسیله نقلیه", new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7584) },
                    { 4, new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7585), false, null, "اسبابکشی و باربری", new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7585) },
                    { 5, new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7586), false, null, "لوازم خانگی", new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7587) },
                    { 6, new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7588), false, null, "خدمات اداری", new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7588) },
                    { 7, new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7589), false, null, "نظافت و بهداشت", new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7590) },
                    { 8, new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7590), false, null, "دیجیتال و نرم افزار", new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7591) },
                    { 9, new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7592), false, null, "پزشکی و سلامت", new DateTime(2025, 2, 21, 20, 36, 22, 141, DateTimeKind.Utc).AddTicks(7592) }
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
                    { 1, 0, null, null, null, 0.0, "2fdc583c-a3f8-4634-bf16-7d13f0b244c8", null, "Admin@gmail.com", false, null, false, null, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEL3ujSQz7IQ7C2U/k77wv3XgK/v1xEj6jDB7jxruRUxsdNKMrJDMpcTab8VM8pu2Dw==", "09121111111", null, false, 1, 1, "cb44e332-abec-48e8-9d82-16be26ddefb2", false, null, null },
                    { 2, 0, null, null, null, 0.0, "e83ac0b2-53e1-4229-8572-8c25301067ff", null, "expert@gmail.com", false, null, false, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAELodCzrJO3iWfXh3gAiR6fNKkk4oBClUY4pt95YBThGrWCHzsM2G5mR1FF3j8kt0qQ==", "09121111112", null, false, 2, 2, "7ee0f124-266a-4a0a-9558-1962e1fa58f5", false, null, null },
                    { 3, 0, null, null, null, 0.0, "4d2e05b6-0e7f-489a-8722-fdf5119ed67a", null, "expert@gmail.com", false, null, false, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEB9A3iqDP/Ff9ZoC1P7Ko7sbNIWG+SbutB3vMjJ6NEhCnjN4QQSjnVHdFGxPqffoLg==", "09121111112", null, false, 3, 3, "67c60f12-fe3b-4c3f-bfd0-482899ea415c", false, null, null },
                    { 4, 0, null, null, null, 0.0, "c60b6b2a-fedb-4cc6-8230-3cd8caa8426f", null, "expert@gmail.com", false, null, false, null, false, null, "EXPERT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEAtB0ShdYMTeOvvE3MGPqwKzPNdaHKNzNHYmbsRQdEqHu8M4wJ7Uo9wg1eTgHn0bvQ==", "09121111112", null, false, 4, 4, "545fad0a-eaec-4ef0-8035-67c71eac13c4", false, null, null },
                    { 5, 0, null, null, null, 0.0, "ef9e6530-7d10-4a3c-98e6-1118081f3c6e", null, "customer@gmail.com", false, null, false, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEOw54QlClGCWS11sUm5t5mCN6WTjfe77HyT/ChoKmOPp/dzXu/tAQuEhuyUHNMU0mA==", "09121111112", null, false, 5, 5, "dfe35d7a-0432-4919-9e95-0b5e7f522d51", false, null, null },
                    { 6, 0, null, null, null, 0.0, "7ea50257-12b7-4ee7-b158-300567bd6db8", null, "customer@gmail.com", false, null, false, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEHVu1iPWrJw8IVp8PPCU+eWFnFeGrDaZV8WHBDD3MWEeAA3rstYRY13ij+wAKYlKFA==", "09121111112", null, false, 6, 6, "ef894f43-600c-4d35-a727-d92028f3e844", false, null, null },
                    { 7, 0, null, null, null, 0.0, "6864c1aa-d5c7-42c6-88b2-9bd1246bd1e3", null, "customer@gmail.com", false, null, false, null, false, null, "COSTOMER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEInH7ZPDvbS0JAwLTlC58piQmIlb+v/26QCWpuUry72xgKv2X5K59CRalPMjnIR6FQ==", "09121111112", null, false, 7, 7, "7ea0ab1c-e515-4759-a462-e6b73beb7827", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateAt", "IsDelete", "PhotoId", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6014), false, null, "بنایی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6015) },
                    { 2, 1, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6018), false, null, "دکوراسیون", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6019) },
                    { 3, 1, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6020), false, null, "نقاشی ساختمان", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6020) },
                    { 4, 1, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6021), false, null, "درب و پنجره", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6022) },
                    { 5, 1, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6023), false, null, "آهنگری و جوشکاری", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6023) },
                    { 6, 1, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6024), false, null, "باغبانی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6024) },
                    { 7, 2, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6025), false, null, "سرمایش و گرمایش", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6026) },
                    { 8, 2, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6027), false, null, "لوله کشی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6027) },
                    { 9, 2, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6028), false, null, "برقو الکترونیک", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6029) },
                    { 10, 2, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6029), false, null, "تلفن و سانترال", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6030) },
                    { 11, 3, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6062), false, null, "خودرو", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6062) },
                    { 12, 4, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6063), false, null, "اسبابکشی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6064) },
                    { 13, 4, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6065), false, null, "حمل بار", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6065) },
                    { 14, 5, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6066), false, null, "لوازم آشپزخانه", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6066) },
                    { 15, 5, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6067), false, null, "لوازم شست و شو", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6068) },
                    { 16, 5, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6069), false, null, "لوازم صوتی و تصویری", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6069) },
                    { 17, 6, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6070), false, null, "ماشین آلات اداری", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6071) },
                    { 18, 6, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6071), false, null, "مبلمان اداری", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6072) },
                    { 19, 7, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6073), false, null, "نظافت", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6073) },
                    { 20, 7, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6074), false, null, "خشک شویی و اتوشویی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6074) },
                    { 21, 7, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6075), false, null, "قالی شویی و مبل شویی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6076) },
                    { 22, 7, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6077), false, null, "سمپاشی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6077) },
                    { 23, 8, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6078), false, null, "موبایل و تبلت", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6078) },
                    { 24, 8, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6079), false, null, "خدمات کامپیوتری", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6080) },
                    { 25, 8, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6081), false, null, "امنیت و شبکه", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6081) },
                    { 26, 9, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6082), false, null, "معاینه پزشک", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6082) },
                    { 27, 9, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6083), false, null, "داروخانه", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6084) },
                    { 28, 9, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6085), false, null, "مشاوره", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(6085) }
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
                    { 1, 500.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8589), "انجام انواع امور پی ریزی", false, null, 1, "پی ریزی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8590), null },
                    { 2, 1000.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8593), "انجام انواع امور بلوک گذاری و دیوار چینی", false, null, 1, "بلوک گذاری و دیوار چینی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8594), null },
                    { 3, 600.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8596), "انجام انواع امور مرتبط با کف ساختمان", false, null, 1, "کف ساختمان", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8596), null },
                    { 4, 6000.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8597), "انجام انواع امور نوسازی ساختمان های قدیمی یا نیازمند تغییر", false, null, 1, "نوسازی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8597), null },
                    { 5, 500.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8599), "انجام انواع امور سیمان کاری", false, null, 1, "سیمان کاری", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8599), null },
                    { 6, 500.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8600), "انجام انواع امور دکور آشپزخانه", false, null, 2, "دکور آشپزخانه", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8601), null },
                    { 7, 580.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8602), "انجام انواع امور دکور حال و پذیرایی", false, null, 2, "دکور حال و پذیرایی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8602), null },
                    { 8, 400.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8604), "انجام انواع امور دکور اتاق خواب", false, null, 2, "دکور اتاق خواب", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8604), null },
                    { 9, 800.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8605), "انجام انواع امور طراحی و دیزاین ساختمان", false, null, 2, "طراحی و دیزاین ساختمان", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8606), null },
                    { 10, 1500.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8607), "انجام انواع امور معماری داخلی", false, null, 2, "معماری داخلی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8607), null },
                    { 11, 800.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8608), "انجام انواع امور نقاشی داخل ساختمان", false, null, 3, "نقاشی داخل ساختمان", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8609), null },
                    { 12, 300.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8610), "انجام انواع امور نقاشی خارج ساختمان", false, null, 3, "نقاشی خارج ساختمان", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8610), null },
                    { 13, 200.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8612), "انجام انواع امور تعمیرات درب و پنجره", false, null, 4, "تعمیرات درب و پنجره", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8612), null },
                    { 14, 800.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8613), "انجام انواع امور سفارش درب و پنجرهن", false, null, 4, "سفارش درب و پنجره", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8614), null },
                    { 15, 800.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8615), "انجام انواع امور آهنگری و جوشکاری لوازم و غیره", false, null, 5, "آهنگری و جوشکاری لوازم و غیره", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8615), null },
                    { 16, 800.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8616), "انجام انواع امور آهنگری و جوشکاری ساختمانی", false, null, 5, "آهنگری و جوشکاری ساختمانی", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8617), null },
                    { 17, 500.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8618), "انجام انواع امور باغبانی ساختمان ها ومجتمع ها", false, null, 6, "باغبانی ساختمان ها ومجتمع ها ", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8618), null },
                    { 18, 800.0, new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8620), "انجام انواع امور باغبانی فضای شهری و سازمان ها", false, null, 6, "باغبانی فضای شهری و سازمان ها", new DateTime(2025, 2, 21, 20, 36, 22, 143, DateTimeKind.Utc).AddTicks(8620), null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreateAt", "CustomersId", "Description", "ExpertId", "IsActive", "IsDelete", "Title", "UpdateAt", "WorkScore" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(4798), 1, "Description", 1, true, false, "Title", new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(4811), 4 },
                    { 2, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(4814), 2, "Description", 2, true, false, "Title", new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(4814), 3 },
                    { 3, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(4816), 3, "Description", 3, true, false, "Title", new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(4817), 5 }
                });

            migrationBuilder.InsertData(
                table: "CustomersRequests",
                columns: new[] { "Id", "CreateAt", "CustomerId", "DateWork", "Description", "IsDelete", "Status", "UpdateAt", "WorkId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(8725), 1, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(8729), "Description", false, 3, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(8739), 1 },
                    { 2, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(8741), 2, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(8741), "Description", false, 4, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(8742), 2 },
                    { 3, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(8743), 3, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(8744), "Description", false, 1, new DateTime(2025, 2, 22, 0, 6, 22, 142, DateTimeKind.Local).AddTicks(8745), 3 }
                });

            migrationBuilder.InsertData(
                table: "ExpertsRequests",
                columns: new[] { "Id", "CreateAt", "CustomersRequestId", "DateWork", "Description", "ExpertId", "IsDelete", "Price", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 22, 0, 6, 22, 143, DateTimeKind.Local).AddTicks(3489), 1, new DateTime(2025, 2, 22, 0, 6, 22, 143, DateTimeKind.Local).AddTicks(3493), "Description", 1, false, 1000.0, new DateTime(2025, 2, 22, 0, 6, 22, 143, DateTimeKind.Local).AddTicks(3494) },
                    { 2, new DateTime(2025, 2, 22, 0, 6, 22, 143, DateTimeKind.Local).AddTicks(3496), 2, new DateTime(2025, 2, 22, 0, 6, 22, 143, DateTimeKind.Local).AddTicks(3497), "Description", 2, false, 1000.0, new DateTime(2025, 2, 22, 0, 6, 22, 143, DateTimeKind.Local).AddTicks(3497) },
                    { 3, new DateTime(2025, 2, 22, 0, 6, 22, 143, DateTimeKind.Local).AddTicks(3499), 3, new DateTime(2025, 2, 22, 0, 6, 22, 143, DateTimeKind.Local).AddTicks(3499), "Description", 3, false, 1000.0, new DateTime(2025, 2, 22, 0, 6, 22, 143, DateTimeKind.Local).AddTicks(3500) }
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
