using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedIsBanned : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBanned",
                table: "OrganizationProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedAt", "IsBanned" },
                values: new object[] { new DateTime(2025, 7, 15, 7, 14, 18, 684, DateTimeKind.Utc).AddTicks(7207), false });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBanned",
                table: "OrganizationProfiles");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "822243dd-5b07-434e-b0bb-47170187fc81", new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4176), "ec32e818-717a-4506-b01e-8200d44a367b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "627040fa-8519-4d49-978b-11adc0a5cfdb", new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4306), "3bb58de2-bb62-4319-b739-579c341083f1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4501), new DateTime(2025, 7, 10, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4462), new DateTime(2025, 6, 30, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4541), new DateTime(2025, 8, 24, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4539), new DateTime(2025, 7, 25, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4548), new DateTime(2025, 8, 9, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 7, 20, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4551), new DateTime(2025, 8, 4, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4550), new DateTime(2025, 7, 25, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4555), new DateTime(2025, 8, 4, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4554), new DateTime(2025, 7, 25, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4352));
        }
    }
}
