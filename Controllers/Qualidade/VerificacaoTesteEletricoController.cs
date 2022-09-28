using Microsoft.AspNetCore.Mvc;

namespace SGV.Controllers.Qualidade
{
    public class VerificacaoTesteEletricoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Visualizar()
        {
            return View();
        }
        public IActionResult Novo()
        {
            return View();
        }
    }
}
