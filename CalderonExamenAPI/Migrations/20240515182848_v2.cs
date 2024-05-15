using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalderonExamenAPI.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musicas",
                table: "Musicas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artistas",
                table: "Artistas");

            migrationBuilder.RenameTable(
                name: "Musicas",
                newName: "Musica");

            migrationBuilder.RenameTable(
                name: "Artistas",
                newName: "Artista");

            migrationBuilder.RenameIndex(
                name: "IX_Musicas_ArtistaId",
                table: "Musica",
                newName: "IX_Musica_ArtistaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musica",
                table: "Musica",
                column: "MusicaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artista",
                table: "Artista",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musica_Artista_ArtistaId",
                table: "Musica",
                column: "ArtistaId",
                principalTable: "Artista",
                principalColumn: "ArtistaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musica_Artista_ArtistaId",
                table: "Musica");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musica",
                table: "Musica");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artista",
                table: "Artista");

            migrationBuilder.RenameTable(
                name: "Musica",
                newName: "Musicas");

            migrationBuilder.RenameTable(
                name: "Artista",
                newName: "Artistas");

            migrationBuilder.RenameIndex(
                name: "IX_Musica_ArtistaId",
                table: "Musicas",
                newName: "IX_Musicas_ArtistaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musicas",
                table: "Musicas",
                column: "MusicaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artistas",
                table: "Artistas",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "ArtistaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
