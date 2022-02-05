using System.Collections.Generic;

namespace Sabor_Easy_MVC.Models
{
    public static class ListaMensagem
    {
        private static List<Mensagem> listaMensagens = new List<Mensagem>();

        public static void IncluirMensagem(Mensagem msg)
        {
            listaMensagens.Add(msg);
        }

        public static List<Mensagem> ListarMensagens()
        {
            return listaMensagens;
        }
    }
}