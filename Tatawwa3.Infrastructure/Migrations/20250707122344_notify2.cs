using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class notify2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvitationId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "29232997-eaf9-4590-8ad2-ebfcf5209512", new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4170), "8efd0071-8370-4243-8944-1641c56da886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "5eae2273-3445-4240-8efc-29b395cf3807", new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4443), "8a420ba4-fa31-4886-b70c-31ca4c27f8d5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4991), new DateTime(2025, 7, 2, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4873), new DateTime(2025, 6, 22, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5103), new DateTime(2025, 8, 16, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5100), new DateTime(2025, 7, 17, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 8, 1, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5110), new DateTime(2025, 7, 12, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5122), new DateTime(2025, 7, 27, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5119), new DateTime(2025, 7, 17, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5131), new DateTime(2025, 7, 27, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5128), new DateTime(2025, 7, 17, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4555));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvitationId",
                table: "Notifications");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "b84ac27a-3a5a-450e-941d-4d8354f1c28c", new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(3678), "b1646262-ad4a-44bc-a7ae-db36c3c9ab24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "f9ebcac4-b9c8-4418-92ab-f9c5822217ae", new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4067), "82e811f1-e04e-4113-a5c9-512dfcf0568b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4493), new DateTime(2025, 6, 29, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4383), new DateTime(2025, 6, 19, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4642), new DateTime(2025, 8, 13, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4617), new DateTime(2025, 7, 14, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4662), new DateTime(2025, 7, 29, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4649), new DateTime(2025, 7, 9, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4672), new DateTime(2025, 7, 24, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4668), new DateTime(2025, 7, 14, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4689), new DateTime(2025, 7, 24, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 7, 14, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4129));
        }
    }
}
