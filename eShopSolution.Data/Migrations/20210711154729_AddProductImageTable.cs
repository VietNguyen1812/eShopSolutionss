using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d2ed84ee-9bb5-44c1-bdd6-9115134849f4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d88beb9-66f7-4b42-8c4b-72fe48a33708", "AQAAAAEAACcQAAAAEDqZ+9iDlBBxpkxMNCd/CQwegeikK9yaNXBG/XP462f1ediXjcHIMX4Nl47oUSjlXw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 47, 28, 834, DateTimeKind.Local).AddTicks(386));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9c98cd96-7a33-4f81-903a-83c708de81e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c7f0564-9321-4678-937f-2671c4b68cf0", "AQAAAAEAACcQAAAAELzN8r6h12Lop4tw2gODscthg+MQGed+tNJfCfXB4DrgrCDYwSdC8I0i7/0IOfdqFA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 47, 9, 906, DateTimeKind.Local).AddTicks(4330));
        }
    }
}
