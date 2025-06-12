using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autonomize.Migrations
{
    /// <inheritdoc />
    public partial class M04AddRelatorio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Vendas");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVenda",
                table: "Vendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RelatorioId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RelatorioId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Relatorios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoItem = table.Column<int>(type: "int", nullable: false),
                    TipoAlteracao = table.Column<int>(type: "int", nullable: false),
                    TipoRelatorio = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Itens = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_RelatorioId",
                table: "Produtos",
                column: "RelatorioId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_RelatorioId",
                table: "Clientes",
                column: "RelatorioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Relatorios_RelatorioId",
                table: "Clientes",
                column: "RelatorioId",
                principalTable: "Relatorios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Relatorios_RelatorioId",
                table: "Produtos",
                column: "RelatorioId",
                principalTable: "Relatorios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Clientes_ClienteId",
                table: "Vendas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Relatorios_RelatorioId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Relatorios_RelatorioId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Clientes_ClienteId",
                table: "Vendas");

            migrationBuilder.DropTable(
                name: "Relatorios");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_RelatorioId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_RelatorioId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "DataVenda",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "RelatorioId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "RelatorioId",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "IdCliente");

            migrationBuilder.AddColumn<string>(
                name: "Cliente",
                table: "Vendas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
