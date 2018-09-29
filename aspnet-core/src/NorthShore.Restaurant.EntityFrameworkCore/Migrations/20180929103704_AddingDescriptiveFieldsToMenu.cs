using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthShore.Restaurant.Migrations
{
    public partial class AddingDescriptiveFieldsToMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiscountedPrice",
                table: "Menus",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCalorie",
                table: "Menus",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Menus",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountedPrice",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "TotalCalorie",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Menus");
        }
    }
}
