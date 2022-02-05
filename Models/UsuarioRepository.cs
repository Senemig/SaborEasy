using MySqlConnector;

namespace Sabor_Easy_MVC.Models
{
    public class UsuarioRepository : Repository
    {

        public void Insert(Usuario usuario)
        {
            conexao.Open();

            string sql = "INSERT INTO usuario(nome, login, senha) VALUES(@Nome, @Login, @Senha)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@Nome", usuario.Nome);
            comando.Parameters.AddWithValue("@Login", usuario.Login);
            comando.Parameters.AddWithValue("@Senha", Cripto.GetMd5Hash(usuario.Senha));
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public bool Query(Usuario usuario)
        {
            conexao.Open();

            string sql = "SELECT * FROM usuario WHERE login = @Login";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Login", usuario.Login);

            MySqlDataReader reader = comando.ExecuteReader();

            if(reader.Read())
            {
                conexao.Close();
                return true;
            }

            else
            {
                conexao.Close();
                return false;
            }
        }

        public Usuario QueryLogin(Usuario usuario)
        {
            conexao.Open();

            string sql = "SELECT * FROM usuario WHERE login = @Login AND senha = @Senha";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Login", usuario.Login);
            comando.Parameters.AddWithValue("@Senha", Cripto.GetMd5Hash(usuario.Senha));

            MySqlDataReader reader = comando.ExecuteReader();

            Usuario usr = null;

            if(reader.Read())
            {
                usr = new Usuario();
                usr.Id = reader.GetInt32("id");
                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                    usr.Nome = reader.GetString("nome");
                if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                    usr.Senha = reader.GetString("senha");
            }

            conexao.Close();

            return usr;
        }
    }
}