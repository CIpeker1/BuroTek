using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuroTek.Migrations
{
    /// <inheritdoc />
    public partial class not : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Not",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "buros",
                columns: table => new
                {
                    BuroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuroAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuroIl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuroIlce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuroSıraNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buros", x => x.BuroId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "buros");

            migrationBuilder.DropColumn(
                name: "Not",
                table: "users");
        }
    }
}
