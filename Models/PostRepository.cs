using System.Collections.Generic;
using MySqlConnector;

namespace Sabor_Easy_MVC.Models
{
    public class PostRepository : Repository
    {

        public void Insert(Post post)
        {
            conexao.Open();

            string sql = "INSERT INTO posts(titulo, hashtags, descricao, imagePath, postDate) VALUES(@Titulo, @Hashtags, @Descricao, @imagePath, @postDate)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Titulo", post.titulo);
            comando.Parameters.AddWithValue("@Hashtags", post.hashtags);
            comando.Parameters.AddWithValue("@Descricao", post.descricao);
            comando.Parameters.AddWithValue("@imagePath", post.imagePath);
            comando.Parameters.AddWithValue("@postDate", post.postDate);
            comando.ExecuteNonQuery();

            conexao.Close(); 
        }

        public List<Post> Querry()
        {
            conexao.Open();

            string sql = "SELECT * FROM posts ORDER BY postDate DESC";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Post> lista = new List<Post>();

            while(reader.Read())
            {
                Post post = new Post();
                post.postId = reader.GetInt32("idPost");
                if(!reader.IsDBNull(reader.GetOrdinal("titulo")))
                    post.titulo = reader.GetString("titulo");
                if(!reader.IsDBNull(reader.GetOrdinal("hashtags")))
                    post.hashtags = reader.GetString("hashtags");
                if(!reader.IsDBNull(reader.GetOrdinal("descricao")))
                    post.descricao = reader.GetString("descricao");
                if(!reader.IsDBNull(reader.GetOrdinal("imagePath")))
                    post.imagePath = reader.GetString("imagePath");
                if(!reader.IsDBNull(reader.GetOrdinal("postDate")))
                    post.postDate = reader.GetDateTime("postdate");

                lista.Add(post);
            }

            conexao.Close();

            return lista;
        }
    }
}