using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class skills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "59cb2c8f-36dc-479f-aec0-9606af95bd45", new DateTime(2025, 7, 3, 0, 6, 47, 854, DateTimeKind.Utc).AddTicks(9913), "eeca5370-c385-4f86-a209-a88721ca8b58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "024b0a15-1a66-44e5-8d18-f770465264e7", new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(167), "d5f88cd7-5f6e-4bef-a56b-8db49e8a23d9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(437), new DateTime(2025, 6, 28, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 6, 18, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(510), new DateTime(2025, 8, 12, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(507), new DateTime(2025, 7, 13, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(515), new DateTime(2025, 7, 28, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(513), new DateTime(2025, 7, 8, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(518), new DateTime(2025, 7, 23, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(517), new DateTime(2025, 7, 13, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(523), new DateTime(2025, 7, 23, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(521), new DateTime(2025, 7, 13, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(246));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "470fdeb0-4e26-4213-a112-d02e52d6125d", new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(7532), "e71f0159-200c-4fb2-94fb-d8ce2bd7f807" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "b10aec8a-92ef-47f2-b0ea-a175e0601be3", new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(7772), "836670c1-71dc-4cf8-a25e-ccd74d2359c9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8295), new DateTime(2025, 6, 27, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8126), new DateTime(2025, 6, 17, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8390), new DateTime(2025, 8, 11, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8387), new DateTime(2025, 7, 12, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 7, 27, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8395), new DateTime(2025, 7, 7, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8406), new DateTime(2025, 7, 22, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8404), new DateTime(2025, 7, 12, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8414), new DateTime(2025, 7, 22, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8411), new DateTime(2025, 7, 12, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(7875));
        }
    }
}
