using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class testMigration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartFoods_Carts_CartId",
                table: "CartFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c76b3f3-ab9e-443b-8115-0d7dfadf2f61");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartFoods_Carts_CartId",
                table: "CartFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92c0e279-2b9b-41d9-b792-3c0d9712dadf");

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
                name: "FK_CartFoods_Carts_CartId",
                table: "CartFoods",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
