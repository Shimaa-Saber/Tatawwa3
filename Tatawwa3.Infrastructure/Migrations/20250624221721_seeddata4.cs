using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "JoinDate", "Role", "TeamID", "VolunteerID" },
                values: new object[] { "member-1", new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7437), null, false, new DateTime(2025, 6, 19, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7435), "Leader", "team-1", "vol-user-1" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7388), new DateTime(2025, 6, 9, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.InsertData(
                table: "VolunteerOpportunities",
                columns: new[] { "Id", "CategoryID", "CreatedAt", "CreatedBy", "Description", "EndDate", "Image", "IsDeleted", "Location", "OrganizationID", "RequiredVolunteers", "StartDate", "Status", "TeamId", "Title" },
                values: new object[,]
                {
                    { "opp-1", "cat-edu-1", new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7484), null, "Help young children learn basic English skills.", new DateTime(2025, 8, 3, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7482), "english-teaching.png", false, "Cairo", "org-profile-1", 10, new DateTime(2025, 7, 4, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7480), 1, null, "Teaching Kids English" },
                    { "opp-2", "cat-edu-1", new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7490), null, "Lead a reading club for teenagers.", new DateTime(2025, 7, 19, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7489), "reading-club.png", false, "Assiut", "org-profile-1", 5, new DateTime(2025, 6, 29, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7488), 1, null, "Reading Club Facilitator" },
                    { "opp-3", "cat-edu-1", new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7495), null, "Teach basic coding to children in underserved communities.", new DateTime(2025, 7, 14, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7494), "coding-kids.png", false, "Jeddah", "org-profile-1", 15, new DateTime(2025, 7, 4, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7493), 1, "team-1", "Coding for Kids" }
                });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 17, 20, 434, DateTimeKind.Utc).AddTicks(7277));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1");

            migrationBuilder.DeleteData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1");

            migrationBuilder.DeleteData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2");

            migrationBuilder.DeleteData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "20cc133c-ba14-4660-8757-b3d925079057", new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2182), "14ce9f06-2817-4f9a-a557-aa3d7dd8158c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "bf4e27cb-9009-4abe-be3c-1d52c36dc8f2", new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2274), "8ef97538-e430-4101-9d53-8380e016d43e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2385), new DateTime(2025, 6, 9, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2305));
        }
    }
}
