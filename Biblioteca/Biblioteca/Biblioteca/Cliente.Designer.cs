
namespace Biblioteca
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textSexual = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textLit = new System.Windows.Forms.TextBox();
            this.dataN = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textrua = new System.Windows.Forms.TextBox();
            this.textnumero = new System.Windows.Forms.TextBox();
            this.textcep = new System.Windows.Forms.TextBox();
            this.textcidade = new System.Windows.Forms.TextBox();
            this.textbairro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Nascimento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gênero:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nº Telefone:";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(652, 361);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(184, 73);
            this.Cadastrar.TabIndex = 7;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(652, 445);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(184, 73);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Perfil Literário:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(90, 77);
            this.textNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(286, 27);
            this.textNome.TabIndex = 10;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(90, 119);
            this.textCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(286, 27);
            this.textCPF.TabIndex = 11;
            // 
            // textSexual
            // 
            this.textSexual.Location = new System.Drawing.Point(105, 196);
            this.textSexual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSexual.Name = "textSexual";
            this.textSexual.Size = new System.Drawing.Size(271, 27);
            this.textSexual.TabIndex = 13;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(154, 231);
            this.textTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(222, 27);
            this.textTel.TabIndex = 15;
            // 
            // textLit
            // 
            this.textLit.Location = new System.Drawing.Point(198, 265);
            this.textLit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textLit.Name = "textLit";
            this.textLit.Size = new System.Drawing.Size(179, 27);
            this.textLit.TabIndex = 16;
            // 
            // dataN
            // 
            this.dataN.Location = new System.Drawing.Point(263, 156);
            this.dataN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataN.Name = "dataN";
            this.dataN.Size = new System.Drawing.Size(228, 27);
            this.dataN.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "Endereço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 35);
            this.label9.TabIndex = 19;
            this.label9.Text = "Rua:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 35);
            this.label10.TabIndex = 20;
            this.label10.Text = "Numero:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(16, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 35);
            this.label11.TabIndex = 21;
            this.label11.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(14, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 35);
            this.label12.TabIndex = 22;
            this.label12.Text = "Cidade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(14, 492);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 35);
            this.label13.TabIndex = 23;
            this.label13.Text = "Bairro:";
            // 
            // textrua
            // 
            this.textrua.Location = new System.Drawing.Point(122, 344);
            this.textrua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textrua.Name = "textrua";
            this.textrua.Size = new System.Drawing.Size(175, 27);
            this.textrua.TabIndex = 24;
            // 
            // textnumero
            // 
            this.textnumero.Location = new System.Drawing.Point(141, 384);
            this.textnumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textnumero.Name = "textnumero";
            this.textnumero.Size = new System.Drawing.Size(157, 27);
            this.textnumero.TabIndex = 25;
            // 
            // textcep
            // 
            this.textcep.Location = new System.Drawing.Point(105, 423);
            this.textcep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textcep.Name = "textcep";
            this.textcep.Size = new System.Drawing.Size(193, 27);
            this.textcep.TabIndex = 26;
            // 
            // textcidade
            // 
            this.textcidade.Location = new System.Drawing.Point(130, 461);
            this.textcidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textcidade.Name = "textcidade";
            this.textcidade.Size = new System.Drawing.Size(167, 27);
            this.textcidade.TabIndex = 27;
            // 
            // textbairro
            // 
            this.textbairro.Location = new System.Drawing.Point(130, 500);
            this.textbairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbairro.Name = "textbairro";
            this.textbairro.Size = new System.Drawing.Size(167, 27);
            this.textbairro.TabIndex = 28;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(848, 531);
            this.Controls.Add(this.textbairro);
            this.Controls.Add(this.textcidade);
            this.Controls.Add(this.textcep);
            this.Controls.Add(this.textnumero);
            this.Controls.Add(this.textrua);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataN);
            this.Controls.Add(this.textLit);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textSexual);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.TextBox textSexual;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textLit;
        private System.Windows.Forms.DateTimePicker dataN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textrua;
        private System.Windows.Forms.TextBox textnumero;
        private System.Windows.Forms.TextBox textcep;
        private System.Windows.Forms.TextBox textcidade;
        private System.Windows.Forms.TextBox textbairro;
    }
}