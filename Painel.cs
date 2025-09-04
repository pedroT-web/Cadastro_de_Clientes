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
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void cad_cli_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();
            cadCli.Show();
        }

        private void consulta_cli_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCli = new ConsultaCliente();
            consultaCli.Show();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
