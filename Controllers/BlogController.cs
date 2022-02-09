using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sabor_Easy_MVC.Models;

namespace Sabor_Easy_MVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Dicas()
        {
            PostService ps = new PostService();
            List<Post> lista = ps.ListarTodos();
            return View(lista);
        }

        public IActionResult NovoPost(int id)
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
                return RedirectToAction("Login", "Usuario");
            else
            {
                if (id == 0)
                {
                    return View();
                }
                else
                {
                    PostService ps = new PostService();
                    return View(ps.ListarPorId(id));
                }
            }
        }

        [HttpPost]
        public IActionResult NovoPost(Post post, IFormFile file)
        {
            PostService ps = new PostService();
            if (post.Id == 0)
            {
                post.imagePath = ImageHandler.UploadImage(file);
                post.postDate = DateTime.Now;
                ps.Inserir(post);
                return RedirectToAction("Dicas", "Blog");

            }
            else
            {
                post.imagePath = ImageHandler.UploadImage(file);
                ps.Atualizar(post);
                return RedirectToAction("Post", post);
            }
        }

        public IActionResult Post(int id)
        {
            PostService ps = new PostService();

            return View(ps.ListarPorId(id));
        }
    }
}