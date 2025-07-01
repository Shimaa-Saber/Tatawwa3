using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class profimg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureUrl",
                table: "VolunteerProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureUrl",
                table: "OrganizationProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e5375162-10cb-4ed1-a08d-ca7c70607dee", new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(3923), "548a3f13-a96a-4e8c-a67c-7907a7bb21e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "b953e29c-b75f-41c4-b232-e046d3079d0a", new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4022), "d24488ed-ea5a-46dd-af87-17a360cef12d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                columns: new[] { "CreatedAt", "ProfilePictureUrl" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(3979), null });

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4160), new DateTime(2025, 6, 25, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4133), new DateTime(2025, 6, 15, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4187), new DateTime(2025, 8, 9, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4184), new DateTime(2025, 7, 10, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4191), new DateTime(2025, 7, 25, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4190), new DateTime(2025, 7, 5, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4194), new DateTime(2025, 7, 20, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4193), new DateTime(2025, 7, 10, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4197), new DateTime(2025, 7, 20, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4197), new DateTime(2025, 7, 10, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                columns: new[] { "CreatedAt", "ProfilePictureUrl" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4074), null });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "CreatedAt", "ProfilePictureUrl" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4050), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictureUrl",
                table: "VolunteerProfiles");

            migrationBuilder.DropColumn(
                name: "ProfilePictureUrl",
                table: "OrganizationProfiles");

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

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4876));

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
    }
}
