using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Library.Filters.SolicitaUsuario
{
    public class AtualizarSolicitaUsuario : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            bool IsValid = false;
            bool IsAdmin = false;
            string Administrador = context.HttpContext.Session.GetString("IsAdmin");
            if (Administrador == "1")
            {
                IsAdmin = true;
            }

            String NumeroOperador = "0";
            if (context.HttpContext.Session.GetString("Codigo") != null)
            {
                NumeroOperador = context.HttpContext.Session.GetString("Codigo");
            }
            int Operador = int.Parse(NumeroOperador);
            MySqlConnection conexao = new MySqlConnection(@"server=srvdados;user id=venax;database=venax;pwd=T3lh4d0@");
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
                var command = new MySqlCommand();
                command.Connection = conexao;
                MySqlDataReader reader; //reader ler as informações do select
                reader = new MySqlCommand("select permissoes.novo from permissoes inner join menus on permissoes.fk_menu = menus.id inner join sub_menus on permissoes.fk_sub_menu = sub_menus.id where fk_Operador =" + Operador + " and Sub_Menu ='" + "Solicitação de acesso" + "'", command.Connection).ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    IsValid = true;
                }
                reader.Close();
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Close();
                }
                if (!IsValid || !IsAdmin)
                {
                    context.Result = new RedirectToActionResult("index", "Home", null);
                }
            }
        }
    }
}
