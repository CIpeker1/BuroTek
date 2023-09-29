using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuroTek.Migrations
{
    /// <inheritdoc />
    public partial class evrakupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DosyaNo",
                table: "evraks");

            migrationBuilder.RenameColumn(
                name: "KurumBelgeTarihi",
                table: "evraks",
                newName: "KurumKayitTarihi");

            migrationBuilder.RenameColumn(
                name: "KurumAdi",
                table: "evraks",
                newName: "KurumBelgeNo");

            migrationBuilder.RenameColumn(
                name: "KisiAdi",
                table: "evraks",
                newName: "GeldigiGittigiKurum");

            migrationBuilder.RenameColumn(
                name: "EklendigiTarih",
                table: "evraks",
                newName: "GeldigiGittigiKisi");

            migrationBuilder.RenameColumn(
                name: "DosyaTuru",
                table: "evraks",
                newName: "BelgeTuru");

            migrationBuilder.RenameColumn(
                name: "DosyaAdi",
                table: "evraks",
                newName: "BaglantiliBuroDosyaNo");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "evraks",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "evraks");

            migrationBuilder.RenameColumn(
                name: "KurumKayitTarihi",
                table: "evraks",
                newName: "KurumBelgeTarihi");

            migrationBuilder.RenameColumn(
                name: "KurumBelgeNo",
                table: "evraks",
                newName: "KurumAdi");

            migrationBuilder.RenameColumn(
                name: "GeldigiGittigiKurum",
                table: "evraks",
                newName: "KisiAdi");

            migrationBuilder.RenameColumn(
                name: "GeldigiGittigiKisi",
                table: "evraks",
                newName: "EklendigiTarih");

            migrationBuilder.RenameColumn(
                name: "BelgeTuru",
                table: "evraks",
                newName: "DosyaTuru");

            migrationBuilder.RenameColumn(
                name: "BaglantiliBuroDosyaNo",
                table: "evraks",
                newName: "DosyaAdi");

            migrationBuilder.AddColumn<int>(
                name: "DosyaNo",
                table: "evraks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
