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
    public partial class Livro : Form
    {
        public Livro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Usuario user7 = new Usuario();
                user7.Visible = true;
                    this.Close();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarLivros cadL = new CadastrarLivros(int.Parse(textISBN.Text), textLivro.Text, textAutor.Text, textGenero.Text, textSinopse.Text, textEditora.Text, textSub.Text, int.Parse(textPagina.Text), int.Parse(textIdade.Text), dataL.Value.Date, int.Parse(Qnt_L.Text));
            MessageBox.Show(cadL.msn);

            textISBN.Text = "";
            textLivro.Text = "";
            textAutor.Text = "";
            textGenero.Text = "";
            textSinopse.Text = "";
            textEditora.Text = "";
            textSub.Text = "";
            textPagina.Text = "";
            textIdade.Text = "";
            Qnt_L.Text = "";
        }

        private void textSinopse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Qnt_L_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
