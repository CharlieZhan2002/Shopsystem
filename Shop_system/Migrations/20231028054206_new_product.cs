using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_system.Migrations
{
    /// <inheritdoc />
    public partial class new_product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Price", "ProductName", "Stock" },
                values: new object[] { 4, 1, 1.00m, "Bananas", 60 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
