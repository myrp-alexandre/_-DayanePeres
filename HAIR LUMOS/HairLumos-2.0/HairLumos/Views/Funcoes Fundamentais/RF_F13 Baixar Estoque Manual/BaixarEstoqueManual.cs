using HairLumos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F13_Baixar_Estoque_Manual
{
    public partial class BaixarEstoqueManual : Form
    {
        List<Entidades.BaixaManual> lista = new List<Entidades.BaixaManual>();

        public BaixarEstoqueManual()
        {
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
            inicializa(false);
            btnExcluir.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        public void inicializa(Boolean estado)
        {
            ttbProduto.Enabled = estado;
            ttbQtde.Enabled = estado;
            dgvProdutos.Enabled = estado;
            btnCancelar.Enabled = estado;
            btnGravar.Enabled = estado;
            btnPesquisar.Enabled = estado;
            btnIncluir.Enabled = estado;
            btnExcluiBaixaProduto.Enabled = estado;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            inicializa(true);
        }

        public void limpatela()
        {
            ttbProduto.Text = "";
            ttbQtde.Text = "";
            dgvProdutos.DataSource = new List<Entidades.BaixaManual>();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpatela();
            inicializa(false);
            btnExcluir.Enabled = false;
        }

        private void carregaDGV(List<Entidades.BaixaManual> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvProdutos.DataSource = bd;
            dgvProdutos.Refresh();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ProdutoController pc = new ProdutoController();
            DataTable dt = pc.retornaProduto(ttbProduto.Text.ToString());
            Entidades.Produto prod = new Entidades.Produto();
            Entidades.BaixaManual baixa = new Entidades.BaixaManual();
            DataRow dr = dt.Rows[0];
            prod.CodigoProduto = Convert.ToInt32(dr["codproduto"].ToString());
            prod.NomeProduto = dr["prod_produto"].ToString();
            prod.Custo = Convert.ToDouble(dr["prod_precocusto"].ToString());
            prod.Venda = Convert.ToDouble(dr["prod_precovenda"].ToString());
            prod.Quantidade = Convert.ToInt32(dr["prod_qtde"].ToString());
            prod.Observacao = dr["prod_obs"].ToString();
            //prod.Categoria.Codigo = Convert.ToInt32(dr["codcategoria"].ToString());
            //prod.Marca.Codigo = Convert.ToInt32(dr["codmarca"].ToString());
            if (Convert.ToInt32(ttbQtde.Text.ToString()) > prod.Quantidade)
            {
                MessageBox.Show("Baixa maior que quantidade no estoque!");
                ttbQtde.Text = "";
            }
            else
            {
                baixa.Prod = prod;
                baixa.Qtde = Convert.ToInt32(ttbQtde.Text.ToString());
                baixa.Data = DateTime.Now;
                baixa.Obs = ttbObs.Text.ToString();
                if (verificaLista(lista, baixa) < 0)
                {
                    lista.Add(baixa);
                }
                else
                {
                    lista.ElementAt(verificaLista(lista, baixa)).Qtde += baixa.Qtde;
                }
                carregaDGV(lista);
                ttbProduto.Text = "";
                ttbQtde.Text = "";
            }
        }

        private int verificaLista(List<Entidades.BaixaManual> lista, Entidades.BaixaManual baixa)
        {
            int i = 0;
            bool teste = false;
            while (i < lista.Count && !teste)
            {
                if (lista.ElementAt(i).Prod.CodigoProduto != baixa.Prod.CodigoProduto)
                    i++;
                else
                {
                    teste = true;
                }
            }
            if (i < lista.Count)
                return i;
            else
                return -1;
        }

        private void btnExcluiBaixaProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.Rows.Count > 0)
            {
                lista.Remove(lista.ElementAt(dgvProdutos.CurrentRow.Index));
                carregaDGV(lista);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ProdutoController pc = new ProdutoController();
            int i, j = 0;
            for(i=0; i<lista.Count; i++)
            {
                lista.ElementAt(i).Prod.Quantidade -= lista.ElementAt(i).Qtde;
                int r = pc.gravaBaixaManual(lista.ElementAt(i));
                int p = pc.atualizaEstoque(lista.ElementAt(i).Prod);
                if (p > 0 && r > 0)
                    j++;
            }
            if (j < lista.Count)
            {
                MessageBox.Show("Erro ao atualizar estoque!");
            }
            else
            {
                MessageBox.Show("Estoque atualizado com sucesso!");
                limpatela();
                inicializa(false);
                lista = new List<Entidades.BaixaManual>();
                carregaDGV(lista);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            lista = new List<Entidades.BaixaManual>();
            carregaDGV(lista);
            btnExcluir.Enabled = true;
            try
            {
                Views.Funcoes_Fundamentais.RF_F13_Baixar_Estoque_Manual.Pesquisa_BaixaEstoque pesquisa_BaixaEstoque = new Pesquisa_BaixaEstoque();

                pesquisa_BaixaEstoque.ShowDialog();

                if (pesquisa_BaixaEstoque.intCodBaixa > 0)
                {
                    Controller.ProdutoController produtoController = new Controller.ProdutoController();
                    DataTable dtRetorno = produtoController.retornabaixaManual(pesquisa_BaixaEstoque.intCodBaixa);
                    Entidades.Produto produto;

                    if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                    {
                        DataRow dr = dtRetorno.Rows[0];

                        for (int i = 0; i < dtRetorno.Rows.Count; i++)
                        {
                            Entidades.BaixaManual baixaManual = new Entidades.BaixaManual();
                            produto = new Entidades.Produto();
                            DataRow drProd = dtRetorno.Rows[i];
                            produto.CodigoProduto = Convert.ToInt32(dr["CodProduto"].ToString());
                            produto.NomeProduto = dr["prod_produto"].ToString();
                            produto.Quantidade = Convert.ToInt32(dr["prod_qtde"].ToString());
                            baixaManual.Qtde = Convert.ToInt32(dr["baix_qtde"].ToString());
                            baixaManual.Data = Convert.ToDateTime(dr["baix_data"].ToString());
                            baixaManual.Prod = produto;
                            baixaManual.Codigo = Convert.ToInt32(dr["codbaixa"].ToString());
                            lista.Add(baixaManual);


                        }
                        carregaDGV(lista);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controller.ProdutoController pc = new ProdutoController();
            if (lista.Count > 0)
            {
                int i = 0;
                bool teste = false;
                while(i<lista.Count && !teste)
                {
                    Entidades.Produto p = new Entidades.Produto();
                    p = lista.ElementAt(i).Prod;
                    p.Quantidade += lista.ElementAt(i).Qtde;
                    int rest = pc.atualizaEstoque(p);
                    int res = pc.excluiBaixa(lista.ElementAt(i));
                    if (res > 0 && rest > 0)
                        i++;
                    else
                        teste = true;
                }
                if (i < lista.Count)
                {
                    MessageBox.Show("Erro ao excluir Baixa!");
                }
                else
                {
                    MessageBox.Show("Baixa excluida com sucesso");
                    lista = new List<Entidades.BaixaManual>();
                    carregaDGV(lista);
                    btnExcluir.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Selecione a baixa a Excluir!");
            }
        }
    }
}
