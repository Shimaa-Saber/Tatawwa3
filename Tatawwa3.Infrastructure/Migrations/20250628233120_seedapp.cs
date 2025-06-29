using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedapp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "ApplicationDate", "AttachmentPath", "CreatedAt", "CreatedBy", "HasRequiredSkills", "IsDeleted", "MotivationLetter", "Note", "OpportunityID", "Status", "VolunteerID" },
                values: new object[,]
                {
                    { "app-1", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5743), null, true, false, "I am passionate about helping children learn.", "Looking forward to this opportunity.", "opp-1", 0, "vol-user-1" },
                    { "app-2", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "attachments/volunteer_cv.pdf", new DateTime(2025, 6, 28, 23, 31, 15, 565, DateTimeKind.Utc).AddTicks(5778), null, true, false, "I have prior experience in similar events.", "Excited to participate.", "opp-2", 1, "vol-user-1" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1");

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "12a7ba91-9c96-4671-8346-da40279ad9a8", new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(2969), "67e75aef-ee45-4376-87e1-b6787dc04999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "675d8e59-8e76-438d-bbc9-e092e12d0c61", new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3155), "14ab0558-19ba-4877-b678-7ed5e6597632" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3572), new DateTime(2025, 6, 23, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 6, 13, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3633), new DateTime(2025, 8, 7, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3630), new DateTime(2025, 7, 8, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3640), new DateTime(2025, 7, 23, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3638), new DateTime(2025, 7, 3, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3646), new DateTime(2025, 7, 18, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3644), new DateTime(2025, 7, 8, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3230));
        }
    }
}
