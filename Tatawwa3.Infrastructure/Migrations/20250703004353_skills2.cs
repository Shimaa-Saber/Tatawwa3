using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class skills2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Skills",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "skillesses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpportunityID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skillesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_skillesses_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_skillesses_VolunteerOpportunities_OpportunityID",
                        column: x => x.OpportunityID,
                        principalTable: "VolunteerOpportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "17a4102c-464d-43a7-b1cb-1dbcfec1bc53", new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8284), "7d0e3bab-f263-4265-b2ef-7124ff72e1fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "adef61b1-63f1-4108-a31b-668e6a159923", new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8466), "c83cd992-f493-40bd-8dd8-c67f819e0f1e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8643), new DateTime(2025, 6, 28, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8612), new DateTime(2025, 6, 18, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8680), new DateTime(2025, 8, 12, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8678), new DateTime(2025, 7, 13, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8684), new DateTime(2025, 7, 28, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8683), new DateTime(2025, 7, 8, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8688), new DateTime(2025, 7, 23, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8687), new DateTime(2025, 7, 13, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 7, 23, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8691), new DateTime(2025, 7, 13, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 43, 52, 97, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.CreateIndex(
                name: "IX_skillesses_CreatedBy",
                table: "skillesses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_skillesses_OpportunityID",
                table: "skillesses",
                column: "OpportunityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "skillesses");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Skills",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "59cb2c8f-36dc-479f-aec0-9606af95bd45", new DateTime(2025, 7, 3, 0, 6, 47, 854, DateTimeKind.Utc).AddTicks(9913), "eeca5370-c385-4f86-a209-a88721ca8b58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "024b0a15-1a66-44e5-8d18-f770465264e7", new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(167), "d5f88cd7-5f6e-4bef-a56b-8db49e8a23d9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(437), new DateTime(2025, 6, 28, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(387), new DateTime(2025, 6, 18, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(510), new DateTime(2025, 8, 12, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(507), new DateTime(2025, 7, 13, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(515), new DateTime(2025, 7, 28, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(513), new DateTime(2025, 7, 8, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(518), new DateTime(2025, 7, 23, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(517), new DateTime(2025, 7, 13, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(523), new DateTime(2025, 7, 23, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(521), new DateTime(2025, 7, 13, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 3, 0, 6, 47, 855, DateTimeKind.Utc).AddTicks(246));
        }
    }
}
