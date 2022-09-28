using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGV.Database;
using SGV.Library.Filters;
using SGV.Library.Filters.SolicitaUsuario;
using SGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SGV.Controllers
{
    public class SolicitacaoUsuarioController : Controller
    {
        private DatabaseContext _dbSolicitaUsuario;

        public SolicitacaoUsuarioController(DatabaseContext db)
        {
            _dbSolicitaUsuario = db;
        }
        [PermissaoSolicitaUsuario]
        [HttpGet]
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var Resultado = _dbSolicitaUsuario.SolicitacaoUsuario.ToList();
            var ResultadoPaginado = Resultado.ToPagedList(pageNumber, 5);
            return View(ResultadoPaginado);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
        [HttpGet]
        [NovoSolicitaUsuario]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        [SalvarSolicitaUsuario]
        public IActionResult Salvar([FromForm] SolicitacaoUsuario SolicitacaoUsuario)
        {

            string sub_menu = Request.Form["setor"];
            var consulta = from m in _dbSolicitaUsuario.Sub_Setor
                           where m.Valor == sub_menu
                           select m;
            int numeral = 0;
            foreach (var resultado in consulta)
            {
                numeral = resultado.Id;
            }
            var s = new SolicitacaoUsuario
            {
                Nome = SolicitacaoUsuario.Nome,
                Setor = numeral,
                Local = SolicitacaoUsuario.Local,
                Data_Comeco = SolicitacaoUsuario.Data_Comeco,
                OperadorSolicitacao = int.Parse(HttpContext.Session.GetString("Codigo")),
                Email = SolicitacaoUsuario.Email,
                Compumate = SolicitacaoUsuario.Compumate,
                NovaEstacao = SolicitacaoUsuario.NovaEstacao,
                SoftwarePadrao = SolicitacaoUsuario.SoftwarePadrao,
                SoftwareEspecial = SolicitacaoUsuario.SoftwareEspecial,
                AcessoInternet = SolicitacaoUsuario.AcessoInternet,
                AcessoPastas = SolicitacaoUsuario.AcessoPastas,
                Ramal = SolicitacaoUsuario.Ramal,
                Skype = SolicitacaoUsuario.Skype,
                Observacoes = SolicitacaoUsuario.Observacoes,
                Data_Criacao = DateTime.Now,
                Data_Alteracao = DateTime.Now,
                Status = 1
            };

            _dbSolicitaUsuario.SolicitacaoUsuario.Add(s);
            _dbSolicitaUsuario.SaveChanges();
            return View("index");

        }
        [HttpGet]
        [PermissaoSolicitaUsuario]
        public ActionResult Visualizar(int Id)
        {
            var visualizacao = _dbSolicitaUsuario.SolicitacaoUsuario.Find(Id);
            var q = (from p in _dbSolicitaUsuario.Sub_Setor
                     where p.Id == visualizacao.Setor
                     select p);
            foreach (var setor in q)
            {
                TempData["Setor"] = setor.Descricao;
            }
            var resultado = new SolicitacaoUsuario
            {
                Nome = visualizacao.Nome,
                Local = visualizacao.Local,
                Data_Comeco = visualizacao.Data_Comeco,
                Email = visualizacao.Email,
                Compumate = visualizacao.Compumate,
                NovaEstacao = visualizacao.NovaEstacao,
                SoftwarePadrao = visualizacao.SoftwarePadrao,
                SoftwareEspecial = visualizacao.SoftwareEspecial,
                AcessoInternet = visualizacao.AcessoInternet,
                AcessoPastas = visualizacao.AcessoPastas,
                Ramal = visualizacao.Ramal,
                Skype = visualizacao.Skype,
                Observacoes = visualizacao.Observacoes
            };
            return View(resultado);
        }

        public ActionResult Apagar()
        {
            return View();
        }

        public ActionResult Atualizar()
        {
            return View();
        }
    }
}
