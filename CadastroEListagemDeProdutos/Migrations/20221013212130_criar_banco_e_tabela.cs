using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroEListagemDeProdutos.Migrations
{
    public partial class criar_banco_e_tabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
