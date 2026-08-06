using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineDataV2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlimYili",
                table: "Ucaklar");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Ucaklar");

            migrationBuilder.DropColumn(
                name: "SimdikiMeydan",
                table: "Ucaklar");

            migrationBuilder.DropColumn(
                name: "UcusSaati",
                table: "Ucaklar");

            migrationBuilder.DropColumn(
                name: "AtananMeydan",
                table: "Personeller");

            migrationBuilder.DropColumn(
                name: "IseGirisTarihi",
                table: "Personeller");

            migrationBuilder.DropColumn(
                name: "UzmanlikAlani",
                table: "Personeller");

            migrationBuilder.AlterColumn<string>(
                name: "KuyrukNo",
                table: "Ucaklar",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "KuyrukNo",
                table: "Ucaklar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlimYili",
                table: "Ucaklar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Ucaklar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SimdikiMeydan",
                table: "Ucaklar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UcusSaati",
                table: "Ucaklar",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "AtananMeydan",
                table: "Personeller",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IseGirisTarihi",
                table: "Personeller",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UzmanlikAlani",
                table: "Personeller",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
