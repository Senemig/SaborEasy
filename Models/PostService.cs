using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Sabor_Easy_MVC.Models
{
    public class PostService
    {
        public List<Post> ListarTodos()
        {
            using (BDContext bc = new BDContext())
            {
                return (bc.Posts.ToList());
            }
        }

        public void Inserir(Post post)
        {
            using (BDContext bc = new BDContext())
            {
                bc.Posts.Add(post);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Post post)
        {
            using (BDContext bc = new BDContext())
            {
                Post p = bc.Posts.Find(post.Id);
                p.titulo = post.titulo;
                p.descricao = post.descricao;
                p.hashtags = post.hashtags;
                p.imagePath = post.imagePath;
                p.conteudo = post.conteudo;

                bc.SaveChanges();
            }
        }
    }
}