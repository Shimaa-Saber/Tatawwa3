using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addOrganizationStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "OrganizationProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "8368406b-5902-47c9-b424-50d012e5275f", new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6584), "e5787dad-f1dd-4b33-9cda-7b952713a5dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "7a617492-4210-4958-9e93-46bde47ec244", new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6689), "8193ae8c-31b8-405b-b385-873f3afc5919" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6642), 0 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6869), new DateTime(2025, 6, 25, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6834), new DateTime(2025, 6, 15, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6903), new DateTime(2025, 8, 9, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6901), new DateTime(2025, 7, 10, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6909), new DateTime(2025, 7, 25, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6907), new DateTime(2025, 7, 5, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6912), new DateTime(2025, 7, 20, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6911), new DateTime(2025, 7, 10, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6736));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "OrganizationProfiles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "d934d0dc-074b-4e86-9976-a3337d386720", new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(8750), "8e36836d-abdf-480c-8018-cd16638b15be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "9ebb0544-92ae-4174-a377-b7e8e9283665", new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(8906), "b633a559-1b40-401e-917d-e176bb55ba49" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9053));

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
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9149), new DateTime(2025, 6, 20, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9103), new DateTime(2025, 6, 10, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9202), new DateTime(2025, 8, 4, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9200), new DateTime(2025, 7, 5, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9207), new DateTime(2025, 7, 20, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9206), new DateTime(2025, 6, 30, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9211), new DateTime(2025, 7, 15, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9210), new DateTime(2025, 7, 5, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(8977));
        }
    }
}
