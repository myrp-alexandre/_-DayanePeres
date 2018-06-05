
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
            Views.Cadastro_FormaPagamento cadastro_FormaPagamento = new Views.Cadastro_FormaPagamento();
            cadastro_FormaPagamento.Show();
        }

        private void cadastroServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Servico cadastro_Servico = new Views.Cadastro_Servico();
            cadastro_Servico.Show();
        }

        private void cadastroPacoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Pacotes cadastro_Pacotes = new Views.Cadastro_Pacotes();
            cadastro_Pacotes.Show();
        }

        private void parametrizaçãoDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Parametro_Sistema parametro_Sistema = new Views.Parametro_Sistema();
            parametro_Sistema.Show();
        }
    }
}
