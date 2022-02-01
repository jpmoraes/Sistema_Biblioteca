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
    public partial class hisCliente : Form
    {
        public hisCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            select_his_clt his_clt = new select_his_clt();
            string Livro;
            DateTime data_Aluguel, data_Entrega;
            int BCPF, cont,i = 0;
            List<string> listaCliente = new List<string>();
            (listaCliente, BCPF) = his_clt.BuscaCPF (int.Parse(CPF.Text));

            cont = listaCliente.Count;
            if (BCPF != -1)
             {

                while (i < cont)
                {
                    Livro = listaCliente[i];
                    data_Aluguel =Convert.ToDateTime(listaCliente[i + 1]);
                    data_Entrega = Convert.ToDateTime(listaCliente[i + 2]);
                    i = i + 3;
                    this.dataGridView1.Rows.Insert(0, Livro, data_Aluguel.ToString("d"), data_Entrega.ToString("d"));

                }
                

            }

            else
             {

            MessageBox.Show(his_clt.msn);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario user4 = new Usuario();
            user4.Visible = true;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
