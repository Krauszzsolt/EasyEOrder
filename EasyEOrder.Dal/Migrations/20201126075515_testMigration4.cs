using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class testMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartFoods_Carts_CartId",
                table: "CartFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_CartFoods_Foods_FoodId",
                table: "CartFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e86d9dd6-54a7-41f2-8d88-461f0b3ec7a8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20c4d336-43d0-44fe-8bf8-34c0c6e09149", "09b408c4-2ed9-48ec-b847-961938fdc39f", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2999a0ae-8f05-4cc9-9251-1ba292c4b1c1", "AQAAAAEAACcQAAAAEJEZn512fLQAH0TF2yz1LeC6IvC59oYsZUfoO9jxV/gRrQsLVgkP5kcVZj69qtveiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c968dfd-879d-48e0-b285-d82d8b598439", "AQAAAAEAACcQAAAAECzkotjH9BUNCdrsQUYMBTJqzwgKI4NVMrAer7W8Uu1JlyrPuczMpZBHbOopghPYSg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartFoods_Carts_CartId",
                table: "CartFoods",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartFoods_Foods_FoodId",
                table: "CartFoods",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartFoods_Carts_CartId",
                table: "CartFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_CartFoods_Foods_FoodId",
                table: "CartFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20c4d336-43d0-44fe-8bf8-34c0c6e09149");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e86d9dd6-54a7-41f2-8d88-461f0b3ec7a8", "962e17cd-23ce-4d7c-ae9d-fc80834401cc", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de21aed8-abf3-494f-84f4-fb4446639789", "AQAAAAEAACcQAAAAEL5WIIUDgJuKEqNEGcPwnhIVRoj2H6jtIcdNIYUxqDt7Mw33RBwPQ3b7QV/sQHagcg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04a4cb9a-1327-4025-bb5a-688381e3e797", "AQAAAAEAACcQAAAAEFOzsZBlRYcY3rsnXjvD5m+kRLO0eiAVWQntusVHaHT5MPmFGoJdYhnu7L6CdCTBBg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartFoods_Carts_CartId",
                table: "CartFoods",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartFoods_Foods_FoodId",
                table: "CartFoods",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
