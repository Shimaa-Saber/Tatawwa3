using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateOrg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "OrganizationProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "OrganizationProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "OrganizationProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "OrganizationProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebsiteUrl",
                table: "OrganizationProfiles",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreatedAt", "Description", "Email", "PhoneNumber", "ProfileImage", "WebsiteUrl" },
                values: new object[] { new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(5574), null, null, null, null, null });

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

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 2, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6191), new DateTime(2025, 6, 17, 1, 0, 15, 892, DateTimeKind.Utc).AddTicks(6180) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "OrganizationProfiles");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "OrganizationProfiles");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "OrganizationProfiles");

            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "OrganizationProfiles");

            migrationBuilder.DropColumn(
                name: "WebsiteUrl",
                table: "OrganizationProfiles");

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
    }
}
