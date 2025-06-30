using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedApps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "ApplicationDate", "AttachmentPath", "CreatedAt", "CreatedBy", "HasRequiredSkills", "IsDeleted", "MotivationLetter", "Note", "OpportunityID", "Status", "VolunteerID" },
                values: new object[] { "app-4", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "attachments/volunteer_cv.pdf", new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5367), null, true, false, "I have prior experience in similar events.", "Excited to participate.", "opp-4", 0, "vol_prof2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "b9b3a80b-0600-4838-ba0b-20acb625ea5d", new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(3229), "34c496f9-fd4e-4b11-aeea-a4efbcca6a0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "2d714435-f1d2-4f76-9dfd-b60e756cc8c4", new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(3455), "df35b4bf-6607-4b2e-b2ac-59642fd77190" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4744), new DateTime(2025, 6, 25, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4666), new DateTime(2025, 6, 15, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4870), new DateTime(2025, 8, 9, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4867), new DateTime(2025, 7, 10, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4876), new DateTime(2025, 7, 25, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4874), new DateTime(2025, 7, 5, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4973), new DateTime(2025, 7, 20, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4879), new DateTime(2025, 7, 10, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CategoryID", "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { "cat-edu-1", new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4988), new DateTime(2025, 7, 20, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4986), new DateTime(2025, 7, 10, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(3596));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "125e92c3-d900-461d-b478-51048f57e0ab", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(650), "8b87a86e-a1b3-4fe3-b194-b673cfaf53e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "5cadcef8-4cf5-4473-b1fd-ca9c257af39d", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(748), "4f61e4db-2adf-4a81-a48c-5d7ea17d60b4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(937), new DateTime(2025, 6, 25, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(901), new DateTime(2025, 6, 15, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(972), new DateTime(2025, 8, 9, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(970), new DateTime(2025, 7, 10, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(977), new DateTime(2025, 7, 25, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(976), new DateTime(2025, 7, 5, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1024), new DateTime(2025, 7, 20, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1023), new DateTime(2025, 7, 10, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CategoryID", "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { "cat-1", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1028), new DateTime(2025, 7, 20, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1027), new DateTime(2025, 7, 10, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(794));
        }
    }
}
