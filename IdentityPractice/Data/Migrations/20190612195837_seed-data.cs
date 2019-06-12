using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityPractice.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "1", 0, "6af112f7-e8de-46c2-a1d0-c1665aabb56c", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGDBJdmOcVZ3FB0E5AxiznGJraW3RJ4dRG9qDDJUCeQZr57UG7ubmg1gZ+YW1tcUug==", null, false, "ddf143d7-a8d6-4479-95d1-4f060c49b407", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "ListItem",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 1, "Bologna", "1" });

            migrationBuilder.InsertData(
                table: "ListItem",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 2, "Peanut butter", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ListItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ListItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
