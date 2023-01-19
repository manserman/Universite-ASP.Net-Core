using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetGestionTaches.Migrations
{
    public partial class CreationRegistre1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilisateur",
                table: "Utilisateur");

            migrationBuilder.RenameTable(
                name: "Utilisateur",
                newName: "Annuaire");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Annuaire",
                table: "Annuaire",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Registre",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NomClasseExecutable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registre", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Annuaire",
                table: "Annuaire");

            migrationBuilder.RenameTable(
                name: "Annuaire",
                newName: "Utilisateur");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilisateur",
                table: "Utilisateur",
                column: "ID");
        }
    }
}
