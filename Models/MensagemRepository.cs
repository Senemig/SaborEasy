using System.Collections.Generic;
using MySqlConnector;

namespace Sabor_Easy_MVC.Models
{
    public class MensagemRepository : Repository
    {

        public void Insert(Mensagem mensagem)
        {
            conexao.Open();

            string sql = "INSERT INTO mensagens(nome, email, mensagem, msgDate) VALUES(@Nome, @Email, @Mensagem, @msgDate)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", mensagem.nome);
            comando.Parameters.AddWithValue("@Email", mensagem.email);
            comando.Parameters.AddWithValue("@Mensagem", mensagem.mensagem);
            comando.Parameters.AddWithValue("@msgDate", mensagem.msgDate);
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public List<Mensagem> Query()
        {
            conexao.Open();

            string sql = "SELECT * FROM mensagens";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Mensagem> lista = new List<Mensagem>();

            while(reader.Read())
            {
                Mensagem mensagem = new Mensagem();
                mensagem.msgId = reader.GetInt32("idMensagem");
                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                    mensagem.nome = reader.GetString("nome");
                if (!reader.IsDBNull(reader.GetOrdinal("email")))
                    mensagem.email = reader.GetString("email");
                if (!reader.IsDBNull(reader.GetOrdinal("mensagem")))
                    mensagem.mensagem = reader.GetString("mensagem");
                if (!reader.IsDBNull(reader.GetOrdinal("msgDate")))
                    mensagem.msgDate = reader.GetDateTime("msgDate");

                lista.Add(mensagem);
            }

            conexao.Close();

            return lista;
        }
    }
}