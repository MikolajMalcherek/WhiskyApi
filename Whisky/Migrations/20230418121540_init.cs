using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Whisky.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistDB",
                columns: table => new
                {
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    slug = table.Column<string>(type: "TEXT", nullable: false),
                    country = table.Column<string>(type: "TEXT", nullable: false),
                    whiskybase_whiskies = table.Column<string>(type: "TEXT", nullable: false),
                    whiskybase_votes = table.Column<string>(type: "TEXT", nullable: false),
                    whiskybase_rating = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistDB", x => x.name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistDB");
        }
    }
}
