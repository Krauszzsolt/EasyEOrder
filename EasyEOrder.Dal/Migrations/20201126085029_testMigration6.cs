using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class testMigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e792e91-12ec-4ec7-8def-ef84fdac92ef");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "063cb9ad-5418-42df-bf32-d429caf6a172");

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
    }
}
