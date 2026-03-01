using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazaTakipApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bedenler",
                columns: table => new
                {
                    BedenId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BedenAdi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bedenler", x => x.BedenId);
                });

            migrationBuilder.CreateTable(
                name: "DepoGirisler",
                columns: table => new
                {
                    DepoGirisId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false),
                    SatisHareketId = table.Column<int>(type: "INTEGER", nullable: false),
                    FirmaId = table.Column<int>(type: "INTEGER", nullable: false),
                    İsyeriId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonelId = table.Column<int>(type: "INTEGER", nullable: false),
                    GelisTar = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GelisMiktar = table.Column<string>(type: "TEXT", nullable: false),
                    GelisBirimi = table.Column<string>(type: "TEXT", nullable: false),
                    AlisFiyati = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoGirisler", x => x.DepoGirisId);
                });

            migrationBuilder.CreateTable(
                name: "Firmalar",
                columns: table => new
                {
                    FirmaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirmaAdi = table.Column<string>(type: "TEXT", nullable: false),
                    FirmaTel = table.Column<string>(type: "TEXT", nullable: false),
                    FirmaAdres = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalar", x => x.FirmaId);
                });

            migrationBuilder.CreateTable(
                name: "Isyerleri",
                columns: table => new
                {
                    IsyeriId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsyeriAdi = table.Column<string>(type: "TEXT", nullable: false),
                    IsyeriAdres = table.Column<string>(type: "TEXT", nullable: false),
                    IsyeriTel = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isyerleri", x => x.IsyeriId);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    MusteriId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MusteriAdi = table.Column<string>(type: "TEXT", nullable: false),
                    MusteriSoyad = table.Column<string>(type: "TEXT", nullable: false),
                    MusteriTel = table.Column<string>(type: "TEXT", nullable: false),
                    MusteriAdres = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.MusteriId);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsyeriId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonelAdi = table.Column<string>(type: "TEXT", nullable: false),
                    PersonelSoyad = table.Column<string>(type: "TEXT", nullable: false),
                    PersonelTel = table.Column<string>(type: "TEXT", nullable: false),
                    PersonelAdres = table.Column<string>(type: "TEXT", nullable: false),
                    SatisHareketId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonelTurId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.PersonelId);
                });

            migrationBuilder.CreateTable(
                name: "PersonelTurler",
                columns: table => new
                {
                    PersonelTurId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonelTuru = table.Column<string>(type: "TEXT", nullable: false),
                    SatisHareketId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTurler", x => x.PersonelTurId);
                });

            migrationBuilder.CreateTable(
                name: "Satislar",
                columns: table => new
                {
                    SatisId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SatisHareketId = table.Column<int>(type: "INTEGER", nullable: false),
                    MusteriId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonelId = table.Column<int>(type: "INTEGER", nullable: false),
                    SatisTar = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SatisMiktar = table.Column<string>(type: "TEXT", nullable: false),
                    SatisBirimi = table.Column<string>(type: "TEXT", nullable: false),
                    SatisFiyati = table.Column<decimal>(type: "TEXT", nullable: false),
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satislar", x => x.SatisId);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirmaId = table.Column<int>(type: "INTEGER", nullable: false),
                    BedenId = table.Column<int>(type: "INTEGER", nullable: false),
                    UrunAdi = table.Column<string>(type: "TEXT", nullable: false),
                    ModelNo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bedenler");

            migrationBuilder.DropTable(
                name: "DepoGirisler");

            migrationBuilder.DropTable(
                name: "Firmalar");

            migrationBuilder.DropTable(
                name: "Isyerleri");

            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "PersonelTurler");

            migrationBuilder.DropTable(
                name: "Satislar");

            migrationBuilder.DropTable(
                name: "Urunler");
        }
    }
}
