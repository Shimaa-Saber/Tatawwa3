using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VolunteerID",
                table: "Participations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "2a1232e1-9d05-47f8-965b-29e9c85ee648", new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(2756), "a2c396b8-a970-4ef5-81dc-2ac1d84b9838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "336155bd-eaea-43fe-90f9-3d13cfb7d0f3", new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(2854), "f77b7b2d-2f98-4b03-a041-65dad7222c85" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3003), new DateTime(2025, 6, 23, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(2978), new DateTime(2025, 6, 13, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3032), new DateTime(2025, 8, 7, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3030), new DateTime(2025, 7, 8, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3036), new DateTime(2025, 7, 23, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3035), new DateTime(2025, 7, 3, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3039), new DateTime(2025, 7, 18, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3038), new DateTime(2025, 7, 8, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 18, 48, 90, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.CreateIndex(
                name: "IX_Participations_VolunteerID",
                table: "Participations",
                column: "VolunteerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_VolunteerProfiles_VolunteerID",
                table: "Participations",
                column: "VolunteerID",
                principalTable: "VolunteerProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_VolunteerProfiles_VolunteerID",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Participations_VolunteerID",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "VolunteerID",
                table: "Participations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "031f0faf-42c1-47fd-be0f-df9b7e3bea83", new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9153), "c5cb0601-3171-4407-aa3a-e4a45f8284bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "2c6a41ca-0459-4bf6-ae39-cb1a97bb4700", new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9325), "bb2219d3-80b9-4b81-9244-f9fc1dbb9685" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9603), new DateTime(2025, 6, 22, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 6, 12, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9669), new DateTime(2025, 8, 6, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9667), new DateTime(2025, 7, 7, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9675), new DateTime(2025, 7, 22, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9674), new DateTime(2025, 7, 2, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9680), new DateTime(2025, 7, 17, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9679), new DateTime(2025, 7, 7, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 16, 41, 56, 703, DateTimeKind.Utc).AddTicks(9413));
        }
    }
}
