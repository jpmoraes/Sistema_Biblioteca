using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Biblioteca
{
    class Cadastro_Dev
    {
        SqlCommand cmd = new SqlCommand();
        ConectBD Dev = new ConectBD();

        public string msn;

        public Cadastro_Dev( int ISBN_livro, int CPF_Cliente, DateTime dt_entrega, string est_livro)
        {

            cmd.CommandText = "insert into Devolucao (ISBN_livro, CPF_Cliente, dt_entrega, est_livro) values (@ISBN_livro,@CPF_Cliente, @dt_entrega,@est_livro)";

            cmd.Parameters.AddWithValue("@CPF_Cliente", CPF_Cliente);
            cmd.Parameters.AddWithValue("@dt_entrega", dt_entrega );
            cmd.Parameters.AddWithValue("@est_livro", est_livro);
            cmd.Parameters.AddWithValue("@ISBN_livro", ISBN_livro);

            try
            {
                Dev.conexao();
                cmd.Connection = Dev.conectar();
                cmd.ExecuteNonQuery();
                Dev.desconectar();

                this.msn = " Cadastro de Devolução concluído ";
            }

            catch (SqlException e)
            {
                this.msn = "Erro ao cadastrar Devolução";
            }
        }
    }


}   

