using Microsoft.AspNetCore.Mvc;
using SGV.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SGV.Controllers.RecursosHumanos
{
    public class solicitacaoDesligamentoController : Controller
    {
        private DatabaseContext _solicitacaoDesligamento;

        public solicitacaoDesligamentoController(DatabaseContext db)
        {
            _solicitacaoDesligamento = db;
        }
        [HttpGet]
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var Resultado = _solicitacaoDesligamento.solicitacaoDesligamento.ToList();
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
    }
}
