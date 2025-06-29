using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedProf3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "8353d595-46ca-44d7-99bc-1291c4e2b071", new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9058), "d5136643-8d7e-48a9-ba7c-c9aab1f74123" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "373c14f0-931d-4617-b8ed-6885b85be4f3", new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9242), "09706b5d-24f7-4e5c-8926-3c64d96078f2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateNumber", "CreatedAt", "CreatedBy", "FileUrl", "IsDeleted", "IsVerified", "IssueDate", "Issuer", "ParticipationID", "Title", "TotalHours", "VerificationCode", "VolunteerID" },
                values: new object[] { "cert-2", "CERT-2025-001", new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9623), null, null, false, true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded Org", "participation-3", "Coding for Kids Participation", 12.5f, "VERIF123", "vol_prof2" });

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9428), new DateTime(2025, 6, 24, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9399), new DateTime(2025, 6, 14, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9464), new DateTime(2025, 8, 8, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9461), new DateTime(2025, 7, 9, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9468), new DateTime(2025, 7, 24, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9467), new DateTime(2025, 7, 4, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9471), new DateTime(2025, 7, 19, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9470), new DateTime(2025, 7, 9, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 14, 47, 43, DateTimeKind.Utc).AddTicks(9292));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2");

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

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 12, 12, 39, 501, DateTimeKind.Utc).AddTicks(3206));

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
    }
}
