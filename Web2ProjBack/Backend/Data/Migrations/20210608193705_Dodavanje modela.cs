using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Data.Migrations
{
    public partial class Dodavanjemodela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ekipe",
                columns: table => new
                {
                    IdEkipe = table.Column<string>(nullable: false),
                    NazivEkipe = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ekipe", x => x.IdEkipe);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    Longitude = table.Column<string>(nullable: false),
                    Latitude = table.Column<string>(nullable: false),
                    ElementType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Nalozi",
                columns: table => new
                {
                    IdNaloga = table.Column<string>(nullable: false),
                    NalogType = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 255, nullable: false),
                    IdIncidenta = table.Column<string>(maxLength: 255, nullable: false),
                    Ulica = table.Column<string>(maxLength: 255, nullable: false),
                    PocetakRada = table.Column<DateTime>(nullable: false),
                    KrajRada = table.Column<DateTime>(nullable: false),
                    Svrha = table.Column<string>(maxLength: 255, nullable: false),
                    Beleske = table.Column<string>(maxLength: 255, nullable: false),
                    Hitno = table.Column<bool>(nullable: false),
                    Kompanija = table.Column<string>(maxLength: 255, nullable: false),
                    TelefonskiBroj = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nalozi", x => x.IdNaloga);
                });

            migrationBuilder.CreateTable(
                name: "Planovi",
                columns: table => new
                {
                    IdPlana = table.Column<string>(nullable: false),
                    DocumentType = table.Column<int>(nullable: false),
                    IdNalogaRada = table.Column<string>(maxLength: 255, nullable: false),
                    Status = table.Column<string>(maxLength: 255, nullable: false),
                    IdIncidenta = table.Column<string>(maxLength: 255, nullable: false),
                    Ulica = table.Column<string>(maxLength: 255, nullable: false),
                    PocetakRada = table.Column<DateTime>(nullable: false),
                    KrajRada = table.Column<DateTime>(nullable: false),
                    Ekipa = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    Svrha = table.Column<string>(nullable: false),
                    Detalji = table.Column<string>(maxLength: 255, nullable: false),
                    Beleske = table.Column<string>(maxLength: 255, nullable: false),
                    Kompanija = table.Column<string>(maxLength: 255, nullable: false),
                    TelefonskiBroj = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planovi", x => x.IdPlana);
                });

            migrationBuilder.CreateTable(
                name: "Poruke",
                columns: table => new
                {
                    IdPoruke = table.Column<string>(nullable: false),
                    IdKorisnika = table.Column<string>(nullable: false),
                    Sadrzaj = table.Column<string>(nullable: false),
                    Tip = table.Column<string>(nullable: false),
                    Procitana = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruke", x => x.IdPoruke);
                });

            migrationBuilder.CreateTable(
                name: "Potrosaci",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Lokacija = table.Column<string>(nullable: true),
                    Prioritet = table.Column<int>(nullable: false),
                    TelefonskiBroj = table.Column<string>(nullable: true),
                    PotrosacType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potrosaci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pozivi",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Razlog = table.Column<string>(maxLength: 255, nullable: false),
                    Komentar = table.Column<string>(maxLength: 255, nullable: false),
                    Kvar = table.Column<string>(maxLength: 255, nullable: false),
                    UsernameKor = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pozivi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resolutions",
                columns: table => new
                {
                    IdRes = table.Column<string>(nullable: false),
                    Cause = table.Column<string>(nullable: false),
                    SubCause = table.Column<string>(nullable: false),
                    Construction = table.Column<string>(nullable: false),
                    Material = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolutions", x => x.IdRes);
                });

            migrationBuilder.CreateTable(
                name: "SafetyDocuments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    SafetyType = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    IdNalogaRada = table.Column<string>(maxLength: 255, nullable: false),
                    Ekipa = table.Column<string>(maxLength: 255, nullable: false),
                    Detalji = table.Column<string>(maxLength: 255, nullable: false),
                    Beleske = table.Column<string>(maxLength: 255, nullable: false),
                    TelefonskiBroj = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafetyDocuments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ekipe");

            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "Nalozi");

            migrationBuilder.DropTable(
                name: "Planovi");

            migrationBuilder.DropTable(
                name: "Poruke");

            migrationBuilder.DropTable(
                name: "Potrosaci");

            migrationBuilder.DropTable(
                name: "Pozivi");

            migrationBuilder.DropTable(
                name: "Resolutions");

            migrationBuilder.DropTable(
                name: "SafetyDocuments");
        }
    }
}
