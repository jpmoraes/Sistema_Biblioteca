using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    class Select_hist_livros
    {
        SqlCommand cmd = new SqlCommand();

        ConectBD conexao = new ConectBD();

        SqlDataReader dr;

        public string msn;

        private string nome_hist_livro = null, nome_hist_cliente = null;
        private List<string> lista = new List<string>();
        DateTime dt_Aluguel, dt_devolucao = new DateTime(1999,1,1);

        private Int32 ISBN = -1;

        public (List<string>, int) BuscaISBN(int ISBN)
        {

            cmd.CommandText = "select Livros.nome_livro,Clientes.nome_cliente , Emprestimo.dt_saida, Devolucao.dt_entrega from Emprestimo join Livros on Livros.ISBN_livro = Emprestimo.ISBN_livro join Clientes on Clientes.CPF_Cliente = Emprestimo.CPF_Cliente join Devolucao on Devolucao.id_emprestimo = Emprestimo.id_emprestimo and Emprestimo.ISBN_livro = @ISBN ";

            cmd.Parameters.AddWithValue("@ISBN", ISBN);

            try
            {

                conexao.conexao();

                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();

                dr.Read();


                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        this.nome_hist_livro = dr.GetString(0);
                        this.nome_hist_cliente = dr.GetString(1);
                        this.dt_Aluguel = dr.GetDateTime(2);
                        this.dt_devolucao = dr.GetDateTime(3);

                        this.lista.Add(this.nome_hist_livro);
                        this.lista.Add(this.nome_hist_cliente);
                        this.lista.Add(Convert.ToString(this.dt_Aluguel));
                        this.lista.Add(Convert.ToString(this.dt_devolucao));


                    }

               

                    this.ISBN = 1;

                    this.msn = "HISTORICO ENCONTRADO";

                }

                else
                {

                    this.msn = "HISTORICO NÃO ENCONTRADO";
                    this.ISBN = -1;

                }

                conexao.desconectar();
            }

            catch (SqlException e)
            {

                this.msn = "ERRO AO BUSCAR O HISTORICO";
            }

            return (lista, this.ISBN);


        }


    }

}