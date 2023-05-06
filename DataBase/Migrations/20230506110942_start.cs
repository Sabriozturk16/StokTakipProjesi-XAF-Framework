using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birims",
                columns: table => new
                {
                    OID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<string>(nullable: true),
                    Adi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.OID);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    OID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.OID);
                });

            migrationBuilder.CreateTable(
                name: "stokKarts",
                columns: table => new
                {
                    OID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<string>(nullable: true),
                    Adi = table.Column<string>(nullable: true),
                    BirimOID = table.Column<int>(nullable: true),
                    KullanımDurumu = table.Column<int>(nullable: false),
                    Miktar = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stokKarts", x => x.OID);
                    table.ForeignKey(
                        name: "FK_stokKarts_Birims_BirimOID",
                        column: x => x.BirimOID,
                        principalTable: "Birims",
                        principalColumn: "OID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "stokHarekets",
                columns: table => new
                {
                    OID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemTarihi = table.Column<DateTime>(nullable: false),
                    IslemTuru = table.Column<int>(nullable: false),
                    Miktar = table.Column<double>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    StokKartId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stokHarekets", x => x.OID);
                    table.ForeignKey(
                        name: "FK_stokHarekets_stokKarts_StokKartId",
                        column: x => x.StokKartId,
                        principalTable: "stokKarts",
                        principalColumn: "OID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StokTedarikcisi",
                columns: table => new
                {
                    OID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<string>(nullable: true),
                    Adi = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    StokKartId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokTedarikcisi", x => x.OID);
                    table.ForeignKey(
                        name: "FK_StokTedarikcisi_stokKarts_StokKartId",
                        column: x => x.StokKartId,
                        principalTable: "stokKarts",
                        principalColumn: "OID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_stokHarekets_StokKartId",
                table: "stokHarekets",
                column: "StokKartId");

            migrationBuilder.CreateIndex(
                name: "IX_stokKarts_BirimOID",
                table: "stokKarts",
                column: "BirimOID");

            migrationBuilder.CreateIndex(
                name: "IX_StokTedarikcisi_StokKartId",
                table: "StokTedarikcisi",
                column: "StokKartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "stokHarekets");

            migrationBuilder.DropTable(
                name: "StokTedarikcisi");

            migrationBuilder.DropTable(
                name: "stokKarts");

            migrationBuilder.DropTable(
                name: "Birims");
        }
    }
}
