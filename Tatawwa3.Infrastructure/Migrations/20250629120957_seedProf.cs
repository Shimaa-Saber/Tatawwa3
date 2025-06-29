using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedProf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "ApplicationDate", "AttachmentPath", "CreatedAt", "CreatedBy", "HasRequiredSkills", "IsDeleted", "MotivationLetter", "Note", "OpportunityID", "Status", "VolunteerID" },
                values: new object[] { "app-3", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "attachments/volunteer_cv.pdf", new DateTime(2025, 6, 29, 12, 9, 56, 925, DateTimeKind.Utc).AddTicks(9102), null, true, false, "I have prior experience in similar events.", "Excited to participate.", "opp-1", 0, "vol_prof2" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "f52b3658-d4f7-4168-80eb-6964d1358514", new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7496), "8b8dc063-8ae0-400a-a7c5-28559dc5dcba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "3868508a-cb6b-4547-8af5-f0536ffae46a", new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7627), "f9da78fd-9f15-4257-9a0d-438c1c52acd0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7812), new DateTime(2025, 6, 23, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7777), new DateTime(2025, 6, 13, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7851), new DateTime(2025, 8, 7, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7847), new DateTime(2025, 7, 8, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7855), new DateTime(2025, 7, 23, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7854), new DateTime(2025, 7, 3, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7858), new DateTime(2025, 7, 18, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7857), new DateTime(2025, 7, 8, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(7667));
        }
    }
}
