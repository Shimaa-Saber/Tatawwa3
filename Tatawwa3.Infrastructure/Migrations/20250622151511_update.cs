using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "VolunteerProfiles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "VolunteerOpportunities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "VolunteerAchievements",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Teams",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TeamMembers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Participations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "OrganizationProfiles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Certificates",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Attendances",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Applications",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Achievements",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "VolunteerProfiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "VolunteerProfiles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "VolunteerProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "VolunteerOpportunities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "VolunteerOpportunities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "VolunteerOpportunities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "VolunteerAchievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "VolunteerAchievements",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "VolunteerAchievements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Teams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Teams",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "TeamMembers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TeamMembers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TeamMembers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Participations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Participations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Participations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "OrganizationProfiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OrganizationProfiles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OrganizationProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Certificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Certificates",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Certificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Attendances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Attendances",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Attendances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Applications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Achievements",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Achievements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerProfiles_CreatedBy",
                table: "VolunteerProfiles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerOpportunities_CreatedBy",
                table: "VolunteerOpportunities",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerAchievements_CreatedBy",
                table: "VolunteerAchievements",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CreatedBy",
                table: "Teams",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_CreatedBy",
                table: "TeamMembers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_CreatedBy",
                table: "Participations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationProfiles_CreatedBy",
                table: "OrganizationProfiles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_CreatedBy",
                table: "Certificates",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatedBy",
                table: "Categories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_CreatedBy",
                table: "Attendances",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CreatedBy",
                table: "Applications",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_CreatedBy",
                table: "Achievements",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_AspNetUsers_CreatedBy",
                table: "Achievements",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_AspNetUsers_CreatedBy",
                table: "Applications",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_AspNetUsers_CreatedBy",
                table: "Attendances",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedBy",
                table: "Categories",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_AspNetUsers_CreatedBy",
                table: "Certificates",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationProfiles_AspNetUsers_CreatedBy",
                table: "OrganizationProfiles",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_AspNetUsers_CreatedBy",
                table: "Participations",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_AspNetUsers_CreatedBy",
                table: "TeamMembers",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_AspNetUsers_CreatedBy",
                table: "Teams",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerAchievements_AspNetUsers_CreatedBy",
                table: "VolunteerAchievements",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerOpportunities_AspNetUsers_CreatedBy",
                table: "VolunteerOpportunities",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerProfiles_AspNetUsers_CreatedBy",
                table: "VolunteerProfiles",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_AspNetUsers_CreatedBy",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_AspNetUsers_CreatedBy",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_AspNetUsers_CreatedBy",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedBy",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_AspNetUsers_CreatedBy",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationProfiles_AspNetUsers_CreatedBy",
                table: "OrganizationProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_AspNetUsers_CreatedBy",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_AspNetUsers_CreatedBy",
                table: "TeamMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_AspNetUsers_CreatedBy",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerAchievements_AspNetUsers_CreatedBy",
                table: "VolunteerAchievements");

            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerOpportunities_AspNetUsers_CreatedBy",
                table: "VolunteerOpportunities");

            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerProfiles_AspNetUsers_CreatedBy",
                table: "VolunteerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_VolunteerProfiles_CreatedBy",
                table: "VolunteerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_VolunteerOpportunities_CreatedBy",
                table: "VolunteerOpportunities");

            migrationBuilder.DropIndex(
                name: "IX_VolunteerAchievements_CreatedBy",
                table: "VolunteerAchievements");

            migrationBuilder.DropIndex(
                name: "IX_Teams_CreatedBy",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_CreatedBy",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_Participations_CreatedBy",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationProfiles_CreatedBy",
                table: "OrganizationProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Certificates_CreatedBy",
                table: "Certificates");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CreatedBy",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_CreatedBy",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Applications_CreatedBy",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_CreatedBy",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "VolunteerProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VolunteerProfiles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "VolunteerProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "VolunteerOpportunities");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VolunteerOpportunities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "VolunteerOpportunities");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "VolunteerAchievements");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VolunteerAchievements");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "VolunteerAchievements");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "OrganizationProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OrganizationProfiles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OrganizationProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Achievements");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VolunteerProfiles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VolunteerOpportunities",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VolunteerAchievements",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teams",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TeamMembers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Participations",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrganizationProfiles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Certificates",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Attendances",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Applications",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Achievements",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
