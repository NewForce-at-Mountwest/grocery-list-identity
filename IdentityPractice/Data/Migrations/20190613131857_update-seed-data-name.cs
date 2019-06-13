using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityPractice.Data.Migrations
{
    public partial class updateseeddataname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "e71e7c96-50cf-4edd-9bb0-93ee6c5120f1", "AQAAAAEAACcQAAAAEOMrmyneTbNeDtF47xlNBww4rmIN1AwGXT/Ay7dWR1iobuzGy7EjTruHrPrJ4iOoMQ==", "a08c6fb5-db6e-4173-a53b-681e0e40e79d", "George", "Brown" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "6af112f7-e8de-46c2-a1d0-c1665aabb56c", "AQAAAAEAACcQAAAAEGDBJdmOcVZ3FB0E5AxiznGJraW3RJ4dRG9qDDJUCeQZr57UG7ubmg1gZ+YW1tcUug==", "ddf143d7-a8d6-4479-95d1-4f060c49b407", "admin", "admin" });
        }
    }
}
