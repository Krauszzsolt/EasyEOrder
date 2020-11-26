using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class testMigration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartFoods_Carts_CartId",
                table: "CartFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_CartFoods_Foods_FoodId",
                table: "CartFoods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartFoods",
                table: "CartFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92c0e279-2b9b-41d9-b792-3c0d9712dadf");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CartFoods",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartFoods",
                table: "CartFoods",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ef29199-5bde-43e5-aa04-facb3103ed4d", "9063e9d3-ca99-462b-ab2c-a9bf8a906d63", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5b91062-c3fc-4ce5-abfd-3edab22eef5b", "AQAAAAEAACcQAAAAEPWgwnShC0TfzJqd+DCdLCk879+5zPmPjTHNUX4zeOBeOiQWBBaA0h5wYPraJExBjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9718d348-4e49-4173-a600-4e356f19468a", "AQAAAAEAACcQAAAAEOsxEYJQuW/lhhtC4odxrKeHfAnQ4rizz4qhHD9zaU50jL9XerAMGZWpBwCTv/2Ndg==" });

            migrationBuilder.CreateIndex(
                name: "IX_CartFoods_CartId",
                table: "CartFoods",
                column: "CartId");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartFoods",
                table: "CartFoods");

            migrationBuilder.DropIndex(
                name: "IX_CartFoods_CartId",
                table: "CartFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ef29199-5bde-43e5-aa04-facb3103ed4d");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CartFoods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartFoods",
                table: "CartFoods",
                columns: new[] { "CartId", "FoodId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "92c0e279-2b9b-41d9-b792-3c0d9712dadf", "b248da63-7416-4e0a-ba50-cf83dd7ca394", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "978a7a47-46ed-4f0a-ad9d-50d30358bbdc", "AQAAAAEAACcQAAAAENGjvWUFg/AMAPgUmSk9FnWkMet2pjNamSBMUDJWqy0cXJbJV4zkE8mvdc4WmXzixQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6fefa941-8365-4c45-ad45-d9ed91494cf6", "AQAAAAEAACcQAAAAEH5gDvewOdvlfhitPXGrsq/Rhq4Fg7GhaXcSDYctshmEfD1smzBN36L2cgY2Q5CDKQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartFoods_Carts_CartId",
                table: "CartFoods",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartFoods_Foods_FoodId",
                table: "CartFoods",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id");
        }
    }
}
