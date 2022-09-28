using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGV.Database;
using SGV.Models;
using System.Linq;

namespace SGV.Controllers
{
    public class UsuarioController : Controller

    {
        private DatabaseContext _db;
        public string Operador { get; set; }

        public UsuarioController(DatabaseContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var Resultado = _db.Usuario.ToList();

            return View(Resultado);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
        [HttpGet]
        public IActionResult Cadastrar([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var Resultado = _db.Usuario.Where(p => p.Nome.StartsWith(usuario.Nome)).ToList();
                if (Resultado.Count != 0)
                {
                    HttpContext.Session.SetString("Resultado_Cad_Usuario", "sim");
                    return View("cadastrar", Resultado);
                }
                HttpContext.Session.SetString("Resultado_Cad_Usuario", "não");
                return View("cadastrar");
            }
            else
            {
                HttpContext.Session.SetString("Resultado_Cad_Usuario", "não");
                return View("cadastrar");
            }
        }
        [HttpPost]
        public IActionResult Cadastrar()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Atualizar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm] Usuario usuario)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Excluir(int Operador)
        {
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Pesquisar([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var Resultado = _db.Usuario.Where(p => p.Nome.StartsWith(usuario.Nome)).ToList();
                if (Resultado.Count != 0)
                {
                    HttpContext.Session.SetString("Resultado_Cad_Usuario", "sim");
                    return View("cadastrar", Resultado);
                }
                HttpContext.Session.SetString("Resultado_Cad_Usuario", "não");
                return View("cadastrar");
            }
            else
            {
                HttpContext.Session.SetString("Resultado_Cad_Usuario", "não");
                return View("cadastrar");
            }

        }

        public IActionResult Solicitar()
        {
            return View();
        }

    }
}
