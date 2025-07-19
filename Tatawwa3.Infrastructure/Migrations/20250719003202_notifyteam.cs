using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class notifyteam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JoinRecuestId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "c95d951f-ae48-4512-a6cd-17567be83b31", new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6211), "d1c34094-6ebb-42b3-9e9e-1a40cbf6a731" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "d105608d-300b-4c3b-bcb3-1be8eda1dcc1", new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6484), "e3274a3d-a64c-4b49-83b0-f44296eb7ce9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-4",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6764), new DateTime(2025, 7, 14, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-001",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6709), new DateTime(2025, 7, 4, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6817), new DateTime(2025, 8, 28, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6815), new DateTime(2025, 7, 29, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6823), new DateTime(2025, 8, 13, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6822), new DateTime(2025, 7, 24, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6828), new DateTime(2025, 8, 8, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6826), new DateTime(2025, 7, 29, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6832), new DateTime(2025, 8, 8, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6831), new DateTime(2025, 7, 29, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 7, 19, 0, 31, 57, 461, DateTimeKind.Utc).AddTicks(6565));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JoinRecuestId",
                table: "Notifications");

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
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 7, 16, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 7, 11, 21, 20, 38, 629, DateTimeKind.Utc).AddTicks(78) });

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
        }
    }
}
