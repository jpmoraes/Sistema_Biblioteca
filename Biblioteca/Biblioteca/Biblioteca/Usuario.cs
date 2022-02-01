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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cpfCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cliente client = new Cliente();
            client.Visible = true;
            this.Close();
        }

        private void livroToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Livro book = new Livro();
            book.Visible = true;
            this.Close();
        }

        private void clienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            B_Cliente B_C = new B_Cliente();
            B_C.Visible = true;
            this.Close();
        }

        private void livroToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            conLivro conlivro = new conLivro();
             conlivro.Visible = true;
                this.Close();
               
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conAgenda conagenda = new conAgenda();
             conagenda.Visible = true;
                this.Close();
      }

        private void clienteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            hisCliente hiscliente = new hisCliente();
                hiscliente.Visible = true;
                    this.Close();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void livroToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            hisLivro hislivro = new hisLivro();
             hislivro.Visible = true;
                this.Close();
       }

        private void multaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Multas multas = new Multas();
              multas.Visible = true;
                this.Close();
        }

        private void eventosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eventos eventos = new Eventos();
                eventos.Visible = true;
                    this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            login1.Visible = true;
            this.Close();
        }

        private void emprestimo_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
             emprestimo.Visible = true;
               this.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Devolucao devolucao = new Devolucao();
            devolucao.Visible = true;
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            listaLivro livro = new listaLivro();
            listaCliente cliente = new listaCliente();

            string B_NL = null, B_NA = null, B_GL = null, B_S = null, B_E = null, B_SG = null, B_C = null;
            DateTime B_A = new DateTime();
            int B_ISBN = -1, B_NP = -1, B_Q = -1;

            string B_G = null, B_PF = null, BNome = null, B_TEL = null, B_Bair = null, B_Rua = null, B_CEP = null, B_Cid = null;
            DateTime D_NC = new DateTime();
            int Bcpf = -1, B_N = -1;

            (B_ISBN, B_NL, B_NA, B_GL, B_S, B_E, B_SG, B_NP, B_C, B_A, B_Q) = livro.BuscaLivro(int.Parse(isbnLivro.Text));
            (Bcpf, B_G, B_PF, BNome, B_TEL, B_Bair, B_Rua, B_N, B_CEP, B_Cid, D_NC) = cliente.BuscaCliente(int.Parse(cpfCliente.Text));

            if (Bcpf != -1)
            {
                MessageBox.Show("Cliente Encontrado " + Bcpf);
            }
            else
            {
                MessageBox.Show("Cliente não Encontrado");
            }

            if (B_ISBN != -1)
            {
                MessageBox.Show("Livro Encontrado " + B_ISBN);
            }
            else
            {
                MessageBox.Show("Livro não Encontrado");
            }

            Emprestimo EM = new Emprestimo();
            if (Bcpf != -1 & B_ISBN != -1)
            {                
                EM.Visible = true;
                EM.isbn = B_ISBN;
                EM.cpf = Bcpf;
                this.Close();
                                
            }


        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
