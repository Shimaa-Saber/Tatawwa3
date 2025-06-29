using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOrganizationTypeToOrganizationProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationType",
                table: "OrganizationProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "6a018c38-611a-461b-ad62-f07588d9b295", new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9330), "9d7e09ab-481e-40b0-bd22-398b6dc1da38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "44690e69-a7de-4b8c-9322-8d7cdf70de0c", new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9472), "94227e5b-6a2f-435e-8813-edf56e4f7efb" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                columns: new[] { "CreatedAt", "OrganizationType" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9411), 0 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9668), new DateTime(2025, 6, 24, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9630), new DateTime(2025, 6, 14, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9713), new DateTime(2025, 8, 8, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9709), new DateTime(2025, 7, 9, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9719), new DateTime(2025, 7, 24, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9717), new DateTime(2025, 7, 4, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9724), new DateTime(2025, 7, 19, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9723), new DateTime(2025, 7, 9, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9513));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrganizationType",
                table: "OrganizationProfiles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "031f0faf-42c1-47fd-be0f-df9b7e3bea83", new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9153), "c5cb0601-3171-4407-aa3a-e4a45f8284bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "2c6a41ca-0459-4bf6-ae39-cb1a97bb4700", new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9325), "bb2219d3-80b9-4b81-9244-f9fc1dbb9685" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9603), new DateTime(2025, 6, 22, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 6, 12, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9669), new DateTime(2025, 8, 6, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9667), new DateTime(2025, 7, 7, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9675), new DateTime(2025, 7, 22, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9674), new DateTime(2025, 7, 2, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9680), new DateTime(2025, 7, 17, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9679), new DateTime(2025, 7, 7, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9413));
        }
    }
}
