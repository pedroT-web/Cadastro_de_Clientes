namespace Cadastro_de_Clientes
{
    partial class ConsultaCliente
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
            this.GridClientes = new System.Windows.Forms.DataGridView();
            this.Fechar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.comboBoxNome = new System.Windows.Forms.ComboBox();
            this.GridNomeSolo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNomeSolo)).BeginInit();
            this.SuspendLayout();
            // 
            // GridClientes
            // 
            this.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClientes.Location = new System.Drawing.Point(34, 322);
            this.GridClientes.Name = "GridClientes";
            this.GridClientes.Size = new System.Drawing.Size(535, 199);
            this.GridClientes.TabIndex = 0;
            this.GridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridClientes_CellContentClick);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Red;
            this.Fechar.ForeColor = System.Drawing.Color.White;
            this.Fechar.Location = new System.Drawing.Point(742, 538);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(175, 49);
            this.Fechar.TabIndex = 2;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.Location = new System.Drawing.Point(742, 193);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(175, 62);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar Clientes";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(742, 278);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(175, 62);
            this.buttonAtualizar.TabIndex = 4;
            this.buttonAtualizar.Text = "Atualizar Dados";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // comboBoxNome
            // 
            this.comboBoxNome.FormattingEnabled = true;
            this.comboBoxNome.Location = new System.Drawing.Point(34, 38);
            this.comboBoxNome.Name = "comboBoxNome";
            this.comboBoxNome.Size = new System.Drawing.Size(535, 21);
            this.comboBoxNome.TabIndex = 5;
            this.comboBoxNome.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GridNomeSolo
            // 
            this.GridNomeSolo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNomeSolo.Location = new System.Drawing.Point(34, 87);
            this.GridNomeSolo.Name = "GridNomeSolo";
            this.GridNomeSolo.Size = new System.Drawing.Size(535, 69);
            this.GridNomeSolo.TabIndex = 6;
            this.GridNomeSolo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClienteSolo_CellContentClick);
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 616);
            this.Controls.Add(this.GridNomeSolo);
            this.Controls.Add(this.comboBoxNome);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.GridClientes);
            this.Name = "ConsultaCliente";
            this.Text = "ConsultaCliente";
            this.Load += new System.EventHandler(this.ConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNomeSolo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridClientes;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.ComboBox comboBoxNome;
        private System.Windows.Forms.DataGridView GridNomeSolo;
    }
}