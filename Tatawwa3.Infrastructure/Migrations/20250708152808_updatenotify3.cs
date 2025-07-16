using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatenotify3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NotifyOnNewVolunteerApplication",
                table: "notificationPreferences",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NotifyOnOpportunityCompleted",
                table: "notificationPreferences",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NotifyOnVolunteerApplicationUnderReview",
                table: "notificationPreferences",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotifyOnNewVolunteerApplication",
                table: "notificationPreferences");

            migrationBuilder.DropColumn(
                name: "NotifyOnOpportunityCompleted",
                table: "notificationPreferences");

            migrationBuilder.DropColumn(
                name: "NotifyOnVolunteerApplicationUnderReview",
                table: "notificationPreferences");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "82b33812-9ca6-492f-8521-9f7b7ab70dbc", new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(4907), "ffa80f08-cc07-4f0e-af24-057557942903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "98d2b135-51a6-448d-9d2b-633cf7f104d2", new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5044), "8fa11b1a-639f-4979-b703-90c796b77c6e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5248), new DateTime(2025, 7, 3, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5195), new DateTime(2025, 6, 23, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5326), new DateTime(2025, 8, 17, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5322), new DateTime(2025, 7, 18, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5331), new DateTime(2025, 8, 2, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5330), new DateTime(2025, 7, 13, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5335), new DateTime(2025, 7, 28, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5334), new DateTime(2025, 7, 18, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5341), new DateTime(2025, 7, 28, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5339), new DateTime(2025, 7, 18, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 14, 33, 28, 237, DateTimeKind.Utc).AddTicks(5088));
        }
    }
}
