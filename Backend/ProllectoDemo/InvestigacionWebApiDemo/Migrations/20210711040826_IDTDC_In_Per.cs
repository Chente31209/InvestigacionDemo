using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestigacionWebApiDemo.Migrations
{
    public partial class IDTDC_In_Per : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_tipoDeCuentaId",
                table: "Permisos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_Id_tipoDeCuentaId",
                table: "Permisos",
                column: "Id_tipoDeCuentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_TiposDeCuentas_Id_tipoDeCuentaId",
                table: "Permisos",
                column: "Id_tipoDeCuentaId",
                principalTable: "TiposDeCuentas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_TiposDeCuentas_Id_tipoDeCuentaId",
                table: "Permisos");

            migrationBuilder.DropIndex(
                name: "IX_Permisos_Id_tipoDeCuentaId",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "Id_tipoDeCuentaId",
                table: "Permisos");
        }
    }
}
