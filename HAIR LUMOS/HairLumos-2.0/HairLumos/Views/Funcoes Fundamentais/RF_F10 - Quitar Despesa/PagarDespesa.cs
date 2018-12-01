using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F10___Quitar_Despesa
{
    public partial class PagarDespesa : Form
    {
        
        private Controller.ContasPagarController cpc = new Controller.ContasPagarController();
        private List<Entidades.TabelaFormaPagamento> listapag = new List<Entidades.TabelaFormaPagamento>();
        private Entidades.ContasPagar cpagar = new Entidades.ContasPagar();

        public PagarDespesa()
        {
            InitializeComponent();
            dgvDespesas.AutoGenerateColumns = false;
        }

        public PagarDespesa(int codConta, int codParcela)
        {
            InitializeComponent();
            dgvDespesas.AutoGenerateColumns = false;
            dgvFormasPagamento.AutoGenerateColumns = false;
            carregaTela(codConta, codParcela);
            carregaCBB();
        }

        private void carregaDGV(List<Entidades.CompraProduto> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvDespesas.DataSource = bd;
            dgvDespesas.Refresh();
        }

        private void carregaDGVF(List<Entidades.TabelaFormaPagamento> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvFormasPagamento.DataSource = bd;
            dgvFormasPagamento.Refresh();
        }

        private void carregaTela(int cod, int parc)
        {
            Controller.DespesaController dc = new Controller.DespesaController();
            Controller.CompraController cc = new Controller.CompraController();
            Controller.PessoaController pc = new Controller.PessoaController();
            Controller.CaixaController cxc = new Controller.CaixaController();
            Controller.UsuarioController uc = new Controller.UsuarioController();
            Controller.PagamentoController pagc = new Controller.PagamentoController();
            Controller.ComissaoController comic = new Controller.ComissaoController();

            Entidades.Despesa desp = new Entidades.Despesa();
            Entidades.Compra compra = new Entidades.Compra();
            Entidades.Pessoa pes = new Entidades.Pessoa();
            Entidades.Caixa caixa = new Entidades.Caixa();
            Entidades.Usuario usuario = new Entidades.Usuario();
            Entidades.FormaPagamento formap = new Entidades.FormaPagamento();
            Entidades.Comissao comis = new Entidades.Comissao();
            Entidades.ContasPagar cp = new Entidades.ContasPagar();

            List<Entidades.CompraProduto> listaItens = new List<Entidades.CompraProduto>();

            ttbCodigo.Text = cod + "";
            DataTable dtGeral = cpc.retornaContaCodParc(cod,parc);
            if(dtGeral!=null && dtGeral.Rows.Count > 0)
            {
                DataRow drGeral = dtGeral.Rows[0];
                DataTable dtDespesa = dc.retornaObjDespesa(Convert.ToInt32(drGeral["coddespesa"].ToString()));
                if(dtDespesa!=null && dtDespesa.Rows.Count > 0)
                {
                    DataRow drDespesa = dtDespesa.Rows[0];
                    desp.Codigo = Convert.ToInt32(drDespesa["coddespesa"].ToString());
                    desp.Descricao = drDespesa["desp_descricao"].ToString();
                    desp.Status = drDespesa["desp_status"].ToString();
                    ttbDespesa.Text = desp.Descricao;
                }
                if(desp.Codigo == 2)
                {
                    listaItens = cc.retornaLista(Convert.ToInt32(drGeral["codcompra"].ToString()));
                }
                DataTable dtCompra = cc.retornaCompra(Convert.ToInt32(drGeral["codcompra"].ToString()));
                if(dtCompra!=null && dtCompra.Rows.Count > 0)
                {
                    DataRow drCompra = dtCompra.Rows[0];
                    compra.Despesa = desp;
                    compra.Codigo = Convert.ToInt32(drCompra["codcompra"].ToString());
                    compra.Data = Convert.ToDateTime(drCompra["comp_datacompra"].ToString());
                    compra.Situacao = drCompra["comp_situacao"].ToString();
                    compra.Lista = listaItens;
                    compra.Obs = drCompra["comp_obs"].ToString();
                    compra.ValorTotal = Convert.ToDouble(drCompra["comp_valortotal"].ToString());
                    DataTable dtPessoa = pc.retornaPessoaCod(drCompra["codpessoa"].ToString());
                    if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                    {
                        DataRow drPessoa = dtPessoa.Rows[0];
                        pes.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                        pes.Nome = drPessoa["pes_nome"].ToString();
                        pes.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                        pes.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                        pes.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                        pes.Observacao = drPessoa["pes_obs"].ToString();
                        pes.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                        pes.Email = drPessoa["pes_email"].ToString();
                        pes.Telefone = drPessoa["pes_fone"].ToString();
                        pes.Celular = drPessoa["pes_cel"].ToString();
                    }
                    compra.Pessoa = pes;
                }
                DataTable dtCaixa = cxc.retornacaixaAbetoDia();
                if(dtCaixa!=null && dtCaixa.Rows.Count > 0)
                {
                    DataRow drCaixa = dtCaixa.Rows[0];
                    caixa.CodCaixa = Convert.ToInt32(drCaixa["codcaixa"].ToString());
                    caixa.DataAbertura = Convert.ToDateTime(drCaixa["caixa_datahoraabertura"].ToString());
                    caixa.DataFechamento = Convert.ToDateTime(drCaixa["caixa_datahorafecha"].ToString());
                    caixa.SaldoInicial = Convert.ToDouble(drCaixa["caixa_saldoinicial"].ToString());
                    caixa.Troco = Convert.ToDouble(drCaixa["caixa_troco"].ToString());
                    caixa.TotalEntrada = Convert.ToDouble(drCaixa["caixa_totalentra"].ToString());
                    caixa.TotalSaida = Convert.ToDouble(drCaixa["caixa_totalsaida"].ToString());
                    DataTable dtUsuario = uc.retornaObjUsuario(Convert.ToInt32(drCaixa["codusuario"].ToString()));
                    if(dtUsuario!=null && dtUsuario.Rows.Count > 0)
                    {
                        DataRow drUsuario = dtUsuario.Rows[0];
                        usuario.UsuarioCodigo = Convert.ToInt32(drUsuario["codusuario"].ToString());
                        usuario.Login = drUsuario["usu_usuario"].ToString();
                        usuario.Senha = drUsuario["usu_senha"].ToString();
                        usuario.Nivel = Convert.ToInt32(drUsuario["usu_nivel"].ToString());
                        usuario.PessoaCod = Convert.ToInt32(drUsuario["codpessoa"].ToString());
                    }
                    caixa.Usuario = usuario;
                    Entidades.Pessoa p = new Entidades.Pessoa();
                    DataTable dtP = pc.retornaPessoaCod(drCaixa["codpessoa"].ToString());
                    if (dtP != null && dtP.Rows.Count > 0)
                    {
                        DataRow drPessoa = dtP.Rows[0];
                        p.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                        p.Nome = drPessoa["pes_nome"].ToString();
                        p.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                        p.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                        p.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                        p.Observacao = drPessoa["pes_obs"].ToString();
                        p.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                        p.Email = drPessoa["pes_email"].ToString();
                        p.Telefone = drPessoa["pes_fone"].ToString();
                        p.Celular = drPessoa["pes_cel"].ToString();
                    }
                    caixa.Pessoa = p;

                }
                DataTable dtForma = pagc.retornaObjFormaPagamento(Convert.ToInt32(drGeral["codformapag"].ToString()));
                if(dtForma!=null && dtForma.Rows.Count > 0)
                {
                    DataRow drForma = dtForma.Rows[0];
                    formap.Codigo = Convert.ToInt32(drForma["codformapag"].ToString());
                    formap.Forma = drForma["formpag_descricao"].ToString();
                }
                DataTable dtComissao = comic.retornaComissao(Convert.ToInt32(drGeral["codcomissao"].ToString()));
                if(dtComissao!=null && dtComissao.Rows.Count > 0)
                {
                    DataRow drComis = dtComissao.Rows[0];
                    comis.CodigoComissao = Convert.ToInt32(drComis["codcomissao"].ToString());
                    comis.DataPagamento = Convert.ToDateTime(drComis["comis_datapagamento"].ToString());
                    comis.ValorTotal = Convert.ToDouble(drComis["comis_valortotal"].ToString());
                    comis.ValorPago = Convert.ToDouble(drComis["comis_valorpago"].ToString());
                    comis.ValorDevolver = Convert.ToDouble(drComis["comis_valordevedor"].ToString());
                    comis.StatusComissao = drComis["comis_statuscomissao"].ToString();
                    comis.StatusPagamento = drComis["comis_statuspagamento"].ToString();
                }
                //carrega objeto
                cp.CodigoContasaPagar = cod;
                cp.DataVencimento = Convert.ToDateTime(drGeral["contpag_datavencimento"].ToString());
                cp.DataPagamento = Convert.ToDateTime(drGeral["contpag_datapagamento"].ToString());
                cp.ValorTotal = Convert.ToDouble(drGeral["contpag_valortotal"].ToString());
                cp.ValorPago = Convert.ToDouble(drGeral["contpag_valorpago"].ToString());
                cp.Observacao = drGeral["contpag_obs"].ToString();
                cp.Status = Convert.ToBoolean(drGeral["contpag_status"].ToString());
                cp.Parcela = Convert.ToInt32(drGeral["contpag_numparc"].ToString());
                cp.Compra = compra;
                cp.Despesa = desp;
                cp.Caixa = caixa;
                cp.FormaPagamento = formap;
                cp.Comissao = comis;
                cp.ValorParcela = Convert.ToDouble(drGeral["contPag_valorParcela"].ToString());
                cp.CodParcela = Convert.ToInt32(drGeral["contPag_Parcela"].ToString());
                this.cpagar = cp;
                mskTotal.Text = cp.ValorParcela+"";
                mskRestante.Text = cp.ValorParcela+"";
                mskSubtotal.Text = cp.ValorParcela + "";
                carregaDGV(listaItens);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mskAcrescimo_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(mskAcrescimo.Text.ToString()))
            {
                double acrescimo = Convert.ToDouble(mskAcrescimo.Text.ToString());
                double total = Convert.ToDouble(mskTotal.Text.ToString());
                total += acrescimo;
                mskTotal.Text = total + "";
            }
        }

        private void mskDesconto_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(mskDesconto.Text.ToString()))
            {
                double desconto = Convert.ToDouble(mskDesconto.Text.ToString());
                double total = Convert.ToDouble(mskTotal.Text.ToString());
                total -= desconto;
                mskTotal.Text = total + "";
            }
        }

        private void btnAdicionarPagamento_Click(object sender, EventArgs e)
        {
            Controller.PagamentoController pagc = new Controller.PagamentoController();
            Entidades.FormaPagamento forma = new Entidades.FormaPagamento();
            Entidades.TabelaFormaPagamento tforma = new Entidades.TabelaFormaPagamento();
            if(Convert.ToInt32(cbbForma.SelectedValue)>0 && !String.IsNullOrEmpty(mskValorPagar.Text.ToString())){
                DataTable dtForma = pagc.retornaObjFormaPagamento(Convert.ToInt32(cbbForma.SelectedValue));
                if(dtForma!=null && dtForma.Rows.Count > 0)
                {

                    DataRow drForma = dtForma.Rows[0];
                    forma.Codigo = Convert.ToInt32(drForma["codformapag"].ToString());
                    forma.Forma = drForma["formpag_descricao"].ToString();
                }
                tforma.Forma = forma;
                tforma.Valor = Convert.ToDouble(mskValorPagar.Text.ToString());
                listapag.Add(tforma);
                carregaDGVF(listapag);
                mskValorPagar.Text = "";
                double recebido = somaValor(listapag);
                mskRecebido.Text = recebido + "";
                double total = Convert.ToDouble(mskTotal.Text.ToString());
                if (total - recebido > 0)
                    mskRestante.Text = (total - recebido) + "";
                else
                {
                    mskRestante.Text = "0.00";
                    mskTroco.Text = (recebido - total) + "";
                }
            }
            
        }

        private double somaValor(List<Entidades.TabelaFormaPagamento> lista)
        {
            double valor = 0;
            for (int i = 0; i < lista.Count; i++)
                valor += lista.ElementAt(i).Valor;
            return valor;
        }

        private void carregaCBB()
        {
            Controller.PagamentoController pagc = new Controller.PagamentoController();
            DataTable dtForma = pagc.retornaFormaPagamento();
            cbbForma.DataSource = dtForma;
            cbbForma.ValueMember = "codformapag";
            cbbForma.DisplayMember = "formpag_descricao";
        }

        private void btnExcluirForma_Click(object sender, EventArgs e)
        {
            Controller.PagamentoController pagc = new Controller.PagamentoController();
            Entidades.FormaPagamento forma = new Entidades.FormaPagamento();
            Entidades.TabelaFormaPagamento tforma = new Entidades.TabelaFormaPagamento();
            if (dgvFormasPagamento.CurrentRow.Index > -1)
            {
                tforma = listapag.ElementAt(dgvFormasPagamento.CurrentRow.Index);
                listapag.Remove(listapag.ElementAt(dgvFormasPagamento.CurrentRow.Index));
                double recebido = somaValor(listapag);
                mskRecebido.Text = recebido + "";
                double total = Convert.ToDouble(mskTotal.Text.ToString());
                if (total - recebido > 0)
                {
                    mskRestante.Text = (total - recebido) + "";
                    mskTroco.Text = "0.00";
                }
                else
                {
                    mskRestante.Text = "0.00";
                    mskTroco.Text = (recebido - total) + "";
                }
            }
        }

        private void btnpAGAMENTOdESPESA_Click(object sender, EventArgs e)
        {
            Controller.ContasPagarController cpag = new Controller.ContasPagarController();
            if (!String.IsNullOrEmpty(mskRecebido.Text.ToString()))
            {
                double recebido = somaValor(listapag);
                double total = Convert.ToDouble(mskTotal.Text.ToString());
                if (recebido < total)
                {
                    this.cpagar.Status = false;
                    this.cpagar.ValorPago = recebido;
                }
                else
                {
                    this.cpagar.Status = true;
                    this.cpagar.ValorPago = total;
                }
                this.cpagar.DataPagamento = DateTime.Now;
                this.cpagar.FormaPagamento = listapag.ElementAt(0).Forma;
                int rest = cpag.pagaConta(this.cpagar);
                if (rest > 0)
                {
                    this.cpagar = new Entidades.ContasPagar();
                    listapag = new List<Entidades.TabelaFormaPagamento>();
                    limpatela();
                    MessageBox.Show("Conta paga com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao realizar pagamento!");
                }
                
            }

        }

        private void limpatela()
        {
            mskAcrescimo.Text = "0.00";
            mskDesconto.Text = "0.00";
            mskValorPagar.Text = "0.00";
            mskRecebido.Text = "0.00";
            mskRestante.Text = "0.00";
            mskTotal.Text = "0.00";
            mskTroco.Text = "0.00";
            mskSubtotal.Text = "0.00";
            dgvDespesas.Rows.Clear();
            dgvFormasPagamento.Rows.Clear();
        }
    }
}
