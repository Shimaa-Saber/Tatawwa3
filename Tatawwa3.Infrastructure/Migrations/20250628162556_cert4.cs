using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cert4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VerificationCode",
                table: "Certificates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CertificateNumber",
                table: "Certificates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FileUrl",
                table: "Certificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Issuer",
                table: "Certificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Certificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "12a7ba91-9c96-4671-8346-da40279ad9a8", new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(2969), "67e75aef-ee45-4376-87e1-b6787dc04999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "675d8e59-8e76-438d-bbc9-e092e12d0c61", new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3155), "14ab0558-19ba-4877-b678-7ed5e6597632" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3572), new DateTime(2025, 6, 23, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 6, 13, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3633), new DateTime(2025, 8, 7, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3630), new DateTime(2025, 7, 8, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3640), new DateTime(2025, 7, 23, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3638), new DateTime(2025, 7, 3, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3646), new DateTime(2025, 7, 18, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3644), new DateTime(2025, 7, 8, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 16, 25, 54, 898, DateTimeKind.Utc).AddTicks(3230));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileUrl",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "Issuer",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Certificates");

            migrationBuilder.AlterColumn<string>(
                name: "VerificationCode",
                table: "Certificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CertificateNumber",
                table: "Certificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "fd1b41a1-6ec9-4207-a035-6c562cf49db0", new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(3985), "e01d43d0-47dd-4382-85ee-c1e69a5503c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "457485a5-2e64-49cb-a6bd-617328152aa0", new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4095), "b30ba285-7162-412a-b777-c6d751eb0ae7" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4288), new DateTime(2025, 6, 23, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4225), new DateTime(2025, 6, 13, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4322), new DateTime(2025, 8, 7, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4321), new DateTime(2025, 7, 8, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4327), new DateTime(2025, 7, 23, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4326), new DateTime(2025, 7, 3, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4330), new DateTime(2025, 7, 18, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4329), new DateTime(2025, 7, 8, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 56, 7, 554, DateTimeKind.Utc).AddTicks(4129));
        }
    }
}
