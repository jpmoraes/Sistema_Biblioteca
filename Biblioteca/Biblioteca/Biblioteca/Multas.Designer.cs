
namespace Biblioteca
{
    partial class Multas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multas));
            this.label1 = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.voltaremprestimo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCpfclient = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasExcedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTaxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela Multa";
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(275, 374);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(111, 42);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // voltaremprestimo
            // 
            this.voltaremprestimo.Location = new System.Drawing.Point(692, 455);
            this.voltaremprestimo.Name = "voltaremprestimo";
            this.voltaremprestimo.Size = new System.Drawing.Size(131, 65);
            this.voltaremprestimo.TabIndex = 2;
            this.voltaremprestimo.Text = "Voltar";
            this.voltaremprestimo.UseVisualStyleBackColor = true;
            this.voltaremprestimo.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF do Cliente:";
            // 
            // textCpfclient
            // 
            this.textCpfclient.Location = new System.Drawing.Point(300, 174);
            this.textCpfclient.Name = "textCpfclient";
            this.textCpfclient.Size = new System.Drawing.Size(204, 23);
            this.textCpfclient.TabIndex = 4;
            this.textCpfclient.TextChanged += new System.EventHandler(this.textCpfclient_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCliente,
            this.diasExcedidos,
            this.valorTaxa,
            this.valorTotal});
            this.dataGridView1.Location = new System.Drawing.Point(183, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // nameCliente
            // 
            this.nameCliente.HeaderText = "Nome do Cliente";
            this.nameCliente.Name = "nameCliente";
            // 
            // diasExcedidos
            // 
            this.diasExcedidos.HeaderText = "Dias Excedidos";
            this.diasExcedidos.Name = "diasExcedidos";
            // 
            // valorTaxa
            // 
            this.valorTaxa.HeaderText = "Valor da Taxa ";
            this.valorTaxa.Name = "valorTaxa";
            // 
            // valorTotal
            // 
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            // 
            // Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(848, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textCpfclient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.voltaremprestimo);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Multas";
            this.Text = "Multas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button voltaremprestimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCpfclient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasExcedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
    }
}