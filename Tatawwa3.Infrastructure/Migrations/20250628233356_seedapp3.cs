using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedapp3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateNumber", "CreatedAt", "CreatedBy", "FileUrl", "IsDeleted", "IsVerified", "IssueDate", "Issuer", "ParticipationID", "Title", "TotalHours", "VerificationCode", "VolunteerID" },
                values: new object[] { "cert-1", "CERT-2025-001", new DateTime(2025, 6, 28, 23, 33, 55, 772, DateTimeKind.Utc).AddTicks(8105), null, null, false, true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded Org", "participation-1", "Coding for Kids Participation", 12.5f, "VERIF123", "vol-user-1" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "30a4d7dc-9b40-40c1-a49d-d2dcd00d7db7", new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9008), "244082bf-8b38-45e9-afe5-eb354d2b6e66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "7893be25-dbd4-4304-ad3a-cfbb8391c1f5", new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9203), "bd25a4d0-75ff-4cfc-b95d-5cacfbb0e1fd" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9484), new DateTime(2025, 6, 23, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9433), new DateTime(2025, 6, 13, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9543), new DateTime(2025, 8, 7, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9540), new DateTime(2025, 7, 8, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9550), new DateTime(2025, 7, 23, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9548), new DateTime(2025, 7, 3, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9555), new DateTime(2025, 7, 18, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9553), new DateTime(2025, 7, 8, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9268));
        }
    }
}
