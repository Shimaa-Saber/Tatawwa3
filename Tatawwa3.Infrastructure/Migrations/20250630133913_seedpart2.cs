using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedpart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "OpportunityId",
            //    table: "Participations",
            //    type: "nvarchar(450)",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "VolunteerID",
            //    table: "Participations",
            //    type: "nvarchar(450)",
            //    nullable: true);

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

            //migrationBuilder.AddColumn<string>(
            //    name: "FileUrl",
            //    table: "Certificates",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Issuer",
            //    table: "Certificates",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "Title",
            //    table: "Certificates",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "VolunteerID",
            //    table: "Certificates",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.InsertData(
            //    table: "Applications",
            //    columns: new[] { "Id", "ApplicationDate", "AttachmentPath", "CreatedAt", "CreatedBy", "HasRequiredSkills", "IsDeleted", "MotivationLetter", "Note", "OpportunityID", "Status", "VolunteerID" },
            //    values: new object[,]
            //    {
            //        { "app-1", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1074), null, true, false, "I am passionate about helping children learn.", "Looking forward to this opportunity.", "opp-1", 0, "vol-user-1" },
            //        { "app-2", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "attachments/volunteer_cv.pdf", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1080), null, true, false, "I have prior experience in similar events.", "Excited to participate.", "opp-2", 1, "vol-user-1" },
            //        { "app-3", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "attachments/volunteer_cv.pdf", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1083), null, true, false, "I have prior experience in similar events.", "Excited to participate.", "opp-1", 0, "vol_prof2" }
            //    });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "125e92c3-d900-461d-b478-51048f57e0ab", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(650), "8b87a86e-a1b3-4fe3-b194-b673cfaf53e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "5cadcef8-4cf5-4473-b1fd-ca9c257af39d", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(748), "4f61e4db-2adf-4a81-a48c-5d7ea17d60b4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(937), new DateTime(2025, 6, 25, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(901), new DateTime(2025, 6, 15, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(972), new DateTime(2025, 8, 9, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(970), new DateTime(2025, 7, 10, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(977), new DateTime(2025, 7, 25, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(976), new DateTime(2025, 7, 5, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1024), new DateTime(2025, 7, 20, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1023), new DateTime(2025, 7, 10, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.InsertData(
                table: "VolunteerOpportunities",
                columns: new[] { "Id", "CategoryID", "Conditions", "CreatedAt", "CreatedBy", "Description", "EndDate", "GenderRequirement", "Image", "IsAttendanceTracked", "IsCertificateAvailable", "IsDeleted", "Location", "OrganizationID", "RequiredVolunteers", "StartDate", "Status", "TeamId", "Title", "TotalHours" },
                values: new object[] { "opp-4", "cat-edu-1", null, new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1028), null, "Teach basic coding to adults in underserved communities.", new DateTime(2025, 7, 20, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1027), null, "coding-kids.png", null, null, false, "Assiut", "org-profile-1", 15, new DateTime(2025, 7, 10, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1027), 1, "cf0cf8e1-5a62-4315-9c90-3f8b727b8251", "programing", null });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(794));

            //migrationBuilder.InsertData(
            //    table: "Participations",
            //    columns: new[] { "Id", "ApplicationID", "CreatedAt", "CreatedBy", "FirstCheckIn", "IsDeleted", "LastCheckOut", "OpportunityId", "Status", "TotalAttendedHours", "VolunteerID" },
            //    values: new object[,]
            //    {
            //        { "participation-1", "app-1", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1123), null, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "opp-1", 1, 12.5f, "vol-user-1" },
            //        { "participation-2", "app-2", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1127), null, new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "opp-2", 1, 8f, "vol-user-1" },
            //        { "participation-3", "app-3", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1131), null, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "opp-1", 1, 12.5f, "vol_prof2" }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Certificates",
            //    columns: new[] { "Id", "CertificateNumber", "CreatedAt", "CreatedBy", "FileUrl", "IsDeleted", "IsVerified", "IssueDate", "Issuer", "ParticipationID", "Title", "TotalHours", "VerificationCode", "VolunteerID" },
            //    values: new object[,]
            //    {
            //        { "cert-1", "CERT-2025-001", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1171), null, null, false, true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded Org", "participation-1", "Coding for Kids Participation", 12.5f, "VERIF123", "vol-user-1" },
            //        { "cert-2", "CERT-2025-001", new DateTime(2025, 6, 30, 13, 39, 12, 401, DateTimeKind.Utc).AddTicks(1175), null, null, false, true, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeded Org", "participation-3", "Coding for Kids Participation", 12.5f, "VERIF123", "vol_prof2" }
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Participations_OpportunityId",
            //    table: "Participations",
            //    column: "OpportunityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Participations_VolunteerID",
            //    table: "Participations",
            //    column: "VolunteerID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Certificates_VolunteerID",
            //    table: "Certificates",
            //    column: "VolunteerID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Certificates_VolunteerProfiles_VolunteerID",
            //    table: "Certificates",
            //    column: "VolunteerID",
            //    principalTable: "VolunteerProfiles",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Participations_VolunteerOpportunities_OpportunityId",
            //    table: "Participations",
            //    column: "OpportunityId",
            //    principalTable: "VolunteerOpportunities",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Participations_VolunteerProfiles_VolunteerID",
            //    table: "Participations",
            //    column: "VolunteerID",
            //    principalTable: "VolunteerProfiles",
            //    principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_VolunteerProfiles_VolunteerID",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_VolunteerOpportunities_OpportunityId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_VolunteerProfiles_VolunteerID",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Participations_OpportunityId",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Participations_VolunteerID",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Certificates_VolunteerID",
                table: "Certificates");

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-1");

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "cert-2");

            migrationBuilder.DeleteData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-2");

            migrationBuilder.DeleteData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-4");

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-2");

            migrationBuilder.DeleteData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-1");

            migrationBuilder.DeleteData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: "participation-3");

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-1");

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: "app-3");

            migrationBuilder.DropColumn(
                name: "OpportunityId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "VolunteerID",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "FileUrl",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "Issuer",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "VolunteerID",
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
                values: new object[] { "2f46d2e1-3fbe-466c-ac0a-88ecb8051f4d", new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1049), "61356e4d-1afd-4698-9dc8-ae4f07cc941a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "70767ea5-3112-4335-94ec-37823fd71693", new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1133), "6c76d44b-d085-4583-86ec-9ca120a9f859" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cat-edu-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "OrganizationProfiles",
                keyColumn: "Id",
                keyValue: "org-profile-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: "member-1",
                columns: new[] { "CreatedAt", "JoinDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1298), new DateTime(2025, 6, 24, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "team-1",
                columns: new[] { "CreatedAt", "CreationDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1277), new DateTime(2025, 6, 14, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-1",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1323), new DateTime(2025, 8, 8, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1319), new DateTime(2025, 7, 9, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-2",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1326), new DateTime(2025, 7, 24, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1325), new DateTime(2025, 7, 4, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "VolunteerOpportunities",
                keyColumn: "Id",
                keyValue: "opp-3",
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1328), new DateTime(2025, 7, 19, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1328), new DateTime(2025, 7, 9, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol_prof2",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "VolunteerProfiles",
                keyColumn: "Id",
                keyValue: "vol-user-1",
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 44, 54, 111, DateTimeKind.Utc).AddTicks(1209));
        }
    }
}
