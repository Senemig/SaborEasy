using System.Security.Cryptography;
using System.Text;

namespace Sabor_Easy_MVC.Models
{
    public static class Cripto
    {
        public static string GetMd5Hash(string senha)
        {
            MD5 md5Hash = MD5.Create();
            byte[] dado = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

            StringBuilder sBuilder = new StringBuilder();

            for(int i = 0; i < dado.Length; i++)            
            {
                sBuilder.Append(dado[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }                
    }
}