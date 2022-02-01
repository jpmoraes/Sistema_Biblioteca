using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CadastrarEndC
    {
        SqlCommand cmd = new SqlCommand();
        ConectBD conexao = new ConectBD();
        public bool msn;

        public CadastrarEndC(string nome_end,int num_end,string CEP_END,string b_end,string c_end,int CPF_C)
        {
            cmd.CommandText = "insert into end_Cliente(Rua,Numero,CEP,bairro,Cidade,CPF_Cliente) values (@rua_end,@n_end,@CEP_end,@bairro_end,@cidade_end,@CPF_CL)";

            cmd.Parameters.AddWithValue("@rua_end",nome_end);
            cmd.Parameters.AddWithValue("@n_end",num_end);
            cmd.Parameters.AddWithValue("@CEP_end",CEP_END);
            cmd.Parameters.AddWithValue("@bairro_end",b_end);
            cmd.Parameters.AddWithValue("@cidade_end",c_end);
            cmd.Parameters.AddWithValue("@CPF_CL",CPF_C);
           

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

