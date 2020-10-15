using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyEOrder.Dal.Migrations
{
    public partial class AddSecondRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1d31b00-7036-45d4-8687-fa62701b768c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b223b3c-58a6-4609-8106-2450bdf17000", "38b122f6-4e7c-47f9-a1ce-82facc54f77b", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aabea667-3fc3-49a0-a46a-6f5b27fb91ac", "AQAAAAEAACcQAAAAEDqEYfm7U9cbZAvC+jci5PBv260K86An8sJmiCIFRZXYwYCP8bvpJNO0WlDnE/Pz4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2b53bef-bda2-474b-9935-329fe06fbc18", "AQAAAAEAACcQAAAAEF8LVhI+JUMBxfNUof3I+LeQA263Lo1iY00hyZSsdutcbyz7DLS9eeBmeP36vbYNOg==" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "CreateTime", "Email", "IsDelete", "MenuId", "ModifyTime", "Name" },
                values: new object[] { new Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c0d"), "Bp., 1117 Karinthy F. út 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Da-Giovanni@pizza.hu", false, new Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Da Giovanni" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreateTime", "IsDelete", "ModifyTime", "Name", "RestaurantId" },
                values: new object[] { new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olasz Pizzak", new Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c0d") });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Category", "CreateTime", "Description", "IsAvailable", "IsDelete", "MenuId", "ModifyTime", "Name", "OrderId", "Price", "Rating" },
                values: new object[,]
                {
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b451"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. ", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Húsos pizza", null, 1650, 4 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b452"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finom mozzarella darabokkal a sajt kedvelőknek.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mozzarellás pizza", null, 1510, 3 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b453"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friss és ízletes alapanyagokból készítve", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halas pizza", null, 1800, 1 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b454"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elkészítéséhez hozzáértő szakácsunk saját receptjeit használja, hogy eredeti olasz pizza kerüljön ki a keze alól.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetáriánus pizza", null, 2000, 4 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b455"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nálunk a tejszínes pizzák is magas színvonalon készülnek.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tejszínes pizza", null, 1680, 3 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b456"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tányérunkra varázsolja az eredeti olasz ízeket.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Capriciosa pizza", null, 2100, 2 },
                    { new Guid("63c299af-c574-42d7-9b74-a0904a96b457"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mindegyikhez minőségi alapanyagokat használunk, mivel mi a minőségi ételek elkötelezettjei vagyunk.", true, false, new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hawaii pizza", null, 1400, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b223b3c-58a6-4609-8106-2450bdf17000");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("63c299af-c574-42d7-9b74-a0904a96b451"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("63c299af-c574-42d7-9b74-a0904a96b452"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("63c299af-c574-42d7-9b74-a0904a96b453"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("63c299af-c574-42d7-9b74-a0904a96b454"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("63c299af-c574-42d7-9b74-a0904a96b455"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("63c299af-c574-42d7-9b74-a0904a96b456"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("63c299af-c574-42d7-9b74-a0904a96b457"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9ba36e79-1d88-4e73-b961-e75fa011a3e7"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("7b21b274-71fe-492a-8fed-f9a21c5a2c0d"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d1d31b00-7036-45d4-8687-fa62701b768c", "e7357f24-21e3-459a-9d9a-0e10df06b678", "Admin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e79db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b15c5ba3-030d-4974-a8be-a09a9ce1a693", "AQAAAAEAACcQAAAAEJ57vLRG1ACbeKnQVOXeN40BEtMcj08L3brrb3eH/muytBcUhm+c11QSaCBiMq66UQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87a50b7-ce6b-4eb9-b99c-a7a4b01e80db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1a79717-3e4a-430e-aa1b-4ad4c9f76878", "AQAAAAEAACcQAAAAECjXO4mgubksgeLj1IJbtaR7bHOH4thhpMTmFmQQnt08tAAtS0ZeZ48jWZhHbFsLVw==" });
        }
    }
}
