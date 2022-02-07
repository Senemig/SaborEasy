using Microsoft.EntityFrameworkCore;

namespace Sabor_Easy_MVC.Models
{
    public class BDContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=saboreasy;Uid=root;");
        }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }

    }
}