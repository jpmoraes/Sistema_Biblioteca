using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Biblioteca
{
    class select_his_clt
    {
        SqlCommand cmd = new SqlCommand();

        ConectBD conexao = new ConectBD();

        SqlDataReader dr;
        private List<string> lista = new List<string>();
        public string msn;

        private string livro = null;
        DateTime data_Aluguel, data_Entrega = new DateTime(1999,1,1);

        private Int32 CPF = -1;

        public (List<string>, int) BuscaCPF (int CPF)
        {

            cmd.CommandText = "select Livros.nome_livro, Emprestimo.dt_saida, Devolucao.dt_entrega from Emprestimo join Livros on Livros.ISBN_livro = Emprestimo.ISBN_livro join Devolucao on Devolucao.id_emprestimo = Emprestimo.id_emprestimo and Emprestimo.CPF_Cliente = @CPF";
            
            cmd.Parameters.AddWithValue("@CPF", CPF);

            try{

                conexao.conexao();

                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();

                dr.Read();



                if (dr.HasRows){

                    while (dr.Read())
                    {
                        this.livro = dr.GetString(0);
                        this.data_Aluguel = dr.GetDateTime(1);
                        this.data_Entrega = dr.GetDateTime(2);

                        this.lista.Add(this.livro);
                        this.lista.Add(Convert.ToString(this.data_Aluguel));
                        this.lista.Add(Convert.ToString(this.data_Entrega));


                    }

                 

                 this.CPF = 1;

                 this.msn = "CLIENTE ENCONTRADO";

                }

                else{

                 this.msn = "CLIENTE NÃO ENCONTRADO";
                 this.CPF = -1;

                }

                conexao.desconectar();
               }

            catch (SqlException e){

                this.msn = "ERRO AO BUSCAR O CLIENTE";
            }

            return (lista,this.CPF);


        }


    }

} 

