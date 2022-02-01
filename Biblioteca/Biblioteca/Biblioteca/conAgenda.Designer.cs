
namespace Biblioteca
{
    partial class conAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conAgenda));
            this.Buscar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BCPFO = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Organizador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LImpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(14, 612);
            this.Buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(155, 83);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(775, 612);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(163, 83);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(344, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar Eventos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(362, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF do Organizador:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BCPFO
            // 
            this.BCPFO.Location = new System.Drawing.Point(323, 271);
            this.BCPFO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BCPFO.Name = "BCPFO";
            this.BCPFO.Size = new System.Drawing.Size(270, 27);
            this.BCPFO.TabIndex = 5;
            this.BCPFO.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Organizador,
            this.DT_Evento,
            this.nomeEvento});
            this.dataGridView1.Location = new System.Drawing.Point(272, 309);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(392, 200);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Organizador
            // 
            this.Organizador.HeaderText = "Organizador";
            this.Organizador.MinimumWidth = 6;
            this.Organizador.Name = "Organizador";
            this.Organizador.Width = 125;
            // 
            // DT_Evento
            // 
            this.DT_Evento.HeaderText = "Data do Evento";
            this.DT_Evento.MinimumWidth = 6;
            this.DT_Evento.Name = "DT_Evento";
            this.DT_Evento.Width = 125;
            // 
            // nomeEvento
            // 
            this.nomeEvento.HeaderText = "Nome do Evento";
            this.nomeEvento.MinimumWidth = 6;
            this.nomeEvento.Name = "nomeEvento";
            this.nomeEvento.Width = 125;
            // 
            // LImpar
            // 
            this.LImpar.Location = new System.Drawing.Point(390, 517);
            this.LImpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LImpar.Name = "LImpar";
            this.LImpar.Size = new System.Drawing.Size(155, 83);
            this.LImpar.TabIndex = 7;
            this.LImpar.Text = "Limpar";
            this.LImpar.UseVisualStyleBackColor = true;
            this.LImpar.Click += new System.EventHandler(this.LImpar_Click);
            // 
            // conAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 711);
            this.Controls.Add(this.LImpar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BCPFO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Buscar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "conAgenda";
            this.Text = "conAgenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BCPFO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEvento;
        private System.Windows.Forms.Button LImpar;
    }
}