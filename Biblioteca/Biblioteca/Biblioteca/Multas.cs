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
    public partial class Multas : Form
    {
        public Multas()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Usuario user8 = new Usuario();
            user8.Visible = true;
            this.Close();


        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Select_multa sM = new Select_multa();
            string nome_Cliente;
            DateTime data_Entrega,d;
            int CPF; 
            double valor_total, dias_Excedidos;
            


            (nome_Cliente, data_Entrega, CPF) = sM.BuscaMulta(int.Parse(textCpfclient.Text));

            if (CPF !=-1){
                d = Convert.ToDateTime(data_Entrega);
                dias_Excedidos = DateTime.Today.Day - d.Day;
                valor_total = dias_Excedidos * 0.5;



                this.dataGridView1.Rows.Insert(0, nome_Cliente,dias_Excedidos,0.50,valor_total);

                MessageBox.Show("Usuário Encontrado");
            }
            else
            {
                MessageBox.Show("Usuário não Encontrado");

            }






        }

        private void textCpfclient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
