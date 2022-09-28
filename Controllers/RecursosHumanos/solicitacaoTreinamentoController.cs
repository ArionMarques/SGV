using Microsoft.AspNetCore.Mvc;
using SGV.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SGV.Controllers.RecursosHumanos
{
    public class solicitacaoTreinamentoController : Controller
    {
        private DatabaseContext _solicitacaoTreinamento;

        public solicitacaoTreinamentoController(DatabaseContext db)
        {
            _solicitacaoTreinamento = db;
        }
        [HttpGet]
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var Resultado = _solicitacaoTreinamento.solicitacaoTreinamento.ToList();
            var ResultadoPaginado = Resultado.ToPagedList(pageNumber, 5);
            return View(ResultadoPaginado);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
        public IActionResult Novo()
        {
            return View();
        }
    }
}
