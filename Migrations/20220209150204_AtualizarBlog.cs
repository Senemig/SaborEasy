using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabor_Easy_MVC.Migrations
{
    public partial class AtualizarBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "conteudo",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "conteudo",
                table: "Posts");
        }
    }
}
