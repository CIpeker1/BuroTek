using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuroTek.Migrations
{
    /// <inheritdoc />
    public partial class notlarrssaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KayitTarihi",
                table: "Notlar",
                newName: "Tarih");

            migrationBuilder.AddColumn<int>(
                name: "DurumId",
                table: "Notlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_DurumId",
                table: "Notlar",
                column: "DurumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notlar_Durum_DurumId",
                table: "Notlar",
                column: "DurumId",
                principalTable: "Durum",
                principalColumn: "DurumId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notlar_Durum_DurumId",
                table: "Notlar");

            migrationBuilder.DropIndex(
                name: "IX_Notlar_DurumId",
                table: "Notlar");

            migrationBuilder.DropColumn(
                name: "DurumId",
                table: "Notlar");

            migrationBuilder.RenameColumn(
                name: "Tarih",
                table: "Notlar",
                newName: "KayitTarihi");
        }
    }
}
