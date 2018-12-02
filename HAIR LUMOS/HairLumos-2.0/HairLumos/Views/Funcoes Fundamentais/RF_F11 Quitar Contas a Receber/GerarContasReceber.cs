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
        public GerarContasReceber()
        {
            InitializeComponent();
        }

        public GerarContasReceber(int cod, double total)
        {
            InitializeComponent();
            carregaTela(cod, total);
            this.cod = cod;
            mskValorTotoalPagar.Text = "0.00";
        }

        private void carregaTela(int cod, double total)
        {
            mskValorTotal.Text = total + "";
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
                    if(total>= tt + valparc)
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
                if (!String.IsNullOrEmpty(ttbQtdeParcela.Text.ToString()))
                {
                    double nparcela = Convert.ToInt32(ttbQtdeParcela.Text.ToString());
                    double valParcela = total / nparcela;
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
                            parc.ValorReceber = tem + valParcela;
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
            if (listaParcelas.Count > 0)
            {
                int rest = crc.gerarContasReceber(this.cod, listaParcelas);
                if (rest > 0)
                {
                    MessageBox.Show("Parcelas geradas com sucesso!");

                }
                else
                {
                    MessageBox.Show("Erro ao gerar parcelas!");
                }
            }
        }
    }
}
