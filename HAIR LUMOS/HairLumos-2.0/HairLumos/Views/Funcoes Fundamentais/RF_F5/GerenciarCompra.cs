using HairLumos.Controller;
using HairLumos.DAO;
using HairLumos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais
{
    public partial class GerenciarCompra : Form
    {
        private List<CompraProduto> lista; 

        public GerenciarCompra()
        {
            InitializeComponent();
            inicializa(false);
            lista = new List<CompraProduto>();
            //dgvGerenciarCompra.AutoGenerateColumns = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Views.Funcoes_Basicas.Pesquisas.Pesquisa_Fornecedor objPessoa = new Funcoes_Basicas.Pesquisas.Pesquisa_Fornecedor();

                objPessoa.ShowDialog();
                if (objPessoa.intCodigoPessoa > 0)
                {
                    Controller.PessoaController pessoaController = new Controller.PessoaController();
                    DataTable dtRetorno = pessoaController.retornaPessoaJuridicaCod(objPessoa.intCodigoPessoa);

                    if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                    {
                        DataRow dr = dtRetorno.Rows[0];
                        ttbFornecedor.Text = dr["jur_fantasia"].ToString();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            try
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

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void inicializa(Boolean estado)
        {
            ttbFornecedor.Enabled = estado;
            btnPesquisaFornecedor.Enabled = estado;
            ttbProduto.Enabled = estado;
            btnPesquisaProduto.Enabled = estado;
            rbSim.Checked = !estado;
            rbNao.Checked = estado;
            ttbQuantidade.Enabled = estado;
            dtpData.Enabled = estado;
            mskCusto.Enabled = estado;
            mskVenda.Enabled = estado;
            btnIncluirProduto.Enabled = estado;
            dgvGerenciarCompra.Enabled = estado;
            btnExcluirCompra.Enabled = estado;
            ttbObservacao.Enabled = estado;
            btnNovo.Enabled = !estado;
            btnGravar.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
            btnCancelar.Enabled = estado;
            btnGerarCompra.Enabled = estado;
            BtnGerarContaPagar.Enabled = estado;
        }

        private void limpaCampos()
        {
            ttbCodigo.Clear();
            ttbFornecedor.Clear();
            ttbProduto.Clear();
            rbSim.Checked = true;
            rbNao.Checked = false;
            ttbQuantidade.Clear();
            dtpData.Value = DateTime.Now;
            mskCusto.Clear();
            mskVenda.Clear();
            dgvGerenciarCompra.Rows.Clear();
            ttbObservacao.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            inicializa(false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            inicializa(true);
        }

        private void carregaDGV(List<CompraProduto> lista)
        {
            dgvGerenciarCompra.DataSource = lista;
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            ProdutoController pc = new ProdutoController();
            ProdutoDAO pd = new ProdutoDAO();
            DataTable dtproduto = pc.retornaProduto(ttbProduto.Text.Trim());
            DataRow dr = dtproduto.Rows[0];
            Produto p = new Produto();
            p.CodigoProduto = Convert.ToInt32(dr["codproduto"]);
            p.Custo = Convert.ToDouble(dr["prod_precocusto"]);
            p.NomeProduto = dr["prod_produto"].ToString();
            p.Venda = Convert.ToDouble(dr["prod_precovenda"]);
            p.Quantidade = Convert.ToInt32(dr["prod_qtde"]);
            p.Observacao = dr["prod_obs"].ToString();
            p.Marca = pd.retornaMarca(Convert.ToInt32(dr["codmarca"]));
            p.Categoria = pd.retornaCateria(Convert.ToInt32(dr["codcategoria"]));
            CompraProduto cp = new CompraProduto();
            cp.Produto = p;
            cp.Qtde = Convert.ToInt32(ttbQuantidade.Text);
            double custo = 0; 
            double.TryParse(mskVenda.Text, out custo);
            cp.Valor = custo;
            lista.Add(cp);
            carregaDGV(lista);
            ttbProduto.Clear();
            ttbQuantidade.Clear();
            mskCusto.Clear();
            mskVenda.Clear();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
