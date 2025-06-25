using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "20cc133c-ba14-4660-8757-b3d925079057", new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2182), "14ce9f06-2817-4f9a-a557-aa3d7dd8158c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "bf4e27cb-9009-4abe-be3c-1d52c36dc8f2", new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2274), "8ef97538-e430-4101-9d53-8380e016d43e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CategoryId", "City", "CreatedAt", "CreatedBy", "CreationDate", "Description", "InternalNotes", "IsDeleted", "IsLinkedToOpportunity", "JoinPermission", "MaxMembers", "Name", "OrganizationID", "Status" },
                values: new object[] { "team-1", "cat-edu-1", "Cairo", new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2385), null, new DateTime(2025, 6, 9, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2362), "Team responsible for organizing educational initiatives.", "Priority team for large campaigns", false, true, 0, 20, "Education Support Team", "org-profile-1", 1 });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 16, 14, 407, DateTimeKind.Utc).AddTicks(2305));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "d0651826-f074-4599-9369-ca86eeb91992", new DateTime(2025, 6, 24, 22, 15, 15, 975, DateTimeKind.Utc).AddTicks(1676), "1fe91c29-0224-4905-acf9-bcd31d119017" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "5a98cba5-e86f-4b2d-8103-7092158bdf5f", new DateTime(2025, 6, 24, 22, 15, 15, 975, DateTimeKind.Utc).AddTicks(1776), "ee0411d3-3eec-4666-8069-e1b9293ad615" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 15, 15, 975, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 15, 15, 975, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 15, 15, 975, DateTimeKind.Utc).AddTicks(1860));
        }
    }
}
