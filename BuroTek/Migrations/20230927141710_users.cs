using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuroTek.Migrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Durum",
                columns: table => new
                {
                    DurumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Durum", x => x.DurumId);
                });

            migrationBuilder.CreateTable(
                name: "evraks",
                columns: table => new
                {
                    EvrakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvrakTuruID = table.Column<int>(type: "int", nullable: false),
                    BelgeTuruID = table.Column<int>(type: "int", nullable: false),
                    KisiAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KurumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DosyaNo = table.Column<int>(type: "int", nullable: false),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BelgeKayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BelgeNo = table.Column<int>(type: "int", nullable: false),
                    KurumBelgeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evraks", x => x.EvrakID);
                });

            migrationBuilder.CreateTable(
                name: "Notlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Not = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciTipi = table.Column<int>(type: "int", nullable: false),
                    DurumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_users_Durum_DurumId",
                        column: x => x.DurumId,
                        principalTable: "Durum",
                        principalColumn: "DurumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_DurumId",
                table: "users",
                column: "DurumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "evraks");

            migrationBuilder.DropTable(
                name: "Notlar");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Durum");
        }
    }
}
