
namespace Biblioteca
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.multaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestimo = new System.Windows.Forms.Button();
            this.cpfCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnLivro = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.consultarToolStripMenuItem1,
            this.agendarToolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem2,
            this.livroToolStripMenuItem4});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.consultaToolStripMenuItem.Text = "Cadastrar";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem2.Text = "Cliente ";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // livroToolStripMenuItem4
            // 
            this.livroToolStripMenuItem4.Name = "livroToolStripMenuItem4";
            this.livroToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.livroToolStripMenuItem4.Text = "Livro";
            this.livroToolStripMenuItem4.Click += new System.EventHandler(this.livroToolStripMenuItem4_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem3,
            this.livroToolStripMenuItem5,
            this.agendaToolStripMenuItem,
            this.históricoToolStripMenuItem,
            this.multaToolStripMenuItem});
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // clienteToolStripMenuItem3
            // 
            this.clienteToolStripMenuItem3.Name = "clienteToolStripMenuItem3";
            this.clienteToolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
            this.clienteToolStripMenuItem3.Text = "Cliente";
            this.clienteToolStripMenuItem3.Click += new System.EventHandler(this.clienteToolStripMenuItem3_Click);
            // 
            // livroToolStripMenuItem5
            // 
            this.livroToolStripMenuItem5.Name = "livroToolStripMenuItem5";
            this.livroToolStripMenuItem5.Size = new System.Drawing.Size(122, 22);
            this.livroToolStripMenuItem5.Text = "Livro";
            this.livroToolStripMenuItem5.Click += new System.EventHandler(this.livroToolStripMenuItem5_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem4,
            this.livroToolStripMenuItem6});
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem4
            // 
            this.clienteToolStripMenuItem4.Name = "clienteToolStripMenuItem4";
            this.clienteToolStripMenuItem4.Size = new System.Drawing.Size(111, 22);
            this.clienteToolStripMenuItem4.Text = "Cliente";
            this.clienteToolStripMenuItem4.Click += new System.EventHandler(this.clienteToolStripMenuItem4_Click);
            // 
            // livroToolStripMenuItem6
            // 
            this.livroToolStripMenuItem6.Name = "livroToolStripMenuItem6";
            this.livroToolStripMenuItem6.Size = new System.Drawing.Size(111, 22);
            this.livroToolStripMenuItem6.Text = "Livro";
            this.livroToolStripMenuItem6.Click += new System.EventHandler(this.livroToolStripMenuItem6_Click);
            // 
            // multaToolStripMenuItem
            // 
            this.multaToolStripMenuItem.Name = "multaToolStripMenuItem";
            this.multaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.multaToolStripMenuItem.Text = "Multa";
            this.multaToolStripMenuItem.Click += new System.EventHandler(this.multaToolStripMenuItem_Click);
            // 
            // agendarToolStripMenuItem2
            // 
            this.agendarToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem1});
            this.agendarToolStripMenuItem2.Name = "agendarToolStripMenuItem2";
            this.agendarToolStripMenuItem2.Size = new System.Drawing.Size(64, 20);
            this.agendarToolStripMenuItem2.Text = "Agendar";
            // 
            // eventosToolStripMenuItem1
            // 
            this.eventosToolStripMenuItem1.Name = "eventosToolStripMenuItem1";
            this.eventosToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.eventosToolStripMenuItem1.Text = "Eventos";
            this.eventosToolStripMenuItem1.Click += new System.EventHandler(this.eventosToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // emprestimo
            // 
            this.emprestimo.Location = new System.Drawing.Point(10, 343);
            this.emprestimo.Name = "emprestimo";
            this.emprestimo.Size = new System.Drawing.Size(138, 47);
            this.emprestimo.TabIndex = 6;
            this.emprestimo.Text = "Emprestimo";
            this.emprestimo.UseVisualStyleBackColor = true;
            this.emprestimo.Click += new System.EventHandler(this.emprestimo_Click);
            // 
            // cpfCliente
            // 
            this.cpfCliente.Location = new System.Drawing.Point(260, 146);
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.Size = new System.Drawing.Size(201, 23);
            this.cpfCliente.TabIndex = 7;
            this.cpfCliente.TextChanged += new System.EventHandler(this.cpfCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digite o CPF do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(258, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite o ISBN do Livro:";
            // 
            // isbnLivro
            // 
            this.isbnLivro.Location = new System.Drawing.Point(260, 198);
            this.isbnLivro.Name = "isbnLivro";
            this.isbnLivro.Size = new System.Drawing.Size(201, 23);
            this.isbnLivro.TabIndex = 10;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(294, 224);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(138, 47);
            this.buscar.TabIndex = 11;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Devolução";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.isbnLivro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpfCliente);
            this.Controls.Add(this.emprestimo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button emprestimo;
        private System.Windows.Forms.TextBox cpfCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbnLivro;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem multaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}