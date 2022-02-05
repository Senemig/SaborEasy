using MySqlConnector;

namespace Sabor_Easy_MVC.Models
{
    public abstract class Repository
    {
        protected const string _strConexao = "DATABASE = SaborEasy; DATA SOURCE = localhost; USER ID = root";
        protected MySqlConnection conexao = new MySqlConnection(_strConexao);
    }
}