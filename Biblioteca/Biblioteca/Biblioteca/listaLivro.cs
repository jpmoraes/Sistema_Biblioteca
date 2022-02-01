using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class listaLivro
    {
        SqlCommand cmd = new SqlCommand();

        ConectBD conexao = new ConectBD();

        SqlDataReader dr;

        public string msn;

        private string B_NL = null, B_NA = null, B_GL = null, B_S = null, B_E = null, B_SG = null, B_C = null;
        private DateTime B_AL = new DateTime();
        private Int32 B_ISBN = -1,B_NP = -1,B_Q = -1;

        public (int,string,string,string,string,string,string,int,string,DateTime,int) BuscaLivro(int ISBN)

        {

            cmd.CommandText = "Select * from Livros where ISBN_livro = @ISBN";

            cmd.Parameters.AddWithValue("@ISBN", ISBN);

            try

            {

                conexao.conexao();

                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();

                dr.Read();

                if (dr.HasRows)

                {

                    this.B_ISBN = dr.GetInt32(0);
                    this.B_NL = dr.GetString(1);
                    this.B_NA = dr.GetString(2);
                    this.B_GL = dr.GetString(3);
                    this.B_S = dr.GetString(4);
                    this.B_E = dr.GetString(5);
                    this.B_SG = dr.GetString(6);
                    this.B_NP = dr.GetInt32(7);
                    this.B_C = dr.GetString(8);
                    this.B_AL = dr.GetDateTime(9);
                    this.B_Q = dr.GetInt32(10);



                    this.msn = "LIVRO ENCONTRADO";

                }

                else

                {

                    this.msn = "LIVRO NÃO ENCONTRADO";

                }

                conexao.desconectar();

            }

            catch (SqlException )

            {

                this.msn = "ERRO AO CADASTRAR";

            }

            return (this.B_ISBN,this.B_NL,this.B_NA,this.B_GL, this.B_S,this.B_E,this.B_SG,this.B_NP,this.B_C,this.B_AL,this.B_Q);

        }
    }
}
