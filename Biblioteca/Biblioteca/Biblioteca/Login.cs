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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            string login ="", senha="";


            if (login == Usuario.Text & senha == Senha.Text) { 
            Usuario user1 = new Usuario();
            user1.Visible = true;
            this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou Senha incorreto");
                Usuario.Text = "";
                Senha.Text = "";
            }
            

        }
                
        

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void esqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
