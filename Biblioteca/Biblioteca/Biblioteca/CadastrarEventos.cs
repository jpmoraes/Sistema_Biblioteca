
using System;
using System.Data.SqlClient;

namespace Biblioteca
{
    class CadastrarEventos
    {
        SqlCommand cmd = new SqlCommand();
        ConectBD conexao = new ConectBD();
        public string msn;

        public CadastrarEventos(string nome_E, string dsc_E,DateTime dt_E, string h_E, string nome_OG, int CPF_C)
        {
            cmd.CommandText = "insert into Eventos(nome_event,dsc_event,dt_event,h_event,nome_org,CPF_Cliente) values (@nome_EV,@dsc_EV,@dt_EV,@h_EV,@nome_OR,@CPF_CL)";

            cmd.Parameters.AddWithValue("@nome_EV", nome_E);
            cmd.Parameters.AddWithValue("@dsc_EV", dsc_E);
            cmd.Parameters.AddWithValue("@dt_EV", dt_E);
            cmd.Parameters.AddWithValue("@h_EV", h_E);
            cmd.Parameters.AddWithValue("@nome_OR", nome_OG);
            cmd.Parameters.AddWithValue("@CPF_CL", CPF_C);

            try
            {
                conexao.conexao();
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                this.msn = "CADASTRADO COM SUCESSO";
            }
            catch (SqlException e)
            {
                this.msn = "ERRO AO CADASTRAR";
            }
        }
    }
}
