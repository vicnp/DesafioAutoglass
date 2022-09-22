using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoglass.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    CodProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescProd = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    Frabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    validade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodForne = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DescFornec = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.CodProduto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
