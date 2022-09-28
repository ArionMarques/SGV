using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGV.Database;
using SGV.Models;

namespace SGV.Controllers
{
    public class PosvendasController : Controller
    {
        public IActionResult Index()
        {
            if (Conexao.conexaoDiversos.State == System.Data.ConnectionState.Closed)
            {
                Conexao.conexaoDiversos.Open();
            }
            var command = new SqlCommand();
            command.Connection = Conexao.conexaoDiversos;
            SqlDataReader Wellingtonreader; //reader é do tipo SqlDatReader
            Wellingtonreader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'wellington bagio ferreira padilha' and DataSolucao IS Null;", command.Connection).ExecuteReader();
            Wellingtonreader.Read();
            if (Wellingtonreader.HasRows)
            {
                ViewBag.Wellington = int.Parse(Wellingtonreader[0].ToString());
                Wellingtonreader.Close();
            }
            SqlDataReader Rafelareader;
            Rafelareader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'rafaela dos santos pinheiro sausen' and DataSolucao IS Null;", command.Connection).ExecuteReader();
            Rafelareader.Read();
            if (Rafelareader.HasRows)
            {
                ViewBag.Rafaela = int.Parse(Rafelareader[0].ToString());
                Rafelareader.Close();
            }
            SqlDataReader Carlareader;
            Carlareader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'carla serafini' and DataSolucao IS Null;", command.Connection).ExecuteReader();
            Carlareader.Read();
            if (Carlareader.HasRows)
            {
                ViewBag.Carla = int.Parse(Carlareader[0].ToString());
                Carlareader.Close();
            }
            SqlDataReader Jonasreader;
            Jonasreader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'jonas ferreira' and DataSolucao IS Null;", command.Connection).ExecuteReader();
            Jonasreader.Read();
            if (Jonasreader.HasRows)
            {
                ViewBag.Jonas = int.Parse(Jonasreader[0].ToString());
                Jonasreader.Close();
            }
            SqlDataReader Anareader;
            Anareader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'ana paula giehl' and DataSolucao IS Null;", command.Connection).ExecuteReader();
            Anareader.Read();
            if (Anareader.HasRows)
            {
                ViewBag.Ana = int.Parse(Anareader[0].ToString());
                Anareader.Close();
            }
            SqlDataReader Thiagoreader;
            Thiagoreader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'thiago weber' and DataSolucao IS Null;", command.Connection).ExecuteReader();
            Thiagoreader.Read();
            if (Thiagoreader.HasRows)
            {
                ViewBag.Thiago = int.Parse(Thiagoreader[0].ToString());
                Thiagoreader.Close();
            }
            SqlDataReader AbertosWellingtonreader; //reader é do tipo SqlDatReader
            AbertosWellingtonreader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'wellington bagio ferreira padilha'", command.Connection).ExecuteReader();
            AbertosWellingtonreader.Read();
            if (AbertosWellingtonreader.HasRows)
            {
                ViewBag.AbertosWellington = int.Parse(AbertosWellingtonreader[0].ToString());
                AbertosWellingtonreader.Close();
            }
            SqlDataReader AbertosRafelareader;
            AbertosRafelareader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'rafaela dos santos pinheiro sausen'", command.Connection).ExecuteReader();
            AbertosRafelareader.Read();
            if (AbertosRafelareader.HasRows)
            {
                ViewBag.AbertosRafaela = int.Parse(AbertosRafelareader[0].ToString());
                AbertosRafelareader.Close();
            }
            SqlDataReader AbertosCarlareader;
            AbertosCarlareader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'carla serafini'", command.Connection).ExecuteReader();
            AbertosCarlareader.Read();
            if (AbertosCarlareader.HasRows)
            {
                ViewBag.AbertosCarla = int.Parse(AbertosCarlareader[0].ToString());
                AbertosCarlareader.Close();
            }
            SqlDataReader AbertosJonasreader;
            AbertosJonasreader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'jonas ferreira'", command.Connection).ExecuteReader();
            AbertosJonasreader.Read();
            if (AbertosJonasreader.HasRows)
            {
                ViewBag.AbertosJonas = int.Parse(AbertosJonasreader[0].ToString());
                AbertosJonasreader.Close();
            }
            SqlDataReader AbertosAnareader;
            AbertosAnareader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'ana paula giehl'", command.Connection).ExecuteReader();
            AbertosAnareader.Read();
            if (AbertosAnareader.HasRows)
            {
                ViewBag.AbertosAna = int.Parse(AbertosAnareader[0].ToString());
                AbertosAnareader.Close();
            }
            SqlDataReader AbertosThiagoreader;
            AbertosThiagoreader = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and Atendente = 'thiago weber'", command.Connection).ExecuteReader();
            AbertosThiagoreader.Read();
            if (AbertosThiagoreader.HasRows)
            {
                ViewBag.AbertosThiago = int.Parse(AbertosThiagoreader[0].ToString());
                AbertosThiagoreader.Close();
            }
            SqlDataReader RS; //reader é do tipo SqlDatReader
            RS = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and ForcliUF = 'rs'", command.Connection).ExecuteReader();
            RS.Read();
            if (RS.HasRows)
            {
                ViewBag.RS = int.Parse(RS[0].ToString());
                RS.Close();
            }
            SqlDataReader SC;
            SC = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and ForcliUF = 'sc'", command.Connection).ExecuteReader();
            SC.Read();
            if (SC.HasRows)
            {
                ViewBag.SC = int.Parse(SC[0].ToString());
                SC.Close();
            }
            SqlDataReader PR;
            PR = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and ForcliUF = 'pr'", command.Connection).ExecuteReader();
            PR.Read();
            if (PR.HasRows)
            {
                ViewBag.PR = int.Parse(PR[0].ToString());
                PR.Close();
            }
            SqlDataReader SP;
            SP = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and ForcliUF = 'sp'", command.Connection).ExecuteReader();
            SP.Read();
            if (SP.HasRows)
            {
                ViewBag.SP = int.Parse(SP[0].ToString());
                SP.Close();
            }
            SqlDataReader RJ;
            RJ = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and ForcliUF = 'rj'", command.Connection).ExecuteReader();
            RJ.Read();
            if (RJ.HasRows)
            {
                ViewBag.RJ = int.Parse(RJ[0].ToString());
                RJ.Close();
            }
            SqlDataReader MG;
            MG = new SqlCommand("select count(codigo) from OSAssistencia where DATAABERTURA between '2021-01-01 00:00:00.000' and GETDATE() and ForcliUF = 'mg'", command.Connection).ExecuteReader();
            MG.Read();
            if (MG.HasRows)
            {
                ViewBag.MG = int.Parse(MG[0].ToString());
                MG.Close();
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
