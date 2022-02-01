using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class listaCliente
    {
        SqlCommand cmd = new SqlCommand();

        ConectBD conexao = new ConectBD();

        SqlDataReader dr;

        public string msn;

        private string B_G = null, B_PF = null, BNome = null, B_TEL= null, B_Bair = null, B_Rua = null, B_CEP = null, B_Cid = null;
        private DateTime D_NC = new DateTime();
        private Int32 Bcpf = -1, B_N = -1;

        public (int,string,string,string,string,string,string,int,string,string,DateTime) BuscaCliente(int cpf)

        {

            cmd.CommandText = "Select * from Clientes join tel_Cliente on tel_Cliente.CPF_Cliente = @cpf inner join end_Cliente on end_Cliente.CPF_Cliente = @cpf and Clientes.CPF_Cliente = @cpf";

            cmd.Parameters.AddWithValue("@cpf", cpf);

            try

            {

                conexao.conexao();

                cmd.Connection = conexao.conectar();

                dr = cmd.ExecuteReader();

                dr.Read();

                if (dr.HasRows)

                {

                    this.Bcpf = dr.GetInt32(0);
                    this.B_G = dr.GetString(1);
                    this.B_PF = dr.GetString(2);
                    this.BNome = dr.GetString(3);
                    this.D_NC = dr.GetDateTime(4);
                    this.B_TEL = dr.GetString(6);
                    this.B_Bair = dr.GetString(9);
                    this.B_Rua = dr.GetString(10);
                    this.B_N = dr.GetInt32(11);
                    this.B_CEP = dr.GetString(12);
                    this.B_Cid = dr.GetString(13);


                    this.msn = "USUÁRIO ENCONTRADO";

                }

                else

                {

                    this.msn = "USUÁRIO NÃO ENCONTRADO";

                }

                conexao.desconectar();

            }

            catch (SqlException )

            {

                this.msn = "ERRO AO CADASTRAR";

            }

            return (this.Bcpf, this.B_G, this.B_PF, this.BNome, this.B_TEL, this.B_Bair, this.B_Rua, this.B_N, this.B_CEP, this.B_Cid,this.D_NC);

        }
    }
}
