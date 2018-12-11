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
    public partial class GerarContasReceber : Form
    {
        private List<Entidades.Parcela> listaParcelas = new List<Entidades.Parcela>();
        Controller.ContasReceberController crc = new Controller.ContasReceberController();
        private int cod = 0;
        private int codFechamento = 0;
        private string tela = "";
        private Entidades.Pessoa pes = new Entidades.Pessoa();

        public GerarContasReceber(int codFechamento, double total, string tela, Entidades.Pessoa pessoa)
        {
            InitializeComponent();
            carregaTelaF(codFechamento, total);
            this.codFechamento = codFechamento;
            mskValorTotoalPagar.Text = "0.00";
            this.tela = tela;
            this.pes = pessoa;
        }

        public GerarContasReceber(int cod, double total)
        {
            InitializeComponent();
            carregaTela(cod, total);
            this.cod = cod;
            mskValorTotoalPagar.Text = "0.00";
        }

        private void carregaTelaF(int codFechamento, double total)
        {
            mskValorTotal.Text = total + "";
            mskValorTotal.Text = Convert.ToDouble(mskValorTotal.Text).ToString("###,###,##0.00");
        }

        private void carregaTela(int cod, double total)
        {
            mskValorTotal.Text = total + "";
            mskValorTotal.Text = Convert.ToDouble(mskValorTotal.Text).ToString("###,###,##0.00");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carregaDGV(List<Entidades.Parcela> list)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = list;
            dgvContas.DataSource = bd;
            dgvContas.Refresh();

        }

        private void cbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (cbManual.Checked)
            {
                ttbQtdeParcela.Enabled = false;
                mskValorParcela.Enabled = true;
                listaParcelas = new List<Entidades.Parcela>();
            }
            else
            {
                ttbQtdeParcela.Enabled = true;
                mskValorParcela.Enabled = false;
                listaParcelas = new List<Entidades.Parcela>();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            int k = listaParcelas.Count;
            double total = Convert.ToDouble(mskValorTotal.Text.ToString());
            Controller.CaixaController cxc = new Controller.CaixaController();
            Entidades.Caixa cx = new Entidades.Caixa();
            Entidades.Parcela parc = new Entidades.Parcela();
            DataTable dtCaixa = cxc.retornacaixaAbetoDia();

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

            }
            if (cbManual.Checked)
            {
                if (!String.IsNullOrEmpty(mskValorParcela.Text.ToString()))
                {
                    double tt = Convert.ToDouble(mskValorTotoalPagar.Text.ToString());
                    double valparc = Convert.ToDouble(mskValorParcela.Text.ToString());
                    string parcv = valparc.ToString("#.##");
                    valparc = Convert.ToDouble(parcv);
                    if (total>= tt + valparc)
                    {
                        parc = new Entidades.Parcela();
                        parc.Codigo = k + 1;
                        parc.DataPagamento = DateTime.MinValue;
                        parc.DataVencimento = dtpDataVencimento.Value.AddDays(k * 30);
                        parc.ValorPago = 0;
                        parc.ValorReceber = valparc;
                        parc.Forma = new Entidades.FormaPagamento();
                        parc.Caixa = cx;
                        listaParcelas.Add(parc);
                        mskValorTotoalPagar.Text = tt + valparc + "";
                        mskValorParcela.Text = "";
                        carregaDGV(listaParcelas);
                    }
                    else
                    {
                        MessageBox.Show("Valor superior ao total!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Digite o valor a ser incluido!");
                }
            }
            else
            {
                listaParcelas = new List<Entidades.Parcela>();
                if (!String.IsNullOrEmpty(ttbQtdeParcela.Text.ToString()))
                {
                    double nparcela = Convert.ToInt32(ttbQtdeParcela.Text.ToString());
                    double valParcela = total / nparcela;
                    string parcv = valParcela.ToString("#.##");
                    valParcela = Convert.ToDouble(parcv);
                    double tem = total;
                    for(int i=0; i<nparcela; i++)
                    {
                        tem -= valParcela;
                        parc = new Entidades.Parcela();
                        parc.Codigo = i + 1;
                        parc.DataPagamento = DateTime.MinValue;
                        parc.DataVencimento = dtpDataVencimento.Value.AddDays(i * 30);
                        parc.ValorPago = 0;
                        if (i + 1 == nparcela)
                        {
                            double vl = tem + valParcela;
                            parc.ValorReceber = Convert.ToDouble(vl.ToString("#.##"));
                        } 
                        else
                            parc.ValorReceber = valParcela;
                        parc.Forma = new Entidades.FormaPagamento();
                        parc.Caixa = cx;
                        listaParcelas.Add(parc);
                    }
                    carregaDGV(listaParcelas);
                    mskValorTotoalPagar.Text = total + "";
                }
                else
                {
                    MessageBox.Show("Digite o numero de parcelas!");
                }
                
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tela))
            {
                if (listaParcelas.Count > 0)
                {
                    int rest = crc.gerarContasReceberF(this.codFechamento, listaParcelas, this.pes);
                    if (rest > 0)
                    {
                        MessageBox.Show("Parcelas geradas com sucesso!");
                        if (listaParcelas.ElementAt(0).DataVencimento.ToString("dd/MM/yyyy").Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                        {
                            Views.Funcoes_Fundamentais.RF_F11_Quitar_Contas_a_Receber.QuitarContasReceber quitar = new QuitarContasReceber();
                            quitar.ShowDialog();
                            mskValorTotal.Text = "";
                            Close();
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gerar parcelas!");
                    }
                }
            }
            else
            {
                if (listaParcelas.Count > 0)
                {
                    int rest = crc.gerarContasReceber(this.cod, listaParcelas);
                    if (rest > 0)
                    {
                        MessageBox.Show("Parcelas geradas com sucesso!");
                        if (listaParcelas.ElementAt(0).DataVencimento.ToString("dd/MM/yyyy").Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                        {
                            Views.Funcoes_Fundamentais.RF_F11_Quitar_Contas_a_Receber.QuitarContasReceber quitar = new QuitarContasReceber();
                            quitar.ShowDialog();
                            mskValorTotal.Text = "";
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gerar parcelas!");
                    }
                }
            }
            
        }

        private void mskValorParcela_Leave(object sender, EventArgs e)
        {
            mskValorParcela.Text = Convert.ToDouble(mskValorParcela.Text).ToString("###,###,##0.00");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resulta = MessageBox.Show("Deseja mesmo cancelar, se cancelar, uma conta será gerada automaticamente", "caption", MessageBoxButtons.YesNo);
            if (resulta == DialogResult.Yes)
            {
                cancelar();
            }
        }

        private void cancelar()
        {
            double total = Convert.ToDouble(mskValorTotal.Text.ToString());
            Controller.CaixaController cxc = new Controller.CaixaController();
            Entidades.Caixa cx = new Entidades.Caixa();
            Entidades.Parcela parc = new Entidades.Parcela();
            DataTable dtCaixa = cxc.retornacaixaAbetoDia();

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

            }      
            parc = new Entidades.Parcela();
            parc.Codigo = 1;
            parc.DataPagamento = DateTime.MinValue;
            parc.DataVencimento = dtpDataVencimento.Value.AddDays(30);
            parc.ValorPago = 0;
            parc.ValorReceber = total;
            parc.Forma = new Entidades.FormaPagamento();
            parc.Caixa = cx;
            listaParcelas.Add(parc);

            if (!String.IsNullOrEmpty(tela))
            {
                if (listaParcelas.Count > 0)
                {
                    int rest = crc.gerarContasReceberF(this.codFechamento, listaParcelas, this.pes);
                    if (rest > 0)
                    {
                        MessageBox.Show("Parcelas geradas com sucesso!");
                        if (listaParcelas.ElementAt(0).DataVencimento.ToString("dd/MM/yyyy").Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                        {
                            mskValorTotal.Text = "";
                            Close();
                            Views.Funcoes_Fundamentais.RF_F11_Quitar_Contas_a_Receber.QuitarContasReceber quitar = new QuitarContasReceber();
                            quitar.ShowDialog();

                        }
                        else
                        {
                            mskValorTotal.Text = "";
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gerar parcelas!");
                    }
                }
            }
            else
            {
                if (listaParcelas.Count > 0)
                {
                    int rest = crc.gerarContasReceber(this.cod, listaParcelas);
                    if (rest > 0)
                    {
                        MessageBox.Show("Parcelas geradas com sucesso!");
                        if (listaParcelas.ElementAt(0).DataVencimento.ToString("dd/MM/yyyy").Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                        {
                            mskValorTotal.Text = "";
                            Close();
                            Views.Funcoes_Fundamentais.RF_F11_Quitar_Contas_a_Receber.QuitarContasReceber quitar = new QuitarContasReceber();
                            quitar.ShowDialog();

                        }
                        else
                        {
                            mskValorTotal.Text = "";
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gerar parcelas!");
                    }
                }
            }

        }

        private void GerarContasReceber_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(mskValorTotal.Text == "")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Uma conta foi gerada para a compra!");
                cancelar();
                Close();
            }
            
        }

        private void DGVMoeda()
        {

            if (dgvContas.Rows.Count > 0)
            {
                this.dgvContas.Columns[1].DefaultCellStyle.Format = "c";
            }

        }
    }
}
