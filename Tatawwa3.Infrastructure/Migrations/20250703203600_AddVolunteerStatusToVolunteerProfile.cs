using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVolunteerStatusToVolunteerProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "VolunteerProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(1961), 0 });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 7, 3, 20, 35, 56, 350, DateTimeKind.Utc).AddTicks(1927), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "VolunteerProfiles");

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
        }
    }
}
