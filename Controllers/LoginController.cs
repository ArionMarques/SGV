using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGV.Database;
using SGV.Models;
using System.Data.SqlClient;
using System.Linq;


namespace SGV.Controllers
{
    public class LoginController : Controller
    {
        private DatabaseContext dados;
        public LoginController(DatabaseContext db)
        {
            dados = db;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromForm] Login login)
        {
            foreach (var key in TempData.Keys.ToList())
            {
                TempData.Remove(key);
            }
            if (ModelState.IsValid)
            {
                SqlConnection conexao = new SqlConnection(@"Data Source=srvsiscompumate;Initial Catalog=GERAL;Persist Security Info=True;User ID=sa;Password=sae");
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                    var command = new SqlCommand();
                    command.Connection = conexao;
                    SqlDataReader reader; //reader ler as informações do select
                    reader = new SqlCommand("select nome, senha FROM  operador where codigo='" + login.CodUsuario + "' and inativo = 0", command.Connection).ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        HttpContext.Session.SetString("Operador", reader[0].ToString());
                        HttpContext.Session.SetString("Senha", reader[1].ToString());
                        HttpContext.Session.SetString("Codigo", login.CodUsuario);
                    }
                    reader.Close();
                }
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Close();
                }

                if (login.Senha == HttpContext.Session.GetString("Senha"))
                {
                    HttpContext.Session.SetString("Login", "sim");
                    TempData["Operador"] = HttpContext.Session.GetString("Operador");

                    var q = (from p in dados.Usuario
                    .DefaultIfEmpty()
                             where p.Operador == int.Parse(login.CodUsuario)
                             select new
                             {
                                 p.Admin
                             }).ToList();
                    if (q.Count > 0)
                    {
                        foreach (var resultado in q)
                        {
                            TempData["IsAdmin"] = resultado.Admin;
                            HttpContext.Session.SetString("IsAdmin", resultado.Admin.ToString());

                        }

                    }
                    else
                    {
                        TempData["IsAdmin"] = 0;
                    }
                    

                    return Redirect("/Permissoes/Permissoes/" + login.CodUsuario);
                    
                }
                else
                {
                    ViewBag.Mensagem = "Usuário ou senha incorretos";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }

}
