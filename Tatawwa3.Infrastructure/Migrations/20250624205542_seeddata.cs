using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tatawwa3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NationalID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "org-user-1", 0, "Cairo", "04199e2f-f386-4591-a4c3-d609589c76eb", new DateTime(2025, 6, 24, 20, 55, 39, 590, DateTimeKind.Utc).AddTicks(5302), "org@example.com", true, false, null, "12345678901234", "ORG@EXAMPLE.COM", "ORG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO6fBKgYj6nRAiD3F6jHUWfXeCmgVi+e3kq9a+vZ7O9GsG2vEMiRKzLskroIfvHHng==", "01000000000", false, 1, "c4233427-b2b8-46d3-bb52-67457113dad3", false, "org@example.com" },
                    { "vol-user-1", 0, "Assiut", "5b8af3cc-20e9-4400-a31d-786265e3be8c", new DateTime(2025, 6, 24, 20, 55, 39, 590, DateTimeKind.Utc).AddTicks(5349), "volunteer@example.com", true, false, null, "98765432109876", "VOLUNTEER@EXAMPLE.COM", "VOLUNTEER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO6fBKgYj6nRAiD3F6jHUWfXeCmgVi+e3kq9a+vZ7O9GsG2vEMiRKzLskroIfvHHng==", "01111111111", false, 0, "6f1a3b36-c5aa-460d-a22e-5129ec81fc79", false, "volunteer@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "org-user-1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "vol-user-1");
        }
    }
}
