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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ReceitaRepository rr = new ReceitaRepository();
            PostRepository pr = new PostRepository();
            
            ViewModel viewModel = new ViewModel();

            viewModel.receitas = rr.Query();
            viewModel.posts = pr.Querry();

            return View(viewModel);
        }

        public IActionResult Receitas()
        {
            ReceitaRepository rr = new ReceitaRepository();
            List<Receita> lista = rr.Query();
            return View(lista);
        }

        

        public IActionResult Dicas()
        {
            PostRepository pr = new PostRepository();
            List<Post> lista = pr.Querry();
            return View(lista);
        }

        public IActionResult Contato()
        {
            return View();
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
            PostRepository pr = new PostRepository();
            pr.Insert(post);
            return RedirectToAction("Dicas", "Home");
        }

        

        [HttpPost]
        public IActionResult EnviarMensagem(Mensagem msg)
        {
            msg.msgDate = DateTime.Now;
            MensagemRepository mr = new MensagemRepository();
            mr.Insert(msg);
            return View("ConfContato", msg);
        }

        public IActionResult ListaMensagens()
        {
            MensagemRepository mr = new MensagemRepository();
            List<Mensagem> lista = mr.Query();
            return View(lista);
        }
    }
}
