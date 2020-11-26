using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class testMigration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3c76b3f3-ab9e-443b-8115-0d7dfadf2f61", "a074731c-780c-490d-9fb1-a33e5a933a47", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57df376b-8bc4-4f8b-8662-c8b3666d88d9", "AQAAAAEAACcQAAAAEGFHfqoE3n0b4d7dvncCIMt9e8+oYEv7IuZawATz60887rf8C0Zn6Fxkv+KUPiyc3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d692afa-3b06-45c5-9a2a-12c883ab8cb2", "AQAAAAEAACcQAAAAEPIzgY5E9dhQODyhxzFDAOdGfrFv71I4fsc79ZM7M0vljBSz57+cfb3EcGBrKlD4BQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartFoods_Foods_FoodId",
                table: "CartFoods",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartFoods_Foods_FoodId",
                table: "CartFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c76b3f3-ab9e-443b-8115-0d7dfadf2f61");

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
                name: "FK_CartFoods_Foods_FoodId",
                table: "CartFoods",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
