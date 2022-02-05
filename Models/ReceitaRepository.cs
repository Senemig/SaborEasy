using System.Collections.Generic;
using MySqlConnector;

namespace Sabor_Easy_MVC.Models
{
    public class ReceitaRepository : Repository
    {

        public void Insert(Receita receita)
        {
            conexao.Open();

            string sql = "INSERT INTO receitas(titulo, ingredientes, modoPreparo, porcoes, tempoPreparo, dataReceita, imagePath) VALUES(@Titulo, @Ingredientes, @modoPreparo, @Porcoes, @tempoPreparo, @dataReceita, @imagePath)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Titulo", receita.Titulo);
            comando.Parameters.AddWithValue("@Ingredientes", receita.Ingredientes);
            comando.Parameters.AddWithValue("@modoPreparo", receita.ModoPreparo);
            comando.Parameters.AddWithValue("@Porcoes", receita.Porcoes);
            comando.Parameters.AddWithValue("@tempoPreparo", receita.TempoPreparo);
            comando.Parameters.AddWithValue("@dataReceita", receita.dataReceita);
            comando.Parameters.AddWithValue("@imagePath", receita.imagePath);
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public List<Receita> Query()
        {
            conexao.Open();

            string sql = "SELECT * FROM receitas ORDER BY dataReceita DESC";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Receita> lista = new List<Receita>();

            while (reader.Read())
            {
                Receita receita = new Receita();
                receita.receitaId = reader.GetInt32("idReceita");
                if (!reader.IsDBNull(reader.GetOrdinal("titulo")))
                    receita.Titulo = reader.GetString("titulo");
                if (!reader.IsDBNull(reader.GetOrdinal("ingredientes")))
                    receita.Ingredientes = reader.GetString("ingredientes");
                if (!reader.IsDBNull(reader.GetOrdinal("modoPreparo")))
                    receita.ModoPreparo = reader.GetString("modoPreparo");
                if (!reader.IsDBNull(reader.GetOrdinal("porcoes")))
                    receita.Porcoes = reader.GetString("porcoes");
                if (!reader.IsDBNull(reader.GetOrdinal("tempoPreparo")))
                    receita.TempoPreparo = reader.GetString("tempoPreparo");
                if (!reader.IsDBNull(reader.GetOrdinal("dataReceita")))
                    receita.dataReceita = reader.GetDateTime("dataReceita");
                if (!reader.IsDBNull(reader.GetOrdinal("imagePath")))
                    receita.imagePath = reader.GetString("imagePath");

                lista.Add(receita);
            }

            conexao.Close();

            return lista;
        }

        public Receita Query(int id)
        {
            conexao.Open();

            string sql = "SELECT * FROM receitas WHERE idReceita = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", id);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                Receita receita = new Receita();
                receita.receitaId = reader.GetInt32("idReceita");
                if (!reader.IsDBNull(reader.GetOrdinal("titulo")))
                    receita.Titulo = reader.GetString("titulo");
                if (!reader.IsDBNull(reader.GetOrdinal("ingredientes")))
                    receita.Ingredientes = reader.GetString("ingredientes");
                if (!reader.IsDBNull(reader.GetOrdinal("modoPreparo")))
                    receita.ModoPreparo = reader.GetString("modoPreparo");
                if (!reader.IsDBNull(reader.GetOrdinal("porcoes")))
                    receita.Porcoes = reader.GetString("porcoes");
                if (!reader.IsDBNull(reader.GetOrdinal("tempoPreparo")))
                    receita.TempoPreparo = reader.GetString("tempoPreparo");
                if (!reader.IsDBNull(reader.GetOrdinal("dataReceita")))
                    receita.dataReceita = reader.GetDateTime("dataReceita");
                if (!reader.IsDBNull(reader.GetOrdinal("imagePath")))
                    receita.imagePath = reader.GetString("imagePath");

                conexao.Close();

                return receita;
            }

            else
            {
                conexao.Close();
                return null;
            }

        }

        public void Update(Receita receita)
        {
            conexao.Open();

            string sql = "UPDATE receitas SET titulo = @Titulo, ingredientes = @Ingredientes, " +
            "modoPreparo = @ModoPreparo, porcoes = @Porcoes, tempoPreparo = @TempoPreparo, " +
            "imagePath = @ImagePath WHERE idReceita = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Titulo", receita.Titulo);
            comando.Parameters.AddWithValue("@Ingredientes", receita.Ingredientes);
            comando.Parameters.AddWithValue("@ModoPreparo", receita.ModoPreparo);
            comando.Parameters.AddWithValue("@Porcoes", receita.Porcoes);
            comando.Parameters.AddWithValue("@TempoPreparo", receita.TempoPreparo);
            comando.Parameters.AddWithValue("@ImagePath", receita.imagePath);
            comando.Parameters.AddWithValue("@Id", receita.receitaId);
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Delete(int id)
        {
            conexao.Open();

            string sql = "DELETE FROM receitas WHERE idReceita = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", id);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}