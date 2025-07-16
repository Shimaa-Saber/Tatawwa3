using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: false
               );

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "ba60eaf7-38e5-497c-9f8d-db7a8899b95c", new DateTime(2025, 7, 16, 21, 20, 38, 628, DateTimeKind.Utc).AddTicks(9712), "306fc745-a46e-4453-adc3-005ed5e33ed6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "45994353-f2cf-4197-bd2b-b502a6a7c3f6", new DateTime(2025, 7, 16, 21, 20, 38, 628, DateTimeKind.Utc).AddTicks(9905), "63cb78ae-2f58-405f-88ea-2d6a962d7ac7" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 628, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate", "Status" },
                values: new object[] { new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 7, 11, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(78), 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(42), new DateTime(2025, 7, 1, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(169), new DateTime(2025, 8, 25, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(167), new DateTime(2025, 7, 26, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(174), new DateTime(2025, 8, 10, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(172), new DateTime(2025, 7, 21, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(178), new DateTime(2025, 8, 5, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(176), new DateTime(2025, 7, 26, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(183), new DateTime(2025, 8, 5, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(181), new DateTime(2025, 7, 26, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 628, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 16, 21, 20, 38, 628, DateTimeKind.Utc).AddTicks(9945));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "7f343432-3f52-4a69-9b32-f62e7019d239", new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7277), "08fea98e-b844-4c94-8c3a-94703f3c164a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "3200f6bb-5d99-447a-99c3-31bd20396d54", new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7520), "cdd8206e-0ea5-48e2-a5db-71631990794b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate", "Status" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7765), new DateTime(2025, 7, 10, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7763), 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7714), new DateTime(2025, 6, 30, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7814), new DateTime(2025, 8, 24, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7812), new DateTime(2025, 7, 25, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7822), new DateTime(2025, 8, 9, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 7, 20, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7826), new DateTime(2025, 8, 4, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7825), new DateTime(2025, 7, 25, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7830), new DateTime(2025, 8, 4, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7829), new DateTime(2025, 7, 25, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 15, 21, 2, 13, 232, DateTimeKind.Utc).AddTicks(7579));
        }
    }
}
