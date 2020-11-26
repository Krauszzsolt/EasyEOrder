using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c1e0d4-3b5b-4498-b147-ca88d221ac32");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "612c79e9-735e-4bdf-a2b9-75a4bc642dce");

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
        }
    }
}
