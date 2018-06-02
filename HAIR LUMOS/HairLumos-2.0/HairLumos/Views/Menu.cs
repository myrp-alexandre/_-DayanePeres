
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cadastroCategoriaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_CategoriaProduto CategoProd = new Views.Cadastro_CategoriaProduto();
            CategoProd.Show();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroMarcaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_MarcaProduto cadastro_MarcaProduto = new Views.Cadastro_MarcaProduto();
            cadastro_MarcaProduto.Show();
        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Produto cadastro_Produto = new Views.Cadastro_Produto();
            cadastro_Produto.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastrodePessoa_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Pessoa cadastro_Pessoa = new Views.Cadastro_Pessoa();
            cadastro_Pessoa.Show();
        }

        private void cadastroDeFormaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
