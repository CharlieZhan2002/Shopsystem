using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_system.Migrations
{
    /// <inheritdoc />
    public partial class updatedseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "PasswordHash", "Username" },
                values: new object[] { "manager@example.com", "111", "manager" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Username",
                value: "customer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "PasswordHash", "Username" },
                values: new object[] { "admin@example.com", "123", "123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Username",
                value: "000");
        }
    }
}
