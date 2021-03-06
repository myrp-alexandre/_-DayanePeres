﻿using System;
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

    public partial class QuitarDespesa : Form
    {
        private Controller.ContasPagarController contcon = new Controller.ContasPagarController();
        public int CodigoConta { get; set; }
        public int CodigoPrcela { get; set; }

        public QuitarDespesa()
        {
            InitializeComponent();
            dgvContas.AutoGenerateColumns = false;
            String datal = DateTime.Now.ToString("dd/MM/yyyy");
            string tipo = "";
            cbCompras.Checked = true;
            cbDespesas.Checked = false;
            if (cbCompras.Checked)
                tipo = "Compra";
            if (chbQuitadas.Checked)
                selecionaContas(Convert.ToDateTime(datal), Convert.ToDateTime(datal), false, tipo);
            else
                selecionaContas(Convert.ToDateTime(datal), Convert.ToDateTime(datal), true, tipo);

            atualizaCamposMoeda();
            DGVMoeda();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVMoeda()
        {

            if(dgvContas.Rows.Count > 0)
            {
                this.dgvContas.Columns["contpag_valortotal"].DefaultCellStyle.Format = "c";
                this.dgvContas.Columns["contPag_valorParcela"].DefaultCellStyle.Format = "c";
                this.dgvContas.Columns["contpag_valorpago"].DefaultCellStyle.Format = "c";
            }
            
        }

        private void atualizaCamposMoeda()
        {
            if (!string.IsNullOrWhiteSpace(ttbTotalPagar.Text))
                ttbTotalPagar.Text = Convert.ToDouble(ttbTotalPagar.Text).ToString("###,###,##0.00");
            if (!string.IsNullOrWhiteSpace(ttbTotalPago.Text))
                ttbTotalPago.Text = Convert.ToDouble(ttbTotalPago.Text).ToString("###,###,##0.00");
            if (!string.IsNullOrWhiteSpace(ttbTotalVencido.Text))
                ttbTotalVencido.Text = Convert.ToDouble(ttbTotalVencido.Text).ToString("###,###,##0.00");

            DGVMoeda();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if(dtpInicio.Value >= dtpFim.Value)
            {
                MessageBox.Show("A data inicial deve ser menor que a final!");
            }
            else
            {
                string tipo = "";
                if (cbCompras.Checked)
                    tipo = "Compra";
                if (chbQuitadas.Checked)
                    selecionaContas(dtpInicio.Value, dtpFim.Value,false, tipo);
                else
                    selecionaContas(dtpInicio.Value, dtpFim.Value, true, tipo);

                atualizaCamposMoeda();
            }
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInicio.Value > dtpFim.Value)
            {
                MessageBox.Show("A data final deve ser maior que a inicial!");
            }
            else
            {
                string tipo = "";
                if (cbCompras.Checked)
                    tipo = "Compra";
                if(chbQuitadas.Checked)
                    selecionaContas(dtpInicio.Value, dtpFim.Value, false, tipo);
                else
                    selecionaContas(dtpInicio.Value, dtpFim.Value, true, tipo);

                atualizaCamposMoeda();
            }
        }

        private void selecionaContas(DateTime datai, DateTime dataf, bool estado, string tipo)
        {
            DataTable dtContas = contcon.retornaPeriodo(datai, dataf, estado,tipo);
            if(dtContas!=null && dtContas.Rows.Count > 0)
            {
                DataRow dr = dtContas.Rows[0];
                int cod = Convert.ToInt32(dr["codContasPagar"].ToString());
                carregaDGV(dtContas);
                ttbTotalPagar.Text = somavalorTotal(dtContas) + "";
                ttbTotalPago.Text = somavalorPago(dtContas) + "";
                ttbTotalVencido.Text = somavalorVencido(dtContas) + "";
            }

        }

        private void carregaDGV(DataTable dt)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = dt;
            dgvContas.DataSource = bd;
            dgvContas.Refresh();
        }

        private double somavalorTotal(DataTable dt)
        {
            double total = 0;
            for(int i =0; i<dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                total += Convert.ToDouble(dr["contPag_valorParcela"].ToString());
            }
            return total;
        }

        private double somavalorPago(DataTable dt)
        {
            double total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if(Convert.ToDouble(dr["contpag_valorpago"].ToString())>0)
                    total += Convert.ToDouble(dr["contpag_valorpago"].ToString());
            }
            return total;
        }

        private double somavalorVencido(DataTable dt)
        {
            double total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (Convert.ToDateTime(dr["contpag_datavencimento"].ToString()) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    total+= Convert.ToDouble(dr["contPag_valorParcela"].ToString())- Convert.ToDouble(dr["contpag_valorpago"].ToString());
                }
            }
            return total;
        }        
        private void ttbTotalPagar_Enter_1(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(ttbTotalPagar);
        }

        private void ttbTotalPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(ttbTotalPagar, e);

        }

        private void ttbTotalPagar_Leave(object sender, EventArgs e)
        {
            ttbTotalPagar.Text = Convert.ToDouble(ttbTotalPagar.Text).ToString("###,###,##0.00");
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

        private void chbQuitadas_CheckedChanged(object sender, EventArgs e)
        {
            if (dtpInicio.Value > dtpFim.Value && !dtpInicio.Value.ToString("dd-MM-yyyy").Equals(dtpFim.Value.ToString("dd-MM-yyyy")))
            {
                MessageBox.Show("A data final deve ser maior que a inicial!");
            }
            else
            {
                string tipo = "";
                if (cbCompras.Checked)
                    tipo = "Compra";
                if (chbQuitadas.Checked)
                    selecionaContas(dtpInicio.Value, dtpFim.Value, false, tipo);
                else
                    selecionaContas(dtpInicio.Value, dtpFim.Value, true, tipo);

                atualizaCamposMoeda();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int intCod = 0;
            int.TryParse(dgvContas.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);
            this.CodigoConta = intCod;
            int intCodP = 0;
            int.TryParse(dgvContas.CurrentRow.Cells[3].FormattedValue.ToString(), out intCodP);
            this.CodigoPrcela = intCodP;

            if (this.CodigoConta > 0 && this.CodigoPrcela>0)
            {
                Views.Funcoes_Fundamentais.RF_F10___Quitar_Despesa.PagarDespesa pagar = new RF_F10___Quitar_Despesa.PagarDespesa(this.CodigoConta, this.CodigoPrcela);
                pagar.ShowDialog();

                string tipo = "";
                if (cbCompras.Checked)
                    tipo = "Compra";
                if (chbQuitadas.Checked)
                    selecionaContas(dtpInicio.Value, dtpFim.Value, false, tipo);
                else
                    selecionaContas(dtpInicio.Value, dtpFim.Value, true, tipo);
            }
            else
            {
                MessageBox.Show("Selecione uma conta para quitar!");
            }

        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            Controller.ContasPagarController cc = new Controller.ContasPagarController();
            int intCod = 0;
            int.TryParse(dgvContas.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);
            int intCodP = 0;
            int.TryParse(dgvContas.CurrentRow.Cells[3].FormattedValue.ToString(), out intCodP);
            double valTotal = 0, pago = 0;
            valTotal = Convert.ToDouble(dgvContas.CurrentRow.Cells[5].Value.ToString());
            pago = Convert.ToDouble(dgvContas.CurrentRow.Cells[6].Value.ToString());

            if (pago > 0 )
            {
                DialogResult resulta = MessageBox.Show("Deseja realmente fazer o estorno", "caption", MessageBoxButtons.YesNo);
                if (resulta == DialogResult.Yes)
                {
                    Entidades.ContasPagar cp = new Entidades.ContasPagar();
                    Entidades.Caixa caixa = new Entidades.Caixa();
                    Entidades.FormaPagamento forma = new Entidades.FormaPagamento();
                    cp.CodigoContasaPagar = intCod;
                    cp.CodParcela = intCodP;
                    cp.ValorPago = 0;
                    cp.DataPagamento = DateTime.MinValue;
                    cp.Status = false;
                    cp.FormaPagamento = forma;
                    caixa.CodCaixa = 1;
                    cp.Caixa = caixa;
                    int rest = cc.pagaConta(cp);
                    if (rest > 0)
                    {
                        MessageBox.Show("Valor Estornado com sucesso!");
                        string tipo = "";
                        if (cbCompras.Checked)
                            tipo = "Compra";
                        if (chbQuitadas.Checked)
                            selecionaContas(dtpInicio.Value, dtpFim.Value, false, tipo);
                        else
                            selecionaContas(dtpInicio.Value, dtpFim.Value, true, tipo);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao extornar valor!");
                    }

                    atualizaCamposMoeda();

                }
            }
            else
            {
                MessageBox.Show("Selecione uma parcela onde ja teve um valor pago!");
            }
            
        }

        public void limpaCampos()
        {
            dtpInicio.Value = DateTime.Now;
            dtpFim.Value = DateTime.Now;
            chbQuitadas.Checked = false;
            dgvContas.DataSource = null;
            ttbTotalPagar.Text = "00,00";
            ttbTotalPago.Text = "00,00";
            ttbTotalVencido.Text = "00,00";
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            atualizaCamposMoeda();
            BtnCancelar.Enabled = false;
            btnSair.Enabled = true;
        }

        private void cbCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCompras.Checked)
                cbDespesas.Checked = false;

            string tipo = "";
            if (cbCompras.Checked)
                tipo = "Compra";
            if (chbQuitadas.Checked)
                selecionaContas(dtpInicio.Value, dtpFim.Value, false, tipo);
            else
                selecionaContas(dtpInicio.Value, dtpFim.Value, true, tipo);
        }

        private void cbDespesas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDespesas.Checked)
                cbCompras.Checked = false;

            string tipo = "";
            if (cbCompras.Checked)
                tipo = "Compra";
            if (chbQuitadas.Checked)
                selecionaContas(dtpInicio.Value, dtpFim.Value, false, tipo);
            else
                selecionaContas(dtpInicio.Value, dtpFim.Value, true, tipo);
        }
    }
}
