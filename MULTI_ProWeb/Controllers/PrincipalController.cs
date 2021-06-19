using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MULTI_ProWeb.Models.Interface;
using MULTI_ProWeb.Models;

namespace MULTI_ProWeb.Controllers
{
    public class PrincipalController : Controller
    {

        //inyectar las dependencias
        private readonly IUsuarioRepository _usuarioRepository;

        public PrincipalController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        //fin de dependencias

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult log()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();     
        }



       
        public IActionResult RegisterUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepository.Add(usuario);
                return RedirectToAction("log");
            }
            else
            {
                return View("register");
            }
        }

    }
}
