using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenTimes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MenuId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<Guid>(nullable: true),
                    ReservationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DayOfWeekOpenTimes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RestaurantId = table.Column<Guid>(nullable: false),
                    DayOfWeek = table.Column<int>(nullable: false),
                    OpenTimesId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayOfWeekOpenTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayOfWeekOpenTimes_OpenTimes_OpenTimesId",
                        column: x => x.OpenTimesId,
                        principalTable: "OpenTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DayOfWeekOpenTimes_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    RestaurantId = table.Column<Guid>(nullable: false),
                    ReservationId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    MyUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tables_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tables_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: false),
                    TableId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    OrderTime = table.Column<DateTime>(nullable: false),
                    ReservationId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MenuId = table.Column<Guid>(nullable: false),
                    CartId = table.Column<Guid>(nullable: true),
                    OrderId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Foods_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartFoods",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FoodId = table.Column<Guid>(nullable: false),
                    CartId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartFoods_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    FoodId = table.Column<Guid>(nullable: false),
                    MyUserId = table.Column<string>(nullable: true),
                    CommentContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodAllergens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    FoodId = table.Column<Guid>(nullable: false),
                    Allergen = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAllergens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodAllergens_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ba4b251-1717-4c14-856c-0d9ad4d97736", "fc14ed50-cef3-419f-ac64-c14433b7f5c3", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "ReservationId", "RestaurantId", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db", 0, "4b87a4db-e9aa-493b-9715-e37760943827", "admin@admin.admin", true, false, null, "ADMIN@ADMIN.ADMIN", "ADMIN@ADMIN.ADMIN", "AQAAAAEAACcQAAAAEJwJjq67DLT6IeKS/LRE2BkDC8RVZglxKrJuLI7FEw0O4PhB6bWp0vpbk2grxPQhXw==", null, false, null, null, null, "string", "Üzletvezető", false, "admin@admin.admin" },
                    { "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db", 0, "45985cd7-7d32-40e6-b4fe-30b6707d318f", "test@test.test", true, false, null, "TEST@TEST.TEST", "TEST@TEST.TEST", "AQAAAAEAACcQAAAAEKS42cLW2vTCanoIa3WBmNdbr3aEsdtqmkbldcZa0vmu6cE7jv1ciu5YDAtDQnZ1ag==", null, false, null, null, null, "string", "Vásárló", false, "test@test.test" }
                });

            migrationBuilder.InsertData(
                table: "OpenTimes",
                columns: new[] { "Id", "CreateTime", "From", "IsDelete", "ModifyTime", "To" },
                values: new object[] { new Guid("fe1ee058-9e79-4544-bf93-026f477fe863"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "CreateTime", "Email", "IsDelete", "MenuId", "ModifyTime", "Name" },
                values: new object[,]
                {
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe843"), "Adress", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@email.email", false, new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RestauranName" },
                    { new Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c0d"), "Bp., 1117 Karinthy F. út 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Da-Giovanni@pizza.hu", false, new Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Da Giovanni" },
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe899"), "Adress", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@email.email", false, new Guid("fe1ee058-9e79-4544-bf93-026f477fe855"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RestauranTest" }
                });

            migrationBuilder.InsertData(
                table: "DayOfWeekOpenTimes",
                columns: new[] { "Id", "CreateTime", "DayOfWeek", "IsDelete", "ModifyTime", "OpenTimesId", "RestaurantId" },
                values: new object[] { new Guid("fe1ee058-9e79-4544-bf93-026f477fe855"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fe1ee058-9e79-4544-bf93-026f477fe843") });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreateTime", "IsDelete", "ModifyTime", "Name", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BestMenu", new Guid("fe1ee058-9e79-4544-bf93-026f477fe843") },
                    { new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olasz Pizzak", new Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c0d") },
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe855"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TestMenu", new Guid("fe1ee058-9e79-4544-bf93-026f477fe899") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "CreateTime", "IsDelete", "ModifyTime", "MyUserId", "Number", "ReservationId", "RestaurantId", "UserId" },
                values: new object[] { new Guid("fe1ee058-9e79-4544-bf93-026f477fe847"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new Guid("fe1ee058-9e79-4544-bf93-026f477fe848"), new Guid("fe1ee058-9e79-4544-bf93-026f477fe843"), "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CartId", "Category", "CreateTime", "Description", "IsAvailable", "IsDelete", "MenuId", "ModifyTime", "Name", "OrderId", "Price", "Rating" },
                values: new object[,]
                {
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe123"), null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. ", true, false, new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FoodTest", null, 0, 4 },
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe124"), null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", true, false, new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soup1", null, 1010, 3 },
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe125"), null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", true, false, new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soup2", null, 12312, 1 },
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe126"), null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descriptionasd", true, false, new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meal1", null, 21312, 4 },
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe127"), null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", true, false, new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meal2", null, 1230, 3 },
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe128"), null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", true, false, new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meal3", null, 3210, 2 },
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe129"), null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", true, false, new Guid("fe1ee058-9e79-4544-bf93-026f477fe844"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meal4", null, 4320, 10 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b451"), null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. ", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Húsos pizza", null, 1650, 4 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b452"), null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finom mozzarella darabokkal a sajt kedvelőknek.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mozzarellás pizza", null, 1510, 3 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b453"), null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friss és ízletes alapanyagokból készítve", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halas pizza", null, 1800, 1 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b454"), null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elkészítéséhez hozzáértő szakácsunk saját receptjeit használja, hogy eredeti olasz pizza kerüljön ki a keze alól.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetáriánus pizza", null, 2000, 4 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b455"), null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nálunk a tejszínes pizzák is magas színvonalon készülnek.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tejszínes pizza", null, 1680, 3 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b456"), null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tányérunkra varázsolja az eredeti olasz ízeket.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Capriciosa pizza", null, 2100, 2 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b457"), null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mindegyikhez minőségi alapanyagokat használunk, mivel mi a minőségi ételek elkötelezettjei vagyunk.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hawaii pizza", null, 1400, 10 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreateTime", "From", "IsDelete", "ModifyTime", "TableId", "To", "UserId" },
                values: new object[] { new Guid("fe1ee058-9e79-4544-bf93-026f477fe849"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fe1ee058-9e79-4544-bf93-026f477fe847"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "Comment", "CreateTime", "IsDelete", "ModifyTime", "OrderTime", "ReservationId", "TotalPrice", "UserId" },
                values: new object[] { new Guid("fe1ee058-9e79-4544-bf93-026f477fe851"), "OrderComment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fe1ee058-9e79-4544-bf93-026f477fe849"), 2000, null });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentContent", "CreateTime", "FoodId", "IsDelete", "ModifyTime", "MyUserId" },
                values: new object[] { new Guid("fe1ee058-9e79-4544-bf93-026f477fe841"), "HejHejHej", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fe1ee058-9e79-4544-bf93-026f477fe123"), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db" });

            migrationBuilder.InsertData(
                table: "FoodAllergens",
                columns: new[] { "Id", "Allergen", "CreateTime", "FoodId", "IsDelete", "ModifyTime" },
                values: new object[,]
                {
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe321"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fe1ee058-9e79-4544-bf93-026f477fe123"), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe1ee058-9e79-4544-bf93-026f477fe322"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fe1ee058-9e79-4544-bf93-026f477fe123"), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RestaurantId",
                table: "AspNetUsers",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_CartFoods_CartId",
                table: "CartFoods",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartFoods_FoodId",
                table: "CartFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ReservationId",
                table: "Carts",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FoodId",
                table: "Comments",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MyUserId",
                table: "Comments",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DayOfWeekOpenTimes_OpenTimesId",
                table: "DayOfWeekOpenTimes",
                column: "OpenTimesId");

            migrationBuilder.CreateIndex(
                name: "IX_DayOfWeekOpenTimes_RestaurantId",
                table: "DayOfWeekOpenTimes",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAllergens_FoodId",
                table: "FoodAllergens",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CartId",
                table: "Foods",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MenuId",
                table: "Foods",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_RestaurantId",
                table: "Menus",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_TableId",
                table: "Reservations",
                column: "TableId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_MyUserId",
                table: "Tables",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_RestaurantId",
                table: "Tables",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "CartFoods");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DayOfWeekOpenTimes");

            migrationBuilder.DropTable(
                name: "FoodAllergens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OpenTimes");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
