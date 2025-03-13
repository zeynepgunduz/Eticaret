using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class GuncelDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "CreateDate", "Email", "IsActive", "IsAdmin", "Name", "Password", "Phone", "Surname", "UserGuid", "Username" },
                values: new object[] { 1, new DateTime(2025, 3, 12, 15, 36, 40, 158, DateTimeKind.Local).AddTicks(5697), "admin@testtt.com", true, true, "Admin", "123", null, "Admin", new Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301"), "admin" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "Logo", "Name", "OrderNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brand1 Description", true, null, "Brand1", 1 },
                    { 2, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brand2 Description", true, null, "Brand2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Description", "Image", "IsActive", "IsTopMenu", "Name", "OrderNo", "ParentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 12, 15, 36, 40, 167, DateTimeKind.Local).AddTicks(843), "Category1 Description", "1.jpg", true, true, "Elektronik", 1, 0 },
                    { 2, new DateTime(2025, 3, 12, 15, 36, 40, 167, DateTimeKind.Local).AddTicks(4332), "Category2 Description", "2.jpg", true, true, "Bilgisayar", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreateDate", "Email", "Message", "Name", "Phone", "Surname" },
                values: new object[] { 1, new DateTime(2025, 3, 12, 15, 36, 40, 168, DateTimeKind.Local).AddTicks(7101), "admin@deneme.com", null, "Admin", null, "Admin" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CretateDate", "Description", "Image", "IsActive", "Name" },
                values: new object[] { 1, new DateTime(2025, 3, 12, 15, 36, 40, 170, DateTimeKind.Local).AddTicks(1368), "Haber1 Description", "1.jpg", true, "Haber1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreateDate", "Description", "Image", "IsActive", "IsHome", "Name", "OrderNo", "Price", "ProductCode", "Stock" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2025, 3, 12, 15, 36, 40, 182, DateTimeKind.Local).AddTicks(8704), "Product1 Description", "1.jpg", true, true, "Product1", 0, 100m, null, 100 },
                    { 2, null, 2, new DateTime(2025, 3, 12, 15, 36, 40, 183, DateTimeKind.Local).AddTicks(2805), "Product2 Description", "2.jpg", true, true, "Product2", 0, 200m, null, 200 }
                });
        }
    }
}
