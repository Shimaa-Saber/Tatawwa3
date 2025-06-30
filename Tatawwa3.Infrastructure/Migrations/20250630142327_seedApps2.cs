using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedApps2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "cc193b6f-bb84-413b-a42f-b379f4b3ec54", new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4474), "8f11fae9-00a3-4ee3-8ab7-e3e6cc11e3b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "a5f82b94-abdd-4127-afc5-dc849034a017", new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4607), "6fb47727-1d80-411e-924a-c163ddbb7047" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.InsertData(
                table: "Participations",
                columns: new[] { "Id", "ApplicationID", "CreatedAt", "CreatedBy", "FirstCheckIn", "IsDeleted", "LastCheckOut", "OpportunityId", "Status", "TotalAttendedHours", "VolunteerID" },
                values: new object[] { "participation-4", "app-4", new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4876), null, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "opp-4", 1, 12.5f, "vol_prof2" });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4751), new DateTime(2025, 6, 25, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4724), new DateTime(2025, 6, 15, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4780), new DateTime(2025, 8, 9, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4777), new DateTime(2025, 7, 10, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4787), new DateTime(2025, 7, 25, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4784), new DateTime(2025, 7, 5, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4792), new DateTime(2025, 7, 20, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 7, 10, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4796), new DateTime(2025, 7, 20, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4795), new DateTime(2025, 7, 10, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4639));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4");

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

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(5367));

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
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4988), new DateTime(2025, 7, 20, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4986), new DateTime(2025, 7, 10, 14, 22, 2, 315, DateTimeKind.Utc).AddTicks(4982) });

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
    }
}
