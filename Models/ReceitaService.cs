using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sabor_Easy_MVC.Models
{
    public class ReceitaService
    {
        public void Inserir(Receita receita)
        {
            using (BDContext bc = new BDContext())
            {
                bc.Receitas.Add(receita);
                bc.SaveChanges();
            }
        }

        public List<Receita> ListarTodos()
        {
            using (BDContext bc = new BDContext())
            {
                return (bc.Receitas.ToList());
            }
        }

        public Receita ListarId(int id)
        {
            using (BDContext bc = new BDContext())
            {
                return (bc.Receitas.Find(id));
            }
        }

        public void Atualizar(Receita receita)
        {
            using (BDContext bc = new BDContext())
            {
                Receita r = bc.Receitas.Find(receita.Id);
                r.Titulo = receita.Titulo;
                r.Ingredientes = receita.Ingredientes;
                r.Porcoes = receita.Porcoes;
                r.TempoPreparo = receita.TempoPreparo;
                r.ModoPreparo = receita.ModoPreparo;
                r.imagePath = receita.imagePath;

                bc.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            using (BDContext bc = new BDContext())
            {
                bc.Receitas.Remove(bc.Receitas.Find(id));
                bc.SaveChanges();
            }
        }
    }
}