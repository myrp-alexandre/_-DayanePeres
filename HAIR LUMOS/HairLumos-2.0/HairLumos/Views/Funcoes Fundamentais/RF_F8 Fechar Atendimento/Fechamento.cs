using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F8_Fechar_Atendimento
{
    public partial class Fechamento : Form
    {

        private List<Entidades.VendaProduto> listaProdutos = new List<Entidades.VendaProduto>();
        private List<Entidades.Agenda> listaAgenda = new List<Entidades.Agenda>();
        List<Entidades.Venda> listaVendas = new List<Entidades.Venda>();
        private int cod;
        private Entidades.Pessoa pes = new Entidades.Pessoa();

        public Fechamento()
        {
            InitializeComponent();
            dgvListaProdutos.AutoGenerateColumns = false;
            dgvListaServicos.AutoGenerateColumns = false;
        }

        public Fechamento(int codV)
        {
            InitializeComponent();
            dgvListaProdutos.AutoGenerateColumns = false;
            dgvListaServicos.AutoGenerateColumns = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mskTotalServico_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            cod = 0;
            Views.Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa pesquisa = new Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa();
            pesquisa.ShowDialog();

            cod = pesquisa.intCodigoPessoa;
            if (cod > 0)
            {
                carregaTela(cod);
            }

        }

        private void carregaTela(int codPessoa)
        {
            Controller.PessoaController pc = new Controller.PessoaController();
            Controller.VendaController vc = new Controller.VendaController();
            Controller.ProdutoController prc = new Controller.ProdutoController();
            Controller.AgendaController agc = new Controller.AgendaController();

            Entidades.Pessoa pessoa = new Entidades.Pessoa();
            Entidades.Venda venda = new Entidades.Venda();
            Entidades.VendaProduto vp = new Entidades.VendaProduto();
            Entidades.Produto prod = new Entidades.Produto();
            Entidades.Categoria cat = new Entidades.Categoria();
            Entidades.Marca mar = new Entidades.Marca();

            
            List<Entidades.VendaProduto> listaItensVenda = new List<Entidades.VendaProduto>();
            listaVendas = new List<Entidades.Venda>();
            DataTable dtPessoa = new DataTable();
            dtPessoa = pc.retornaPessoaCod(codPessoa + "");
            if(dtPessoa!=null && dtPessoa.Rows.Count > 0)
            {
                DataRow drPessoa = dtPessoa.Rows[0];
                pessoa.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                pessoa.Nome = drPessoa["pes_nome"].ToString();
                pessoa.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                pessoa.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                pessoa.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                pessoa.Observacao = drPessoa["pes_obs"].ToString();
                pessoa.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                pessoa.Email = drPessoa["pes_email"].ToString();
                pessoa.Telefone = drPessoa["pes_fone"].ToString();
                pessoa.Celular = drPessoa["pes_cel"].ToString();
                pes = pessoa;
                ttbCliente.Text = pessoa.Nome;
            }
            //procuro todas as venda abertas do cliente
            DataTable dtVenda = new DataTable();
            dtVenda = vc.retornaVendaPessoa(codPessoa);
            if(dtVenda!=null && dtVenda.Rows.Count > 0)
            {
                for(int i=0; i<dtVenda.Rows.Count; i++)
                {
                    DataRow drVenda = dtVenda.Rows[i];
                    venda = new Entidades.Venda();
                    venda.Codigo = Convert.ToInt32(drVenda["codvenda"].ToString());
                    venda.Data = Convert.ToDateTime(drVenda["vend_datavenda"].ToString());
                    venda.Situacao = drVenda["vend_situacao"].ToString();
                    venda.ValorTotal = Convert.ToDouble(drVenda["vend_valortotal"].ToString());
                    venda.Observacao = drVenda["vend_obs"].ToString();
                    venda.Pessoa = pessoa;

                    DataTable dtItens = vc.retornaProdutos(venda.Codigo);
                    if(dtItens!=null && dtItens.Rows.Count > 0)
                    {
                        for(int k =0; k<dtItens.Rows.Count; k++)
                        {
                            DataRow drItens = dtItens.Rows[i];
                            vp = new Entidades.VendaProduto();
                            vp.Quantidade = Convert.ToInt32(drItens["vendprod_qtde"].ToString());
                            vp.Valor = Convert.ToDouble(drItens["vendprod_valor"].ToString());
                            DataTable dtProduto = new DataTable();
                            dtProduto = prc.retornaProduto(Convert.ToInt32(drItens["codproduto"].ToString()));
                            if(dtProduto!=null && dtProduto.Rows.Count > 0)
                            {
                                DataRow drProduto = dtProduto.Rows[0];
                                prod = new Entidades.Produto();
                                cat = new Entidades.Categoria();
                                mar = new Entidades.Marca();
                                prod.CodigoProduto = Convert.ToInt32(drProduto["codproduto"].ToString());
                                prod.NomeProduto = drProduto["prod_produto"].ToString();
                                prod.Custo = Convert.ToDouble(drProduto["prod_precocusto"].ToString());
                                prod.Venda = Convert.ToDouble(drProduto["prod_precovenda"].ToString());
                                prod.Quantidade = Convert.ToInt32(drProduto["prod_qtde"].ToString());
                                prod.Observacao = drProduto["prod_obs"].ToString();
                                cat.Codigo = Convert.ToInt32(drProduto["codcategoria"].ToString());
                                mar.Codigo = Convert.ToInt32(drProduto["codmarca"].ToString());
                                prod.Marca = mar;
                                prod.Categoria = cat;
                            }
                            vp.Produto = prod;
                            listaItensVenda.Add(vp);
                        }
                    }
                    venda.ListavendaProdutos = listaItensVenda;
                    listaVendas.Add(venda);
                }
            }

            DataTable dtServicos = agc.retornaServicosCliente(codPessoa);
            if (dtServicos != null && dtServicos.Rows.Count > 0)
            {
                convertLista(dtServicos);
                carregaGridServico(dtServicos);
            }

            for (int i =0; i<listaVendas.Count; i++)
            {
                for(int j=0; j<listaVendas.ElementAt(i).ListavendaProdutos.Count; j++)
                {
                    listaProdutos.Add(listaVendas.ElementAt(i).ListavendaProdutos.ElementAt(j));
                }
            }
            carregaDGVProduto();
            mskTotalProduto.Text = somaValor() + "";
            mskTotalServico.Text = somaSubtotal(dtServicos) + "";
            mskTotalGeral.Text = somaSubtotal(dtServicos) + somaValor() + "";
            mskTotalProduto.Text = Convert.ToDouble(mskTotalProduto.Text).ToString("###,###,##0.00");
            mskTotalServico.Text = Convert.ToDouble(mskTotalServico.Text).ToString("###,###,##0.00");
            mskTotalGeral.Text = Convert.ToDouble(mskTotalGeral.Text).ToString("###,###,##0.00");
        }

        private double somaSubtotal(DataTable dtServico)
        {
            double total = 0;
            for (int i = 0; i < dtServico.Rows.Count; i++)
            {
                DataRow dr = dtServico.Rows[i];
                total += Convert.ToDouble(dr["agen_valor"].ToString());
            }
            return total;
        }

        private void convertLista(DataTable dtServicos)
        {
            listaAgenda = new List<Entidades.Agenda>();
            for (int i = 0; i < dtServicos.Rows.Count; i++)
            {
                Entidades.Agenda a = new Entidades.Agenda();
                DataRow drAgenda = dtServicos.Rows[i];
                a.Codigo = Convert.ToInt32(drAgenda["codagenda"].ToString());
                a.Status = drAgenda["agen_status"].ToString();
                listaAgenda.Add(a);
            }
        }


        private void carregaGridServico(DataTable dt)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = dt;
            dgvListaServicos.DataSource = bd;
            dgvListaServicos.Refresh();
            //DGVMoeda();
        }

        private void carregaDGVProduto()
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = listaProdutos;
            dgvListaProdutos.DataSource = bd;
            dgvListaProdutos.Refresh();
        }

        private double somaValor()
        {
            double total = 0;
            for(int i = 0; i<listaProdutos.Count; i++)
            {
                total += listaProdutos.ElementAt(i).Quantidade * listaProdutos.ElementAt(i).Valor;
            }
            return total;
        }

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            if (dgvListaServicos.CurrentRow.Index > -1)
            {
                listaAgenda.RemoveAt(dgvListaServicos.CurrentRow.Index);
                double valor = Convert.ToDouble(dgvListaServicos.Rows[dgvListaServicos.CurrentRow.Index].Cells[1].Value);
                double sub = Convert.ToDouble(mskTotalServico.Text.ToString());
                double tot = Convert.ToDouble(mskTotalGeral.Text.ToString());
                dgvListaServicos.Rows.RemoveAt(dgvListaServicos.CurrentRow.Index);
                mskTotalServico.Text = (sub - valor) + "";
                mskTotalServico.Text = Convert.ToDouble(mskTotalServico.Text).ToString("###,###,##0.00");

                mskTotalGeral.Text = (tot - valor) + "";
                mskTotalGeral.Text = Convert.ToDouble(mskTotalGeral.Text).ToString("###,###,##0.00");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ttbCliente.Text = "";
            listaProdutos = new List<Entidades.VendaProduto>();
            carregaDGVProduto();
            DataTable dtServico = new DataTable();
            carregaGridServico(dtServico);
            mskTotalGeral.Text = "0.00";
            mskTotalProduto.Text = "0.00";
            mskTotalServico.Text = "0.00";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Controller.FechamentoController fec = new Controller.FechamentoController();
            Controller.AgendaController ac = new Controller.AgendaController();
            Controller.VendaController vc = new Controller.VendaController();
            //criar fechamento, atribuir nas vendas e agendamentos
            if(!String.IsNullOrEmpty(ttbCliente.Text) && !String.IsNullOrEmpty(mskTotalGeral.Text))
            {
                double total = Convert.ToDouble(mskTotalGeral.Text.ToString());
                int res = fec.gravarFechamento(pes, total);
                if (res > 0)
                {
                    int i = 0;
                    bool teste = false;
                    while(i<listaAgenda.Count && !teste)
                    {
                        Entidades.Fechamento fechamento = new Entidades.Fechamento();
                        fechamento.Codigo = res;
                        listaAgenda.ElementAt(i).Fechamento = fechamento;
                        int p = ac.atualizaFechamento(listaAgenda.ElementAt(i));
                        if (p > 0)
                            i++;
                        else
                            teste = true;
                    }
                    if (i < listaAgenda.Count)
                    {
                        MessageBox.Show("Erro ao atualizar agenda!");
                    }
                    else
                    {
                        int k = 0;
                        bool resp = false;
                        while (k < listaVendas.Count && !resp)
                        {
                            int t = vc.atualizaFechamento(listaVendas.ElementAt(k).Codigo, res);
                            if (t > 0)
                                k++;
                            else
                                teste = true;
                        }
                        if (k < listaVendas.Count)
                        {
                            MessageBox.Show("Erro ao atualizar venda!");
                        }
                        else
                        {
                            Views.Funcoes_Fundamentais.RF_F11_Quitar_Contas_a_Receber.GerarContasReceber gerar = new RF_F11_Quitar_Contas_a_Receber.GerarContasReceber(res, total, "fechamento", pes);
                            gerar.ShowDialog();
                        }
                            
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao gravar fechamento!");
                }
            }
        }
    }
}
