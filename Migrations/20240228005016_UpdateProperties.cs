using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaDeskRP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurfaceArea",
                table: "Desk");

            migrationBuilder.AddColumn<int>(
                name: "RushDays",
                table: "Desk",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

    }
}
