using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Loja.cod
{
    class Conexao
    {
        private static SqlConnection con;

        public static SqlConnection Abrir()
        {
            if (con == null)
            {
                con = new SqlConnection("Server=(IZAELEFFEMBERG);izael_000;Database=Loja");
            }
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public static void Fechar()
        {
            if (con != null && con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
        }

        public static bool EstaAberta()
        {
            if (con == null)
            {
                return false;
            }
            else
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
