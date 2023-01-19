using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetGestionTaches.Migrations
{
    public partial class CreationRegistre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
