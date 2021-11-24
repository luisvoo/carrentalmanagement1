using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "a4c2ad15-184e-40e6-b9b9-d7a1eb4f5b3c", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "1dfab661-347b-4710-b2df-358680ec13d8", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c4f531d2-af92-4076-ac17-030e1bfa07f1", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEOxEVEhIvZE/KVEWhTKmsPUF+3QxJe1n+eRRKsHL5vNZedRi68PC4yTQh/7iM4mWqg==", null, false, "eba39d12-cb11-454a-81da-4b68fc4b9f6d", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 15, 11, 58, 481, DateTimeKind.Local).AddTicks(8139), new DateTime(2021, 11, 24, 15, 11, 58, 482, DateTimeKind.Local).AddTicks(6142), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 15, 11, 58, 482, DateTimeKind.Local).AddTicks(6958), new DateTime(2021, 11, 24, 15, 11, 58, 482, DateTimeKind.Local).AddTicks(6963), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 15, 11, 58, 483, DateTimeKind.Local).AddTicks(8290), new DateTime(2021, 11, 24, 15, 11, 58, 483, DateTimeKind.Local).AddTicks(8296), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 15, 11, 58, 483, DateTimeKind.Local).AddTicks(8300), new DateTime(2021, 11, 24, 15, 11, 58, 483, DateTimeKind.Local).AddTicks(8301), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 15, 11, 58, 484, DateTimeKind.Local).AddTicks(1349), new DateTime(2021, 11, 24, 15, 11, 58, 484, DateTimeKind.Local).AddTicks(1354), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 15, 11, 58, 484, DateTimeKind.Local).AddTicks(1357), new DateTime(2021, 11, 24, 15, 11, 58, 484, DateTimeKind.Local).AddTicks(1358), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 24, 15, 11, 58, 484, DateTimeKind.Local).AddTicks(1360), new DateTime(2021, 11, 24, 15, 11, 58, 484, DateTimeKind.Local).AddTicks(1361), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 24, 15, 11, 58, 484, DateTimeKind.Local).AddTicks(1362), new DateTime(2021, 11, 24, 15, 11, 58, 484, DateTimeKind.Local).AddTicks(1363), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
