using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce0ea342-61d0-4cd4-d790-d11210b6acb5",
                column: "ConcurrencyStamp",
                value: "db6b8343-9aa5-4dd5-b309-4f3efbb4388d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0ea942-7df0-42c5-9d10-c18919b6a8d7",
                column: "ConcurrencyStamp",
                value: "dcd98301-8fc2-4f41-be87-7b38204312f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9f52f7c-70c5-4830-b39a-44c5e5f297a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddb83509-6a3c-4a7b-8290-0bcecc7ce493", "AQAAAAEAACcQAAAAELqDdL2h1Ag13VF7b0DoCRSYBf5mJ6xnUv3yFc51yAQk4VME0SjfJjVV+/MGJQjq1Q==", "03f088ee-a4dc-41c9-8e74-65e8b0afb35a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee0e28ef-86e5-4091-af27-d7ef29661605",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d02cdc9c-b278-42e8-8342-aa5809fcd7df", "AQAAAAEAACcQAAAAEOeDqvFRVvOtC8/zUW5aE5M6Lz7Gitzv4TheUJf5aEp1R2Nns8BDQXDbgDSEIF/GFw==", "730bf1bd-e33b-4774-9fb1-413e360e6a86" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce0ea342-61d0-4cd4-d790-d11210b6acb5",
                column: "ConcurrencyStamp",
                value: "b11e140c-cb65-4e2b-b721-9604c468087a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0ea942-7df0-42c5-9d10-c18919b6a8d7",
                column: "ConcurrencyStamp",
                value: "410d8c50-9d8b-4e7c-aecb-7e07cc44c301");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9f52f7c-70c5-4830-b39a-44c5e5f297a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bfceac9-d9e3-4cab-8907-7f3e63dafa6a", "AQAAAAEAACcQAAAAEKOP1Be//2WlrTXklOJ7ElDFXrJhmryQun7dOiLXxbpWNV9MxUAMNsqHHzj+7Fol5A==", "d331b92e-9497-47df-b523-44edf88f10dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee0e28ef-86e5-4091-af27-d7ef29661605",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2e58342-5b9d-4d53-b677-0369e46ca0a9", "AQAAAAEAACcQAAAAEFaUMyVTsM9F4Ha7zcJT09Rhfl5Z7fGKZaxAhaAIrmSRNjcQDZDQyBKx+bIzKMGA3Q==", "c62da4fd-2c05-42b2-b02d-f792b07345d3" });
        }
    }
}
