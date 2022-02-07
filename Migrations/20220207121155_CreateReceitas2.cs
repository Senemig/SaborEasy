using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabor_Easy_MVC.Migrations
{
    public partial class CreateReceitas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_receitas",
                table: "receitas");

            migrationBuilder.DropColumn(
                name: "receitaId",
                table: "receitas");

            migrationBuilder.RenameTable(
                name: "receitas",
                newName: "Receitas");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Receitas",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receitas",
                table: "Receitas",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Receitas",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Receitas");

            migrationBuilder.RenameTable(
                name: "Receitas",
                newName: "receitas");

            migrationBuilder.AddColumn<int>(
                name: "receitaId",
                table: "receitas",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_receitas",
                table: "receitas",
                column: "receitaId");
        }
    }
}
