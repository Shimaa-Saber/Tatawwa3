using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateteam3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "Image",
            //    table: "VolunteerOpportunities",
            //    type: "nvarchar(max)",
            //    nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamId",
                table: "VolunteerOpportunities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "CategoryId",
            //    table: "Teams",
            //    type: "nvarchar(450)",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "City",
            //    table: "Teams",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "InternalNotes",
            //    table: "Teams",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.AddColumn<bool>(
            //    name: "IsLinkedToOpportunity",
            //    table: "Teams",
            //    type: "bit",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "JoinPermission",
            //    table: "Teams",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "MaxMembers",
            //    table: "Teams",
            //    type: "int",
            //    nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JoinRequests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TeamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VolunteerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Motivation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasPreviousExperience = table.Column<bool>(type: "bit", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinRequests_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JoinRequests_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinRequests_VolunteerProfiles_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "VolunteerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerOpportunities_TeamId",
                table: "VolunteerOpportunities",
                column: "TeamId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Teams_CategoryId",
            //    table: "Teams",
            //    column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinRequests_CreatedBy",
                table: "JoinRequests",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_JoinRequests_TeamId",
                table: "JoinRequests",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinRequests_VolunteerId",
                table: "JoinRequests",
                column: "VolunteerId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Teams_Categories_CategoryId",
            //    table: "Teams",
            //    column: "CategoryId",
            //    principalTable: "Categories",
            //    principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerOpportunities_Teams_TeamId",
                table: "VolunteerOpportunities",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Categories_CategoryId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerOpportunities_Teams_TeamId",
                table: "VolunteerOpportunities");

            migrationBuilder.DropTable(
                name: "JoinRequests");

            migrationBuilder.DropIndex(
                name: "IX_VolunteerOpportunities_TeamId",
                table: "VolunteerOpportunities");

            migrationBuilder.DropIndex(
                name: "IX_Teams_CategoryId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "VolunteerOpportunities");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "VolunteerOpportunities");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "InternalNotes",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "IsLinkedToOpportunity",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "JoinPermission",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "MaxMembers",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "TeamMembers");
        }
    }
}
