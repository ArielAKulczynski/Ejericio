using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ejercicio.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Identificacion = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.PersonaID);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    numeroCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaID = table.Column<int>(type: "int", nullable: false),
                    tipoCuenta = table.Column<int>(type: "int", nullable: false),
                    saldoInicial = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteIdPersonaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.numeroCuenta);
                    table.ForeignKey(
                        name: "FK_Cuentas_Clientes_ClienteIdPersonaID",
                        column: x => x.ClienteIdPersonaID,
                        principalTable: "Clientes",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    MovimientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaID = table.Column<int>(type: "int", nullable: false),
                    numeroCuenta = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipoMovimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<int>(type: "int", nullable: false),
                    saldo = table.Column<int>(type: "int", nullable: false),
                    PersonaClientePersonaID = table.Column<int>(type: "int", nullable: true),
                    CuentaNumeronumeroCuenta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.MovimientoId);
                    table.ForeignKey(
                        name: "FK_Movimientos_Clientes_PersonaClientePersonaID",
                        column: x => x.PersonaClientePersonaID,
                        principalTable: "Clientes",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movimientos_Cuentas_CuentaNumeronumeroCuenta",
                        column: x => x.CuentaNumeronumeroCuenta,
                        principalTable: "Cuentas",
                        principalColumn: "numeroCuenta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_ClienteIdPersonaID",
                table: "Cuentas",
                column: "ClienteIdPersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_CuentaNumeronumeroCuenta",
                table: "Movimientos",
                column: "CuentaNumeronumeroCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_PersonaClientePersonaID",
                table: "Movimientos",
                column: "PersonaClientePersonaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
