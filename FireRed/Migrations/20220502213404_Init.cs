using Microsoft.EntityFrameworkCore.Migrations;

namespace FireRed.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lv = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderType = table.Column<int>(type: "int", nullable: false),
                    PokemonStatsId = table.Column<int>(type: "int", nullable: false),
                    PokemonMovesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonMoves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonCanUse = table.Column<bool>(type: "bit", nullable: false),
                    MoveLV = table.Column<int>(type: "int", nullable: false),
                    MoveName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoveCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovePower = table.Column<int>(type: "int", nullable: false),
                    MoveAccurancy = table.Column<int>(type: "int", nullable: false),
                    MovePP = table.Column<int>(type: "int", nullable: false),
                    PokemomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMoves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonMoves_Pokemons_PokemomId",
                        column: x => x.PokemomId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HP = table.Column<int>(type: "int", nullable: false),
                    ATK = table.Column<int>(type: "int", nullable: false),
                    DEF = table.Column<int>(type: "int", nullable: false),
                    SPATK = table.Column<int>(type: "int", nullable: false),
                    SPDEF = table.Column<int>(type: "int", nullable: false),
                    SPEED = table.Column<int>(type: "int", nullable: false),
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonStats_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMoves_PokemomId",
                table: "PokemonMoves",
                column: "PokemomId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonStats_PokemonId",
                table: "PokemonStats",
                column: "PokemonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonMoves");

            migrationBuilder.DropTable(
                name: "PokemonStats");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
