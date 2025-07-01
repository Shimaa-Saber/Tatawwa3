using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedProf2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e759800d-bfa9-499d-8450-d7138febe714", new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(2590), "331d9e3a-0375-4d83-abab-514260214711" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "136c6545-7f80-4372-952e-5901f286ad5d", new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(2818), "9be1314d-6a19-4fc0-8c19-74c94ecedb16" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.InsertData(
                table: "Participations",
                columns: new[] { "Id", "ApplicationID", "CreatedAt", "CreatedBy", "FirstCheckIn", "IsDeleted", "LastCheckOut", "OpportunityId", "Status", "TotalAttendedHours", "VolunteerID" },
                values: new object[] { "participation-3", "app-3", new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3206), null, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "opp-1", 1, 12.5f, "vol_prof2" });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3035), new DateTime(2025, 6, 24, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(2993), new DateTime(2025, 6, 14, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3083), new DateTime(2025, 8, 8, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3080), new DateTime(2025, 7, 9, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3090), new DateTime(2025, 7, 24, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3088), new DateTime(2025, 7, 4, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3094), new DateTime(2025, 7, 19, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3093), new DateTime(2025, 7, 9, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(2866));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "47b17d9e-f396-49d3-aba6-f0b91ef56c97", new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(8728), "eb50a438-7a65-4ba3-a032-354c6558a54f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "0d7a74b3-3a7a-427c-a26f-f0d330717981", new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(8832), "b1cf360a-b690-4df5-84aa-d22b1a5011b0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9013), new DateTime(2025, 6, 24, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(8982), new DateTime(2025, 6, 14, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9046), new DateTime(2025, 8, 8, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 7, 9, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9050), new DateTime(2025, 7, 24, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9049), new DateTime(2025, 7, 4, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9053), new DateTime(2025, 7, 19, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9052), new DateTime(2025, 7, 9, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(8881));
        }
    }
}
