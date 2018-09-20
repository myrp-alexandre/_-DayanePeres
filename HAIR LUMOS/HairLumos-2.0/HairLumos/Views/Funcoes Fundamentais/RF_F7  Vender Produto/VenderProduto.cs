using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F7_Vender_Produto
{
    public partial class VenderProduto : Form
    {
        Entidades.Pessoa Pessoa = new Entidades.Pessoa();
        List<Entidades.VendaProduto> listVendaProduto = new List<Entidades.VendaProduto>();
        Entidades.Produto prod = new Entidades.Produto();

        public VenderProduto()
        {
            InitializeComponent();
            ttbCliente.Enabled = false;
            mskTelefone.Enabled = false;
            mskValor.Enabled = false;
            mskValorTotal.Enabled = false;
            ttbProduto.Enabled = false;
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            Views.Pesquisa_Pessoa pesquisa_Pessoa = new Pesquisa_Pessoa();

            pesquisa_Pessoa.ShowDialog();
            if (pesquisa_Pessoa.intCodigoPessoa > 0)
            {
                Controller.PessoaController pessoaController = new Controller.PessoaController();
                DataTable dtRetorno = pessoaController.retornaPessoaCod(pesquisa_Pessoa.intCodigoPessoa.ToString());

                if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                {

                    DataRow dr = dtRetorno.Rows[0];
                    ttbCliente.Text = dr["pes_nome"].ToString();
                    Pessoa.Codigo = Convert.ToInt32(dr["codpessoa"].ToString());
                    Pessoa.Nome = dr["pes_nome"].ToString();

                    DataTable dtContato = pessoaController.retornaContato(Pessoa.Codigo);

                    if (dtContato != null && dtContato.Rows.Count > 0)
                    {
                        DataRow drContato = dtContato.Rows[0];
                        mskTelefone.Text = drContato["cont_telefone"].ToString();
                    }


                }
            }


        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Basicas.Pesquisas.Pesquisa_Produto objProduto = new Funcoes_Basicas.Pesquisas.Pesquisa_Produto();

            objProduto.ShowDialog();
            if (objProduto.codProduto > 0)
            {
                Controller.ProdutoController produtoController = new Controller.ProdutoController();
                DataTable dtRetorno = produtoController.retornaProduto(objProduto.codProduto);

                if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                {
                    DataRow dr = dtRetorno.Rows[0];
                    ttbProduto.Text = dr["prod_produto"].ToString();
                    mskValor.Text = dr["prod_precovenda"].ToString();
                    prod.CodigoProduto = Convert.ToInt32(dr["codproduto"].ToString());

                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Entidades.VendaProduto vep = new Entidades.VendaProduto();
            Controller.ProdutoController produtoController = new Controller.ProdutoController();
            DataTable dtRetorno = produtoController.retornaProduto(prod.CodigoProduto);
            if(dtRetorno.Rows.Count>0 && dtRetorno != null)
            {
                DataRow dr = dtRetorno.Rows[0];
                prod.CodigoProduto = Convert.ToInt32(dr["codproduto"].ToString());
                prod.NomeProduto = dr["prod_produto"].ToString();
                prod.Venda = Convert.ToDouble(dr["prod_precoVenda"].ToString());
                vep.Produto = prod;
                vep.Valor = prod.Venda;
                prod = new Entidades.Produto();
            }

            vep.Quantidade = Convert.ToInt32(mskQtde.Text.ToString());
            insereLista(listVendaProduto, vep);
            carregaDgv(listVendaProduto);
            ttbProduto.Text = "";
            mskValor.Text = "";
            mskQtde.Text = "";
        }

        private void carregaDgv(List<Entidades.VendaProduto> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvProdutos.DataSource = bd;
            dgvProdutos.Refresh();
        }

        private void insereLista(List<Entidades.VendaProduto> lista, Entidades.VendaProduto vep)
        {
            int i = 0;
            bool achou = false;
            while(i< lista.Count && !achou)
            {
                if (lista.ElementAt(i).Produto.CodigoProduto == vep.Produto.CodigoProduto)
                {
                    lista.ElementAt(i).Quantidade += vep.Quantidade;
                    achou = true;
                    listVendaProduto = lista;
                }
            }
            if (!achou)
                listVendaProduto.Add(vep);

        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.SelectedRows.Count > 0)
            {
                listVendaProduto.RemoveAt(dgvProdutos.CurrentRow.Index);
                carregaDgv(listVendaProduto);
            }
        }
    }
}
