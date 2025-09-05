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
            string idadeString = textBoxIdade.Text;
            string arroba = "@";

            bool validarIdade = int.TryParse(idadeString, out int idade);

            

            if(String.IsNullOrEmpty(nome)  )
            {
                    MessageBox.Show("Dados Inválidos,O campo Nome está incorreto, Digite Novamente o Nome", "Dados Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNome.Focus();
                return;
            }else if (String.IsNullOrEmpty(sobrenome))
            {
                MessageBox.Show("Dados Inválidos,O campo Sobrenome está incorreto, Digite Novamente o Sobrenome", "Dados Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxSobrenome.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Dados Inválidos,O campo Email está incorreto, Digite Novamente o Email", "Dados Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxEmail.Focus();
                return;
            }
            else if(email.Contains(arroba) == false)
            {
                MessageBox.Show("Dados Inválidos,O campo Email Precisa de @,Digite Novamente o Email", "Dados Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxEmail.Focus();
                return;
            }
            else if (validarIdade == false || idade >= 130 || idade <= 0)
            {
                MessageBox.Show("Dados Inválidos,O campo Idade está incorreto, Digite Novamente a Idade", "Dados Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxIdade.Focus();
                return;
            }
            else
            {
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

                        limparDados();

                        conexao.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Cadastrar Cliente, Erro de conexão com o banco de dados" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

                idade = int.Parse(idadeString);

            
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparDados()
        {
            textBoxNome.Clear();
            textBoxEmail.Clear();
            textBoxSobrenome.Clear();
            textBoxIdade.Clear();
            textBoxNome.Focus();
        }
    }
}
