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
    public partial class conLivro : Form
    {
        public conLivro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltalivro_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Visible = true;
            this.Close();
        }

        private void buscalivro_Click(object sender, EventArgs e)
        {

        }
    }
}
