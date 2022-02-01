using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CadastrarTelC
    {
        SqlCommand cmd = new SqlCommand();
        ConectBD conexao = new ConectBD();
        public bool msn;

        public CadastrarTelC(string Tel_C,int CPF_C)
        {
            cmd.CommandText = "insert into tel_Cliente(tel_cliente,CPF_Cliente) values (@Tel_CL,@CPF_CL)";

            cmd.Parameters.AddWithValue("@Tel_CL", Tel_C);
            cmd.Parameters.AddWithValue("@CPF_CL", CPF_C);
     

            try
            {
                conexao.conexao();
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                this.msn = true;
            }
            catch (SqlException e)
            {
                this.msn = false;
            }
        }
    }
}

