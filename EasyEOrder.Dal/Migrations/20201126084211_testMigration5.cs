using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class testMigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20c4d336-43d0-44fe-8bf8-34c0c6e09149");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e792e91-12ec-4ec7-8def-ef84fdac92ef", "3dec0a39-12fe-4b8f-9dc7-8ef0a531ec5f", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2c2ca1a-f507-4dff-8687-6e9b23196436", "AQAAAAEAACcQAAAAEMcO6i5MZ58Q5YHmf2RE60WZvgUnrf0BMnTBN3dNKF/OM6WLH05aSrgfOjhcEiZnIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da5caaee-926e-44a2-95ae-773e2d1fede3", "AQAAAAEAACcQAAAAELpAsvuhwzGO2D+s8KuyMoB7gYcbIj2H84pckgJH9XdWMg2CrSdItdjkSibI3OYKjQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e792e91-12ec-4ec7-8def-ef84fdac92ef");

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
        }
    }
}
