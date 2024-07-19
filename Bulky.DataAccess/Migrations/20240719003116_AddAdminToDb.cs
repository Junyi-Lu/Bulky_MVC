using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d18fceea-cbde-4eb8-a7ee-11d89dcc22cd", 0, "Chicago", null, "82137385-7668-4e5e-b819-8b675c4ad760", "ApplicationUser", "admin@dotnetmastery.com", false, false, null, "Bhrugen Patel", null, null, null, "1112223333", false, "23422", "dc497053-f38d-4026-8ec4-3db8f1699a83", "IL", "test 123 Ave", false, "admin@dotnetmastery.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18fceea-cbde-4eb8-a7ee-11d89dcc22cd");
        }
    }
}
