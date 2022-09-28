using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SGV.Database
{
    public class Conexao
    {
        public static SqlConnection conexaoGeral = new SqlConnection(@"Data Source=srvsiscompumate;Initial Catalog=GERAL;Persist Security Info=True;User ID=sa;Password=sae");
        public static SqlConnection conexaoDiversos = new SqlConnection(@"Data Source=srvsiscompumate;Initial Catalog=DIVERSOS;Persist Security Info=True;User ID=sa;Password=sae");
        public static MySqlConnection conexaoSGV = new MySqlConnection(@"server=srvdados;user id=venax;database=venax;pwd=T3lh4d0@");
        public static void ConectarGeral()
        {
            if (conexaoGeral.State == System.Data.ConnectionState.Closed)
            {
                conexaoGeral.Open();
            }
        }
        public static void DesconectarGeral()
        {
            if (conexaoGeral.State == System.Data.ConnectionState.Closed)
            {
                conexaoGeral.Close();
            }
        }
        public static void ConectarDiversos()
        {
            if (conexaoDiversos.State == System.Data.ConnectionState.Closed)
            {
                conexaoDiversos.Open();
            }
        }
        public static void DesconectarDiversos()
        {
            if (conexaoDiversos.State == System.Data.ConnectionState.Closed)
            {
                conexaoDiversos.Close();
            }
        }
    }
}
