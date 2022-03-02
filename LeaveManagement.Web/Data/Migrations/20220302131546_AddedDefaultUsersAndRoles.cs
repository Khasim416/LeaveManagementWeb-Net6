using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ce0ea342-61d0-4cd4-d790-d11210b6acb5", "b11e140c-cb65-4e2b-b721-9604c468087a", "Administrator", "ADMINISTRATOR" },
                    { "cf0ea942-7df0-42c5-9d10-c18919b6a8d7", "410d8c50-9d8b-4e7c-aecb-7e07cc44c301", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ee0e28ef-86e5-4091-af27-d7ef29661605", 0, "e2e58342-5b9d-4d53-b677-0369e46ca0a9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFaUMyVTsM9F4Ha7zcJT09Rhfl5Z7fGKZaxAhaAIrmSRNjcQDZDQyBKx+bIzKMGA3Q==", null, false, "c62da4fd-2c05-42b2-b02d-f792b07345d3", null, false, "admin@localhost.com" },
                    { "c9f52f7c-70c5-4830-b39a-44c5e5f297a1", 0, "3bfceac9-d9e3-4cab-8907-7f3e63dafa6a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKOP1Be//2WlrTXklOJ7ElDFXrJhmryQun7dOiLXxbpWNV9MxUAMNsqHHzj+7Fol5A==", null, false, "d331b92e-9497-47df-b523-44edf88f10dc", null, false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ce0ea342-61d0-4cd4-d790-d11210b6acb5", "ee0e28ef-86e5-4091-af27-d7ef29661605" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cf0ea942-7df0-42c5-9d10-c18919b6a8d7", "c9f52f7c-70c5-4830-b39a-44c5e5f297a1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf0ea942-7df0-42c5-9d10-c18919b6a8d7", "c9f52f7c-70c5-4830-b39a-44c5e5f297a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce0ea342-61d0-4cd4-d790-d11210b6acb5", "ee0e28ef-86e5-4091-af27-d7ef29661605" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce0ea342-61d0-4cd4-d790-d11210b6acb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0ea942-7df0-42c5-9d10-c18919b6a8d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9f52f7c-70c5-4830-b39a-44c5e5f297a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee0e28ef-86e5-4091-af27-d7ef29661605");
        }
    }
}
