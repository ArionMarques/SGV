using Microsoft.AspNetCore.Mvc;

namespace SGV.Controllers.Informatica
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            return View();
        }
    }
}
