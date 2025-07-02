using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class att : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Attendances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "cf4ed1c2-83bc-40f3-961a-6bc1f64e4203", new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2509), "5d143d51-ea0e-4b73-b121-57bfe44eeabe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "00a703f3-671e-46c8-a8a7-d5bc0b75989f", new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2642), "1d6b8ecb-97f1-4baf-be31-be0253937452" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2896), new DateTime(2025, 6, 26, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2864), new DateTime(2025, 6, 16, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2937), new DateTime(2025, 8, 10, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2933), new DateTime(2025, 7, 11, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2942), new DateTime(2025, 7, 26, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2940), new DateTime(2025, 7, 6, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2946), new DateTime(2025, 7, 21, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2945), new DateTime(2025, 7, 11, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2950), new DateTime(2025, 7, 21, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2949), new DateTime(2025, 7, 11, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 21, 25, 56, 97, DateTimeKind.Utc).AddTicks(2688));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Attendances");

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
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 23, 26, 612, DateTimeKind.Utc).AddTicks(4574));

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
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4197), new DateTime(2025, 7, 20, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4197), new DateTime(2025, 7, 10, 15, 0, 42, 549, DateTimeKind.Utc).AddTicks(4196) });

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
