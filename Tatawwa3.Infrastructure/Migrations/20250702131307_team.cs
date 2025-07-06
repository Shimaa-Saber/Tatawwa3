using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class team : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1");

            migrationBuilder.AddColumn<string>(
                name: "TeamGoals",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CategoryId", "City", "CreatedAt", "CreatedBy", "CreationDate", "Description", "InternalNotes", "IsDeleted", "IsLinkedToOpportunity", "JoinPermission", "MaxMembers", "Name", "OrganizationID", "Status", "TeamGoals" },
                values: new object[] { "team-001", "cat-edu-1", "Cairo", new DateTime(2025, 7, 2, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8126), null, new DateTime(2025, 6, 17, 13, 13, 3, 392, DateTimeKind.Utc).AddTicks(8115), "Team responsible for organizing educational initiatives.", "Priority team for large campaigns", false, true, 0, 20, "Education Support Team", "org-profile-1", 1, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001");

            migrationBuilder.DropColumn(
                name: "TeamGoals",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "0d23736a-9b40-4736-965e-ba614361f933", new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(5438), "ce8ea409-409e-42ff-8922-c9df47dc1680" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "55e3a499-cec6-4d40-a57e-4dc35619c902", new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(5691), "66f2851d-bf1e-4eb4-bbe2-77295d6edee5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6293), new DateTime(2025, 6, 27, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CategoryId", "City", "CreatedAt", "CreatedBy", "CreationDate", "Description", "InternalNotes", "IsDeleted", "IsLinkedToOpportunity", "JoinPermission", "MaxMembers", "Name", "OrganizationID", "Status" },
                values: new object[] { "team-1", "cat-edu-1", "Cairo", new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6191), null, new DateTime(2025, 6, 17, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6180), "Team responsible for organizing educational initiatives.", "Priority team for large campaigns", false, true, 0, 20, "Education Support Team", "org-profile-1", 1 });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6561), new DateTime(2025, 8, 11, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6558), new DateTime(2025, 7, 12, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6580), new DateTime(2025, 7, 27, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6567), new DateTime(2025, 7, 7, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6589), new DateTime(2025, 7, 22, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6587), new DateTime(2025, 7, 12, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6598), new DateTime(2025, 7, 22, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6596), new DateTime(2025, 7, 12, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(5816));
        }
    }
}
