using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatenotify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "notificationPreferences",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NotifyOnApplicationAccepted = table.Column<bool>(type: "bit", nullable: false),
                    NotifyOnCertificateIssued = table.Column<bool>(type: "bit", nullable: false),
                    NotifyOnOpportunityRecommendations = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notificationPreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_notificationPreferences_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_notificationPreferences_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "400c9f53-cefb-4eec-968e-57d800a15b46", new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8031), "d4bcc96a-f24b-4821-842a-46d34187c11f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "97cf741e-9cff-4a0f-a184-651f8157e576", new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8126), "67eb628f-0b4d-49f4-ae12-3babd4f3041d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 7, 3, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8246), new DateTime(2025, 6, 23, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8305), new DateTime(2025, 8, 17, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8303), new DateTime(2025, 7, 18, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8309), new DateTime(2025, 8, 2, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8308), new DateTime(2025, 7, 13, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8313), new DateTime(2025, 7, 28, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8312), new DateTime(2025, 7, 18, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8317), new DateTime(2025, 7, 28, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8316), new DateTime(2025, 7, 18, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 13, 48, 58, 619, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.CreateIndex(
                name: "IX_notificationPreferences_CreatedBy",
                table: "notificationPreferences",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_notificationPreferences_UserId",
                table: "notificationPreferences",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "notificationPreferences");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "29232997-eaf9-4590-8ad2-ebfcf5209512", new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4170), "8efd0071-8370-4243-8944-1641c56da886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "5eae2273-3445-4240-8efc-29b395cf3807", new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4443), "8a420ba4-fa31-4886-b70c-31ca4c27f8d5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4991), new DateTime(2025, 7, 2, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4873), new DateTime(2025, 6, 22, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5103), new DateTime(2025, 8, 16, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5100), new DateTime(2025, 7, 17, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 8, 1, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5110), new DateTime(2025, 7, 12, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5122), new DateTime(2025, 7, 27, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5119), new DateTime(2025, 7, 17, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5131), new DateTime(2025, 7, 27, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5128), new DateTime(2025, 7, 17, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 7, 12, 23, 40, 962, DateTimeKind.Utc).AddTicks(4555));
        }
    }
}
