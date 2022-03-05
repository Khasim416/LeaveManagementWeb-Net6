using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce0ea342-61d0-4cd4-d790-d11210b6acb5",
                column: "ConcurrencyStamp",
                value: "20cc69d5-e679-4a70-8aa1-4d740d5d513c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0ea942-7df0-42c5-9d10-c18919b6a8d7",
                column: "ConcurrencyStamp",
                value: "32276d0a-9883-4bc6-8b2c-7bab04ba285f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9f52f7c-70c5-4830-b39a-44c5e5f297a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bed6da97-6f0b-40b0-9bd0-a138ede43451", "AQAAAAEAACcQAAAAELv26lEKb2jssgjKLAdwi07XbpdRCrOn2RoanzA7S4GokR7BzCXdk2b+Ba8YJqJbBQ==", "7710e7ba-9a77-4458-b8ac-f608d5807718" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee0e28ef-86e5-4091-af27-d7ef29661605",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "810a2dd6-a6e5-45da-ba49-594a6f88a571", "AQAAAAEAACcQAAAAEHagMKL5yRYMERH7CqYOU3Pk59SjfioiN7hIkuC86Bwmmb86Qfy+tdLnrkV1FJLBMQ==", "02c63ad4-bc78-47e9-af6c-ccc7b803ac57" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
