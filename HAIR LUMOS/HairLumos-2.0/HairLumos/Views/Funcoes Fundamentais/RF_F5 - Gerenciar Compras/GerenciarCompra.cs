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
        private CompraController cc = new CompraController();
        

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
                        ttbFornecedor.Text = dr["jur_razaosocial"].ToString();

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
            
            btnLocalizar.Enabled = estado;
            btnExcluir.Enabled = estado;
            btnCancelar.Enabled = estado;
            btnGerarCompra.Enabled = estado;
            
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
            lista = new List<CompraProduto>();
            dgvGerenciarCompra.DataSource = lista;
            ttbObservacao.Clear();
            totalCompra.Text = "0,00";
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
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvGerenciarCompra.DataSource = bd;
            dgvGerenciarCompra.Refresh();
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
            double.TryParse(mskCusto.Text, out custo);
            cp.Valor = custo;
            int v = verificaLista(lista, cp);
            if (v >= 0)
            {
                lista.ElementAt(v).Qtde += cp.Qtde;
            }
            else
            {
                lista.Add(cp);
            }
            carregaDGV(lista);
            somavalor();
            ttbProduto.Clear();
            ttbQuantidade.Clear();
            mskCusto.Clear();
            mskVenda.Clear();
        }

        private int verificaLista(List<CompraProduto> lista, CompraProduto cp) 
        {
            for(int i = 0; i<lista.Count; i++)
            {
                if (lista.ElementAt(i).Produto.CodigoProduto == cp.Produto.CodigoProduto)
                    return i;
            }
            return -1;
        }

        private void somavalor()
        {
            double total = 0;
            for (int i = 0; i < lista.Count; i++)
                total += lista.ElementAt(i).Qtde * lista.ElementAt(i).Valor;

            totalCompra.Text = (total.ToString());

        }

        private void btnExcluirCompra_Click(object sender, EventArgs e)
        {
            if (dgvGerenciarCompra.Rows.Count > 0)
            {
                lista.Remove(lista.ElementAt(dgvGerenciarCompra.CurrentRow.Index));
                carregaDGV(lista);
                somavalor();
            }
        }

        private void btnGerarCompra_Click(object sender, EventArgs e)
        {
            int codigo = 0, despesa = 0, codPessoa = 0;
            bool consignado = false;
            double valorTotal = 0;
            //verifica se tem codigo
            if(ttbCodigo.Text!=null && ttbCodigo.Text != "")
            {
                codigo = Convert.ToInt32(ttbCodigo.Text.ToString());
            }
            //busca despesa compra
            Controller.DespesaController _ctrlDespesa = new Controller.DespesaController();
            DataTable dtRetorno = _ctrlDespesa.retornaObjDespesa("Compra");
            if (dtRetorno != null && dtRetorno.Rows.Count>0)
            {
                DataRow dr = dtRetorno.Rows[0];
                despesa = Convert.ToInt32(dr["coddespesa"].ToString());
            }
            //retorna pessoa pelo nome
            Controller.PessoaController pc = new PessoaController();
            DataTable dtPessoa = pc.retornaPessoa(ttbFornecedor.Text.ToString());
            if(dtPessoa!=null && dtPessoa.Rows.Count > 0)
            {
                DataRow drPessoa = dtPessoa.Rows[0];
                codPessoa = Convert.ToInt32(drPessoa["codpessoa"].ToString());
            }
            //verifica consignado
            if (rbSim.Checked)
                consignado = true;
            else
                consignado = false;
            //convert o valor total
            valorTotal = Convert.ToDouble(totalCompra.Text.ToString());

            //chama o gravar
            int rest = cc.geravaCompra(codigo, despesa, DateTime.Now, "aberta", consignado, valorTotal, ttbObservacao.Text.ToString(), codPessoa, lista);


            if (rest > 0)
            {
                MessageBox.Show("Gravado com sucesso!");

                DialogResult result = MessageBox.Show("Gerar Contas a Pagar", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Views.Funcoes_Fundamentais.RF_F5.GerarContaPagar gerarContaPagar = new RF_F5.GerarContaPagar();
                    gerarContaPagar.ShowDialog();
                }
                

                limpaCampos();
                inicializa(false);
            }
            else
            {
                MessageBox.Show("Erro ao gravar dados. Falta cadastrar Despesa Tipo: Compra");
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Views.Funcoes_Fundamentais.RF_F5___Gerenciar_Compras.PesquisarCompras objCompras = new RF_F5___Gerenciar_Compras.PesquisarCompras();
                objCompras.ShowDialog();
                if (objCompras.codCompra > 0)
                {
                    DataTable dtRetorno = cc.retornaCompra(objCompras.codCompra);

                    if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                    {
                        DataRow dr = dtRetorno.Rows[0];
                        ttbCodigo.Text = dr["codcompra"].ToString();
                        // adciona pessoa na tela
                        PessoaController pc = new PessoaController();
                        DataTable dtPessoa = pc.retornaPessoaCod(dr["codpessoa"].ToString());
                        if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                        {
                            DataRow drPessoa = dtPessoa.Rows[0];
                            ttbFornecedor.Text = drPessoa["pes_nome"].ToString();
                        }
                        lista = cc.retornaLista(Convert.ToInt32(dr["codcompra"].ToString()));
                        carregaDGV(lista);
                        somavalor();

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
            int codigo = 0;
            if(ttbCodigo.Text!=null && ttbCodigo.Text != "")
            {
                codigo = Convert.ToInt32(ttbCodigo.Text.ToString());
                int result = cc.excluirCompra(codigo);
                if(result > 0)
                {
                    MessageBox.Show("Excluido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir!");
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGerarContaPagar_Click(object sender, EventArgs e)
        {

        }
    }
}
