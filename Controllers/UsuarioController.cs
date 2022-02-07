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
            UsuarioService us = new UsuarioService();
            if (us.BuscarLogin(usuario.Login) == null)
            {
                us.Inserir(usuario);
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
            UsuarioService us = new UsuarioService();
            Usuario u = us.BuscarLogin(usuario.Login);

            if (us.ValidarUsuario(usuario))
            {
                HttpContext.Session.SetInt32("idUsuario", u.Id);
                HttpContext.Session.SetString("nomeUsuario", u.Nome);
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