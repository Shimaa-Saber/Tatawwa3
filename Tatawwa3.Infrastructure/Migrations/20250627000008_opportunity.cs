using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class opportunity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "FullName", "SecurityStamp" },
                values: new object[] { "dcef0f0d-c6fe-4b3d-a8e7-a7265706a484", new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7417), null, "b256a6e2-a621-4883-a8f8-ea160e748036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "FullName", "SecurityStamp" },
                values: new object[] { "bb0f1384-c128-4354-9c54-c3218ed2e807", new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7658), null, "dc273ddf-3f85-477b-a580-c57a3291b271" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8163), new DateTime(2025, 6, 22, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7995), new DateTime(2025, 6, 12, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 8, 6, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8265), new DateTime(2025, 7, 7, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 7, 22, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 7, 2, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 7, 17, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 7, 7, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 0, 0, 5, 798, DateTimeKind.Utc).AddTicks(7763));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

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
                value: new DateTime(2025, 6, 25, 19, 49, 30, 606, DateTimeKind.Utc).AddTicks(2408));

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
