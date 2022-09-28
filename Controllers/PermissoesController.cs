using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGV.Database;
using System.Linq;

namespace SGV.Controllers
{
    public class PermissoesController : Controller
    {
        private DatabaseContext _db;

        public PermissoesController(DatabaseContext db)
        {
            _db = db;
        }
        public IActionResult Index(int id)
        {
            int fk_id_operador = id;
            var Resultado = _db.Permissoes.Find(fk_id_operador);
            return Redirect("/home/index/");
        }

        public ActionResult Permissoes(int id)
        {
            var q = (from p in _db.Permissoes
                     from f in _db.Menus
                     .Where(f => f.Id == p.fk_Menu)
                     from s in _db.Sub_Menus
                     .Where(s => s.Id == p.fk_Sub_Menu)
                     .DefaultIfEmpty()
                     where p.fk_Operador == id
                     select new
                     {
                         p.Editar,
                         p.Apagar,
                         p.Imprimir,
                         MenuName = (string)f.Menu,
                         SubMenuName = (string)s.Sub_Menu
                     }).ToList();
            
            if (q.Count > 0)
            {
                foreach (var consulta in q)
                {
                    TempData["NomeMenu" + consulta.MenuName] = true;
                    TempData["NomeSubMenu" + consulta.SubMenuName] = true;
                    TempData["EditarMenu" + consulta.MenuName] = consulta.Editar;
                    TempData["ApagarMenu" + consulta.MenuName] = consulta.Apagar;
                    TempData["ImprimirMenu" + consulta.MenuName] = consulta.Imprimir;
                }
            }

            return RedirectToAction("index", "home", q);
        }

    }
}
