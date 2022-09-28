using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGV.Database;

namespace SGV.Controllers
{
    public class Sub_SetorController : Controller
    {
        private DatabaseContext _Sub_Setor;

        public Sub_SetorController(DatabaseContext Sub_Setor)
        {
            _Sub_Setor = Sub_Setor;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Seleciona()
        {
            var q = (from p in _Sub_Setor.Sub_Setor
                     from f in _Sub_Setor.Setor
                     .Where(f => f.Id == p.Id)
                     .DefaultIfEmpty()
                     where p.Id == 29
                     select new
                     {
                         p.Id,
                         p.Descricao,
                     }).ToList();

            return View();
        }
    }
}
