using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
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



            labelMenssagem0.Text = "Dados do Cliente";
            labelMenssagem1.Text = $"Nome: {nome}";
            labelMenssagem2.Text = $"Sobrenome: {sobrenome}";
            labelMenssagem3.Text = $"Email: {email}";
            labelMenssagem4.Text = $"Idade: {idade}";
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
