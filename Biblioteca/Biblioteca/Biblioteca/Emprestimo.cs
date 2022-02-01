using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;

namespace Biblioteca
{
    public partial class Emprestimo : Form
    {
        public Emprestimo()
        {
            InitializeComponent();
        }

        private void nomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        public int isbn, cpf;
        private void Finalizar_Click(object sender, EventArgs e)
        {
            Usuario US = new Usuario();


            if (isbn == 0 || cpf == 0)
            {
                MessageBox.Show("Verifique na tela inicial a existência do Usuário e Livro");
            }
            else
            {
                Cadastro_emp cademp = new Cadastro_emp(isbn, cpf, datasaida.Value.Date, dataentrega.Value.Date);

                MessageBox.Show(cademp.msn);
            }
            isbn = 0;
            cpf = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void multasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Multas multa = new Multas();
            multa.Visible = true;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Usuario user5 = new Usuario();
            user5.Visible = true;
            this.Close();
        }
    }
}
