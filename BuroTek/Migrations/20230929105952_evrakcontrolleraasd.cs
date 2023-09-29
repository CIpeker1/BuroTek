using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuroTek.Migrations
{
    /// <inheritdoc />
    public partial class evrakcontrolleraasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EvrakTuruID",
                table: "evraks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EvrakTuruID",
                table: "evraks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
