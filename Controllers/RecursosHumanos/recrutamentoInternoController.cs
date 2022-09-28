using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Controllers.RecursosHumanos
{
    public class recrutamentoInternoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
