using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeastFit.Migrations
{
    public partial class RemovedUnits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Units",
                table: "recipes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Units",
                table: "recipes",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }
    }
}
