using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop_system.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "ShippingAddress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerUserId",
                table: "OrderProducts",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Discriminator", "Email", "PasswordHash", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "Admin", "admin@example.com", "123", 0, "admin" },
                    { 2, "Manager", "admin@example.com", "123", 3, "123" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Discriminator", "Email", "PasswordHash", "Role", "ShippingAddress", "Username" },
                values: new object[] { 3, "Customer", "customer@example.com", "000", 2, "1234 Customer St.", "000" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_CustomerUserId",
                table: "OrderProducts",
                column: "CustomerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Users_CustomerUserId",
                table: "OrderProducts",
                column: "CustomerUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Users_CustomerUserId",
                table: "OrderProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderProducts_CustomerUserId",
                table: "OrderProducts");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerUserId",
                table: "OrderProducts");

            migrationBuilder.AlterColumn<string>(
                name: "ShippingAddress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Email", "PasswordHash", "Role", "ShippingAddress", "Username" },
                values: new object[] { "test", "test", 2, "111 Test Street", "test@mail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "PasswordHash", "Role", "ShippingAddress", "Username" },
                values: new object[] { "test", "admin", 0, "N/A", "admin@admin.com" });
        }
    }
}
