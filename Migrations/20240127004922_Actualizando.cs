using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegPrioridades.Migrations
{
    /// <inheritdoc />
    public partial class Actualizando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dirección",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Descripción",
                table: "Prioridades",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "Teléfono",
                table: "Clientes",
                newName: "Direccion");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Clientes",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Prioridades",
                newName: "Descripción");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Clientes",
                newName: "Teléfono");

            migrationBuilder.AddColumn<string>(
                name: "Dirección",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
