using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class hisLivro : Form
    {
        public hisLivro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuario user9 = new Usuario();
            user9.Visible = true;
            this.Close();
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscahislivro_Click(object sender, EventArgs e)
        {
            Select_hist_livros hist_livro = new Select_hist_livros();
            List<string> listaLivro = new List<string>();
            string nome_hist_livro, nome_hist_cliente;
            DateTime dt_Aluguel, dt_devolucao;
            int ISBN,cont;
            (listaLivro, ISBN) = hist_livro.BuscaISBN(int.Parse(hislivro1.Text));

            cont = listaLivro.Count;
            if (ISBN != -1) {
                int i = 0;
                while (i < cont)
                {
                    nome_hist_livro = listaLivro[i];
                    nome_hist_cliente = listaLivro[i + 1];
                    dt_Aluguel = Convert.ToDateTime(listaLivro[i + 2]);
                    dt_devolucao = Convert.ToDateTime(listaLivro[i + 3]);
                    i = i + 4;
                    this.dataGridView1.Rows.Insert(0, nome_hist_livro, nome_hist_cliente, dt_Aluguel.ToString("d"), dt_devolucao.ToString("d"));

                }

               

            }

            else {

                MessageBox.Show(hist_livro.msn);

            }
        }
        private void hisLivro_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {






        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {






        }
    }
}
