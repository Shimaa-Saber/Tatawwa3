using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeactivationRequestedToOrganization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeactivationRequested",
                table: "OrganizationProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "2f46d2e1-3fbe-466c-ac0a-88ecb8051f4d", new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1049), "61356e4d-1afd-4698-9dc8-ae4f07cc941a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "70767ea5-3112-4335-94ec-37823fd71693", new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1133), "6c76d44b-d085-4583-86ec-9ca120a9f859" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                columns: new[] { "CreatedAt", "IsDeactivationRequested" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1095), false });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1298), new DateTime(2025, 6, 24, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1277), new DateTime(2025, 6, 14, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1323), new DateTime(2025, 8, 8, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1319), new DateTime(2025, 7, 9, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1326), new DateTime(2025, 7, 24, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1325), new DateTime(2025, 7, 4, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1328), new DateTime(2025, 7, 19, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1328), new DateTime(2025, 7, 9, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1209));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeactivationRequested",
                table: "OrganizationProfiles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "6a018c38-611a-461b-ad62-f07588d9b295", new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9330), "9d7e09ab-481e-40b0-bd22-398b6dc1da38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "44690e69-a7de-4b8c-9322-8d7cdf70de0c", new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9472), "94227e5b-6a2f-435e-8813-edf56e4f7efb" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9668), new DateTime(2025, 6, 24, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9630), new DateTime(2025, 6, 14, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9713), new DateTime(2025, 8, 8, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9709), new DateTime(2025, 7, 9, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9719), new DateTime(2025, 7, 24, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9717), new DateTime(2025, 7, 4, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9724), new DateTime(2025, 7, 19, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9723), new DateTime(2025, 7, 9, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 8, 27, 631, DateTimeKind.Utc).AddTicks(9513));
        }
    }
}
