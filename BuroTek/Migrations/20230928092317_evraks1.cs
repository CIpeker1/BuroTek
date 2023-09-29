using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuroTek.Migrations
{
    /// <inheritdoc />
    public partial class evraks1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DosyaAdi",
                table: "evraks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DosyaTuru",
                table: "evraks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EklendigiTarih",
                table: "evraks",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DosyaAdi",
                table: "evraks");

            migrationBuilder.DropColumn(
                name: "DosyaTuru",
                table: "evraks");

            migrationBuilder.DropColumn(
                name: "EklendigiTarih",
                table: "evraks");
        }
    }
}
