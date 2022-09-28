using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using SGV.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Controllers
{
    public class IndicadoresController : Controller
    {
        public IActionResult Index()
        {
            Conexao.conexaoSGV.Close();
            if (Conexao.conexaoSGV.State == System.Data.ConnectionState.Closed)
            {
                Conexao.conexaoSGV.Open();
            }
            var command = new MySqlCommand();
            command.Connection = Conexao.conexaoSGV;

            MySqlDataReader Janeiro; //reader é do tipo SqlDatReader
            Janeiro = new MySqlCommand("select valor from indicadores where mes = 1 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Janeiro.Read();
            if (Janeiro.HasRows)
            {
                ViewBag.Janeiro = int.Parse(Janeiro[0].ToString());
                Janeiro.Close();
            }
            MySqlDataReader Fevereiro;
            Fevereiro = new MySqlCommand("select valor from indicadores where mes = 2 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Fevereiro.Read();
            if (Fevereiro.HasRows)
            {
                ViewBag.Fevereiro = int.Parse(Fevereiro[0].ToString());
                Fevereiro.Close();
            }
            MySqlDataReader Marco;
            Marco = new MySqlCommand("select valor from indicadores where mes = 3 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Marco.Read();
            if (Marco.HasRows)
            {
                ViewBag.Marco = int.Parse(Marco[0].ToString());
                Marco.Close();
            }
            MySqlDataReader Abril;
            Abril = new MySqlCommand("select valor from indicadores where mes = 4 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Abril.Read();
            if (Abril.HasRows)
            {
                ViewBag.Abril = int.Parse(Abril[0].ToString());
                Abril.Close();
            }
            MySqlDataReader Maio;
            Maio = new MySqlCommand("select valor from indicadores where mes = 5 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Maio.Read();
            if (Maio.HasRows)
            {
                ViewBag.Maio = int.Parse(Maio[0].ToString());
                Maio.Close();
            }
            MySqlDataReader Junho;
            Junho = new MySqlCommand("select valor from indicadores where mes = 6 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Junho.Read();
            if (Junho.HasRows)
            {
                ViewBag.Junho = int.Parse(Junho[0].ToString());
                Junho.Close();
            }
            MySqlDataReader Julho;
            Julho = new MySqlCommand("select valor from indicadores where mes = 7 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Julho.Read();
            if (Julho.HasRows)
            {
                ViewBag.Julho = int.Parse(Julho[0].ToString());
                Julho.Close();
            }
            MySqlDataReader Agosto;
            Agosto = new MySqlCommand("select valor from indicadores where mes = 8 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Agosto.Read();
            if (Agosto.HasRows)
            {
                ViewBag.Agosto = int.Parse(Agosto[0].ToString());
                Agosto.Close();
            }
            MySqlDataReader Setembro;
            Setembro = new MySqlCommand("select valor from indicadores where mes = 9 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Setembro.Read();
            if (Setembro.HasRows)
            {
                ViewBag.Setembro = int.Parse(Setembro[0].ToString());
                Setembro.Close();
            }
            MySqlDataReader Outubro;
            Outubro = new MySqlCommand("select valor from indicadores where mes = 10 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Outubro.Read();
            if (Outubro.HasRows)
            {
                ViewBag.Outubro = int.Parse(Outubro[0].ToString());
                Outubro.Close();
            }
            MySqlDataReader Novembro;
            Novembro = new MySqlCommand("select valor from indicadores where mes = 11 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Novembro.Read();
            if (Novembro.HasRows)
            {
                ViewBag.Novembro = int.Parse(Novembro[0].ToString());
                Novembro.Close();
            }
            MySqlDataReader Dezembro;
            Dezembro = new MySqlCommand("select valor from indicadores where mes = 12 and iq ='IQ-30';", command.Connection).ExecuteReader();
            Dezembro.Read();
            if (Dezembro.HasRows)
            {
                ViewBag.Dezembro = int.Parse(Dezembro[0].ToString());
                Dezembro.Close();
            }
            if (Conexao.conexaoSGV.State == System.Data.ConnectionState.Open)
            {
                Conexao.conexaoSGV.Close();
            }
            if (Conexao.conexaoSGV.State == System.Data.ConnectionState.Closed)
            {
                Conexao.conexaoSGV.Open();
            }
            
            MySqlDataReader Janeiro31; //reader é do tipo SqlDatReader
            Janeiro31 = new MySqlCommand("select valor from indicadores where mes = 1 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Janeiro31.Read();
            if (Janeiro31.HasRows)
            {
                ViewBag.Janeiro31 = int.Parse(Janeiro31[0].ToString());
                Janeiro31.Close();
            }
            MySqlDataReader Fevereiro31;
            Fevereiro31 = new MySqlCommand("select valor from indicadores where mes = 2 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Fevereiro31.Read();
            if (Fevereiro31.HasRows)
            {
                ViewBag.Fevereiro31 = int.Parse(Fevereiro31[0].ToString());
                Fevereiro31.Close();
            }
            MySqlDataReader Marco31;
            Marco31 = new MySqlCommand("select valor from indicadores where mes = 3 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Marco31.Read();
            if (Marco31.HasRows)
            {
                ViewBag.Marco31 = int.Parse(Marco31[0].ToString());
                Marco31.Close();
            }
            MySqlDataReader Abril31;
            Abril31 = new MySqlCommand("select valor from indicadores where mes = 4 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Abril31.Read();
            if (Abril31.HasRows)
            {
                ViewBag.Abril31 = int.Parse(Abril31[0].ToString());
                Abril31.Close();
            }
            MySqlDataReader Maio31;
            Maio31 = new MySqlCommand("select valor from indicadores where mes = 5 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Maio31.Read();
            if (Maio31.HasRows)
            {
                ViewBag.Maio31 = int.Parse(Maio31[0].ToString());
                Maio31.Close();
            }
            MySqlDataReader Junho31;
            Junho31 = new MySqlCommand("select valor from indicadores where mes = 6 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Junho31.Read();
            if (Junho31.HasRows)
            {
                ViewBag.Junho31 = int.Parse(Junho31[0].ToString());
                Junho31.Close();
            }
            MySqlDataReader Julho31;
            Julho31 = new MySqlCommand("select valor from indicadores where mes = 7 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Julho31.Read();
            if (Julho31.HasRows)
            {
                ViewBag.Julho31 = int.Parse(Julho31[0].ToString());
                Julho31.Close();
            }
            MySqlDataReader Agosto31;
            Agosto31 = new MySqlCommand("select valor from indicadores where mes = 8 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Agosto31.Read();
            if (Agosto31.HasRows)
            {
                ViewBag.Agosto31 = int.Parse(Agosto31[0].ToString());
                Agosto31.Close();
            }
            MySqlDataReader Setembro31;
            Setembro31 = new MySqlCommand("select valor from indicadores where mes = 9 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Setembro31.Read();
            if (Setembro31.HasRows)
            {
                ViewBag.Setembro31 = int.Parse(Setembro31[0].ToString());
                Setembro31.Close();
            }
            MySqlDataReader Outubro31;
            Outubro31 = new MySqlCommand("select valor from indicadores where mes = 10 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Outubro31.Read();
            if (Outubro31.HasRows)
            {
                ViewBag.Outubro31 = int.Parse(Outubro31[0].ToString());
                Outubro31.Close();
            }
            MySqlDataReader Novembro31;
            Novembro31 = new MySqlCommand("select valor from indicadores where mes = 11 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Novembro31.Read();
            if (Novembro31.HasRows)
            {
                ViewBag.Novembro31 = int.Parse(Novembro31[0].ToString());
                Novembro31.Close();
            }
            MySqlDataReader Dezembro31;
            Dezembro31 = new MySqlCommand("select valor from indicadores where mes = 12 and iq ='IQ-31';", command.Connection).ExecuteReader();
            Dezembro31.Read();
            if (Dezembro31.HasRows)
            {
                ViewBag.Dezembro31 = int.Parse(Dezembro31[0].ToString());
                Dezembro31.Close();
            }
            if (Conexao.conexaoSGV.State == System.Data.ConnectionState.Open)
            {
                Conexao.conexaoSGV.Close();
            }
            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
