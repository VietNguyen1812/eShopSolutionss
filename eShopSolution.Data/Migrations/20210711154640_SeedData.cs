using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "38726886-47bb-4f9e-a9a4-4b370911ee0c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a7aa8d8-aaa2-4b4f-9712-5279974a69ab", "AQAAAAEAACcQAAAAEJAyNAM2jbZ0RLnTobrd9vMlOapQ31nab7Dp6Cqq7H0AkAh8z7eR3IjZ355+OSoizQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 46, 39, 370, DateTimeKind.Local).AddTicks(7676));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "64874a48-d6d0-461e-a67e-265293924416");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61196b06-eeae-4489-a22d-010c51f1c73d", "AQAAAAEAACcQAAAAEK7mmP87maw8NBEXtutbZThJxDKxpE9kU3ePXxJtf9VANV9+qsc5BwOhOz3rU5NIcQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 46, 18, 524, DateTimeKind.Local).AddTicks(7020));
        }
    }
}
