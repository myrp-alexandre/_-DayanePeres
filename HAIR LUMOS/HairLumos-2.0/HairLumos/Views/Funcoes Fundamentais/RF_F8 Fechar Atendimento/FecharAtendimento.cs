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
    public partial class FecharAtendimento : Form
    {
        //private List<Entidades.TabelaVendaProduto> listaVendaProduto;
        //private List<Entidades.Venda> listaVenda;
        //private List<Entidades.Produto> listaProduto;
        private List<Entidades.TabelaFormaPagamento> listapag = new List<Entidades.TabelaFormaPagamento>();
        private List<Entidades.Parcela> listaparcela = new List<Entidades.Parcela>();
        private List<Entidades.Agenda> listaAgenda = new List<Entidades.Agenda>();
        public int codConta = 0;
        public int codVenda = 0;
        public int codFechamento = 0;
        private Entidades.Parcela parct = new Entidades.Parcela();

        public string quemChamou { get; set; }

        public FecharAtendimento()
        {
            InitializeComponent();
            pesquisaVendaProduto();
            CarregaFormasPagamento();
        }

        public FecharAtendimento(int codC, int codP)
        {
            InitializeComponent();
            dgvformasPagamento.AutoGenerateColumns = false;
            CarregaFormasPagamento();
            carregaTela(codC, codP);
            this.codConta = codC;
        }

        private void carregaTela(int codD, int codP)
        {
            Controller.ContasReceberController crc = new Controller.ContasReceberController();
            Controller.PessoaController pc = new Controller.PessoaController();
            Controller.VendaController vc = new Controller.VendaController();
            Controller.ComissaoController cmc = new Controller.ComissaoController();
            Controller.PacoteController pacc = new Controller.PacoteController();
            Controller.AgendaController agc = new Controller.AgendaController();

            Entidades.ContasReceber cr = new Entidades.ContasReceber();
            Entidades.Pessoa _pessoa = new Entidades.Pessoa();
            Entidades.Caixa cx = new Entidades.Caixa();
            Entidades.Parcela parc = new Entidades.Parcela();
            Entidades.FormaPagamento forma = new Entidades.FormaPagamento();
            Entidades.Venda venda = new Entidades.Venda();
            Entidades.Comissao cm = new Entidades.Comissao();
            Entidades.Contrato ct = new Entidades.Contrato();
            Entidades.Usuario _usuario = new Entidades.Usuario();

            DataTable dtContaRec = crc.retornaContasCod(codD);
            if(dtContaRec!=null && dtContaRec.Rows.Count > 0)
            {
                DataRow drContasRec = dtContaRec.Rows[0];
                cr.Codigo = Convert.ToInt32(drContasRec["codcontareceber"].ToString());
                cr.DtVencimento = Convert.ToDateTime(drContasRec["contrec_datavencimento"].ToString());
                cr.ValorTotal = Convert.ToDouble(drContasRec["contrec_valortotal"].ToString());
                cr.Obs = drContasRec["contrec_obs"].ToString();
                cr.CodigoFechamento = Convert.ToInt32(drContasRec["codfiado"].ToString());

                DataTable dtPessoa = pc.retornaPessoaCod(drContasRec["codpessoa"].ToString());
                if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                {
                    DataRow drPessoa = dtPessoa.Rows[0];
                    _pessoa.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                    _pessoa.Nome = drPessoa["pes_nome"].ToString();
                    _pessoa.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                    _pessoa.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                    _pessoa.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                    _pessoa.Observacao = drPessoa["pes_obs"].ToString();
                    _pessoa.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                    _pessoa.Email = drPessoa["pes_email"].ToString();
                    _pessoa.Telefone = drPessoa["pes_fone"].ToString();
                    _pessoa.Celular = drPessoa["pes_cel"].ToString();
                }
                cr.Pessoaf = _pessoa;
                ttbCliente.Text = _pessoa.Nome;
                
                DataTable dtVenda = vc.retornaVendaCod(Convert.ToInt32(drContasRec["codvenda"].ToString()));
                if(dtVenda!=null && dtVenda.Rows.Count > 0)
                {
                    DataRow drVenda = dtVenda.Rows[0];
                    venda.Codigo = Convert.ToInt32(drVenda["codvenda"].ToString());
                    venda.Data = Convert.ToDateTime(drVenda["vend_datavenda"].ToString());
                    venda.Situacao = drVenda["vend_situacao"].ToString();
                    venda.ValorTotal = Convert.ToDouble(drVenda["vend_valortotal"].ToString());
                    venda.Observacao = drVenda["vend_obs"].ToString();
                    venda.CodigoFechamento = Convert.ToInt32(drVenda["codfechamento"].ToString());
                    venda.Pessoa = _pessoa;
                    this.codVenda = venda.Codigo;
                    this.codFechamento = venda.CodigoFechamento;
                }
                cr.Venda = venda;
                DataTable dtProdutosVenda = vc.retornaProdutos(venda.Codigo);
                // carregaGridProduto(dtProdutosVenda);

                DataTable dtComissao = cmc.retornaComissao(Convert.ToInt32(drContasRec["codcomissao"].ToString()));
                if(dtComissao!=null && dtComissao.Rows.Count > 0)
                {
                    DataRow drComissao = dtComissao.Rows[0];
                    cm.CodigoComissao = Convert.ToInt32(drComissao["codcomissao"].ToString());
                    cm.DataPagamento = Convert.ToDateTime(drComissao["comis_datapagamento"].ToString());
                    cm.ValorTotal = Convert.ToDouble(drComissao["comis_valortotal"].ToString());
                    cm.ValorPago = Convert.ToDouble(drComissao["comis_valorpago"].ToString());
                    cm.ValorDevolver = Convert.ToDouble(drComissao["comis_valordevedor"].ToString());
                    cm.StatusComissao = drComissao["comis_statuscomissao"].ToString();
                    cm.StatusPagamento = drComissao["comis_statuspagamento"].ToString();
                }
                cr.Comissao = cm;
                cr.Contrato = ct;
                List<Entidades.Parcela> lista = new List<Entidades.Parcela>();
                DataTable dtParcela = crc.retornaParcelaContaReceber(codD, codP);
                if (dtParcela != null && dtParcela.Rows.Count > 0)
                {
                    DataRow drParcela = dtParcela.Rows[0];
                    parc.Codigo = codP;
                    parc.DataPagamento = Convert.ToDateTime(drParcela["parc_datapagamento"].ToString());
                    parc.DataVencimento = Convert.ToDateTime(drParcela["parc_datavencimento"].ToString());
                    parc.ValorPago = Convert.ToDouble(drParcela["parc_valorpago"].ToString());
                    parc.ValorReceber = Convert.ToDouble(drParcela["parc_valor"].ToString());

                    DataTable dtCaixa = new Controller.CaixaController().retornacaixaAbetoDia();
                    if (dtCaixa != null && dtCaixa.Rows.Count > 0)
                    {
                        DataRow drCaixa = dtCaixa.Rows[0];
                        cx.CodCaixa = Convert.ToInt32(drCaixa["codcaixa"].ToString());
                        cx.DataAbertura = Convert.ToDateTime(drCaixa["caixa_datahoraabertura"].ToString());
                        cx.DataFechamento = Convert.ToDateTime(drCaixa["caixa_datahorafecha"].ToString());
                        cx.SaldoInicial = Convert.ToDouble(drCaixa["caixa_saldoinicial"].ToString());
                        cx.Troco = Convert.ToDouble(drCaixa["caixa_troco"].ToString());
                        cx.TotalEntrada = Convert.ToDouble(drCaixa["caixa_totalentra"].ToString());
                        cx.TotalSaida = Convert.ToDouble(drCaixa["caixa_totalsaida"].ToString());
                        DataTable dtP = new Controller.PessoaController().retornaPessoaCod(drCaixa["codpessoa"].ToString());
                        if (dtP != null && dtP.Rows.Count > 0)
                        {
                            _pessoa = new Entidades.Pessoa();
                            DataRow drPessoa = dtPessoa.Rows[0];
                            _pessoa.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                            _pessoa.Nome = drPessoa["pes_nome"].ToString();
                            _pessoa.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                            _pessoa.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                            _pessoa.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                            _pessoa.Observacao = drPessoa["pes_obs"].ToString();
                            _pessoa.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                            _pessoa.Email = drPessoa["pes_email"].ToString();
                            _pessoa.Telefone = drPessoa["pes_fone"].ToString();
                            _pessoa.Celular = drPessoa["pes_cel"].ToString();
                        }
                        cx.Pessoa = _pessoa;
                        DataTable dtUsuario = new Controller.UsuarioController().retornaObjUsuario(Convert.ToInt32(drCaixa["codusuario"].ToString()));
                        if (dtUsuario != null && dtUsuario.Rows.Count > 0)
                        {
                            DataRow drUsuario = dtUsuario.Rows[0];
                            _usuario.UsuarioCodigo = Convert.ToInt32(drUsuario["codusuario"].ToString());
                            _usuario.Login = drUsuario["usu_usuario"].ToString();
                            _usuario.Senha = drUsuario["usu_senha"].ToString();
                            _usuario.Nivel = Convert.ToInt32(drUsuario["usu_nivel"].ToString());
                        }
                        cx.Usuario = _usuario;
                    }
                    parc.Caixa = cx;

                    DataTable dtForma = new Controller.PagamentoController().retornaObjFormaPagamento(Convert.ToInt32(drParcela["codformapag"].ToString()));
                    if(dtForma!=null && dtForma.Rows.Count > 0)
                    {
                        if (dtForma != null && dtForma.Rows.Count > 0)
                        {
                            DataRow drForma = dtForma.Rows[0];
                            forma.Codigo = Convert.ToInt32(drForma["codformapag"].ToString());
                            forma.Forma = drForma["formpag_descricao"].ToString();
                        }
                    }
                    parc.Forma = forma;
                    lista.Add(parc);
                    this.listaparcela = lista;
                    this.parct = parc;
                    this.codConta = cr.Codigo;                    
                }
                cr.Lista = lista;
                DataTable dtServicos = agc.retornaServicosCliente(cr.Pessoaf.Codigo);
                if(dtServicos!=null && dtServicos.Rows.Count > 0)
                {
                    convertLista(dtServicos);
                    //carregaGridServico(dtServicos);
                }
                mskSubtotal.Text = somaSubtotal(dtServicos)+ this.parct.ValorReceber + "";
                mskSubtotal.Text = Convert.ToDouble(mskSubtotal.Text).ToString("###,###,##0.00");

                mskTotal.Text = somaSubtotal(dtServicos)+ this.parct.ValorReceber + "";
                mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");

                mskRecebido.Text = "0.00";
                mskRestante.Text = "0.00";
                mskTroco.Text = "0.00";
            }
        }

        private void convertLista(DataTable dtServicos)
        {
            listaAgenda = new List<Entidades.Agenda>();
            for(int i = 0; i<dtServicos.Rows.Count; i++)
            {
                Entidades.Agenda a = new Entidades.Agenda();
                DataRow drAgenda = dtServicos.Rows[i];
                a.Codigo = Convert.ToInt32(drAgenda["codagenda"].ToString());
                a.Status = drAgenda["agen_status"].ToString();
                listaAgenda.Add(a);
            }
        }

        private double somaSubtotal(DataTable dtServico)
        {
            double total = 0;
            for(int i = 0; i< dtServico.Rows.Count; i++)
            {
                DataRow dr = dtServico.Rows[i];
                total += Convert.ToDouble(dr["agen_valor"].ToString());
            }
            return total;
        }

        private void mskAcrescimo_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(mskAcrescimo.Text.ToString()))
            {
                double acrescimo = Convert.ToDouble(mskAcrescimo.Text.ToString());
                double total = Convert.ToDouble(mskTotal.Text.ToString());
                total += acrescimo;
                mskTotal.Text = total + "";
                mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");
                mskAcrescimo.Text = Convert.ToDouble(mskAcrescimo.Text).ToString("###,###,##0.00");
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
                mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");
                mskDesconto.Text = Convert.ToDouble(mskDesconto.Text).ToString("###,###,##0.00");
            }
        }

        private void CarregaFormasPagamento()
        {
            Controller.PagamentoController objForma = new Controller.PagamentoController();

            DataTable dtFormas = objForma.retornaFormaPagamento();
            if (dtFormas != null && dtFormas.Rows.Count > 0)
            {
                this.cbbForma.ValueMember = "codformapag";
                this.cbbForma.DisplayMember = "formpag_descricao";
                this.cbbForma.DataSource = dtFormas;
            }
        }
        

        private void pesquisaVendaProduto()
        {
            try
            {
                Controller.VendaController vendaController = new Controller.VendaController();
                Entidades.VendaProduto vendaProduto = new Entidades.VendaProduto();

                int intCodVendaProd = vendaController.retornaUltimaVendaProduto();

                int codVenda = 0;

                if(intCodVendaProd > 0)
                {
                    DataTable dtVenda = vendaController.retornaVendaCod(intCodVendaProd);


                    if(dtVenda != null && dtVenda.Rows.Count > 0)
                    {
                        DataRow drVenda = dtVenda.Rows[0];
                        codVenda = Convert.ToInt32(drVenda["codvenda"].ToString());

                        DataTable dtVendProd = vendaController.retornaVendaProdutoCod(codVenda);

                        if(dtVendProd != null && dtVendProd.Rows.Count > 0)
                        {
                            DataRow dr = dtVendProd.Rows[0];
                            for (int i = 0; i < dtVendProd.Rows.Count; i++)
                            {
                                
                                //Entidades.Venda venda = new Entidades.Venda();
                                vendaProduto = new Entidades.VendaProduto();
                                //DataRow drVendProd = dtVendProd.Rows[i];
                                mskTotal.Text = dr["vend_valortotal"].ToString();
                            }
                            mskTotal.Text = dr["vend_valortotal"].ToString();
                            mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");
                        }
                        

                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }
            

        }
       

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void mskAcrescimo_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskAcrescimo);
        }

        

        private void mskAcrescimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskAcrescimo, e);
        }

        private void mskDesconto_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskDesconto);
        }

        

        private void mskDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskDesconto, e);
        }

        private void mskValorPagar_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskValorPagar);
        }

        private void mskValorPagar_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mskValorPagar.Text) && mskValorPagar.Equals("00,00"))
                mskValorPagar.Text = Convert.ToDouble(mskValorPagar.Text).ToString("###,###,##0.00");
        }

        private void mskValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskValorPagar, e);
        }

        private void mskSubtotal_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskSubtotal);
        }

        private void mskSubtotal_Leave(object sender, EventArgs e)
        {
            mskSubtotal.Text = Convert.ToDouble(mskSubtotal.Text).ToString("###,###,##0.00");
        }

        private void mskSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskSubtotal, e);
        }

        private void mskTotal_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotal);
        }

        private void mskTotal_Leave(object sender, EventArgs e)
        {
            mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");

        }

        private void mskTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotal, e);
        }

        private void mskRecebido_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskRecebido);
        }

        private void mskRecebido_Leave(object sender, EventArgs e)
        {
            mskRecebido.Text = Convert.ToDouble(mskRecebido.Text).ToString("###,###,##0.00");
        }

        private void mskRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskRecebido, e);
        }

        private void mskRestante_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskRestante);
        }

        private void mskRestante_Leave(object sender, EventArgs e)
        {
            mskRestante.Text = Convert.ToDouble(mskRestante.Text).ToString("###,###,##0.00");
        }

        private void mskRestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskRestante, e);
        }

        private void mskTroco_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTroco);
        }

        private void mskTroco_Leave(object sender, EventArgs e)
        {
            mskTroco.Text = Convert.ToDouble(mskTroco.Text).ToString("###,###,##0.00");
        }

        private void mskTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTroco, e);
        }

        private void btnFecharVenda_Click(object sender, EventArgs e)
        {
            Controller.AgendaController ac = new Controller.AgendaController();
            Controller.VendaController vc = new Controller.VendaController();
            Controller.ContasReceberController crc = new Controller.ContasReceberController();

            if (listapag != null && listapag.Count > 0)
            {
                string status = "";
                double rec = Convert.ToDouble(mskRecebido.Text.ToString());
                double tot = Convert.ToDouble(mskTotal.Text.ToString());
                if (tot > rec)
                    status = "aberta";
                else
                    status = "fechada";
                int i = 0;
                if (status.Equals("fechada"))
                {

                    if (this.codFechamento > 0)
                    {
                        if (crc.verificaParcelas(this.codConta))
                        {
                            if (listaAgenda != null && listaAgenda.Count > 0)
                            {

                                bool teste = false;
                                while (i < listaAgenda.Count && !teste)
                                {

                                    listaAgenda.ElementAt(i).Status = status;
                                    int rest = ac.atualizaStatus(listaAgenda.ElementAt(i));
                                    if (rest > 0)
                                        i++;
                                    else
                                        teste = true;
                                }
                            }
                            if (i < listaAgenda.Count)
                            {
                                MessageBox.Show("Erro ao atualizar serviços!");
                            }
                            else
                            {

                                this.parct.DataPagamento = DateTime.Now;
                                if (tot > rec)
                                    this.parct.ValorPago = rec;
                                else
                                    this.parct.ValorPago = tot;
                                this.parct.Forma = listapag.ElementAt(0).Forma;
                                int ver = crc.realizarRecebimento(this.parct, this.codConta);
                                if (ver <= 0)
                                {
                                    MessageBox.Show("Erro ao receber parcela");
                                }
                                else
                                {
                                    //int per = crc.atualizaStatus(this.codConta, status);

                                    if (crc.verificaParcelas(this.codConta))
                                    {
                                        int per = crc.atualizaStatus(this.codConta, status);
                                        if (per > 0)
                                        {
                                            int tes = vc.atualizaStatus(this.codVenda, status);
                                            if (tes > 0)
                                            {
                                                MessageBox.Show("Conta recebida com sucesso!");
                                                limpatela();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Erro ao receber conta!!!");
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                    else
                    {
                        if (listaAgenda != null && listaAgenda.Count > 0)
                        {

                            bool teste = false;
                            while (i < listaAgenda.Count && !teste)
                            {

                                listaAgenda.ElementAt(i).Status = status;
                                int rest = ac.atualizaStatus(listaAgenda.ElementAt(i));
                                if (rest > 0)
                                    i++;
                                else
                                    teste = true;
                            }
                        }
                        if (i < listaAgenda.Count)
                        {
                            MessageBox.Show("Erro ao atualizar serviços!");
                        }
                        else
                        {

                            this.parct.DataPagamento = DateTime.Now;
                            if (tot > rec)
                                this.parct.ValorPago = rec;
                            else
                                this.parct.ValorPago = tot;
                            this.parct.Forma = listapag.ElementAt(0).Forma;
                            int ver = crc.realizarRecebimento(this.parct, this.codConta);
                            if (ver <= 0)
                            {
                                MessageBox.Show("Erro ao receber parcela");
                            }
                            else
                            {
                                //int per = crc.atualizaStatus(this.codConta, status);

                                if (crc.verificaParcelas(this.codConta))
                                {
                                    int per = crc.atualizaStatus(this.codConta, status);
                                    if (per > 0)
                                    {
                                        int tes = vc.atualizaStatus(this.codVenda, status);
                                        if (tes > 0)
                                        {
                                            MessageBox.Show("Conta recebida com sucesso!");
                                            limpatela();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Erro ao receber conta!!!");
                                        }
                                    }
                                }
                            }

                        }
                    }
                } 
                else
                {
                    this.parct.DataPagamento = DateTime.Now;
                    if (tot > rec)
                        this.parct.ValorPago = rec;
                    else
                        this.parct.ValorPago = tot;
                    this.parct.Forma = listapag.ElementAt(0).Forma;
                    int ver = crc.realizarRecebimento(this.parct, this.codConta);
                    if (ver <= 0)
                    {
                        MessageBox.Show("Erro ao receber parcela");
                    }
                    else
                    {
                        int per = crc.atualizaStatus(this.codConta, status);
                        if (per > 0)
                        {
                            MessageBox.Show("Conta recebida com sucesso!");

                        }
                        else
                        {
                            MessageBox.Show("Erro ao receber Conta!");
                        }
                    }
                }

                MessageBox.Show("Fechamento realizado com sucesso!");
                limpatela();
                Close();
            }
        }

        private void btnExcluirForma_Click(object sender, EventArgs e)
        {
            Controller.PagamentoController pagc = new Controller.PagamentoController();
            Entidades.FormaPagamento forma = new Entidades.FormaPagamento();
            Entidades.TabelaFormaPagamento tforma = new Entidades.TabelaFormaPagamento();
            if (dgvformasPagamento.CurrentRow.Index > -1)
            {
                tforma = listapag.ElementAt(dgvformasPagamento.CurrentRow.Index);
                listapag.Remove(listapag.ElementAt(dgvformasPagamento.CurrentRow.Index));
                carregaDGVF(listapag);
                double recebido = somaValor(listapag);
                mskRecebido.Text = recebido + "";
                double total = Convert.ToDouble(mskTotal.Text.ToString());
                if (total - recebido > 0)
                {
                    mskRestante.Text = (total - recebido) + "";
                    mskTroco.Text = "0.00";
                    mskRestante.Text = Convert.ToDouble(mskRestante.Text).ToString("###,###,##0.00");

                }
                else
                {
                    mskRestante.Text = "0.00";
                    mskTroco.Text = (recebido - total) + "";
                    mskTroco.Text = Convert.ToDouble(mskTroco.Text).ToString("###,###,##0.00");
                }
            }
        }

        private void btnAdicionarPagamento_Click(object sender, EventArgs e)
        {
            Controller.PagamentoController pagc = new Controller.PagamentoController();
            Entidades.FormaPagamento forma = new Entidades.FormaPagamento();
            Entidades.TabelaFormaPagamento tforma = new Entidades.TabelaFormaPagamento();
            if (Convert.ToInt32(cbbForma.SelectedValue) > 0 && !String.IsNullOrEmpty(mskValorPagar.Text.ToString()))
            {
                DataTable dtForma = pagc.retornaObjFormaPagamento(Convert.ToInt32(cbbForma.SelectedValue));
                if (dtForma != null && dtForma.Rows.Count > 0)
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
                {
                    mskRestante.Text = (total - recebido) + "";
                    mskRestante.Text = Convert.ToDouble(mskRestante.Text).ToString("###,###,##0.00");
                }
                else
                {
                    mskRestante.Text = "0.00";
                    mskTroco.Text = (recebido - total) + "";
                    mskTroco.Text = Convert.ToDouble(mskTroco.Text).ToString("###,###,##0.00");
                }
            }
        }

        private void carregaDGVF(List<Entidades.TabelaFormaPagamento> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvformasPagamento.DataSource = bd;
            dgvformasPagamento.Refresh();
        }

        private double somaValor(List<Entidades.TabelaFormaPagamento> lista)
        {
            double valor = 0;
            for (int i = 0; i < lista.Count; i++)
                valor += lista.ElementAt(i).Valor;
            return valor;
        }

        

        private void limpatela()
        {
            mskAcrescimo.Text = "";
            mskDesconto.Text = "";
            mskSubtotal.Text = "";
            mskTotal.Text = "";
            mskRecebido.Text = "";
            mskRestante.Text = "";
            mskTroco.Text = "";
            ttbCliente.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpatela();
        }
    }
}
