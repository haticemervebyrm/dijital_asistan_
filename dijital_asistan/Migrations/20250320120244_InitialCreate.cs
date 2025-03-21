using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dijital_asistan.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DegerTipi",
                columns: table => new
                {
                    DegerTipiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DegerTipiAdi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegerTipi", x => x.DegerTipiId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HatirlaticiTipi",
                columns: table => new
                {
                    HatirlaticiTipiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HatirlaticiTipiAdi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Baslik = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HatirlaticiTarihi = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HatirlaticiTipi", x => x.HatirlaticiTipiId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciAdi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SifreHash = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Yas = table.Column<int>(type: "int", nullable: true),
                    Cinsiyet = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eposta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EpostaDogrulandi = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EpostaDogrulamaTarihi = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Durum = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullaniciId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SensorVeriTipi",
                columns: table => new
                {
                    SensorVeriTipiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SensorTipi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Veri = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorVeriTipi", x => x.SensorVeriTipiId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "YapayZekaAnalizTipi",
                columns: table => new
                {
                    AnalizTipiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnalizTipiAdi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sonuc = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YapayZekaAnalizTipi", x => x.AnalizTipiId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Aksesuar",
                columns: table => new
                {
                    AksesuarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    AksesuarTipi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KullanimDurumu = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aksesuar", x => x.AksesuarId);
                    table.ForeignKey(
                        name: "FK_Aksesuar_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Besin",
                columns: table => new
                {
                    BesinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    Kategori = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Karbonhidrat = table.Column<float>(type: "float", nullable: false),
                    Protein = table.Column<float>(type: "float", nullable: false),
                    Yag = table.Column<float>(type: "float", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besin", x => x.BesinId);
                    table.ForeignKey(
                        name: "FK_Besin_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Degerler",
                columns: table => new
                {
                    DegerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    DegerTipiId = table.Column<int>(type: "int", nullable: true),
                    DegerListesi = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TahlilSonuclari = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tarih = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degerler", x => x.DegerId);
                    table.ForeignKey(
                        name: "FK_Degerler_DegerTipi_DegerTipiId",
                        column: x => x.DegerTipiId,
                        principalTable: "DegerTipi",
                        principalColumn: "DegerTipiId");
                    table.ForeignKey(
                        name: "FK_Degerler_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hatirlaticilar",
                columns: table => new
                {
                    HatirlaticiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    HatirlaticiTipiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hatirlaticilar", x => x.HatirlaticiId);
                    table.ForeignKey(
                        name: "FK_Hatirlaticilar_HatirlaticiTipi_HatirlaticiTipiId",
                        column: x => x.HatirlaticiTipiId,
                        principalTable: "HatirlaticiTipi",
                        principalColumn: "HatirlaticiTipiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hatirlaticilar_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ilaclar",
                columns: table => new
                {
                    IlacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IlacAd = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dozaj = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BaslangicTarih = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AlindiMi = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilaclar", x => x.IlacId);
                    table.ForeignKey(
                        name: "FK_Ilaclar_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RandevuTakipler",
                columns: table => new
                {
                    RandevuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    RandevuTarihi = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DoktorAdi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Notlar = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RandevuTakipler", x => x.RandevuId);
                    table.ForeignKey(
                        name: "FK_RandevuTakipler_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rapor",
                columns: table => new
                {
                    RaporId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    RaporTarihi = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RaporIcerigi = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rapor", x => x.RaporId);
                    table.ForeignKey(
                        name: "FK_Rapor_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tavsiyeler",
                columns: table => new
                {
                    TavsiyeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    TavsiyeMetni = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tarih = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tavsiyeler", x => x.TavsiyeId);
                    table.ForeignKey(
                        name: "FK_Tavsiyeler_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SensorVeri",
                columns: table => new
                {
                    SensorVeriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    SensorVeriTipiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorVeri", x => x.SensorVeriId);
                    table.ForeignKey(
                        name: "FK_SensorVeri_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SensorVeri_SensorVeriTipi_SensorVeriTipiId",
                        column: x => x.SensorVeriTipiId,
                        principalTable: "SensorVeriTipi",
                        principalColumn: "SensorVeriTipiId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "YapayZekaAnaliz",
                columns: table => new
                {
                    AnalizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    AnalizTipiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YapayZekaAnaliz", x => x.AnalizId);
                    table.ForeignKey(
                        name: "FK_YapayZekaAnaliz_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YapayZekaAnaliz_YapayZekaAnalizTipi_AnalizTipiId",
                        column: x => x.AnalizTipiId,
                        principalTable: "YapayZekaAnalizTipi",
                        principalColumn: "AnalizTipiId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Aksesuar_KullaniciId",
                table: "Aksesuar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Besin_KullaniciId",
                table: "Besin",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Degerler_DegerTipiId",
                table: "Degerler",
                column: "DegerTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Degerler_KullaniciId",
                table: "Degerler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Hatirlaticilar_HatirlaticiTipiId",
                table: "Hatirlaticilar",
                column: "HatirlaticiTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Hatirlaticilar_KullaniciId",
                table: "Hatirlaticilar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilaclar_KullaniciId",
                table: "Ilaclar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_RandevuTakipler_KullaniciId",
                table: "RandevuTakipler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Rapor_KullaniciId",
                table: "Rapor",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_SensorVeri_KullaniciId",
                table: "SensorVeri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_SensorVeri_SensorVeriTipiId",
                table: "SensorVeri",
                column: "SensorVeriTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Tavsiyeler_KullaniciId",
                table: "Tavsiyeler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_YapayZekaAnaliz_AnalizTipiId",
                table: "YapayZekaAnaliz",
                column: "AnalizTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_YapayZekaAnaliz_KullaniciId",
                table: "YapayZekaAnaliz",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aksesuar");

            migrationBuilder.DropTable(
                name: "Besin");

            migrationBuilder.DropTable(
                name: "Degerler");

            migrationBuilder.DropTable(
                name: "Hatirlaticilar");

            migrationBuilder.DropTable(
                name: "Ilaclar");

            migrationBuilder.DropTable(
                name: "RandevuTakipler");

            migrationBuilder.DropTable(
                name: "Rapor");

            migrationBuilder.DropTable(
                name: "SensorVeri");

            migrationBuilder.DropTable(
                name: "Tavsiyeler");

            migrationBuilder.DropTable(
                name: "YapayZekaAnaliz");

            migrationBuilder.DropTable(
                name: "DegerTipi");

            migrationBuilder.DropTable(
                name: "HatirlaticiTipi");

            migrationBuilder.DropTable(
                name: "SensorVeriTipi");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "YapayZekaAnalizTipi");
        }
    }
}
