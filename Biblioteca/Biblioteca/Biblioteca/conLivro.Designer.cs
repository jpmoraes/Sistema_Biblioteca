
namespace Biblioteca
{
    partial class conLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conLivro));
            this.label1 = new System.Windows.Forms.Label();
            this.conlivro1 = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colunlivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunentrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.buscalivro = new System.Windows.Forms.Button();
            this.voltalivro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN do Livro :";
            // 
            // conlivro1
            // 
            this.conlivro1.Location = new System.Drawing.Point(295, 157);
            this.conlivro1.Name = "conlivro1";
            this.conlivro1.Size = new System.Drawing.Size(242, 23);
            this.conlivro1.TabIndex = 3;
            this.conlivro1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunlivro,
            this.colunaluguel,
            this.colunentrega});
            this.dataGridView.Location = new System.Drawing.Point(219, 215);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(343, 132);
            this.dataGridView.TabIndex = 7;
            // 
            // colunlivro
            // 
            this.colunlivro.HeaderText = "Livro";
            this.colunlivro.Name = "colunlivro";
            // 
            // colunaluguel
            // 
            this.colunaluguel.HeaderText = "Data Aluguel";
            this.colunaluguel.Name = "colunaluguel";
            // 
            // colunentrega
            // 
            this.colunentrega.HeaderText = "Data Entrega";
            this.colunentrega.Name = "colunentrega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(277, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Consulta do Livro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buscalivro
            // 
            this.buscalivro.Location = new System.Drawing.Point(12, 451);
            this.buscalivro.Name = "buscalivro";
            this.buscalivro.Size = new System.Drawing.Size(192, 55);
            this.buscalivro.TabIndex = 9;
            this.buscalivro.Text = "Buscar";
            this.buscalivro.UseVisualStyleBackColor = true;
            this.buscalivro.Click += new System.EventHandler(this.buscalivro_Click);
            // 
            // voltalivro
            // 
            this.voltalivro.Location = new System.Drawing.Point(628, 451);
            this.voltalivro.Name = "voltalivro";
            this.voltalivro.Size = new System.Drawing.Size(192, 55);
            this.voltalivro.TabIndex = 10;
            this.voltalivro.Text = "Voltar";
            this.voltalivro.UseVisualStyleBackColor = true;
            this.voltalivro.Click += new System.EventHandler(this.voltalivro_Click);
            // 
            // conLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 535);
            this.Controls.Add(this.voltalivro);
            this.Controls.Add(this.buscalivro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.conlivro1);
            this.Controls.Add(this.label1);
            this.Name = "conLivro";
            this.Text = "conLivro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conlivro1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscalivro;
        private System.Windows.Forms.Button voltalivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunlivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunentrega;
    }
}