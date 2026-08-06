using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineDataV2.Migrations
{
    /// <inheritdoc />
    public partial class AddBakimPersonelJunctionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UzmanlikAlani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IseGirisTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtananMeydan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ucaklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KuyrukNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlimYili = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UcusSaati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SimdikiMeydan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucaklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BakimKayitlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UcakId = table.Column<int>(type: "int", nullable: false),
                    BakimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakimKayitlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BakimKayitlari_Ucaklar_UcakId",
                        column: x => x.UcakId,
                        principalTable: "Ucaklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BakimPersonel",
                columns: table => new
                {
                    BakimId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakimPersonel", x => new { x.BakimId, x.PersonelId });
                    table.ForeignKey(
                        name: "FK_BakimPersonel_BakimKayitlari_BakimId",
                        column: x => x.BakimId,
                        principalTable: "BakimKayitlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BakimPersonel_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BakimKayitlari_UcakId",
                table: "BakimKayitlari",
                column: "UcakId");

            migrationBuilder.CreateIndex(
                name: "IX_BakimPersonel_PersonelId",
                table: "BakimPersonel",
                column: "PersonelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BakimPersonel");

            migrationBuilder.DropTable(
                name: "BakimKayitlari");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Ucaklar");
        }
    }
}
