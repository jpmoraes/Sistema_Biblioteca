
namespace Biblioteca
{
    partial class Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.dataE = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEventos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textHorario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textOrganizador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textCpfOr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Evento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(673, 379);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(170, 71);
            this.Cadastrar.TabIndex = 2;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(673, 458);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(170, 71);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataE
            // 
            this.dataE.Location = new System.Drawing.Point(104, 260);
            this.dataE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataE.Name = "dataE";
            this.dataE.Size = new System.Drawing.Size(267, 27);
            this.dataE.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cadastro de Eventos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(157, 207);
            this.textDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(445, 27);
            this.textDesc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horario:";
            // 
            // textEventos
            // 
            this.textEventos.Location = new System.Drawing.Point(249, 151);
            this.textEventos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEventos.Name = "textEventos";
            this.textEventos.Size = new System.Drawing.Size(355, 27);
            this.textEventos.TabIndex = 9;
            this.textEventos.TextChanged += new System.EventHandler(this.textHora_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição:";
            // 
            // textHorario
            // 
            this.textHorario.Location = new System.Drawing.Point(145, 317);
            this.textHorario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textHorario.Name = "textHorario";
            this.textHorario.Size = new System.Drawing.Size(219, 27);
            this.textHorario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome do Organizador:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textOrganizador
            // 
            this.textOrganizador.Location = new System.Drawing.Point(318, 376);
            this.textOrganizador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textOrganizador.Name = "textOrganizador";
            this.textOrganizador.Size = new System.Drawing.Size(282, 27);
            this.textOrganizador.TabIndex = 13;
            this.textOrganizador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "CPF do Organizador:";
            // 
            // textCpfOr
            // 
            this.textCpfOr.Location = new System.Drawing.Point(261, 431);
            this.textCpfOr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCpfOr.Name = "textCpfOr";
            this.textCpfOr.Size = new System.Drawing.Size(211, 27);
            this.textCpfOr.TabIndex = 15;
            this.textCpfOr.TextChanged += new System.EventHandler(this.textCod_TextChanged);
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 530);
            this.Controls.Add(this.textCpfOr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textOrganizador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textHorario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEventos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataE);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Eventos";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Eventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DateTimePicker dataE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEventos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textOrganizador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCpfOr;
    }
}