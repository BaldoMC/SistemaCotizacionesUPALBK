using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Cotizaciones.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Rut = table.Column<string>(nullable: false),
                    Materno = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Paterno = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Rut);
                });

            migrationBuilder.CreateTable(
                name: "Cotizaciones",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonaRut = table.Column<string>(nullable: true),
                    costo = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    fechaCreacion = table.Column<DateTime>(nullable: false),
                    fechaValidez = table.Column<DateTime>(nullable: false),
                    nombreCliente = table.Column<string>(nullable: true),
                    nombreProductor = table.Column<string>(nullable: true),
                    total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizaciones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Personas_PersonaRut",
                        column: x => x.PersonaRut,
                        principalTable: "Personas",
                        principalColumn: "Rut",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_PersonaRut",
                table: "Cotizaciones",
                column: "PersonaRut");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
