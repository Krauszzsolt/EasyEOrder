using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class testMigration7 : Migration
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
                keyValue: "063cb9ad-5418-42df-bf32-d429caf6a172");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98c6d45c-fb5f-4cca-9fb0-f29493df622f", "87952471-6b00-4d0c-bde8-f6faf9944b3d", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f22a8f42-84a5-44a9-b2fa-2dfd9fe18e08", "AQAAAAEAACcQAAAAED48aHjtQlLYoSPC7ydYYnE6uF+Jgcq/5uuNmikIS5k20ni/Y4OIyC2UdHdd4Zj2Vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8cfff89b-72c1-4483-be59-ecc64910b329", "AQAAAAEAACcQAAAAEG4f8+4O8008bysfOZPiDL8JHxT4sVHUnHynBtbX27xvE43fWRzOdIOEwPDN8ou3lA==" });

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
                keyValue: "98c6d45c-fb5f-4cca-9fb0-f29493df622f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "063cb9ad-5418-42df-bf32-d429caf6a172", "42aef8d6-1de2-4f0a-8996-a6f32cb253ad", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "324ca106-bd2a-4c92-a515-10ed25d3fbdf", "AQAAAAEAACcQAAAAENuYBjhOdLjq+Td0tl5qX4Bv2RUY0BsPIMCLB36FC6e8Iyx5nUhu8LWUQ8GlRNv3wA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25357278-757f-4e9d-931a-d4493fa24a2a", "AQAAAAEAACcQAAAAEPlqgN5y+DjvvCQvnO4tz5h38nRqiiw8T+lSkcvGyOv7AR81VGKXdkcNsHiHy7IxnA==" });

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
    }
}
