using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestigacionWebApiDemo.Migrations
{
    public partial class Nueva_Tabla_TienePermisos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "TienePermioso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_tipoDeCuentaId = table.Column<int>(type: "int", nullable: true),
                    Id_permisosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TienePermioso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TienePermioso_Permisos_Id_permisosId",
                        column: x => x.Id_permisosId,
                        principalTable: "Permisos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TienePermioso_TiposDeCuentas_Id_tipoDeCuentaId",
                        column: x => x.Id_tipoDeCuentaId,
                        principalTable: "TiposDeCuentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TienePermioso_Id_permisosId",
                table: "TienePermioso",
                column: "Id_permisosId");

            migrationBuilder.CreateIndex(
                name: "IX_TienePermioso_Id_tipoDeCuentaId",
                table: "TienePermioso",
                column: "Id_tipoDeCuentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TienePermioso");

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
    }
}
