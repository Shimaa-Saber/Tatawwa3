using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVolunteerOpportunityFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Conditions",
                table: "VolunteerOpportunities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderRequirement",
                table: "VolunteerOpportunities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAttendanceTracked",
                table: "VolunteerOpportunities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCertificateAvailable",
                table: "VolunteerOpportunities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalHours",
                table: "VolunteerOpportunities",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "505dbe51-814d-47cf-a17c-e7472ba1b183", new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2355), "1ee6326b-fb88-4de5-9cf1-8d3e1d8c8d0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "d498b845-ca4e-47d8-956f-5b4b57491de2", new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2440), "6e3a82b2-1c6d-4190-9d9a-6db99ab5ee48" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2586), new DateTime(2025, 6, 20, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2559), new DateTime(2025, 6, 10, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "Conditions", "CreatedAt", "EndDate", "GenderRequirement", "IsAttendanceTracked", "IsCertificateAvailable", "StartDate", "TotalHours" },
                values: new object[] { null, new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2618), new DateTime(2025, 8, 4, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2616), null, null, null, new DateTime(2025, 7, 5, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2614), null });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "Conditions", "CreatedAt", "EndDate", "GenderRequirement", "IsAttendanceTracked", "IsCertificateAvailable", "StartDate", "TotalHours" },
                values: new object[] { null, new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2622), new DateTime(2025, 7, 20, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2621), null, null, null, new DateTime(2025, 6, 30, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2620), null });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "Conditions", "CreatedAt", "EndDate", "GenderRequirement", "IsAttendanceTracked", "IsCertificateAvailable", "StartDate", "TotalHours" },
                values: new object[] { null, new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2625), new DateTime(2025, 7, 15, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2624), null, null, null, new DateTime(2025, 7, 5, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2624), null });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2478));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conditions",
                table: "VolunteerOpportunities");

            migrationBuilder.DropColumn(
                name: "GenderRequirement",
                table: "VolunteerOpportunities");

            migrationBuilder.DropColumn(
                name: "IsAttendanceTracked",
                table: "VolunteerOpportunities");

            migrationBuilder.DropColumn(
                name: "IsCertificateAvailable",
                table: "VolunteerOpportunities");

            migrationBuilder.DropColumn(
                name: "TotalHours",
                table: "VolunteerOpportunities");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e225b654-c28f-4f1b-bca8-50d0974ff10d", new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4127), "6f9517c0-ec81-4782-828d-2e58ff6d3333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "325ac72a-2ca7-47e8-83e1-c5387a1344cb", new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4283), "8ab8a428-db39-404e-8b8c-f7f68cca73de" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4436), new DateTime(2025, 6, 20, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4408), new DateTime(2025, 6, 10, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4466), new DateTime(2025, 8, 4, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 7, 5, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4470), new DateTime(2025, 7, 20, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4469), new DateTime(2025, 6, 30, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4473), new DateTime(2025, 7, 15, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4472), new DateTime(2025, 7, 5, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4312));
        }
    }
}
