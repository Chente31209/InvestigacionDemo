using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestigacionWebApiDemo.Migrations
{
    public partial class CinT_Usu_TpDCu1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TiposDeCuentas_Usuarios_UsuarioId",
                table: "TiposDeCuentas");

            migrationBuilder.DropIndex(
                name: "IX_TiposDeCuentas_UsuarioId",
                table: "TiposDeCuentas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TiposDeCuentas");

            migrationBuilder.AddColumn<int>(
                name: "Id_tipoDeCuentaId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Id_tipoDeCuentaId",
                table: "Usuarios",
                column: "Id_tipoDeCuentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposDeCuentas_Id_tipoDeCuentaId",
                table: "Usuarios",
                column: "Id_tipoDeCuentaId",
                principalTable: "TiposDeCuentas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposDeCuentas_Id_tipoDeCuentaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Id_tipoDeCuentaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Id_tipoDeCuentaId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TiposDeCuentas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TiposDeCuentas_UsuarioId",
                table: "TiposDeCuentas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TiposDeCuentas_Usuarios_UsuarioId",
                table: "TiposDeCuentas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
