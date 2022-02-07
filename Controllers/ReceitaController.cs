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
    public class ReceitaController : Controller
    {
        public IActionResult CriarReceita()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarReceita(Receita receita, IFormFile file)
        {
            receita.imagePath = ImageHandler.UploadImage(file);
            receita.dataReceita = DateTime.Now;
            ReceitaService rs = new ReceitaService();
            rs.Inserir(receita);

            return RedirectToAction("Receitas", "Home");
        }

        public IActionResult EditarReceita(int id)
        {
            ReceitaService rs = new ReceitaService();
            Receita receita = rs.ListarId(id);

            return View(receita);
        }

        [HttpPost]
        public IActionResult EditarReceita(Receita receita, IFormFile file)
        {
            ReceitaService rs = new ReceitaService();
            if (file != null)
            {
                receita.imagePath = ImageHandler.UploadImage(file);
            }
            rs.Atualizar(receita);

            return RedirectToAction("Receitas", "Home");
        }

        public IActionResult RemoverReceita(int id)
        {
            ReceitaService rs = new ReceitaService();
            Receita receita = rs.ListarId(id);

            return View(receita);
        }

        [HttpPost]
        public IActionResult RemoverReceita(Receita receita)
        {
            ReceitaService rs = new ReceitaService();
            rs.Remover(receita.Id);

            return RedirectToAction("Receitas", "Home");
        }

        public IActionResult ExibirReceita(int id)
        {
            ReceitaService rs = new ReceitaService();

            Receita receita = rs.ListarId(id);

            return View("Receita", receita);
        }
    }
}