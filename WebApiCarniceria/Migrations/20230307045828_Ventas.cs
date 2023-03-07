using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCarniceria.Migrations
{
    public partial class Ventas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "apellido",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "direccion",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefono",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id_venta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId_cliente = table.Column<int>(type: "int", nullable: true),
                    fecha_venta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id_venta);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_clienteId_cliente",
                        column: x => x.clienteId_cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_cliente");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_clienteId_cliente",
                table: "Ventas",
                column: "clienteId_cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropColumn(
                name: "apellido",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "direccion",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "telefono",
                table: "Clientes");
        }
    }
}
