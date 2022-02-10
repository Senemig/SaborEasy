using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabor_Easy_MVC.Migrations
{
    public partial class VideoReceita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "videoPath",
                table: "Receitas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "videoPath",
                table: "Receitas");
        }
    }
}
