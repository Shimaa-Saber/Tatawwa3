using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Finally : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Applications");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "dcef0f0d-c6fe-4b3d-a8e7-a7265706a484", new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7417), "b256a6e2-a621-4883-a8f8-ea160e748036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "bb0f1384-c128-4354-9c54-c3218ed2e807", new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7658), "dc273ddf-3f85-477b-a580-c57a3291b271" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8163), new DateTime(2025, 6, 22, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7995), new DateTime(2025, 6, 12, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 8, 6, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8265), new DateTime(2025, 7, 7, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 7, 22, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 7, 2, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 7, 17, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 7, 7, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7763));
        }
    }
}
