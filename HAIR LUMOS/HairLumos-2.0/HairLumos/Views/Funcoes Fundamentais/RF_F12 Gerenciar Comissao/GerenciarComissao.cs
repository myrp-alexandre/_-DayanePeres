using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F12_Gerenciar_Comissao
{

    public partial class GerenciarComissao : Form
    {

        private List<Entidades.TabelaComissao> listaComissao = new List<Entidades.TabelaComissao>();
        private List<Entidades.TabelaComissao> listaaux = new List<Entidades.TabelaComissao>();
        private Controller.ComissaoController cc = new Controller.ComissaoController();

        public GerenciarComissao()
        {
            InitializeComponent();
            carregaFuncionario();
            rbTodas.Checked = true;
            rbPagar.Checked = false;
            rbReceber.Checked = false;

        }

        private void carregaFuncionario()
        {
            Controller.PessoaController pc = new Controller.PessoaController();
            DataTable dtFuncionario = pc.retornaPessoaJuridica();
            cbbParceiro.DataSource = dtFuncionario;
            cbbParceiro.ValueMember = "codpessoa";
            cbbParceiro.DisplayMember = "pes_nome";
        }

        // Converte campo da grid em valor moeda
        private void DGVMoeda()
        {
            // 1ª grid
            this.dgvComissaoListadas.Columns["Valor"].DefaultCellStyle.Format = "c";


            //2ª grid
            this.dgvAux.Columns["Valor"].DefaultCellStyle.Format = "c";
        }

        private void mskTotalPagar_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotalPagar);
        }

        private void mskTotalPagar_Leave(object sender, EventArgs e)
        {
            mskTotalPagar.Text = Convert.ToDouble(mskTotalPagar.Text).ToString("###,###,##0.00");
        }

        private void mskTotalPagar_KeyPress(object sender, KeyPressEventArgs e)
        {

            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotalPagar, e);
        }

        private void mskTotalReceber_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotalReceber);
        }

        private void mskTotalReceber_Leave(object sender, EventArgs e)
        {
            mskTotalReceber.Text = Convert.ToDouble(mskTotalReceber.Text).ToString("###,###,##0.00");
        }

        private void mskTotalReceber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotalReceber, e);
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carregaDGV()
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = listaComissao;
            dgvComissaoListadas.DataSource = bd;
            dgvComissaoListadas.Refresh();
        }

        private void carregaDGVAux()
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = listaaux;
            dgvAux.DataSource = bd;
            dgvAux.Refresh();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Controller.ComissaoController cmc = new Controller.ComissaoController();
            string status = "";
            if (rbPagar.Checked)
                status = "Pagar";
            if (rbReceber.Checked)
                status = "Receber";
            if (rbTodas.Checked)
                status = "Todas";
            if (dtpDtAte.Value < dtpDtDe.Value)
            {
                MessageBox.Show("Data Final não pode ser inferior a data inicial!");
            }
            else
            {
                DateTime dataI = dtpDtDe.Value.AddDays(-1);
                DataTable dtGeral = cmc.retornaGeral(Convert.ToInt32(cbbParceiro.SelectedValue), status, dataI.ToString("yyyy-MM-dd"), dtpDtAte.Value.ToString("yyyy-MM-dd"));
                if(dtGeral!=null && dtGeral.Rows.Count > 0)
                {
                    for(int i=0; i<dtGeral.Rows.Count; i++)
                    {
                        DataRow drGeral = dtGeral.Rows[i];
                        Entidades.TabelaComissao tc = new Entidades.TabelaComissao();
                        tc.CodComis = Convert.ToInt32(drGeral["codcomissao"].ToString());
                        tc.Data = Convert.ToDateTime(drGeral["agen_dataagendamento"].ToString());
                        tc.Valor = Convert.ToDouble(drGeral["prestserv_valor"].ToString());
                        tc.Status = drGeral["prestser_pagrec"].ToString();
                        tc.Nome = drGeral["pes_nome"].ToString();
                        tc.Pagamento = drGeral["comis_statuspagamento"].ToString();
                        listaComissao.Add(tc);
                    }
                    carregaDGV();
                }
                else
                {
                    MessageBox.Show("A busca não retornou resultados!");
                    listaComissao = new List<Entidades.TabelaComissao>();
                    carregaDGV();
                }
            }
        }

        private void rbPagar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPagar.Checked)
            {
                rbReceber.Checked = false;
                rbTodas.Checked = false;
            }
        }

        private void rbReceber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReceber.Checked)
            {
                rbTodas.Checked = false;
                rbPagar.Checked = false;
            }
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodas.Checked)
            {
                rbReceber.Checked = false;
                rbPagar.Checked = false;
            }
        }

        private void btnSelecionaTodos_Click(object sender, EventArgs e)
        {
            listaaux = listaComissao;
            listaComissao = new List<Entidades.TabelaComissao>();
            carregaDGV();
            carregaDGVAux();
            mskTotal.Text = somaValor() + "";
            mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");
            mskTotalPagar.Text = somaPagar() + "";
            mskTotalPagar.Text = Convert.ToDouble(mskTotalPagar.Text).ToString("###,###,##0.00");
            mskTotalReceber.Text = somaReceber() + "";
            mskTotalReceber.Text = Convert.ToDouble(mskTotalReceber.Text).ToString("###,###,##0.00");
        }

        private double somaValor()
        {
            double total = 0;
            for(int i=0;i<listaaux.Count; i++)
            {
                total += listaaux.ElementAt(i).Valor;
            }
            return total;
        }

        private double somaPagar()
        {
            double total = 0;
            for (int i = 0; i < listaaux.Count; i++)
            {
                if(listaaux.ElementAt(i).Status.Equals("PAGAR"))
                    total += listaaux.ElementAt(i).Valor;
            }
            return total;
        }

        private double somaReceber()
        {
            double total = 0;
            for (int i = 0; i < listaaux.Count; i++)
            {
                if (listaaux.ElementAt(i).Status.Equals("RECEBER"))
                    total += listaaux.ElementAt(i).Valor;
            }
            return total;
        }

        private void btnExcuirServico_Click(object sender, EventArgs e)
        {
            if (dgvComissaoListadas.CurrentRow.Index > -1)
            {
                listaaux.Add(listaComissao.ElementAt(dgvComissaoListadas.CurrentRow.Index));
                listaComissao.Remove(listaComissao.ElementAt(dgvComissaoListadas.CurrentRow.Index));
                carregaDGV();
                carregaDGVAux();
                mskTotal.Text = somaValor() + "";
                mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");
                mskTotalPagar.Text = somaPagar() + "";
                mskTotalPagar.Text = Convert.ToDouble(mskTotalPagar.Text).ToString("###,###,##0.00");
                mskTotalReceber.Text = somaReceber() + "";
                mskTotalReceber.Text = Convert.ToDouble(mskTotalReceber.Text).ToString("###,###,##0.00");
            }
            else
            {
                MessageBox.Show("Selecione uma comissão!");
            }
            
        }

        private void btnVoltaUm_Click(object sender, EventArgs e)
        {
            if (dgvAux.CurrentRow.Index > -1)
            {
                listaComissao.Add(listaaux.ElementAt(dgvAux.CurrentRow.Index));
                listaaux.Remove(listaaux.ElementAt(dgvAux.CurrentRow.Index));
                carregaDGV();
                carregaDGVAux();
                mskTotal.Text = somaValor() + "";
                mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");
                mskTotalPagar.Text = somaPagar() + "";
                mskTotalPagar.Text = Convert.ToDouble(mskTotalPagar.Text).ToString("###,###,##0.00");
                mskTotalReceber.Text = somaReceber() + "";
                mskTotalReceber.Text = Convert.ToDouble(mskTotalReceber.Text).ToString("###,###,##0.00");
            }
            else
            {
                MessageBox.Show("Selecione uma comissão!");
            }
        }

        private void btnVoltaTodos_Click(object sender, EventArgs e)
        {
            listaComissao = listaaux;
            listaaux = new List<Entidades.TabelaComissao>();
            carregaDGV();
            carregaDGVAux();
            mskTotal.Text = somaValor() + "";
            mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");
            mskTotalPagar.Text = somaPagar() + "";
            mskTotalPagar.Text = Convert.ToDouble(mskTotalPagar.Text).ToString("###,###,##0.00");
            mskTotalReceber.Text = somaReceber() + "";
            mskTotalReceber.Text = Convert.ToDouble(mskTotalReceber.Text).ToString("###,###,##0.00");
        }

        private void btnQuitarComissao_Click(object sender, EventArgs e)
        {

            Controller.ContasPagarController cpc = new Controller.ContasPagarController();
            Controller.ContasReceberController crc = new Controller.ContasReceberController();

            Entidades.Caixa _caixa = new Entidades.Caixa();
            Entidades.Pessoa _pessoa = new Entidades.Pessoa();
            Entidades.Usuario _usuario = new Entidades.Usuario();
            Entidades.Comissao cm = new Entidades.Comissao();
            Entidades.Despesa _despesa = new Entidades.Despesa();
            Entidades.FormaPagamento forma = new Entidades.FormaPagamento();

            if (listaaux!=null && listaaux.Count > 0)
            {
                int i = 0;
                bool teste = false;
                while(i<listaaux.Count && !teste)
                {
                    
                    forma.Codigo = 3;

                    DataTable dtCaixa = new Controller.CaixaController().retornacaixaAbetoDia();
                    if (dtCaixa != null && dtCaixa.Rows.Count > 0)
                    {
                        DataRow drCaixa = dtCaixa.Rows[0];
                        _caixa.CodCaixa = Convert.ToInt32(drCaixa["codcaixa"].ToString());
                        _caixa.DataAbertura = Convert.ToDateTime(drCaixa["caixa_datahoraabertura"].ToString());
                        _caixa.DataFechamento = Convert.ToDateTime(drCaixa["caixa_datahorafecha"].ToString());
                        _caixa.SaldoInicial = Convert.ToDouble(drCaixa["caixa_saldoinicial"].ToString());
                        _caixa.Troco = Convert.ToDouble(drCaixa["caixa_troco"].ToString());
                        _caixa.TotalEntrada = Convert.ToDouble(drCaixa["caixa_totalentra"].ToString());
                        _caixa.TotalSaida = Convert.ToDouble(drCaixa["caixa_totalsaida"].ToString());
                        DataTable dtPessoa = new Controller.PessoaController().retornaPessoaCod(drCaixa["codpessoa"].ToString());
                        if (dtPessoa != null && dtPessoa.Rows.Count > 0)
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
                        _caixa.Pessoa = _pessoa;
                        DataTable dtUsuario = new Controller.UsuarioController().retornaObjUsuario(Convert.ToInt32(drCaixa["codusuario"].ToString()));
                        if (dtUsuario != null && dtUsuario.Rows.Count > 0)
                        {
                            DataRow drUsuario = dtUsuario.Rows[0];
                            _usuario.UsuarioCodigo = Convert.ToInt32(drUsuario["codusuario"].ToString());
                            _usuario.Login = drUsuario["usu_usuario"].ToString();
                            _usuario.Senha = drUsuario["usu_senha"].ToString();
                            _usuario.Nivel = Convert.ToInt32(drUsuario["usu_nivel"].ToString());
                        }
                        _caixa.Usuario = _usuario;

                    }

                    DataTable dtDespesa = new Controller.ContasPagarController().retornaDespesaNome("Comissão");
                    if (dtDespesa != null && dtDespesa.Rows.Count > 0)
                    {
                        DataRow dr = dtDespesa.Rows[0];
                        _despesa.Codigo = Convert.ToInt32(dr["coddespesa"].ToString());
                        _despesa.Descricao = dr["desp_descricao"].ToString();
                        _despesa.Status = dr["desp_status"].ToString();
                    }

                    cm.CodigoComissao = listaaux.ElementAt(i).CodComis;
                    if (listaaux.ElementAt(i).Status.Equals("PAGAR"))
                    {
                        cm.ValorPago = listaaux.ElementAt(i).Valor;
                        cm.ValorDevolver = 0;
                    }
                    else
                    {
                        cm.ValorDevolver = listaaux.ElementAt(i).Valor;
                        cm.ValorPago = 0;
                    }
                    cm.DataPagamento = listaaux.ElementAt(i).Data;
                    cm.StatusPagamento = "fechada";
                    int k = cc.atualizaComissao(cm);
                    if (k > 0)
                    {
                        if (listaaux.ElementAt(i).Status.Equals("PAGAR"))
                        {
                            Entidades.ContasPagar cp = new Entidades.ContasPagar();
                            cp.DataPagamento = DateTime.Now;
                            cp.CodigoContasaPagar = cpc.retornaMax() + 1;
                            cp.DataVencimento = listaaux.ElementAt(i).Data;
                            cp.ValorPago = listaaux.ElementAt(i).Valor;
                            cp.ValorTotal = listaaux.ElementAt(i).Valor;
                            cp.ValorParcela = listaaux.ElementAt(i).Valor;
                            cp.Observacao = "";
                            cp.Status = true;
                            cp.Parcela = 1;
                            cp.Compra = new Entidades.Compra();
                            cp.Comissao = cm;
                            cp.Caixa = _caixa;
                            cp.CodParcela = 1;
                            cp.Despesa = _despesa;
                            cp.FormaPagamento = forma;
                            int p = cpc.insereLancamento(cp);
                            if (p > 0)
                                i++;
                            else
                                teste = true;
                        }
                        else
                        {
                            Entidades.ContasReceber cr = new Entidades.ContasReceber();
                            cr.DtVencimento = listaaux.ElementAt(i).Data;
                            cr.ValorTotal = listaaux.ElementAt(i).Valor;
                            cr.Obs = "fechada";
                            DataTable dtPessoa = new Controller.PessoaController().retornaPessoaCod(cbbParceiro.SelectedValue.ToString());
                            if (dtPessoa != null && dtPessoa.Rows.Count > 0)
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
                            cr.Pessoaf = _pessoa;
                            cr.Contrato = new Entidades.Contrato();
                            cr.Venda = new Entidades.Venda();
                            cr.CodigoFechamento = 0;
                            cr.Comissao = cm;
                            cr.Lista = new List<Entidades.Parcela>();
                            int tes = crc.gerarContasReceber(cr);
                            if (tes > 0)
                                i++;
                            else
                                teste = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao finalizar comissão!");
                        teste = true;
                    }
                    
                }
                if (i < listaaux.Count)
                {
                    MessageBox.Show("Erro ao finalizar Comissões!");
                }
                else
                {
                    MessageBox.Show("Acerto de comissão finalizado com sucesso!");
                    listaaux = new List<Entidades.TabelaComissao>();
                    listaComissao = new List<Entidades.TabelaComissao>();
                    carregaDGV();
                    carregaDGVAux();
                    mskTotal.Text = somaValor() + "";
                    mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");
                    mskTotalPagar.Text = somaPagar() + "";
                    mskTotalPagar.Text = Convert.ToDouble(mskTotalPagar.Text).ToString("###,###,##0.00");
                    mskTotalReceber.Text = somaReceber() + "";
                    mskTotalReceber.Text = Convert.ToDouble(mskTotalReceber.Text).ToString("###,###,##0.00");
                }
            }
            else
            {
                MessageBox.Show("Nenhuma comissão na lista para acerto");
            }
        }
    }
}
