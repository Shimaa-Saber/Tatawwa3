using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class VPAddedban : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBanned",
                table: "VolunteerProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedAt", "IsBanned" },
                values: new object[] { new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2068), false });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "CreatedAt", "IsBanned" },
                values: new object[] { new DateTime(2025, 7, 15, 14, 55, 3, 96, DateTimeKind.Utc).AddTicks(2039), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBanned",
                table: "VolunteerProfiles");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "52256419-352f-49c0-a984-aca4ddeea847", new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7109), "bd055fcf-f33a-4922-82d4-67a72b50c8a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "54e6a500-04ab-4bf6-9a03-7d1176c42c08", new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7256), "de05342d-8305-4fd5-a2bf-08edf4cd7f32" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7457), new DateTime(2025, 7, 10, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7415), new DateTime(2025, 6, 30, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7498), new DateTime(2025, 8, 24, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7494), new DateTime(2025, 7, 25, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7505), new DateTime(2025, 8, 9, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7503), new DateTime(2025, 7, 20, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7510), new DateTime(2025, 8, 4, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7508), new DateTime(2025, 7, 25, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7515), new DateTime(2025, 8, 4, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7514), new DateTime(2025, 7, 25, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7300));
        }
    }
}
