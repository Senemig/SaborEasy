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
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            UsuarioRepository ur = new UsuarioRepository();
            if (!ur.Query(usuario))
            {
                ur.Insert(usuario);
                return RedirectToAction("Login", "Usuario");
            }
            else
            {
                ViewBag.Mensagem = "Login já cadastrado";
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usr = ur.QueryLogin(usuario);

            if (usr != null)
            {
                HttpContext.Session.SetInt32("idUsuario", usr.Id);
                HttpContext.Session.SetString("nomeUsuario", usr.Nome);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.Clear();
                ViewBag.Mensagem = "Usuário não cadastrado!";
                return View();
            }

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}