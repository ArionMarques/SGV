using Microsoft.AspNetCore.Mvc;
using SGV.Database;
using SGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SGV.Controllers
{
    public class SoftwaresController : Controller
    {
        private DatabaseContext _db;
        public SoftwaresController(DatabaseContext db)
        {
            _db = db;
        }
        public ActionResult MyAction(string submitButton)
        {
            switch (submitButton)
            {
                case "limpar":
                    // call another action to perform the cancellation
                    return Novo();
                case "editar":
                    // call another action to perform the cancellation
                    return Novo();
                default:
                    // If they've submitted the form without a submitButton, 
                    // just return the view again.
                    return View("Index");
            }
        }
        [HttpGet]
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var Resultado = _db.Softwares.ToList();
            var ResultadoPaginado = Resultado.ToPagedList(pageNumber, 5);
            return View(ResultadoPaginado);
        }

        [HttpGet]
        public IActionResult Visualizar(int Id)
        {
            Softwares softwares = _db.Softwares.Find(Id);
            return View(softwares);
        }
        public ActionResult Novo()
        {
            return View("Novo");
        }
        [HttpPost]
        public ActionResult Cadastrar([FromForm] Softwares softwares)
        {
            if (ModelState.IsValid)
            {
                _db.Softwares.Add(softwares);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("novo", softwares);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Softwares softwares)
        {
            if (ModelState.IsValid)
            {
                _db.Softwares.Update(softwares);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Editar");
        }

        [HttpGet]
        public IActionResult Editar(int Id)
        {
            Softwares softwares = _db.Softwares.Find(Id);
            return View(softwares);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
