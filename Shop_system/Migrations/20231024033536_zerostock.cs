using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_system.Migrations
{
    /// <inheritdoc />
    public partial class zerostock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Price", "ProductName", "Stock" },
                values: new object[] { 4, 1, 1.00m, "Bananas | 180g", 0 });
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
