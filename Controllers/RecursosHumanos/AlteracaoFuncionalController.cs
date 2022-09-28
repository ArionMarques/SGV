using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGV.Database;
using X.PagedList;

namespace SGV.Controllers.RecursosHumanos
{
    public class AlteracaoFuncionalController : Controller
    {
        private DatabaseContext _AlteracaoFuncional;

        public AlteracaoFuncionalController(DatabaseContext db)
        {
            _AlteracaoFuncional = db;
        }
        [HttpGet]
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var Resultado = _AlteracaoFuncional.AlteracaoFuncional.ToList();
            var ResultadoPaginado = Resultado.ToPagedList(pageNumber, 5);
            return View(ResultadoPaginado);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Novo()
        {
            return View();
        }
        public ActionResult Visualizar()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }
        public ActionResult Salvar()
        {
            return View();
        }
        public ActionResult Apagar()
        {
            return View();
        }
    }
}