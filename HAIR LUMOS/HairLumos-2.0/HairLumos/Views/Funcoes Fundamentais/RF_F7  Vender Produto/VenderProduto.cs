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

        int codPessoa = 0;
        int qtdeProdEstoque = 0;

        bool statusFiado = false;

        public VenderProduto()
        {
            InitializeComponent();
            _inicializa();
            mskValorTotal.Enabled = false;
        }

        private void DGVMoeda()
        {
            this.dgvProdutos.Columns["Valor"].DefaultCellStyle.Format = "c";
            
        }

        public void _inicializa()
        {

            ttbProduto.Enabled = false;
            mskValor.Enabled = false;
            mskQtde.Enabled = false;
            dgvProdutos.Enabled = false;
            mskValorTotal.Enabled = false;

            btnPesquisar.Enabled = false;
            btnPesquisarProduto.Enabled = false;
            btnIncluir.Enabled = false;
            btnExcluirItem.Enabled = false;
            btnPesquisar.Enabled = false;
            btnPesquisarCliente.Enabled = false;
            btnCancelar.Enabled = false;
            btnFecharVenda.Enabled = false;
            btnSair.Enabled = false;

        }

        public void _btnNovo()
        {
            ttbProduto.Enabled = true;
            mskValor.Enabled = true;
            mskQtde.Enabled = true;
            dgvProdutos.Enabled = true;
            

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnPesquisarProduto.Enabled = true;
            btnPesquisarCliente.Enabled = true;
            btnIncluir.Enabled = true;
            btnExcluirItem.Enabled = true;
            btnPesquisar.Enabled = true;
            btnCancelar.Enabled = true;
            btnFecharVenda.Enabled = true;
            btnSair.Enabled = true;

            ttbCliente.Focus();

            _limpaCampos();
         
        }

        public void _limpaCampos()
        {
            ttbCliente.Text = "";
            mskTelefone.Text = "";
            ttbProduto.Text = "";
            mskValor.Text = "";
            mskQtde.Text = "";
            dgvProdutos.Rows.Clear();
            mskValorTotal.Text = "";
        }

        public void _btnCancelar()
        {
            _btnNovo();
            _limpaCampos();
            btnNovo.Enabled = true;
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa pesquisa_Pessoa = new Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa();

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
                    codPessoa = Pessoa.Codigo;
                    Pessoa.Nome = dr["pes_nome"].ToString();
                    mskTelefone.Text = dr["pes_fone"].ToString();
                    statusFiado = Convert.ToBoolean(dr["pes_fiado"].ToString());
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
                    qtdeProdEstoque = Convert.ToInt32(dr["prod_qtde"].ToString());

                    if(qtdeProdEstoque > 0)
                    {
                        ttbProduto.Text = dr["prod_produto"].ToString();
                        mskValor.Text = dr["prod_precovenda"].ToString();
                        prod.CodigoProduto = Convert.ToInt32(dr["codproduto"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Não há produto em estoque.");
                    }
                          
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            try
            {
                Entidades.VendaProduto vep = new Entidades.VendaProduto();
                Controller.ProdutoController produtoController = new Controller.ProdutoController();
                DataTable dtRetorno = produtoController.retornaProduto(prod.CodigoProduto);
                if (dtRetorno.Rows.Count > 0 && dtRetorno != null)
                {
                    
                    DataRow dr = dtRetorno.Rows[0];
                    prod.CodigoProduto = Convert.ToInt32(dr["codproduto"].ToString());
                    prod.NomeProduto = dr["prod_produto"].ToString();
                    prod.Venda = Convert.ToDouble(dr["prod_precoVenda"].ToString());
                    prod.Quantidade = Convert.ToInt32(dr["prod_qtde"].ToString());
                    vep.Produto = prod;
                    vep.Valor = prod.Venda;
                    prod = new Entidades.Produto();

                    double soma = 0;
                    double multValor = 0;
                    int qtdeProd = 0;

                    if (string.IsNullOrWhiteSpace(mskQtde.Text))
                    {
                        MessageBox.Show("Informe a quantidade do produto a ser vendida!");
                    }
                    else
                    {
                        qtdeProd = Convert.ToInt32(mskQtde.Text.ToString());
                        vep.Quantidade = qtdeProd;


                        if(qtdeProd <= qtdeProdEstoque)
                        {

                            insereLista(listVendaProduto, vep);
                            carregaDgv(listVendaProduto);
                            mskValorTotal.Text = somaValorTotal(listVendaProduto) + "";
                            mskValorTotal.Text = Convert.ToDouble(mskValorTotal.Text).ToString("###,###,##0.00");
                        }
                        else
                        {
                            MessageBox.Show("Não há quantidade desejada em estoque");
                        }

                    }
                    
                }
                ttbProduto.Text = "";
                mskValor.Text = "";
                mskQtde.Text = "";


            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void carregaDgv(List<Entidades.VendaProduto> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvProdutos.DataSource = bd;
            dgvProdutos.Refresh();
            DGVMoeda();
        }

        private void insereLista(List<Entidades.VendaProduto> lista, Entidades.VendaProduto vep)
        {
            int i = 0;
            bool achou = false;
            if (lista.Count > 0)
            {
                while (i < lista.Count && !achou)
                {
                    if (lista.ElementAt(i).Produto.CodigoProduto == vep.Produto.CodigoProduto)
                    {
                        lista.ElementAt(i).Quantidade += vep.Quantidade;
                        achou = true;
                        listVendaProduto = lista;
                    }
                    i++;
                }
                if (!achou)
                    listVendaProduto.Add(vep);
            }else
                listVendaProduto.Add(vep);

        }

        private double somaValorTotal(List<Entidades.VendaProduto> lista)
        {
            double total = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                total += (lista.ElementAt(i).Valor * lista.ElementAt(i).Quantidade);
            }

            return total;
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.SelectedRows.Count > 0)
            {
                listVendaProduto.RemoveAt(dgvProdutos.CurrentRow.Index);
                carregaDgv(listVendaProduto);

                mskValorTotal.Text = somaValorTotal(listVendaProduto)+"";
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharVenda_Click(object sender, EventArgs e)
        {

            try
            {
                Controller.VendaController vendaController = new Controller.VendaController();
            
                if (!String.IsNullOrWhiteSpace(ttbCliente.Text))
                {

                    if (listVendaProduto.Count > 0)
                    {
                        
                        int rest = vendaController.gravaVendaProduto(DateTime.Now, "", Convert.ToDouble(mskValorTotal.Text), "", codPessoa, listVendaProduto);

                        if(rest > 0)
                        {
                            MessageBox.Show("Venda Gravada com Sucesso!");

                            if(statusFiado == true)
                            {
                                DialogResult dialogResult = MessageBox.Show("Cliente habilitado para pagamento fiado. Deseja pagar no Fiado? ", "Aviso", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    Views.Funcoes_Fundamentais.RF_F8_Fechar_Atendimento.FecharAtendimento fecharAtendimento = new RF_F8_Fechar_Atendimento.FecharAtendimento();
                                    fecharAtendimento.ShowDialog();
                                    fecharAtendimento.quemChamou = "VendaProduto";
                                }
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Finalizar venda!");
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Insira Produto(s) para finalizar a venda.");
                    }

                }
                else
                {
                    MessageBox.Show("Informe o Cliente");
                }
            }
            catch (Exception)
            {

                throw;
            }
            

            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _btnCancelar();
        }

        private void mskValor_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskValor);
        }

        private void mskValor_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(mskValor.Text))
                mskValor.Text = Convert.ToDouble(mskValor.Text).ToString("###,###,##0.00");
        }

        private void mskValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskValor, e);
        }

        private void mskValorTotal_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskValorTotal);
        }

        private void mskValorTotal_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mskValorTotal.Text) && mskValorTotal.Equals("00,00"))
                mskValorTotal.Text = Convert.ToDouble(mskValorTotal.Text).ToString("###,###,##0.00");
        }

        private void mskValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskValorTotal, e);
        }
    }
}