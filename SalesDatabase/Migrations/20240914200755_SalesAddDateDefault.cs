using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddDateDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Data",
                table: "sales",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "sales");
        }
    }
}
