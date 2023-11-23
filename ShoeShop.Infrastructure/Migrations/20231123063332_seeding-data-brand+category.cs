using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeShop.Infrastructure.Migrations
{
    public partial class seedingdatabrandcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "4c6c33ce-9dce-4397-a921-c929751b9841");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "e5711d38-a1ed-47b4-a9ed-14b3b0184272");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19ebcdc1-bcf6-4c8c-9c98-ca05661b48b2", "AQAAAAEAACcQAAAAEBD07XGfVhQtixBMGiAqekpKT85iP1VpG9J4LbjhMzWcsTECHzELpPC9dy3twOuqPg==", "138b3682-6b4a-4615-8bd9-e2cea5572deb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d839230f-669d-4442-8690-65407eda810d", "AQAAAAEAACcQAAAAEF5Ej/lr2X/9booG83zLwbgDFoNn9VCV+VJOHVST69WdOytnNutuJrox89R2iyvS0A==", "69147a26-ecba-4ea7-ba3f-d39934095ee9" });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "BrandStatus", "CreatedAt", "CreatedBy", "NameBrand", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("2199d691-f475-425f-b2a4-e8e3b50e8a8a"), 0, new DateTime(2023, 11, 23, 13, 33, 31, 605, DateTimeKind.Local).AddTicks(5580), "ChienCo", "Nike", null, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryStatus", "CreatedAt", "CreatedBy", "NameCategory", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("8e017451-ae52-470c-a666-90f871c47947"), 0, new DateTime(2023, 11, 23, 13, 33, 31, 605, DateTimeKind.Local).AddTicks(6098), "ChienCo", "The thao", null, null });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: new Guid("0e6bf7f0-1a58-4382-92e8-71ac890e441b"),
                column: "CreatedAt",
                value: new DateTime(2023, 11, 23, 13, 33, 31, 618, DateTimeKind.Local).AddTicks(5899));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: new Guid("2199d691-f475-425f-b2a4-e8e3b50e8a8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e017451-ae52-470c-a666-90f871c47947"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "44e8ffe0-d2f8-4bb9-b05a-361432717f1f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "9d954cec-a40b-426f-b43d-edd5f6355839");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "482dbea6-be6c-4d29-b007-649badebd73e", "AQAAAAEAACcQAAAAEBxFfT2VFOvC6u2ykxYrcWHVbz4Y3R8RWk9Oi/wjcbWFBf5/0L0dYH9mFHb8fOyl0w==", "dfb2b106-0ca2-4cd1-a59d-20ae04ca18ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f53952ef-6be4-4683-a176-321c5d270e29", "AQAAAAEAACcQAAAAECkaN5Wf26u24wvIAylqHU931moARQtp/cSC3KS4lF2QJ1DpNac+aV0ZOCPIhtga/g==", "6bb00609-1c1d-43e9-b8af-abf4d79afc4f" });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: new Guid("0e6bf7f0-1a58-4382-92e8-71ac890e441b"),
                column: "CreatedAt",
                value: new DateTime(2023, 11, 22, 14, 19, 31, 720, DateTimeKind.Local).AddTicks(7128));
        }
    }
}
