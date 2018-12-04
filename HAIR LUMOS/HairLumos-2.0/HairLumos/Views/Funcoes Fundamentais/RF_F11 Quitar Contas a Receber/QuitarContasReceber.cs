using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F11_Quitar_Contas_a_Receber
{
    public partial class QuitarContasReceber : Form
    {
        private Controller.ContasReceberController crc = new Controller.ContasReceberController();
        public int codC { get; set; }
        public int codP { get; set; }

        public QuitarContasReceber()
        {
            InitializeComponent();
            _inicializa();
            dgvParcelas.AutoGenerateColumns = false;
        }

        private void _inicializa()
        {
            cbbEmAberto.Checked = true;
            cbbPago.Checked = false;
            cbbVencido.Checked = false;
        }

        private void carregaDGV(DataTable dt)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = dt;
            dgvParcelas.DataSource = bd;
            dgvParcelas.Refresh();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvParcelas.CurrentRow.Index > -1)
            {
                int intCodC = 0, intCodP = 0;
                int.TryParse(dgvParcelas.CurrentRow.Cells[0].FormattedValue.ToString(), out intCodC);
                int.TryParse(dgvParcelas.CurrentRow.Cells[1].FormattedValue.ToString(), out intCodP);
                if(intCodC>0 && intCodP > 0)
                {
                    this.codC = intCodC;
                    this.codP = intCodP;
                    Views.Funcoes_Fundamentais.RF_F8_Fechar_Atendimento.FecharAtendimento fechar = new RF_F8_Fechar_Atendimento.FecharAtendimento(this.codC, this.codP);
                    fechar.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selecione a parcela para quitar!");
            }
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            if (dgvParcelas.CurrentRow.Index > -1)
            {
                Controller.VendaController vc = new Controller.VendaController();
                Entidades.Pessoa _pessoa = new Entidades.Pessoa();
                Entidades.Parcela parc = new Entidades.Parcela();
                Entidades.Caixa cx = new Entidades.Caixa();
                Entidades.Usuario _usuario = new Entidades.Usuario();

                double pago = 0;
                double.TryParse(dgvParcelas.CurrentRow.Cells[3].FormattedValue.ToString(), out pago);
                if (pago > 0)
                {
                    DialogResult resulta = MessageBox.Show("Deseja realmente fazer o estorno", "caption", MessageBoxButtons.YesNo);
                    if (resulta == DialogResult.Yes)
                    {
                        int intcodc =0, intcodp = 0;
                        int.TryParse(dgvParcelas.CurrentRow.Cells[0].FormattedValue.ToString(), out intcodc);
                        int.TryParse(dgvParcelas.CurrentRow.Cells[1].FormattedValue.ToString(), out intcodp);
                        if(intcodc>0 && intcodp > 0)
                        {
                            DataTable dt = crc.retornaParcelaContaReceber(intcodc, intcodp);
                            if(dt!=null && dt.Rows.Count > 0)
                            {
                                DataRow drParcela = dt.Rows[0];
                                parc.Codigo = intcodp;
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
                                        DataRow drPessoa = dtP.Rows[0];
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

                            }

                            parc.ValorPago = 0;
                            parc.DataPagamento = DateTime.MinValue;
                            parc.Forma = new Entidades.FormaPagamento();

                            int res = crc.realizarRecebimento(parc, intcodc);
                            if (res > 0)
                            {
                                int tes = crc.atualizaStatus(intcodc, "aberta");
                                if (tes > 0)
                                {
                                    int cod = crc.retornaVenda(intcodc);
                                    int p = vc.atualizaStatus(cod, "aberta");
                                    if (p > 0)
                                    {
                                        MessageBox.Show("Valor estornado com sucesso!");
                                        limpaCampos();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao realizar estorno!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erro ao realizar estorno!");
                            }
                        }
                    }
                }
                
            }
        }

        public void limpaCampos()
        {
            dtpDataDe.Value = DateTime.Now;
            dtpDataAte.Value = DateTime.Now;
            cbbEmAberto.Checked = true;
            cbbPago.Checked = false;
            cbbVencido.Checked = false;
            dgvParcelas.DataSource = null;
            ttbTotalPagar.Text = "00,00";
            ttbTotalPago.Text = "00,00";
            ttbTotalVencido.Text = "00,00";

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double somaTotal(DataTable dt)
        {
            double total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                total += Convert.ToDouble(dr["parc_valor"].ToString());
            }
            return total;
        }

        private double somaRecebido(DataTable dt)
        {
            double total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                total += Convert.ToDouble(dr["parc_valorpago"].ToString());
            }
            return total;
        }

        private double somaVencido(DataTable dt)
        {
            double total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if(Convert.ToDateTime(dr["parc_datavencimento"].ToString()) < Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")) && dr["contrec_obs"].ToString().Equals("aberta"))
                    total += Convert.ToDouble(dr["parc_valor"].ToString()) - Convert.ToDouble(dr["parc_valorpago"].ToString());
            }
            return total;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (dtpDataDe.Value <= dtpDataAte.Value)
                {
                    string situacao = "";
                    if (cbbPago.Checked)
                        situacao = "Pago";
                    if (cbbVencido.Checked)
                        situacao = "Vencido";
                    if (cbbEmAberto.Checked)
                        situacao = "Em aberto";
                    dt = crc.retornaContasReceber(dtpDataDe.Value.ToString("yyyy-MM-dd"), dtpDataAte.Value.ToString("yyyy-MM-dd"), situacao);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        carregaDGV(dt);
                        ttbTotalPagar.Text = somaTotal(dt) + "";
                        ttbTotalPagar.Text = Convert.ToDouble(ttbTotalPagar.Text).ToString("###,###,##0.00");
                        ttbTotalPago.Text = somaRecebido(dt) + "";
                        ttbTotalPago.Text = Convert.ToDouble(ttbTotalPago.Text).ToString("###,###,##0.00");
                        ttbTotalVencido.Text = somaVencido(dt) + "";
                        ttbTotalVencido.Text = Convert.ToDouble(ttbTotalVencido.Text).ToString("###,###,##0.00");
                    }
                    else
                    {
                        MessageBox.Show("Não há nenhuma conta a Receber");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "");
            }
           
        }

        private void ttbTotalPagar_Enter_1(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(ttbTotalPagar);
        }

        private void ttbTotalPagar_Leave(object sender, EventArgs e)
        {
            ttbTotalPagar.Text = Convert.ToDouble(ttbTotalPagar.Text).ToString("###,###,##0.00");
        }

        private void ttbTotalPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(ttbTotalPagar, e);
        }

        private void ttbTotalPago_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(ttbTotalPago);
        }

        private void ttbTotalPago_Leave(object sender, EventArgs e)
        {
            ttbTotalPago.Text = Convert.ToDouble(ttbTotalPago.Text).ToString("###,###,##0.00");
        }

        private void ttbTotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(ttbTotalPago, e);
        }

        private void ttbTotalVencido_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(ttbTotalVencido);
        }

        private void ttbTotalVencido_Leave(object sender, EventArgs e)
        {
            ttbTotalVencido.Text = Convert.ToDouble(ttbTotalVencido.Text).ToString("###,###,##0.00");
        }

        private void ttbTotalVencido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(ttbTotalVencido, e);
        }

        private void DGVMoeda()
        {
            this.dgvParcelas.Columns["contRec_valorTotal"].DefaultCellStyle.Format = "c";
        }

        private void cbbVencido_Click(object sender, EventArgs e)
        {
            if (cbbVencido.Checked)
            {
                cbbPago.Checked = false;
                cbbEmAberto.Checked = false;
            }
        }

        private void cbbPago_Click(object sender, EventArgs e)
        {
            if (cbbPago.Checked)
            {
                cbbVencido.Checked = false;
                cbbEmAberto.Checked = false;
            }
        }

        private void cbbEmAberto_Click(object sender, EventArgs e)
        {
            if (cbbEmAberto.Checked)
            {
                cbbVencido.Checked = false;
                cbbPago.Checked = false;
            }
        }
    }
}
