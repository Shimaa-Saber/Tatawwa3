using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.InsertData(
                table: "VolunteerProfiles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Interests", "IsDeleted", "IsVerified", "Rating", "Skills", "TotalHours", "UserID" },
                values: new object[] { "vol_prof2", new DateTime(2025, 6, 25, 0, 0, 16, 144, DateTimeKind.Utc).AddTicks(4338), null, "[\"Education\",\"Health\"]", false, false, 0f, null, 0f, "1b5b5731-bcf1-4178-87ad-cf43dac0bbeb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "dd0c3a66-224f-4c3a-8d5e-aab06bf2ec6f", new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7009), "9c1c3624-093b-4145-8b78-b42966da1600" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "fa6ec67d-ef3c-487a-af05-6e96dadd3d20", new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7223), "b1a88251-4dc2-4988-b13e-0a2ac3e44354" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7437), new DateTime(2025, 6, 19, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7388), new DateTime(2025, 6, 9, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7484), new DateTime(2025, 8, 3, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7482), new DateTime(2025, 7, 4, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7490), new DateTime(2025, 7, 19, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7489), new DateTime(2025, 6, 29, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7495), new DateTime(2025, 7, 14, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7494), new DateTime(2025, 7, 4, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7277));
        }
    }
}
