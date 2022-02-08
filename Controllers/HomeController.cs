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
            ReceitaService rs = new ReceitaService();
            PostService ps = new PostService();

            ViewModel viewModel = new ViewModel();

            viewModel.receitas = rs.ListarTodos();
            viewModel.posts = ps.ListarTodos();

            return View(viewModel);
        }

        public IActionResult Receitas(int totalPag, int pagAtual)
        {
            ReceitaService rs = new ReceitaService();
            List<Receita> lista = rs.ListarTodos();
            if (lista.Count <= 6)
            {
                ViewData["totalPag"] = 1;
                ViewData["pagAtual"] = 1;
            }
            else if (lista.Count >= 7)
            {
                ViewData["totalPag"] = (lista.Count / 6 + ((lista.Count % 6) == 0 ? 0 : 1));
                ViewData["pagAtual"] = pagAtual;
            }

            return View(lista);
        }



        public IActionResult Dicas()
        {
            PostService ps = new PostService();
            List<Post> lista = ps.ListarTodos();
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
            PostService ps = new PostService();
            ps.Inserir(post);
            return RedirectToAction("Dicas", "Home");
        }



        [HttpPost]
        public IActionResult EnviarMensagem(Mensagem mensagem)
        {
            mensagem.msgDate = DateTime.Now;
            MensagemService ms = new MensagemService();
            ms.Inserir(mensagem);
            return View("ConfContato", mensagem);
        }

        public IActionResult ListaMensagens()
        {
            MensagemService ms = new MensagemService();
            List<Mensagem> lista = ms.ListarTodos();
            return View(lista);
        }
    }
}
