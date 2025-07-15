using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTeamMemberStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "TeamMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "7f343432-3f52-4a69-9b32-f62e7019d239", new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7277), "08fea98e-b844-4c94-8c3a-94703f3c164a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "3200f6bb-5d99-447a-99c3-31bd20396d54", new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7520), "cdd8206e-0ea5-48e2-a5db-71631990794b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate", "Status" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7765), new DateTime(2025, 7, 10, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7763), 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7714), new DateTime(2025, 6, 30, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7814), new DateTime(2025, 8, 24, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7812), new DateTime(2025, 7, 25, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7822), new DateTime(2025, 8, 9, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 7, 20, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7826), new DateTime(2025, 8, 4, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7825), new DateTime(2025, 7, 25, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7830), new DateTime(2025, 8, 4, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7829), new DateTime(2025, 7, 25, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7579));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TeamMembers");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e629c2dd-4e03-4c10-945b-6b74b10b69dd", new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(1887), "b09dcabd-6c66-4aa6-b19e-1b9d757890bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "ff955e6a-081a-4d2c-9519-d10fa26b6e41", new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2003), "066b7dbe-6c35-4c28-bf10-4a557a977e3b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2175), new DateTime(2025, 7, 10, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2139), new DateTime(2025, 6, 30, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2210), new DateTime(2025, 8, 24, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2208), new DateTime(2025, 7, 25, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2215), new DateTime(2025, 8, 9, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2213), new DateTime(2025, 7, 20, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2218), new DateTime(2025, 8, 4, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2217), new DateTime(2025, 7, 25, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2222), new DateTime(2025, 8, 4, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2221), new DateTime(2025, 7, 25, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2039));
        }
    }
}
