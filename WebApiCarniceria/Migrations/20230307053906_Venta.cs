using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCarniceria.Migrations
{
    public partial class Venta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_cliente",
                table: "Ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_cliente",
                table: "Ventas");
        }
    }
}
