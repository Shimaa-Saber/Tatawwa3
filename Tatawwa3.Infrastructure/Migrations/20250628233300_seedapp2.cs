using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedapp2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "30a4d7dc-9b40-40c1-a49d-d2dcd00d7db7", new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9008), "244082bf-8b38-45e9-afe5-eb354d2b6e66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "7893be25-dbd4-4304-ad3a-cfbb8391c1f5", new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9203), "bd25a4d0-75ff-4cfc-b95d-5cacfbb0e1fd" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.InsertData(
                table: "Participations",
                columns: new[] { "Id", "ApplicationID", "CreatedAt", "CreatedBy", "FirstCheckIn", "IsDeleted", "LastCheckOut", "OpportunityId", "Status", "TotalAttendedHours", "VolunteerID" },
                values: new object[,]
                {
                    { "participation-1", "app-1", new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9703), null, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "opp-1", 1, 12.5f, "vol-user-1" },
                    { "participation-2", "app-2", new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9707), null, new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "opp-2", 1, 8f, "vol-user-1" }
                });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9484), new DateTime(2025, 6, 23, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9433), new DateTime(2025, 6, 13, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9543), new DateTime(2025, 8, 7, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9540), new DateTime(2025, 7, 8, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9550), new DateTime(2025, 7, 23, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9548), new DateTime(2025, 7, 3, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9555), new DateTime(2025, 7, 18, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9553), new DateTime(2025, 7, 8, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 32, 59, 120, DateTimeKind.Utc).AddTicks(9268));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1");

            migrationBuilder.DeleteData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "b11daa2d-49f4-4817-a191-224d8397ef8a", new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5165), "3b940e77-a1c3-4563-ad70-55c61ba6b497" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "ecffc799-b3cd-453e-8abb-ea5c5cfcd7af", new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5348), "ce2b13ff-c91c-48d8-af69-3895af426d7b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5661), new DateTime(2025, 6, 23, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5628), new DateTime(2025, 6, 13, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5695), new DateTime(2025, 8, 7, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5692), new DateTime(2025, 7, 8, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5699), new DateTime(2025, 7, 23, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5697), new DateTime(2025, 7, 3, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5702), new DateTime(2025, 7, 18, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5701), new DateTime(2025, 7, 8, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5397));
        }
    }
}
