using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuroTek.Migrations
{
    /// <inheritdoc />
    public partial class qweqwe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "KayitTarihi",
                table: "Notlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KayitTarihi",
                table: "Notlar");
        }
    }
}
