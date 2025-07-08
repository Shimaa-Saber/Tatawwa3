using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatenotify2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_notificationPreferences_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_notificationPreferences_UserId",
                table: "notificationPreferences",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_notificationPreferences_UserId",
                table: "notificationPreferences");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "400c9f53-cefb-4eec-968e-57d800a15b46", new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8031), "d4bcc96a-f24b-4821-842a-46d34187c11f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "97cf741e-9cff-4a0f-a184-651f8157e576", new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8126), "67eb628f-0b4d-49f4-ae12-3babd4f3041d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 7, 3, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8246), new DateTime(2025, 6, 23, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8305), new DateTime(2025, 8, 17, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8303), new DateTime(2025, 7, 18, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8309), new DateTime(2025, 8, 2, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8308), new DateTime(2025, 7, 13, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8313), new DateTime(2025, 7, 28, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8312), new DateTime(2025, 7, 18, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8317), new DateTime(2025, 7, 28, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8316), new DateTime(2025, 7, 18, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.CreateIndex(
                name: "IX_notificationPreferences_UserId",
                table: "notificationPreferences",
                column: "UserId");
        }
    }
}
