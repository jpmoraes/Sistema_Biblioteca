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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Usuario user2 = new Usuario();
            user2.Visible = true;
            this.Close();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            
            
           CadastrarCliente cadC = new CadastrarCliente (int.Parse(textCPF.Text), textSexual.Text, textLit.Text,textNome.Text,dataN.Value.Date);

           CadastrarTelC cadCT = new CadastrarTelC(textTel.Text, int.Parse(textCPF.Text));

           CadastrarEndC cadCE = new CadastrarEndC(textrua.Text, int.Parse(textnumero.Text), textcep.Text, textbairro.Text, textcidade.Text,int.Parse(textCPF.Text));

            if(cadC.msn & cadCT.msn & cadCE.msn)
            {
                MessageBox.Show("CADASTRADO COM SUCESSO");
            }
            else
            {
                MessageBox.Show("ERRO AO CADASTRAR");
            }

            textCPF.Text = "";
            textSexual.Text = "";
            textLit.Text = "";
            textNome.Text = "";
            textTel.Text = "";
            textrua.Text = "";
            textnumero.Text = "";
            textcep.Text = "";
            textbairro.Text = "";
            textcidade.Text = "";

        }
    }
}
