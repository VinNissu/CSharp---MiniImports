using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_imports
{
    internal class Conexao
    {

        public static SqlConnection conn;
        private static string conexao = @"Data Source= SJC0562927W10-1; Initial Catalog = Banco; User=sa; Password= Senac123";

        public static void Conectar()
        {
            conn = new SqlConnection(conexao);
            conn.Open();
        }

        public static void Desconectar()
        {
            conn.Close();
        }
    }
}
