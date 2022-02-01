using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Sql;
using System.Data.OleDb;


namespace Biblioteca
{
    class ConectBD
    {
        SqlConnection con = new SqlConnection();

        public void conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-6SR2HDU\MSSQL;Initial Catalog=Biblioteca_Projeto;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void desconectar ()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
