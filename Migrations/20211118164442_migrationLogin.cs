using Microsoft.EntityFrameworkCore.Migrations;

namespace Turnos.Migrations
{
    public partial class migrationLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaHoraInicio",
                table: "Turno",
                newName: "fechaHoraInicio");

            migrationBuilder.RenameColumn(
                name: "FechaHoraFin",
                table: "Turno",
                newName: "fechaHoraFin");

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LoginId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.RenameColumn(
                name: "fechaHoraInicio",
                table: "Turno",
                newName: "FechaHoraInicio");

            migrationBuilder.RenameColumn(
                name: "fechaHoraFin",
                table: "Turno",
                newName: "FechaHoraFin");
        }
    }
}
