
namespace Biblioteca
{
    partial class hisLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hisLivro));
            this.buscahislivro = new System.Windows.Forms.Button();
            this.voltahislivro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hislivro1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome_hist_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_hist_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Aluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_devolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscahislivro
            // 
            this.buscahislivro.Location = new System.Drawing.Point(273, 385);
            this.buscahislivro.Name = "buscahislivro";
            this.buscahislivro.Size = new System.Drawing.Size(107, 40);
            this.buscahislivro.TabIndex = 3;
            this.buscahislivro.Text = "Buscar";
            this.buscahislivro.UseVisualStyleBackColor = true;
            this.buscahislivro.Click += new System.EventHandler(this.buscahislivro_Click);
            // 
            // voltahislivro
            // 
            this.voltahislivro.Location = new System.Drawing.Point(657, 477);
            this.voltahislivro.Name = "voltahislivro";
            this.voltahislivro.Size = new System.Drawing.Size(124, 44);
            this.voltahislivro.TabIndex = 4;
            this.voltahislivro.Text = "Voltar";
            this.voltahislivro.UseVisualStyleBackColor = true;
            this.voltahislivro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Histórico do Livro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(205, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "ISBN Livro :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hislivro1
            // 
            this.hislivro1.Location = new System.Drawing.Point(347, 164);
            this.hislivro1.Name = "hislivro1";
            this.hislivro1.Size = new System.Drawing.Size(276, 23);
            this.hislivro1.TabIndex = 7;
            this.hislivro1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_hist_livro,
            this.nome_hist_cliente,
            this.dt_Aluguel,
            this.dt_devolucao});
            this.dataGridView1.Location = new System.Drawing.Point(225, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(422, 162);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // nome_hist_livro
            // 
            this.nome_hist_livro.HeaderText = "Nome do Livro";
            this.nome_hist_livro.Name = "nome_hist_livro";
            // 
            // nome_hist_cliente
            // 
            this.nome_hist_cliente.HeaderText = "Nome do Cliente";
            this.nome_hist_cliente.Name = "nome_hist_cliente";
            // 
            // dt_Aluguel
            // 
            this.dt_Aluguel.HeaderText = "Data de Aluguel";
            this.dt_Aluguel.Name = "dt_Aluguel";
            // 
            // dt_devolucao
            // 
            this.dt_devolucao.HeaderText = "Data Devolução";
            this.dt_devolucao.Name = "dt_devolucao";
            // 
            // hisLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.hislivro1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voltahislivro);
            this.Controls.Add(this.buscahislivro);
            this.Name = "hisLivro";
            this.Text = "hisLivro";
            this.Load += new System.EventHandler(this.hisLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscahislivro;
        private System.Windows.Forms.Button voltahislivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hislivro1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_hist_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_hist_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Aluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_devolucao;
    }
}