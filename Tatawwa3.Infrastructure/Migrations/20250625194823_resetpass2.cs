using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class resetpass2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "passwordResetTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_passwordResetTokens_UserId",
                table: "passwordResetTokens",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_passwordResetTokens_AspNetUsers_UserId",
                table: "passwordResetTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_passwordResetTokens_AspNetUsers_UserId",
                table: "passwordResetTokens");

            migrationBuilder.DropIndex(
                name: "IX_passwordResetTokens_UserId",
                table: "passwordResetTokens");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "passwordResetTokens",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "b34ff47e-a61f-4673-aded-960390ea3b52", new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(2632), "10237ccf-8f58-4337-be18-5eb6c05080e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "26d4b23b-1ac0-40a0-88e6-08b2aae8e297", new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(2893), "b8d35282-d4b8-4461-81f1-6dbe1058f5e0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3340), new DateTime(2025, 6, 20, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3233), new DateTime(2025, 6, 10, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3554), new DateTime(2025, 8, 4, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3552), new DateTime(2025, 7, 5, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3559), new DateTime(2025, 7, 20, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3558), new DateTime(2025, 6, 30, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3564), new DateTime(2025, 7, 15, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3563), new DateTime(2025, 7, 5, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 19, 36, 53, 256, DateTimeKind.Utc).AddTicks(3010));
        }
    }
}
