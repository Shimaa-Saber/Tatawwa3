using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "OrganizationProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "c679f10f-6049-43b5-b4b6-ba6986765a9d", new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(7769), "76a9386c-16fd-4270-87f1-7578c1cc23a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "b13e63df-991a-49f4-851e-a5e091a36043", new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(7893), "a8aaa5f1-a5c7-4366-a3bf-b5cc661176c9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                columns: new[] { "City", "CreatedAt" },
                values: new object[] { "minya", new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8079), new DateTime(2025, 6, 25, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8045), new DateTime(2025, 6, 15, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8116), new DateTime(2025, 8, 9, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8115), new DateTime(2025, 7, 10, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8121), new DateTime(2025, 7, 25, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8119), new DateTime(2025, 7, 5, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8124), new DateTime(2025, 7, 20, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8123), new DateTime(2025, 7, 10, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 15, 23, 10, 322, DateTimeKind.Utc).AddTicks(7936));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "OrganizationProfiles");

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
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 14, 12, 6, 761, DateTimeKind.Utc).AddTicks(6642));

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
    }
}
