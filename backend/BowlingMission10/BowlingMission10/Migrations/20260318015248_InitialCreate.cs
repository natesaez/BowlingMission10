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
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: false),
                    CaptainId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Bowlers",
                columns: table => new
                {
                    BowlerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BowlerFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerMiddleInit = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerLastName = table.Column<string>(type: "TEXT", nullable: false),
                    TeamID = table.Column<int>(type: "INTEGER", nullable: false),
                    BowlerAddress = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerCity = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerState = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerZip = table.Column<int>(type: "INTEGER", nullable: false),
                    BowlerPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowlers", x => x.BowlerId);
                    table.ForeignKey(
                        name: "FK_Bowlers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bowlers_TeamId",
                table: "Bowlers",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
