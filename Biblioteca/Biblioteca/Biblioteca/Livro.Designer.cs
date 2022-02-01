
namespace Biblioteca
{
    partial class Livro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textLivro = new System.Windows.Forms.TextBox();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.textSinopse = new System.Windows.Forms.TextBox();
            this.textPagina = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textEditora = new System.Windows.Forms.TextBox();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.textSub = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataL = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Qnt_L = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(254, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN:";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(12, 445);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(219, 73);
            this.Cadastrar.TabIndex = 2;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(619, 445);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(219, 73);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sinopse:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nº Páginas:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Autor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Editora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(291, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gênero:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(291, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Subgênero:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(254, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(362, 45);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cadastro de Livro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(291, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "Classificação:";
            // 
            // textLivro
            // 
            this.textLivro.Location = new System.Drawing.Point(95, 54);
            this.textLivro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textLivro.Name = "textLivro";
            this.textLivro.Size = new System.Drawing.Size(153, 27);
            this.textLivro.TabIndex = 12;
            this.textLivro.TextChanged += new System.EventHandler(this.textLivro_TextChanged);
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(347, 54);
            this.textISBN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(146, 27);
            this.textISBN.TabIndex = 13;
            // 
            // textSinopse
            // 
            this.textSinopse.Location = new System.Drawing.Point(16, 118);
            this.textSinopse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSinopse.Multiline = true;
            this.textSinopse.Name = "textSinopse";
            this.textSinopse.Size = new System.Drawing.Size(600, 117);
            this.textSinopse.TabIndex = 14;
            this.textSinopse.TextChanged += new System.EventHandler(this.textSinopse_TextChanged);
            // 
            // textPagina
            // 
            this.textPagina.Location = new System.Drawing.Point(176, 361);
            this.textPagina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPagina.Name = "textPagina";
            this.textPagina.Size = new System.Drawing.Size(104, 27);
            this.textPagina.TabIndex = 15;
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(111, 241);
            this.textAutor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(169, 27);
            this.textAutor.TabIndex = 16;
            // 
            // textEditora
            // 
            this.textEditora.Location = new System.Drawing.Point(134, 272);
            this.textEditora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditora.Name = "textEditora";
            this.textEditora.Size = new System.Drawing.Size(132, 27);
            this.textEditora.TabIndex = 17;
            // 
            // textGenero
            // 
            this.textGenero.Location = new System.Drawing.Point(391, 239);
            this.textGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(169, 27);
            this.textGenero.TabIndex = 18;
            // 
            // textIdade
            // 
            this.textIdade.Location = new System.Drawing.Point(461, 303);
            this.textIdade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(99, 27);
            this.textIdade.TabIndex = 19;
            // 
            // textSub
            // 
            this.textSub.Location = new System.Drawing.Point(428, 272);
            this.textSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSub.Name = "textSub";
            this.textSub.Size = new System.Drawing.Size(132, 27);
            this.textSub.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(16, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ano:";
            // 
            // dataL
            // 
            this.dataL.Location = new System.Drawing.Point(77, 301);
            this.dataL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataL.Name = "dataL";
            this.dataL.Size = new System.Drawing.Size(203, 27);
            this.dataL.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(16, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 29);
            this.label12.TabIndex = 23;
            this.label12.Text = "Quantidade:";
            // 
            // Qnt_L
            // 
            this.Qnt_L.Location = new System.Drawing.Point(178, 332);
            this.Qnt_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Qnt_L.Name = "Qnt_L";
            this.Qnt_L.Size = new System.Drawing.Size(102, 27);
            this.Qnt_L.TabIndex = 24;
            this.Qnt_L.TextChanged += new System.EventHandler(this.Qnt_L_TextChanged);
            // 
            // Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 531);
            this.Controls.Add(this.Qnt_L);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textSub);
            this.Controls.Add(this.textIdade);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.textEditora);
            this.Controls.Add(this.textAutor);
            this.Controls.Add(this.textPagina);
            this.Controls.Add(this.textSinopse);
            this.Controls.Add(this.textISBN);
            this.Controls.Add(this.textLivro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Livro";
            this.Text = "Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textLivro;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.TextBox textSinopse;
        private System.Windows.Forms.TextBox textPagina;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textEditora;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.TextBox textSub;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dataL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Qnt_L;
    }
}