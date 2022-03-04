using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce0ea342-61d0-4cd4-d790-d11210b6acb5",
                column: "ConcurrencyStamp",
                value: "f41a14ac-fcbe-492e-bcf5-8a0856317499");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0ea942-7df0-42c5-9d10-c18919b6a8d7",
                column: "ConcurrencyStamp",
                value: "e5b62238-7c90-4464-9bb4-49865fb816e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9f52f7c-70c5-4830-b39a-44c5e5f297a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9063d0c-8a84-4160-baf5-3349f37f3430", "AQAAAAEAACcQAAAAEO2nIHqCCIMol42zk/roLx/d6R0aK+4ECjpLY1OtACQd72OjdxGctbG1k5kmdVU2Ng==", "fd91e3fa-bcfa-4eac-8698-decd1438a0fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee0e28ef-86e5-4091-af27-d7ef29661605",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db4b8eb7-4757-40de-9f3c-3db3a16720ad", "AQAAAAEAACcQAAAAEFI3MauOQ/nONxi2kyC0vP2ft3oMp3L76OFPnnLPV3hfg+4TsabZXR4hsYRROGlktQ==", "eba4de9c-74c9-4b72-8745-fd7f5f45cbba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
    }
}
