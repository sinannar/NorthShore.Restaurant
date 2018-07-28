using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthShore.Restaurant.Migrations
{
    public partial class PriceForFoodAndDiscountForMenuMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiscountRate",
                table: "Menus",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Foods",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountRate",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Foods");
        }
    }
}
