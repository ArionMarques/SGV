using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Controllers.Laboratorio
{
    public class RNCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Responder()
        {
            return View();
        }
    }
}
