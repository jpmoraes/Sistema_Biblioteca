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
    public partial class conAgenda : Form
    {
        public conAgenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Usuario conagenda1 = new Usuario();
            conagenda1.Visible = true;
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            listaEventos lE = new listaEventos();


            string nome_E, dsc_E, nome_Org,H_E;
            DateTime dt_E = new DateTime();


            int BCPF_Org;



            (nome_E, dsc_E, dt_E, nome_Org, BCPF_Org,H_E) = lE.BuscaEventos(int.Parse(BCPFO.Text));



            if (BCPF_Org != -1)
            {
                this.dataGridView1.Rows.Insert(0, nome_Org, dt_E.ToString("d"), nome_E);
            }



            else



            {



                MessageBox.Show("Usuário não encontrado");



            }
        }

        private void LImpar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
        }
    }
}
