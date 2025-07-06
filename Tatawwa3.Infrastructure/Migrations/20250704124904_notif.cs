using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class notif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
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
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "b84ac27a-3a5a-450e-941d-4d8354f1c28c", new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(3678), "b1646262-ad4a-44bc-a7ae-db36c3c9ab24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "f9ebcac4-b9c8-4418-92ab-f9c5822217ae", new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4067), "82e811f1-e04e-4113-a5c9-512dfcf0568b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4493), new DateTime(2025, 6, 29, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4383), new DateTime(2025, 6, 19, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4642), new DateTime(2025, 8, 13, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4617), new DateTime(2025, 7, 14, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4662), new DateTime(2025, 7, 29, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4649), new DateTime(2025, 7, 9, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4672), new DateTime(2025, 7, 24, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4668), new DateTime(2025, 7, 14, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4689), new DateTime(2025, 7, 24, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 7, 14, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 12, 49, 0, 484, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CreatedBy",
                table: "Notifications",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "f5dc817e-fb64-4708-9f62-a7d498cacd9f", new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(1690), "538ec295-36a2-4b64-8bdd-4ad9fc30f0ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e6896a22-3b22-449b-aefd-21ec218a4a2d", new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(1884), "3d0ac5eb-a077-4513-970e-63f0f5e32b9c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2089), new DateTime(2025, 6, 28, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2049), new DateTime(2025, 6, 18, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2130), new DateTime(2025, 8, 12, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2127), new DateTime(2025, 7, 13, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2134), new DateTime(2025, 7, 28, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2133), new DateTime(2025, 7, 8, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2137), new DateTime(2025, 7, 23, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2136), new DateTime(2025, 7, 13, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2142), new DateTime(2025, 7, 23, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2141), new DateTime(2025, 7, 13, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(1927));
        }
    }
}
