using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeBar.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class AddPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mesa = table.Column<string>(type: "varchar(250)", nullable: false),
                    Garcom_Id = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    Situacao = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBGarcom",
                        column: x => x.Garcom_Id,
                        principalTable: "TBGarcom",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBPedido_TBProduto",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    ProdutosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPedido_TBProduto", x => new { x.PedidoId, x.ProdutosId });
                    table.ForeignKey(
                        name: "FK_TBPedido_TBProduto_TBPedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "TBPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBProduto_TBProduto_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "TBProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_Garcom_Id",
                table: "TBPedido",
                column: "Garcom_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_TBProduto_ProdutosId",
                table: "TBPedido_TBProduto",
                column: "ProdutosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBPedido_TBProduto");

            migrationBuilder.DropTable(
                name: "TBPedido");
        }
    }
}
