using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultPedidos
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cad2 = new CadastroCliente();
            cad2.Show();
        }

        private void buttonTelaInicialPesquisarCliente_Click(object sender, EventArgs e)
        {
            CadastroClientePesquisar cad = new CadastroClientePesquisar();
            cad.Show();
        }

        private void btnTelaInicialCadastroProduto_Click(object sender, EventArgs e)
        {
            CadastroProdutos cad3 = new CadastroProdutos();
            cad3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Configure the OpenFileDialog properties
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileDialog1.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
