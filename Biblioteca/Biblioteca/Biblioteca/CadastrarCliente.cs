using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CadastrarCliente
    {
        SqlCommand cmd = new SqlCommand();
        ConectBD conexao = new ConectBD();
        public bool msn;

        public CadastrarCliente(int CPF_C,string g_C,string pf_C,string nome_C,DateTime dt_nascimento_C)
        {
            cmd.CommandText = "insert into Clientes(CPF_Cliente,genero_cliente,pf_liter,nome_cliente,dt_nascimento) values (@CPF_CL,@g_CL,@pf_CL,@nome_CL,@dt_nascimento_CL)";

            cmd.Parameters.AddWithValue("@CPF_CL",CPF_C);
            cmd.Parameters.AddWithValue("@g_CL",g_C);
            cmd.Parameters.AddWithValue("@pf_CL",pf_C);
            cmd.Parameters.AddWithValue("@nome_CL",nome_C );
            cmd.Parameters.AddWithValue("@dt_nascimento_CL",dt_nascimento_C);
           

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
