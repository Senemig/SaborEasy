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

        public IActionResult Posting()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
                return RedirectToAction("Login", "Usuario");
            else
                return View();
        }

        [HttpPost]
        public IActionResult NovoPost(Post post, IFormFile file)
        {
            post.imagePath = ImageHandler.UploadImage(file);
            post.postDate = DateTime.Now;
            PostService ps = new PostService();
            ps.Inserir(post);
            return RedirectToAction("Dicas", "Blog");
        }

    }
}