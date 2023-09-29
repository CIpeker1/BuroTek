using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuroTek.Migrations
{
    /// <inheritdoc />
    public partial class users3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KayitTuru",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KayitTuru",
                table: "users");
        }
    }
}
