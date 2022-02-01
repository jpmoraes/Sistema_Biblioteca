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
    public partial class B_Cliente : Form
    {
        public B_Cliente()
        {
            InitializeComponent();
        }

        private void LImpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            listaCliente lC = new listaCliente();



            string B_G, B_PF, Bnome, B_TEL, B_Bair, B_Rua, B_CEP, B_Cid;
            DateTime D_nc = new DateTime();


            int Bcpf, B_N;



            (Bcpf, B_G, B_PF, Bnome, B_TEL, B_Bair, B_Rua, B_N, B_CEP, B_Cid,D_nc) = lC.BuscaCliente(int.Parse(BCPF.Text));



            if (Bcpf != -1)
            {
                textBox1.Text = Bnome;
                textBox2.Text = B_TEL;
                textBox3.Text = B_G;
                textBox4.Text = B_PF;
                textBox5.Text = B_Rua;
                textBox6.Text = Convert.ToString(B_N);
                textBox7.Text = B_CEP;
                textBox8.Text = B_Cid;
                textBox9.Text = B_Bair;
                dataN.Value = D_nc;



            }



            else



            {



                MessageBox.Show("Usuário não encontrado");



            }
        }

        private void B_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Usuario user3 = new Usuario();
            user3.Visible = true;
            this.Close();
        }
    }
}
