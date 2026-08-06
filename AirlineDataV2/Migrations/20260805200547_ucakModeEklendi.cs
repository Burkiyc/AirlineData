using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineDataV2.Migrations
{
    /// <inheritdoc />
    public partial class ucakModeEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Ucaklar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Ucaklar");
        }
    }
}
