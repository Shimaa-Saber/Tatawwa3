using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cert3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OpportunityId",
                table: "Participations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "fd1b41a1-6ec9-4207-a035-6c562cf49db0", new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(3985), "e01d43d0-47dd-4382-85ee-c1e69a5503c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "457485a5-2e64-49cb-a6bd-617328152aa0", new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4095), "b30ba285-7162-412a-b777-c6d751eb0ae7" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4288), new DateTime(2025, 6, 23, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4225), new DateTime(2025, 6, 13, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4322), new DateTime(2025, 8, 7, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4321), new DateTime(2025, 7, 8, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4327), new DateTime(2025, 7, 23, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4326), new DateTime(2025, 7, 3, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4330), new DateTime(2025, 7, 18, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4329), new DateTime(2025, 7, 8, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.CreateIndex(
                name: "IX_Participations_OpportunityId",
                table: "Participations",
                column: "OpportunityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_VolunteerOpportunities_OpportunityId",
                table: "Participations",
                column: "OpportunityId",
                principalTable: "VolunteerOpportunities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_VolunteerOpportunities_OpportunityId",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Participations_OpportunityId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "OpportunityId",
                table: "Participations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "557e4965-3b4d-429d-8234-2d9b6cb2a4e4", new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(309), "0f7fdb0a-7cd3-48fe-bde8-c633deacf757" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "a9b899bf-b44a-4e35-a0dd-b7635c9245bb", new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(585), "2f3cea87-fc71-401b-b4f4-4e255ca9ca96" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1091), new DateTime(2025, 6, 23, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(984), new DateTime(2025, 6, 13, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1190), new DateTime(2025, 8, 7, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1188), new DateTime(2025, 7, 8, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1201), new DateTime(2025, 7, 23, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1198), new DateTime(2025, 7, 3, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1209), new DateTime(2025, 7, 18, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1207), new DateTime(2025, 7, 8, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 24, 10, 902, DateTimeKind.Utc).AddTicks(692));
        }
    }
}
