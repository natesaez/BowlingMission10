using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BowlingMission10.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bowlers",
                columns: table => new
                {
                    BowlerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BowlerFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerMiddleInit = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerLastName = table.Column<string>(type: "TEXT", nullable: false),
                    TeamID = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerAddress = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerCity = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerState = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerZip = table.Column<int>(type: "INTEGER", nullable: false),
                    BowlerPhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowlers", x => x.BowlerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");
        }
    }
}
