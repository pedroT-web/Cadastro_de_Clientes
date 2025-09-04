namespace Cadastro_de_Clientes
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enviar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.labelMenssagem0 = new System.Windows.Forms.Label();
            this.labelMenssagem1 = new System.Windows.Forms.Label();
            this.labelMenssagem2 = new System.Windows.Forms.Label();
            this.labelMenssagem3 = new System.Windows.Forms.Label();
            this.labelMenssagem4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enviar
            // 
            this.Enviar.BackColor = System.Drawing.Color.Green;
            this.Enviar.ForeColor = System.Drawing.Color.White;
            this.Enviar.Location = new System.Drawing.Point(626, 398);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(177, 40);
            this.Enviar.TabIndex = 0;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = false;
            this.Enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Red;
            this.Fechar.ForeColor = System.Drawing.Color.White;
            this.Fechar.Location = new System.Drawing.Point(431, 398);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(177, 40);
            this.Fechar.TabIndex = 1;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite seu Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(248, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(555, 35);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite seu Sobrenome:";
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.Location = new System.Drawing.Point(314, 82);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(489, 35);
            this.textBoxSobrenome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite seu E-mail:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(248, 137);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(555, 35);
            this.textBoxEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Digite sua Idade:";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdade.Location = new System.Drawing.Point(248, 189);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(555, 35);
            this.textBoxIdade.TabIndex = 4;
            // 
            // labelMenssagem0
            // 
            this.labelMenssagem0.AutoSize = true;
            this.labelMenssagem0.Location = new System.Drawing.Point(40, 250);
            this.labelMenssagem0.Name = "labelMenssagem0";
            this.labelMenssagem0.Size = new System.Drawing.Size(0, 13);
            this.labelMenssagem0.TabIndex = 4;
            // 
            // labelMenssagem1
            // 
            this.labelMenssagem1.AutoSize = true;
            this.labelMenssagem1.Location = new System.Drawing.Point(40, 276);
            this.labelMenssagem1.Name = "labelMenssagem1";
            this.labelMenssagem1.Size = new System.Drawing.Size(0, 13);
            this.labelMenssagem1.TabIndex = 5;
            // 
            // labelMenssagem2
            // 
            this.labelMenssagem2.AutoSize = true;
            this.labelMenssagem2.Location = new System.Drawing.Point(40, 301);
            this.labelMenssagem2.Name = "labelMenssagem2";
            this.labelMenssagem2.Size = new System.Drawing.Size(0, 13);
            this.labelMenssagem2.TabIndex = 6;
            // 
            // labelMenssagem3
            // 
            this.labelMenssagem3.AutoSize = true;
            this.labelMenssagem3.Location = new System.Drawing.Point(40, 323);
            this.labelMenssagem3.Name = "labelMenssagem3";
            this.labelMenssagem3.Size = new System.Drawing.Size(0, 13);
            this.labelMenssagem3.TabIndex = 7;
            // 
            // labelMenssagem4
            // 
            this.labelMenssagem4.AutoSize = true;
            this.labelMenssagem4.Location = new System.Drawing.Point(40, 349);
            this.labelMenssagem4.Name = "labelMenssagem4";
            this.labelMenssagem4.Size = new System.Drawing.Size(0, 13);
            this.labelMenssagem4.TabIndex = 8;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.labelMenssagem4);
            this.Controls.Add(this.labelMenssagem3);
            this.Controls.Add(this.labelMenssagem2);
            this.Controls.Add(this.labelMenssagem1);
            this.Controls.Add(this.labelMenssagem0);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Enviar);
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label labelMenssagem0;
        private System.Windows.Forms.Label labelMenssagem1;
        private System.Windows.Forms.Label labelMenssagem2;
        private System.Windows.Forms.Label labelMenssagem3;
        private System.Windows.Forms.Label labelMenssagem4;
    }
}

