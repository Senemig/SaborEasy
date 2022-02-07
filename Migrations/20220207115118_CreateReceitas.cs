using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabor_Easy_MVC.Migrations
{
    public partial class CreateReceitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "receitas",
                columns: table => new
                {
                    receitaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    imagePath = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(nullable: true),
                    Ingredientes = table.Column<string>(nullable: true),
                    ModoPreparo = table.Column<string>(nullable: true),
                    Porcoes = table.Column<string>(nullable: true),
                    TempoPreparo = table.Column<string>(nullable: true),
                    dataReceita = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receitas", x => x.receitaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "receitas");
        }
    }
}
