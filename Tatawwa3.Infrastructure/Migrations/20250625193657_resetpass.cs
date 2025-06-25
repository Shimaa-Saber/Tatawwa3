using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class resetpass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "passwordResetTokens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passwordResetTokens", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "b34ff47e-a61f-4673-aded-960390ea3b52", new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(2632), "10237ccf-8f58-4337-be18-5eb6c05080e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "26d4b23b-1ac0-40a0-88e6-08b2aae8e297", new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(2893), "b8d35282-d4b8-4461-81f1-6dbe1058f5e0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3340), new DateTime(2025, 6, 20, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3233), new DateTime(2025, 6, 10, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3554), new DateTime(2025, 8, 4, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3552), new DateTime(2025, 7, 5, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3559), new DateTime(2025, 7, 20, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3558), new DateTime(2025, 6, 30, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3564), new DateTime(2025, 7, 15, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3563), new DateTime(2025, 7, 5, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3010));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "passwordResetTokens");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e225b654-c28f-4f1b-bca8-50d0974ff10d", new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4127), "6f9517c0-ec81-4782-828d-2e58ff6d3333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "325ac72a-2ca7-47e8-83e1-c5387a1344cb", new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4283), "8ab8a428-db39-404e-8b8c-f7f68cca73de" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4436), new DateTime(2025, 6, 20, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4408), new DateTime(2025, 6, 10, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4466), new DateTime(2025, 8, 4, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 7, 5, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4470), new DateTime(2025, 7, 20, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4469), new DateTime(2025, 6, 30, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4473), new DateTime(2025, 7, 15, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 7, 5, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4312));
        }
    }
}
