using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F5
{
    public partial class GerarContaPagar : Form
    {
        private int codCompra { get; set; }
        private double valorTotal { get; set; }

        private List<Entidades.ContasPagar> listacontasPagars = new List<Entidades.ContasPagar>();
        private Controller.CompraController CompraController = new Controller.CompraController();
        private Entidades.ContasPagar ContasPagar = new Entidades.ContasPagar();

        public GerarContaPagar()
        {
            InitializeComponent();
            mskValorTotal.Enabled = false;
            mskValorParcela.Enabled = false;

            dgvContas.AutoGenerateColumns = false;

            _inicializa();

            DataTable dt = CompraController.retornaCompraMAX();

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                codCompra = Convert.ToInt32(dr["codcompra"].ToString());
                mskValorTotal.Text = Convert.ToDouble(dr["comp_valortotal"]).ToString();
                valorTotal = Convert.ToDouble(mskValorTotal.Text);
                DGVMoeda();
            }

            if (!string.IsNullOrWhiteSpace(mskValorTotal.Text))
                mskValorTotal.Text = Convert.ToDouble(mskValorTotal.Text).ToString("###,###,##0.00");
            if (!string.IsNullOrWhiteSpace(mskValorParcela.Text))
                mskValorParcela.Text = Convert.ToDouble(mskValorParcela.Text).ToString("###,###,##0.00");
            if (!string.IsNullOrWhiteSpace(mskValorTotoalPagar.Text))
                mskValorTotoalPagar.Text = Convert.ToDouble(mskValorTotoalPagar.Text).ToString("###,###,##0.00");

        }

        private void _inicializa()
        {
            dtpDataVencimento.Value = DateTime.Now;
            ttbQtdeParcela.Text = "";
            mskValorTotal.Text = "";
            mskValorParcela.Text = "";
            dgvContas.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resulta = MessageBox.Show("Deseja mesmo cancelar, se cancelar, uma conta será gerada automaticamente", "caption", MessageBoxButtons.YesNo);
            if (resulta == DialogResult.Yes)
            {
                cancelarClose();
            }
        }

        private void cancelarClose()
        {
            Controller.ContasPagarController contasPagarController = new Controller.ContasPagarController();

            Controller.CompraController compraController = new Controller.CompraController();
            Entidades.Compra compra = new Entidades.Compra();

            Controller.DespesaController despesaController = new Controller.DespesaController();
            Entidades.Despesa despesa = new Entidades.Despesa();

            Controller.PessoaController pessoaController = new Controller.PessoaController();
            Entidades.Pessoa pessoa = new Entidades.Pessoa();

            Controller.CaixaController caixaController = new Controller.CaixaController();
            Entidades.Caixa caixa = new Entidades.Caixa();
            string codPessoa = "";
            double valorParcelasTotal = Convert.ToDouble(mskValorTotal.Text.ToString());

            DataTable dt = compraController.retornaCompra(codCompra);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                compra = new Entidades.Compra();
                compra.Codigo = Convert.ToInt32(dr["codcompra"].ToString());

                compra.Data = Convert.ToDateTime(dr["comp_datacompra"].ToString());
                compra.Situacao = dr["comp_situacao"].ToString();
                compra.Consignado = Convert.ToBoolean(dr["comp_statusconsignado"].ToString());
                compra.ValorTotal = Convert.ToDouble(dr["comp_valortotal"].ToString());
                compra.Obs = dr["comp_obs"].ToString();

                codPessoa = dr["codpessoa"].ToString();
                compra.Pessoa.Codigo = Convert.ToInt32(dr["codpessoa"].ToString());

                DataTable dtDespesa = despesaController.retornaObjDespesa("Compra");

                if (dtDespesa != null && dt.Rows.Count > 0)
                {
                    DataRow drDespesa = dtDespesa.Rows[0];
                    despesa.Codigo = Convert.ToInt32(drDespesa["coddespesa"].ToString());
                    despesa.Descricao = drDespesa["desp_descricao"].ToString();
                    despesa.Status = drDespesa["desp_status"].ToString();

                }

                compra.Despesa = despesa;

                DataTable dtPessoa = pessoaController.retornaPessoaCod(codPessoa);

                if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                {
                    DataRow drPessoa = dtPessoa.Rows[0];
                    pessoa.Codigo = Convert.ToInt32(drPessoa["codPessoa"].ToString());
                    pessoa.Nome = drPessoa["pes_nome"].ToString();
                }

                compra.Pessoa = pessoa;

            }

            DataTable dtCaixa = caixaController.retornacaixaAbetoDia();

            if (dtCaixa != null && dtCaixa.Rows.Count > 0)
            {
                DataRow drCaixa = dtCaixa.Rows[0];
                caixa.DataAbertura = Convert.ToDateTime(drCaixa["caixa_datahoraabertura"].ToString());
                caixa.DataFechamento = Convert.ToDateTime(drCaixa["caixa_datahorafecha"].ToString());
                caixa.SaldoInicial = Convert.ToDouble(drCaixa["caixa_saldoinicial"].ToString());
                caixa.Troco = Convert.ToDouble(drCaixa["caixa_troco"].ToString());
                caixa.TotalEntrada = Convert.ToDouble(drCaixa["caixa_totalentra"].ToString());
                caixa.TotalSaida = Convert.ToDouble(drCaixa["caixa_totalsaida"].ToString());

            }

            


            if (dtpDataVencimento.Value.Date >= DateTime.Now.Date)
            {

                for (int i = 0; i < 1; i++)
                {
                    ContasPagar = new Entidades.ContasPagar();
                    ContasPagar.Parcela = 1;
                    ContasPagar.ValorTotal = valorParcelasTotal;
                    ContasPagar.DataVencimento = dtpDataVencimento.Value.AddDays(30);
                    ContasPagar.CodParcela = i + 1;
                    ContasPagar.ValorParcela = valorParcelasTotal;
                    ContasPagar.Status = false;
                    ContasPagar.Compra = compra;
                    ContasPagar.Despesa = despesa;
                    ContasPagar.Caixa = caixa;
                    ContasPagar.FormaPagamento = new Entidades.FormaPagamento();
                    ContasPagar.Comissao = new Entidades.Comissao();


                    listacontasPagars.Add(ContasPagar);

                }
                mskValorTotoalPagar.Text = Convert.ToString(valorParcelasTotal);
                mskValorTotoalPagar.Text = Convert.ToDouble(mskValorTotoalPagar.Text).ToString("###,###,##0.00");
                
                
            }


            
            int cod = contasPagarController.retornaMax();
            cod += 1;

            try
            {
                int i = 0;
                bool retur = false;

                while (i < listacontasPagars.Count && !retur)
                {
                    listacontasPagars.ElementAt(i).CodigoContasaPagar = cod;
                    listacontasPagars.ElementAt(i).Parcela = listacontasPagars.Count;
                    int res = contasPagarController.insereLancamento(listacontasPagars.ElementAt(i));

                    if (res < 0)
                    {
                        MessageBox.Show("Erro");
                        retur = true;
                    }
                    else { i++; }

                }
                if (listacontasPagars.ElementAt(0).DataVencimento.ToString("dd/MM/yyyy").Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    mskValorTotal.Text = "";
                    Close();
                    Views.Funcoes_Fundamentais.QuitarDespesa quitarDespesas = new QuitarDespesa();
                    quitarDespesas.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Parcelas geradas com sucesso!");
                    mskValorTotal.Text = "";
                    Close();

                }
            }
            catch (Exception ex)
            {

                throw;
            } 

        }

        private void DGVMoeda()
        {
            this.dgvContas.Columns["ValorParcela"].DefaultCellStyle.Format = "c";
        }
        

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Controller.ContasPagarController contasPagarController = new Controller.ContasPagarController();
            if (somaValor(listacontasPagars) == Convert.ToDouble(mskValorTotal.Text))
            {
                int cod = contasPagarController.retornaMax();
                cod += 1;

                try
                {
                    int i = 0;
                    bool retur = false;

                    while (i < listacontasPagars.Count && !retur)
                    {
                        listacontasPagars.ElementAt(i).CodigoContasaPagar = cod;
                        listacontasPagars.ElementAt(i).Parcela = listacontasPagars.Count;
                        int res = contasPagarController.insereLancamento(listacontasPagars.ElementAt(i));

                        if (res < 0)
                        {
                            MessageBox.Show("Erro");
                            retur = true;
                        }
                        else { i++; }

                    }
                    if (listacontasPagars.ElementAt(0).DataVencimento.ToString("dd/MM/yyyy").Equals(DateTime.Now.ToString("dd/MM/yyyy")))
                    {
                        mskValorTotal.Text = "";
                        Close();
                        Views.Funcoes_Fundamentais.QuitarDespesa quitarDespesas = new QuitarDespesa();
                        quitarDespesas.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Parcelas geradas com sucesso!");
                        mskValorTotal.Text = "";
                        Close();

                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Valor total incluido inferior ao total da compra!");
            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Controller.ContasPagarController contasPagarController = new Controller.ContasPagarController();

            Controller.CompraController compraController = new Controller.CompraController();
            Entidades.Compra compra = new Entidades.Compra();

            Controller.DespesaController despesaController = new Controller.DespesaController();
            Entidades.Despesa despesa = new Entidades.Despesa();

            Controller.PessoaController pessoaController = new Controller.PessoaController();
            Entidades.Pessoa pessoa = new Entidades.Pessoa();

            Controller.CaixaController caixaController = new Controller.CaixaController();
            Entidades.Caixa caixa = new Entidades.Caixa();
            string codPessoa = "";
            int k = listacontasPagars.Count;
            DataTable dt = compraController.retornaCompra(codCompra);

            double valorParcelasTotal = 0;

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                compra = new Entidades.Compra();
                compra.Codigo = Convert.ToInt32(dr["codcompra"].ToString());

                compra.Data = Convert.ToDateTime(dr["comp_datacompra"].ToString());
                compra.Situacao = dr["comp_situacao"].ToString();
                compra.Consignado = Convert.ToBoolean(dr["comp_statusconsignado"].ToString());
                compra.ValorTotal = Convert.ToDouble(dr["comp_valortotal"].ToString());
                compra.Obs = dr["comp_obs"].ToString();

                codPessoa = dr["codpessoa"].ToString();
                compra.Pessoa.Codigo = Convert.ToInt32(dr["codpessoa"].ToString());

                DataTable dtDespesa = despesaController.retornaObjDespesa("Compra");

                if (dtDespesa != null && dt.Rows.Count > 0)
                {
                    DataRow drDespesa = dtDespesa.Rows[0];
                    despesa.Codigo = Convert.ToInt32(drDespesa["coddespesa"].ToString());
                    despesa.Descricao = drDespesa["desp_descricao"].ToString();
                    despesa.Status = drDespesa["desp_status"].ToString();

                }

                compra.Despesa = despesa;

                DataTable dtPessoa = pessoaController.retornaPessoaCod(codPessoa);

                if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                {
                    DataRow drPessoa = dtPessoa.Rows[0];
                    pessoa.Codigo = Convert.ToInt32(drPessoa["codPessoa"].ToString());
                    pessoa.Nome = drPessoa["pes_nome"].ToString();
                }

                compra.Pessoa = pessoa;

            }

            DataTable dtCaixa = caixaController.retornacaixaAbetoDia();

            if (dtCaixa != null && dtCaixa.Rows.Count > 0)
            {
                DataRow drCaixa = dtCaixa.Rows[0];
                caixa.DataAbertura = Convert.ToDateTime(drCaixa["caixa_datahoraabertura"].ToString());
                caixa.DataFechamento = Convert.ToDateTime(drCaixa["caixa_datahorafecha"].ToString());
                caixa.SaldoInicial = Convert.ToDouble(drCaixa["caixa_saldoinicial"].ToString());
                caixa.Troco = Convert.ToDouble(drCaixa["caixa_troco"].ToString());
                caixa.TotalEntrada = Convert.ToDouble(drCaixa["caixa_totalentra"].ToString());
                caixa.TotalSaida = Convert.ToDouble(drCaixa["caixa_totalsaida"].ToString());

            }
            
            if (!cbManual.Checked) {
                try
                {
                    if (string.IsNullOrWhiteSpace(ttbQtdeParcela.Text))
                        MessageBox.Show("Informe uma valor para a parcela ou 0");


                    if (dtpDataVencimento.Value.Date >= DateTime.Now.Date)
                    {
                        double valorParc = Convert.ToDouble(mskValorTotal.Text) / Convert.ToInt32(ttbQtdeParcela.Text);
                        valorParc = Convert.ToDouble(valorParc.ToString("#.##"));
                        double resto = Convert.ToDouble(mskValorTotal.Text) - (Convert.ToInt32(ttbQtdeParcela.Text) * valorParc);
                        if(resto>0)
                            resto = Convert.ToDouble(resto.ToString("#.##"));

                        for (int i = 0; i < Convert.ToInt32(ttbQtdeParcela.Text); i++)
                        {
                            ContasPagar = new Entidades.ContasPagar();
                            ContasPagar.Parcela = Convert.ToInt32(ttbQtdeParcela.Text);
                            ContasPagar.ValorTotal = Convert.ToDouble(mskValorTotal.Text);
                            ContasPagar.DataVencimento = dtpDataVencimento.Value.AddDays(i * 30);
                            ContasPagar.CodParcela = i + 1;
                            if (i + 1 == Convert.ToInt32(ttbQtdeParcela.Text))
                                ContasPagar.ValorParcela = valorParc + resto;
                            else
                                ContasPagar.ValorParcela = valorParc;
                            ContasPagar.Status = false;
                            ContasPagar.Compra = compra;
                            ContasPagar.Despesa = despesa;
                            ContasPagar.Caixa = caixa;
                            ContasPagar.FormaPagamento = new Entidades.FormaPagamento();
                            ContasPagar.Comissao = new Entidades.Comissao();


                            listacontasPagars.Add(ContasPagar);

                        }
                        valorParcelasTotal += ContasPagar.Parcela * ContasPagar.ValorParcela;
                        mskValorTotoalPagar.Text = Convert.ToString(valorParcelasTotal);
                        mskValorTotoalPagar.Text = Convert.ToDouble(mskValorTotoalPagar.Text).ToString("###,###,##0.00");
                        carregaDGV(listacontasPagars);
                    }                        
                    else
                    {
                        MessageBox.Show("Data inválida.");
                    }


                    
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                //insere parcela manual
                
                double total = Convert.ToDouble(mskValorTotal.Text);
                double parcela = Convert.ToDouble(mskValorParcela.Text);
                parcela = Convert.ToDouble(parcela.ToString("#.##"));
                if(total >= somaValor(listacontasPagars) + parcela)
                {
                    ContasPagar = new Entidades.ContasPagar();
                    ContasPagar.ValorTotal = total;
                    ContasPagar.DataVencimento = dtpDataVencimento.Value;
                    ContasPagar.CodParcela = k + 1;
                    ContasPagar.ValorParcela = parcela;
                    ContasPagar.Status = false;
                    ContasPagar.Compra = compra;
                    ContasPagar.Despesa = despesa;
                    ContasPagar.Caixa = caixa;
                    ContasPagar.FormaPagamento = new Entidades.FormaPagamento();
                    ContasPagar.Comissao = new Entidades.Comissao();
                    listacontasPagars.Add(ContasPagar);
                    carregaDGV(listacontasPagars);
                    valorParcelasTotal = somaValor(listacontasPagars);
                    mskValorTotoalPagar.Text = Convert.ToString(valorParcelasTotal);
                    mskValorTotoalPagar.Text = Convert.ToDouble(mskValorTotoalPagar.Text).ToString("###,###,##0.00");
                }
                else
                {
                    MessageBox.Show("Valor ultrapassa o total");
                }
                               

            }
            

        }

        private double somaValor(List<Entidades.ContasPagar> lista)
        {
            double total = 0;
            for (int i = 0; i < lista.Count; i++)
                total += lista.ElementAt(i).ValorParcela;

            return total;
        }

        private void carregaDGV(List<Entidades.ContasPagar> list)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = list;
            dgvContas.DataSource = bd;
            dgvContas.Refresh();

        }

        private void ttbQtdeParcela_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valor= 0;
                int qtdPar = 0;

                if (!string.IsNullOrWhiteSpace(mskValorTotal.Text))
                    valor = Convert.ToDouble(mskValorTotal.Text);

                if (!string.IsNullOrWhiteSpace(ttbQtdeParcela.Text))
                    qtdPar = Convert.ToInt32(ttbQtdeParcela.Text);

                mskValorParcela.Text = Convert.ToString(valor / qtdPar); ;
                mskValorParcela.Text = Convert.ToDouble(mskValorParcela.Text).ToString("###,###,##0.00");

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resulta = MessageBox.Show("Deseja mesmo cancelar, se cancelar, uma conta será gerada automaticamente", "caption", MessageBoxButtons.YesNo);
            if (resulta == DialogResult.Yes)
            {
                cancelarClose();
                Close();
            }
        }

        private void mskValorTotal_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskValorTotal);
        }

        private void mskValorTotal_Leave(object sender, EventArgs e)
        {
            mskValorTotal.Text = Convert.ToDouble(mskValorTotal.Text).ToString("###,###,##0.00");
        }

        private void mskValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskValorTotal, e);
        }

        private void mskValorParcela_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskValorParcela);
        }

        private void mskValorParcela_Leave(object sender, EventArgs e)
        {
            mskValorParcela.Text = Convert.ToDouble(mskValorParcela.Text).ToString("###,###,##0.00");
        }

        private void mskValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskValorParcela, e);
        }

        private void cbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (cbManual.Checked)
            {
                mskValorParcela.Enabled = true;
                ttbQtdeParcela.Enabled = false;
            }
            else
            {
                mskValorParcela.Enabled = false;
                ttbQtdeParcela.Enabled = true;
            }
        }

        private void ttbQtdeParcela_Enter(object sender, EventArgs e)
        {
            mskValorTotal.Text = Convert.ToDouble(mskValorTotal.Text).ToString("###,###,##0.00");
        }

        private void GerarContaPagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(mskValorTotal.Text == "")
            {
                //sai fora
                Close();
            }
            else
            {
                MessageBox.Show("Uma conta a pagar foi gerada para a compra!");
                cancelarClose();
                Close();
            }
            
        }
    }
}
