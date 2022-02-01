using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Cadastro_emp
    {
        SqlCommand cmd = new SqlCommand();
        ConectBD emp = new ConectBD();

        public string msn;

        public Cadastro_emp( int isbn, int cpf, DateTime dt_saida, DateTime dt_preve)
        {
            cmd.CommandText = "insert into Emprestimo (CPF_Cliente, ISBN_livro, dt_saida, dt_preve) values (@cpf,@isbn,@dt_saida, @dt_preve)";

            cmd.Parameters.AddWithValue("@dt_saida", dt_saida);
            cmd.Parameters.AddWithValue("@dt_preve", dt_preve);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                emp.conexao();
                cmd.Connection = emp.conectar();
                cmd.ExecuteNonQuery();
                emp.desconectar();

                this.msn = " Cadastro concluído ";
            }

            catch (SqlException e) 
            {
                this.msn = "Erro ao cadastrar";
            }
        }

        public Cadastro_emp()
        {
        }
    }
}
