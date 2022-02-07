using System.Collections.Generic;
using System.Linq;

namespace Sabor_Easy_MVC.Models
{
    public class UsuarioService
    {
        public void Inserir(Usuario usuario)
        {
            using (BDContext bc = new BDContext())
            {
                usuario.Senha = Cripto.GetMd5Hash(usuario.Senha);
                bc.Usuarios.Add(usuario);
                bc.SaveChanges();
            }
        }

        public Usuario BuscarLogin(string login)
        {
            using (BDContext bc = new BDContext())
            {
                Usuario u = bc.Usuarios.Where(u => u.Login == login).FirstOrDefault();

                return u;
            }
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            using (BDContext bc = new BDContext())
            {
                if (bc.Usuarios.Where(u => u.Login == usuario.Login && u.Senha == Cripto.GetMd5Hash(usuario.Senha)).FirstOrDefault() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<Usuario> ListarTodos()
        {
            using (BDContext bc = new BDContext())
            {
                return (bc.Usuarios.ToList());
            }
        }

        public Usuario BuscarPorId(int id)
        {
            using (BDContext bc = new BDContext())
            {
                return (bc.Usuarios.Find(id));
            }
        }

        public void Editar(Usuario usuario)
        {
            using (BDContext bc = new BDContext())
            {
                Usuario user = bc.Usuarios.Find(usuario.Id);
                user.Nome = usuario.Nome;
                user.Login = usuario.Login;
                user.Senha = Cripto.GetMd5Hash(usuario.Senha);

                bc.SaveChanges();
            }
        }
    }
}