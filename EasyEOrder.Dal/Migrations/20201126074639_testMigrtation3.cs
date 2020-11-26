using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class testMigrtation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66d87d82-8d3c-407e-99f5-47330eebe22c");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CartFoods");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e86d9dd6-54a7-41f2-8d88-461f0b3ec7a8");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CartFoods",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
