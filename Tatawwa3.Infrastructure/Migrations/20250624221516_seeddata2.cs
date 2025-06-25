using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerOpportunities_Teams_TeamId",
                table: "VolunteerOpportunities");

            migrationBuilder.AlterColumn<string>(
                name: "TeamId",
                table: "VolunteerOpportunities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Icon", "IsDeleted", "Name" },
                values: new object[] { "cat-edu-1", new DateTime(2025, 6, 24, 22, 15, 15, 975, DateTimeKind.Utc).AddTicks(1894), null, "Educational programs and initiatives", "education.png", false, "Education" });

            migrationBuilder.InsertData(
                table: "OrganizationProfiles",
                columns: new[] { "Id", "CommercialRegistration", "CreatedAt", "CreatedBy", "IsDeleted", "IsVerified", "OrganizationName", "UserID" },
                values: new object[] { "org-profile-1", "REG123456", new DateTime(2025, 6, 24, 22, 15, 15, 975, DateTimeKind.Utc).AddTicks(1746), null, false, true, "Seeded Org", "org-user-1" });

            migrationBuilder.InsertData(
                table: "VolunteerProfiles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Interests", "IsDeleted", "IsVerified", "Rating", "Skills", "TotalHours", "UserID" },
                values: new object[] { "vol-user-1", new DateTime(2025, 6, 24, 22, 15, 15, 975, DateTimeKind.Utc).AddTicks(1860), null, "[\"Education\",\"Health\"]", false, false, 0f, null, 0f, "vol-user-1" });

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerOpportunities_Teams_TeamId",
                table: "VolunteerOpportunities",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerOpportunities_Teams_TeamId",
                table: "VolunteerOpportunities");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1");

            migrationBuilder.DeleteData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1");

            migrationBuilder.DeleteData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1");

            migrationBuilder.AlterColumn<string>(
                name: "TeamId",
                table: "VolunteerOpportunities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "04199e2f-f386-4591-a4c3-d609589c76eb", new DateTime(2025, 6, 24, 20, 55, 39, 590, DateTimeKind.Utc).AddTicks(5302), "c4233427-b2b8-46d3-bb52-67457113dad3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "5b8af3cc-20e9-4400-a31d-786265e3be8c", new DateTime(2025, 6, 24, 20, 55, 39, 590, DateTimeKind.Utc).AddTicks(5349), "6f1a3b36-c5aa-460d-a22e-5129ec81fc79" });

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerOpportunities_Teams_TeamId",
                table: "VolunteerOpportunities",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
