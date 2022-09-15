using Microsoft.EntityFrameworkCore.Migrations;

namespace CuidadoRemoto.Persistencia.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sugerencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veterinarios",
                table: "Veterinarios");

            migrationBuilder.RenameTable(
                name: "Veterinarios",
                newName: "Veterinarion");

            migrationBuilder.AddColumn<int>(
                name: "Cedula_Propietario",
                table: "Propietarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_Bovino",
                table: "Bovinos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterinarion",
                table: "Veterinarion",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Indicaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicaciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVisita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadVisitas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indicaciones");

            migrationBuilder.DropTable(
                name: "Visitas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veterinarion",
                table: "Veterinarion");

            migrationBuilder.DropColumn(
                name: "Cedula_Propietario",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "Codigo_Bovino",
                table: "Bovinos");

            migrationBuilder.RenameTable(
                name: "Veterinarion",
                newName: "Veterinarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterinarios",
                table: "Veterinarios",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Sugerencias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sugerencias", x => x.id);
                });
        }
    }
}
