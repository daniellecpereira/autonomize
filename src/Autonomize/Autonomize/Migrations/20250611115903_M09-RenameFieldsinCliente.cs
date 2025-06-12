using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autonomize.Migrations
{
    /// <inheritdoc />
    public partial class M09RenameFieldsinCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelefoneCliente",
                table: "Clientes",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "NomeCliente",
                table: "Clientes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "EnderecoCliente",
                table: "Clientes",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "EmailCliente",
                table: "Clientes",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Clientes",
                newName: "TelefoneCliente");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Clientes",
                newName: "NomeCliente");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Clientes",
                newName: "EnderecoCliente");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Clientes",
                newName: "EmailCliente");
        }
    }
}
