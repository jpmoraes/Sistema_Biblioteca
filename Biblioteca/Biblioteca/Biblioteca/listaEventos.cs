using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class listaEventos
    {
        SqlCommand cmd = new SqlCommand();

        ConectBD conexao = new ConectBD();

        SqlDataReader dr;

        public string msn;

        private string B_NE = null,B_DE  =null,B_NO = null, B_HE =  null;
        private DateTime D_E = new DateTime(1900, 1, 1);
        private Int32 B_CPFO = -1;

        public (string,string,DateTime,string,int,string) BuscaEventos(int CPFO)

        {

            cmd.CommandText = "Select * from Eventos where CPF_Cliente = @cpf";

            cmd.Parameters.AddWithValue("@cpf", CPFO);

            try

            {

                conexao.conexao();

                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();
               


                dr.Read();

                if (dr.HasRows)

                {

                    this.B_CPFO = dr.GetInt32(5);
                    this.B_NE = dr.GetString(1);
                    this.B_DE = dr.GetString(2);
                    this.D_E = dr.GetDateTime(3);
                    this.B_NO = dr.GetString(4);
                    this.B_HE = dr.GetString(6);

                    this.msn = "EVENTO ENCONTRADO";

                }

                else

                {

                    this.msn = "EVENTO NÃO ENCONTRADO(ieieie)";

                }

                conexao.desconectar();

            }

            catch (SqlException )

            {

                this.msn = "ERRO AO CADASTRAR";

            }

            return ( this.B_NE, this.B_DE, this.D_E, this.B_NO,this.B_CPFO, this.B_HE);

        }
    }
}
