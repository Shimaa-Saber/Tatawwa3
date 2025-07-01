using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVolunteerInvitationTablee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VolunteerInvitations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VolunteerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvitationType = table.Column<int>(type: "int", nullable: true),
                    OpportunityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PersonalMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerInvitations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolunteerInvitations_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VolunteerInvitations_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VolunteerInvitations_VolunteerOpportunities_OpportunityId",
                        column: x => x.OpportunityId,
                        principalTable: "VolunteerOpportunities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VolunteerInvitations_VolunteerProfiles_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "VolunteerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "4c54c0ec-d64e-41db-9594-f21200d3afbd", new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3651), "96008ce4-f1ca-48ef-8679-052d37860e77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "1e697bee-130e-45c9-8f95-ace54dc6c462", new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3731), "76123d09-48e8-4656-bd51-bc255dbd3d4d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3889), new DateTime(2025, 6, 22, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3857), new DateTime(2025, 6, 12, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3922), new DateTime(2025, 8, 6, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3919), new DateTime(2025, 7, 7, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3926), new DateTime(2025, 7, 22, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3925), new DateTime(2025, 7, 2, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3930), new DateTime(2025, 7, 17, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3929), new DateTime(2025, 7, 7, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 11, 41, 4, 188, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerInvitations_CreatedBy",
                table: "VolunteerInvitations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerInvitations_OpportunityId",
                table: "VolunteerInvitations",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerInvitations_TeamId",
                table: "VolunteerInvitations",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerInvitations_VolunteerId",
                table: "VolunteerInvitations",
                column: "VolunteerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolunteerInvitations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "d934d0dc-074b-4e86-9976-a3337d386720", new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(8750), "8e36836d-abdf-480c-8018-cd16638b15be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "9ebb0544-92ae-4174-a377-b7e8e9283665", new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(8906), "b633a559-1b40-401e-917d-e176bb55ba49" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9149), new DateTime(2025, 6, 20, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9103), new DateTime(2025, 6, 10, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9202), new DateTime(2025, 8, 4, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9200), new DateTime(2025, 7, 5, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9207), new DateTime(2025, 7, 20, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9206), new DateTime(2025, 6, 30, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9211), new DateTime(2025, 7, 15, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9210), new DateTime(2025, 7, 5, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 48, 22, 724, DateTimeKind.Utc).AddTicks(8977));
        }
    }
}
