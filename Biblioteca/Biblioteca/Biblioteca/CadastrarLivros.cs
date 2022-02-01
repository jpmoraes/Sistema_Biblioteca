
using System;
using System.Data.SqlClient;

namespace Biblioteca
{
    class CadastrarLivros
    {
        SqlCommand cmd = new SqlCommand();
        ConectBD conexao = new ConectBD();
        public string msn;

        public CadastrarLivros(int isbn_L, string nome_L, string nome_A, string genero_L, string sinopse_L, string editora_L, string subG_L, int n_paginas_L, int cl_idade, DateTime ano_L, int qnt_L)
        {
            cmd.CommandText = "insert into Livros(ISBN_livro,nome_livro,nome_autor,genero_livro,sinopse,editora,subgenero,n_paginas,clas_idade,ano_livro,qnt_livro) values (@ISBN_LV,@nome_LV,@nome_AT,@genero_LV,@sinopse_LV,@editora_LV,@subG_LV,@n_paginas_LV,@cl_idade,@ano_LV,@qnt_LV)";

            cmd.Parameters.AddWithValue("@ISBN_LV", isbn_L);
            cmd.Parameters.AddWithValue("@nome_LV", nome_L);
            cmd.Parameters.AddWithValue("@nome_AT", nome_A);
            cmd.Parameters.AddWithValue("@genero_LV", genero_L);
            cmd.Parameters.AddWithValue("@sinopse_LV", sinopse_L);
            cmd.Parameters.AddWithValue("@editora_LV", editora_L);
            cmd.Parameters.AddWithValue("@subG_LV", subG_L);
            cmd.Parameters.AddWithValue("@n_paginas_LV", n_paginas_L);
            cmd.Parameters.AddWithValue("@cl_idade", cl_idade);
            cmd.Parameters.AddWithValue("@ano_LV", ano_L);
            cmd.Parameters.AddWithValue("@qnt_LV", qnt_L);

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
