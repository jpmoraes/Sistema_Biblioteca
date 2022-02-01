using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    class Select_multa {

        SqlCommand cmd = new SqlCommand();

        ConectBD conexao = new ConectBD();

        SqlDataReader dr;

        public string msn;

        private string nome_Cliente = null;

        DateTime data_Entrega = new DateTime(1999,1,1);

        private Int32 CPF = -1;

        public (string, DateTime, int) BuscaMulta(int CPF)
        {

            cmd.CommandText = "Select Clientes.nome_cliente, Devolucao.dt_entrega from Clientes join Devolucao on Devolucao.CPF_Cliente = @CPF and Devolucao.CPF_Cliente = Clientes.CPF_Cliente";

            cmd.Parameters.AddWithValue("@CPF", CPF);

            try
            {

                conexao.conexao();

                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();

                dr.Read();



                if (dr.HasRows)
                {

                    this.nome_Cliente = dr.GetString(0);

                    this.data_Entrega = dr.GetDateTime(1);

                    this.CPF = 1;

                    this.msn = "USUÁRIO ENCONTRADO";

                }

                else
                {

                    this.msn = "USUÁRIO NÃO ENCONTRADO";
                    this.CPF = -1;

                }

                conexao.desconectar();
            }

            catch (SqlException e)
            {

                this.msn = "ERRO AO CADASTRAR";
            }

            return (this.nome_Cliente, this.data_Entrega, this.CPF);


        }


    }

}

