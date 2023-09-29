using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuroTek.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notlar_Durum_DurumId",
                table: "Notlar");

            migrationBuilder.DropForeignKey(
                name: "FK_users_Durum_DurumId",
                table: "users");

            migrationBuilder.DropTable(
                name: "Durum");

            migrationBuilder.DropIndex(
                name: "IX_users_DurumId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_Notlar_DurumId",
                table: "Notlar");

            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "users");

            migrationBuilder.DropColumn(
                name: "DurumId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "DurumId",
                table: "Notlar");

            migrationBuilder.RenameColumn(
                name: "Not",
                table: "users",
                newName: "Durum");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Durum",
                table: "users",
                newName: "Not");

            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DurumId",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DurumId",
                table: "Notlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_users_DurumId",
                table: "users",
                column: "DurumId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_users_Durum_DurumId",
                table: "users",
                column: "DurumId",
                principalTable: "Durum",
                principalColumn: "DurumId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
