using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cadastro_de_Clientes
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            fnListarClientes();
            fnCarregarComboBox();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            fnListarClientes();
        }

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (GridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente para executar a remoção do mesmo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow linhaSelecionada = GridClientes.SelectedRows[0];
            int idCliente = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);

            DialogResult confirmacao = MessageBox.Show("Relmente Deseja Deleter o cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                string conexaoBanco = "server=localhost;user id=root;database=db_clientes";
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    try
                    {
                        conexao.Open();
                        string delete = "DELETE FROM tb_clientes WHERE id = @id"; // Linha de execussão de exclusão
                        MySqlCommand cmd = new MySqlCommand(delete, conexao); // criando um novo comando 
                        cmd.Parameters.AddWithValue("@id", idCliente); // Adicionando o valor do id para a variável temporaria
                        cmd.ExecuteNonQuery(); // execução do comando

                        conexao.Close(); // fechando o banco
                        fnListarClientes(); // instanciando a função para ser executada depois de deletar o cliente;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar cliente, erro de conexão de banco de dados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void fnListarClientes()
        {
            string conexaoBanco = "server=localhost;user id=root;password=;database=db_clientes";
            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM tb_clientes";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    GridClientes.DataSource = tabela;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Cadastrar Cliente, Erro de conexão com o banco de dados" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = GridClientes.SelectedRows[0];
            int idCliente = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);
            string nomeCliente = Convert.ToString(linhaSelecionada.Cells["nome"].Value);
            string sobreNomeCliente = Convert.ToString(linhaSelecionada.Cells["sobrenome"].Value);
            string emailCliente = Convert.ToString(linhaSelecionada.Cells["email"].Value);
            int idadeCliente = Convert.ToInt32(linhaSelecionada.Cells["idade"].Value);

            DialogResult confirmacao = MessageBox.Show("Relmente Deseja Atualizar o cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                string conexaoBanco = "server=localhost;user id=root;database=db_clientes";
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    try
                    {
                        conexao.Open();
                        string delete = "UPDATE tb_clientes SET nome = @nome, sobrenome = @sobrenome, email = @email, idade = @idade WHERE id = @id"; // Linha de execussão de exclusão
                        MySqlCommand cmd = new MySqlCommand(delete, conexao); // criando um novo comando 
                        cmd.Parameters.AddWithValue("@id", idCliente); // Adicionando o valor do id para a variável temporaria
                        cmd.Parameters.AddWithValue("@nome", nomeCliente);
                        cmd.Parameters.AddWithValue("@sobrenome", sobreNomeCliente);
                        cmd.Parameters.AddWithValue("@email", emailCliente);
                        cmd.Parameters.AddWithValue("@idade", idadeCliente);
                        cmd.ExecuteNonQuery(); // execução do comando

                        conexao.Close(); // fechando o banco
                        fnListarClientes(); // instanciando a função para ser executada depois de deletar o cliente;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar cliente, erro de conexão de banco de dados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fnCarregarComboBox()
        {
            string conexaoBanco = "server=localhost;user id=root;database=db_clientes";
            using (MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conn.Open();
                    string script = "SELECT id, nome FROM tb_clientes";
                    MySqlCommand cmd = new MySqlCommand(script, conn);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    comboBoxNome.ValueMember = "id";
                    comboBoxNome.DisplayMember = "nome";
                    comboBoxNome.DataSource = tabela;


                    int id_nome = Convert.ToInt32(comboBoxNome.ValueMember);
                    string scriptSolo = "SELECT * FROM tb_clientes WHERE id = @id";
                    MySqlCommand cmdSolo = new MySqlCommand(scriptSolo, conn);
                    cmd.Parameters.AddWithValue("@id", id_nome);
                    MySqlDataAdapter adaptadorSolo = new MySqlDataAdapter(cmd);
                    DataTable tabelaSolo = new DataTable();
                    adaptador.Fill(tabelaSolo);

                    GridNomeSolo.DataSource = tabelaSolo;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridViewClienteSolo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string conexaoBanco()
        {
            string conexaoBanco = "server=localhost;user id=root;database=db_clientes";

            return conexaoBanco;
        }
    }
}
