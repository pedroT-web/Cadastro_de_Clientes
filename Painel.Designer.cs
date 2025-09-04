namespace Cadastro_de_Clientes
{
    partial class Painel
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
            this.cad_cli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.consulta_cli = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cad_cli
            // 
            this.cad_cli.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cad_cli.Location = new System.Drawing.Point(173, 139);
            this.cad_cli.Name = "cad_cli";
            this.cad_cli.Size = new System.Drawing.Size(206, 49);
            this.cad_cli.TabIndex = 0;
            this.cad_cli.Text = "Cadastro de Clientes";
            this.cad_cli.UseVisualStyleBackColor = true;
            this.cad_cli.Click += new System.EventHandler(this.cad_cli_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // consulta_cli
            // 
            this.consulta_cli.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulta_cli.Location = new System.Drawing.Point(413, 139);
            this.consulta_cli.Name = "consulta_cli";
            this.consulta_cli.Size = new System.Drawing.Size(206, 49);
            this.consulta_cli.TabIndex = 2;
            this.consulta_cli.Text = "Consuta de Clientes";
            this.consulta_cli.UseVisualStyleBackColor = true;
            this.consulta_cli.Click += new System.EventHandler(this.consulta_cli_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Red;
            this.Fechar.ForeColor = System.Drawing.Color.White;
            this.Fechar.Location = new System.Drawing.Point(303, 213);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(177, 40);
            this.Fechar.TabIndex = 3;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.consulta_cli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cad_cli);
            this.Name = "Painel";
            this.Text = "painel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cad_cli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button consulta_cli;
        private System.Windows.Forms.Button Fechar;
    }
}