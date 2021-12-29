using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turnos.Migrations
{
    public partial class MigracionMedicoEspecialidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "HorarioAtencionDesde",
                table: "Medico",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HorarioAtencionAntes",
                table: "Medico",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false);

            migrationBuilder.CreateTable(
                name: "MedicoEspecialidad",
                columns: table => new
                {
                    IdMedico = table.Column<int>(nullable: false),
                    IdEspecialidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoEspecialidad", x => new { x.IdMedico, x.IdEspecialidad });
                    table.ForeignKey(
                        name: "FK_MedicoEspecialidad_Especialidad_IdEspecialidad",
                        column: x => x.IdEspecialidad,
                        principalTable: "Especialidad",
                        principalColumn: "IdEspecialidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoEspecialidad_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicoEspecialidad_IdEspecialidad",
                table: "MedicoEspecialidad",
                column: "IdEspecialidad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicoEspecialidad");

            migrationBuilder.AlterColumn<string>(
                name: "HorarioAtencionDesde",
                table: "Medico",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldUnicode: false);

            migrationBuilder.AlterColumn<string>(
                name: "HorarioAtencionAntes",
                table: "Medico",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldUnicode: false);
        }
    }
}
