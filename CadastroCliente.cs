using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro_de_Clientes
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            string email = textBoxEmail.Text;
            int idade = int.Parse(textBoxIdade.Text);
            string conexaoBanco = "server=localhost;user id=root;password=;database=db_clientes";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string query = "INSERT INTO tb_clientes (nome, sobrenome, email, idade) VALUES (@nome, @sobrenome, @email, @idade)";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@idade", idade);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Cliente {nome} Cadastrado Com Sucesso", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxNome.Clear();
                    textBoxEmail.Clear();
                    textBoxSobrenome.Clear();
                    textBoxIdade.Clear();
                    textBoxNome.Focus();

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Cadastrar Cliente, Erro de conexão com o banco de dados" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
