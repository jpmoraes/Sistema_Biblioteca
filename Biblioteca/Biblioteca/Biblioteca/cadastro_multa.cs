using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Biblioteca
{
    class cadastro_multa
    {
        SqlCommand cmd = new SqlCommand();
        ConectBD mult = new ConectBD();

        public string msn;

        public cadastro_multa(int CPF_Cliente)
        {
            cmd.CommandText = "insert into Multa (CPF_Cliente) values (@CPF_Cliente)";

            cmd.Parameters.AddWithValue("@CPF_Cliente", CPF_Cliente);
            
            try
            {
                mult.conexao();
                cmd.Connection = mult.conectar();
                cmd.ExecuteNonQuery();
                mult.desconectar();

                this.msn = " Cadastro de multa concluído ";
            }

            catch (SqlException e)
            {
                this.msn = "Erro ao cadastrar multa";
            }
        }
    }

}


