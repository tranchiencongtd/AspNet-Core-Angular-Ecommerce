using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class updatetablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PromotionManufactureres",
                table: "PromotionManufactureres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategorie",
                table: "ProductCategorie");

            migrationBuilder.RenameTable(
                name: "PromotionManufactureres",
                newName: "PromotionManufacturers");

            migrationBuilder.RenameTable(
                name: "ProductCategorie",
                newName: "ProductCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PromotionManufacturers",
                table: "PromotionManufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PromotionManufacturers",
                table: "PromotionManufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "PromotionManufacturers",
                newName: "PromotionManufactureres");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "ProductCategorie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PromotionManufactureres",
                table: "PromotionManufactureres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategorie",
                table: "ProductCategorie",
                column: "Id");
        }
    }
}
