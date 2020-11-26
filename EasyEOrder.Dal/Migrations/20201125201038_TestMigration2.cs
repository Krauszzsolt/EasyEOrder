using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class TestMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartFoods",
                table: "CartFoods");

            migrationBuilder.DropIndex(
                name: "IX_CartFoods_CartId",
                table: "CartFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "612c79e9-735e-4bdf-a2b9-75a4bc642dce");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartFoods",
                table: "CartFoods",
                columns: new[] { "CartId", "FoodId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66d87d82-8d3c-407e-99f5-47330eebe22c", "0014a940-172e-4aef-bd57-cb2dc48aa9b2", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99e7dc11-060e-4fe1-9c62-57d665afe967", "AQAAAAEAACcQAAAAEIhhw5jAn7Y/awtqo0LGhg3Yu5env+eozKpMzo/gbmP2DCygqt485kfnY+eZxFjT5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2955d8c7-b86c-4876-897b-02313c78612c", "AQAAAAEAACcQAAAAEO/bMq3tfp3Ku8Xt4V4EwUYzDAutSqHM03vIuOj3UdFuXSnol81oDqOwwxgeyo8dzw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartFoods",
                table: "CartFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66d87d82-8d3c-407e-99f5-47330eebe22c");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartFoods",
                table: "CartFoods",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "612c79e9-735e-4bdf-a2b9-75a4bc642dce", "a948b328-be46-44df-8e61-66bda896b01e", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d25001bf-3197-4fe5-8ddc-e1a25ae90a80", "AQAAAAEAACcQAAAAELdWSPfv8z3mIxLjccmZMmKWW8khBTRC6NOVMqoP1tZ1i0cpTZfyWZ64/qO6l7gOXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34a85e09-c07f-4c7a-88a1-dae7c5137cd9", "AQAAAAEAACcQAAAAEOMTou9F+mOxD3jJtR5BrKOXG0kRI1s1TviXGxbXJ5jwnYo0z75yZ6ipRNpBYqJMAw==" });

            migrationBuilder.CreateIndex(
                name: "IX_CartFoods_CartId",
                table: "CartFoods",
                column: "CartId");
        }
    }
}
