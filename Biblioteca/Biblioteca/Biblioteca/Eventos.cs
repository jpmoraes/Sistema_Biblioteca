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
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarEventos cadE = new CadastrarEventos(textEventos.Text, textDesc.Text, dataE.Value.Date, textHorario.Text, textOrganizador.Text, int.Parse(textCpfOr.Text));

            MessageBox.Show(cadE.msn);

            textEventos.Text = "";
            textDesc.Text = "";
            textHorario.Text = "";
            textOrganizador.Text = "";
            textCpfOr.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario user6 = new Usuario();
            user6.Visible = true;
            this.Close();
        }

        private void textHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Eventos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
