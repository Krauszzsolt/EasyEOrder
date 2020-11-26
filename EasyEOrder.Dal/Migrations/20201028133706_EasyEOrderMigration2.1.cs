using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class EasyEOrderMigration21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Carts_OrderId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_OrderId",
                table: "Foods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b223b3c-58a6-4609-8106-2450bdf17000");

            migrationBuilder.AddColumn<Guid>(
                name: "CartId",
                table: "Foods",
                nullable: true);

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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7c1e0d4-3b5b-4498-b147-ca88d221ac32", "619b8f3d-5d38-40b0-a651-3f0df3fabdda", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30d8f288-c361-4cdf-ac0c-8276b113fa75", "AQAAAAEAACcQAAAAECP3bOkuNjGP05xpl9KAE7OVV493qQZ64u269M8FVeI+UqjjtjVpdPiMsyJhUuNudQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7a7b90c-9e09-4bbf-80d8-8b9444a60172", "AQAAAAEAACcQAAAAEEwZJg8Fu5HwnTXWMfs9FRLy07Hsy0aiwsmqPr1/3h2rfIQByfTziQ45XXCXyEIGLg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CartId",
                table: "Foods",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartFoods_CartId",
                table: "CartFoods",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartFoods_FoodId",
                table: "CartFoods",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Carts_CartId",
                table: "Foods",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Carts_CartId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "CartFoods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_CartId",
                table: "Foods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c1e0d4-3b5b-4498-b147-ca88d221ac32");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Foods");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b223b3c-58a6-4609-8106-2450bdf17000", "38b122f6-4e7c-47f9-a1ce-82facc54f77b", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aabea667-3fc3-49a0-a46a-6f5b27fb91ac", "AQAAAAEAACcQAAAAEDqEYfm7U9cbZAvC+jci5PBv260K86An8sJmiCIFRZXYwYCP8bvpJNO0WlDnE/Pz4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2b53bef-bda2-474b-9935-329fe06fbc18", "AQAAAAEAACcQAAAAEF8LVhI+JUMBxfNUof3I+LeQA263Lo1iY00hyZSsdutcbyz7DLS9eeBmeP36vbYNOg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_OrderId",
                table: "Foods",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Carts_OrderId",
                table: "Foods",
                column: "OrderId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
