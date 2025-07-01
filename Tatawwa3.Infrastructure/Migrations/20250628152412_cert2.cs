using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cert2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VolunteerID",
                table: "Certificates",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_VolunteerID",
                table: "Certificates",
                column: "VolunteerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_VolunteerProfiles_VolunteerID",
                table: "Certificates",
                column: "VolunteerID",
                principalTable: "VolunteerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_VolunteerProfiles_VolunteerID",
                table: "Certificates");

            migrationBuilder.DropIndex(
                name: "IX_Certificates_VolunteerID",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "VolunteerID",
                table: "Certificates");

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
        }
    }
}
