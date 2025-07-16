using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedOpportunityIdtoTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OpportunityId",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreatedAt", "CreationDate", "OpportunityId" },
                values: new object[] { new DateTime(2025, 7, 15, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4462), new DateTime(2025, 6, 30, 6, 58, 13, 812, DateTimeKind.Utc).AddTicks(4453), null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpportunityId",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "d92b683d-02da-41e8-b7d0-a65f1842142e", new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6235), "f9af9263-f159-4eeb-96de-cfa0db02a057" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "81fd8946-3a26-4318-a283-de1f248891bc", new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6507), "b9027412-7d08-4724-8a45-96db6150e7ce" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6789), new DateTime(2025, 7, 3, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6740), new DateTime(2025, 6, 23, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6848), new DateTime(2025, 8, 17, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6846), new DateTime(2025, 7, 18, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6856), new DateTime(2025, 8, 2, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6854), new DateTime(2025, 7, 13, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6861), new DateTime(2025, 7, 28, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6858), new DateTime(2025, 7, 18, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6865), new DateTime(2025, 7, 28, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6864), new DateTime(2025, 7, 18, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 15, 28, 0, 763, DateTimeKind.Utc).AddTicks(6565));
        }
    }
}
