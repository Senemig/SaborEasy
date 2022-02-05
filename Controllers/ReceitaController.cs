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
            ReceitaRepository rr = new ReceitaRepository();
            rr.Insert(receita);

            return RedirectToAction("Receitas", "Home");
        }

        public IActionResult EditarReceita(int id)
        {
            ReceitaRepository rr = new ReceitaRepository();
            Receita receita = rr.Query(id);

            return View(receita);
        }

        [HttpPost]
        public IActionResult EditarReceita(Receita receita, IFormFile file)
        {
            ReceitaRepository rr = new ReceitaRepository();
            if (file != null)
            {
                receita.imagePath = ImageHandler.UploadImage(file);
            }
            rr.Update(receita);

            return RedirectToAction("Receitas", "Home");
        }

        public IActionResult RemoverReceita(int id)
        {
            ReceitaRepository rr = new ReceitaRepository();
            Receita receita = rr.Query(id);

            return View(receita);
        }

        [HttpPost]
        public IActionResult RemoverReceita(Receita receita)
        {
            ReceitaRepository rr = new ReceitaRepository();
            rr.Delete(receita.receitaId);

            return RedirectToAction("Receitas", "Home");
        }

        public IActionResult ExibirReceita(int id)
        {
            ReceitaRepository rr = new ReceitaRepository();

            Receita receita = rr.Query(id);

            return View("Receita", receita);
        }
    }
}