using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class EasyEOrderMigrationWithRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c6291cb-8711-49b0-9314-ec2d93b139d2");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ce36b49-93a7-46b5-9de4-d03d80105af7", "ec2d218d-00b7-4cb3-98b0-d23d2c40dba9", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Title" },
                values: new object[] { "1f521405-beee-4625-8760-f3e6b639d377", "AQAAAAEAACcQAAAAEFxe+LAARmB5geiDNhMN4UlLBuzfuxHmnkxnjskCcUx8R20l6EAfXtJG4fr/fEp7Fw==", "Üzletvezető" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Title" },
                values: new object[] { "b1f8c1ba-b334-49fb-acb2-bdc37a266fbf", "AQAAAAEAACcQAAAAEKRsgoYNJVPur0wOnUOuTZjNRVlsVGQBF62TChWbGRAJJ8MjEAW0m2U/1y6oUHYMXw==", "Vásárló" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ce36b49-93a7-46b5-9de4-d03d80105af7");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c6291cb-8711-49b0-9314-ec2d93b139d2", "06875523-e11a-4d3d-83c3-4d1768193516", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d7c2253-a4c2-488e-9643-dddcf1f962a6", "AQAAAAEAACcQAAAAEMUjTbw/pq0W9IbrCaIli6OYbBhGc/QgpcF7pGhgN6KmMnTqI9it3czUVYVZPdhuTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b9685ec-0b40-4c99-89b9-c8cd94af786d", "AQAAAAEAACcQAAAAEJnlw0r0j21VTq2+gz3ix1VtOQwbV6oqO2JzSiTZMBQZ0BTMwks0Zeo00C44WlwhNg==" });
        }
    }
}
