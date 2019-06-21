using Microsoft.EntityFrameworkCore.Migrations;

namespace apiKitWeb.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KitNets_Usuarios_UsuarioId",
                table: "KitNets");

            migrationBuilder.DropIndex(
                name: "IX_KitNets_UsuarioId",
                table: "KitNets");

            migrationBuilder.DropColumn(
                name: "Localizacao",
                table: "KitNets");

            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "KitNets",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "KitNets",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "KitNets");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "KitNets");

            migrationBuilder.AddColumn<string>(
                name: "Localizacao",
                table: "KitNets",
                nullable: true);

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
    }
}
