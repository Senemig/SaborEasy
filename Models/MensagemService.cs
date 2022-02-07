using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace Sabor_Easy_MVC.Models
{
    public class MensagemService
    {
        public List<Mensagem> ListarTodos()
        {
            using (BDContext bc = new BDContext())
            {
                return (bc.Mensagens.ToList());
            }
        }

        public void Inserir(Mensagem mensagem)
        {
            using (BDContext bc = new BDContext())
            {
                bc.Mensagens.Add(mensagem);
                bc.SaveChanges();
            }
        }
    }
}