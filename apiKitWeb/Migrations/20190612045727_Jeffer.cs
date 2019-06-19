using Microsoft.EntityFrameworkCore.Migrations;

namespace apiKitWeb.Migrations
{
    public partial class Jeffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_kitNets_KitNetId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_KitNetId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kitNets",
                table: "kitNets");

            migrationBuilder.DropColumn(
                name: "KitNetId",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "kitNets",
                newName: "KitNets");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "KitNets",
                newName: "KitNetId");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "KitNets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KitNets",
                table: "KitNets",
                column: "KitNetId");

            migrationBuilder.CreateIndex(
                name: "IX_KitNets_UsuarioId",
                table: "KitNets",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_KitNets_Usuarios_UsuarioId",
                table: "KitNets",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KitNets_Usuarios_UsuarioId",
                table: "KitNets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KitNets",
                table: "KitNets");

            migrationBuilder.DropIndex(
                name: "IX_KitNets_UsuarioId",
                table: "KitNets");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "KitNets");

            migrationBuilder.RenameTable(
                name: "KitNets",
                newName: "kitNets");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "KitNetId",
                table: "kitNets",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "KitNetId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_kitNets",
                table: "kitNets",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_KitNetId",
                table: "Usuarios",
                column: "KitNetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_kitNets_KitNetId",
                table: "Usuarios",
                column: "KitNetId",
                principalTable: "kitNets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
