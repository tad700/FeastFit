using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeastFit.Migrations
{
    public partial class AddedRecipeID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IDOfRecipe",
                table: "recipes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDOfRecipe",
                table: "recipes");
        }
    }
}
