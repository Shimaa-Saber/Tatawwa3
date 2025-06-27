using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixVolunteerCategoryRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "VolunteerProfiles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryId1",
                table: "VolunteerProfiles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "d48822c1-5444-4265-97ec-956e86475439", new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3261), "d0b7de77-4680-4ee4-9ff8-7a726cc14731" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "757b6c2e-90b7-4a91-b3f7-080990fd1209", new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3366), "a14af87b-5660-4972-bdec-8060b35ee37f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3531), new DateTime(2025, 6, 21, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3496), new DateTime(2025, 6, 11, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3568), new DateTime(2025, 8, 5, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3563), new DateTime(2025, 7, 6, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3572), new DateTime(2025, 7, 21, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3571), new DateTime(2025, 7, 1, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3576), new DateTime(2025, 7, 16, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3574), new DateTime(2025, 7, 6, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                columns: new[] { "CategoryId", "CategoryId1", "CreatedAt" },
                values: new object[] { null, null, new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "CategoryId", "CategoryId1", "CreatedAt" },
                values: new object[] { null, null, new DateTime(2025, 6, 26, 1, 11, 18, 307, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerProfiles_CategoryId1",
                table: "VolunteerProfiles",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerProfiles_Categories_CategoryId1",
                table: "VolunteerProfiles",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerProfiles_Categories_CategoryId1",
                table: "VolunteerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_VolunteerProfiles_CategoryId1",
                table: "VolunteerProfiles");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "VolunteerProfiles");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "VolunteerProfiles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "70253c07-10e5-4fd0-bbd1-cfd34de00a99", new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(5853), "662efa44-d6c3-4041-96ad-8a32d06d5d00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e99a8b7d-ac38-4086-a614-d2c9941ddd30", new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(5997), "df87e3cc-5296-4af2-917d-a8f3d91ff996" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6193), new DateTime(2025, 6, 20, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6154), new DateTime(2025, 6, 10, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6232), new DateTime(2025, 8, 4, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6230), new DateTime(2025, 7, 5, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6237), new DateTime(2025, 7, 20, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6236), new DateTime(2025, 6, 30, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6241), new DateTime(2025, 7, 15, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6240), new DateTime(2025, 7, 5, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 11, 31, 32, 368, DateTimeKind.Utc).AddTicks(6045));
        }
    }
}
