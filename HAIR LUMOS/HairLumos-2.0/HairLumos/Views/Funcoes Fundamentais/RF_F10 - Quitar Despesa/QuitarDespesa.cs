using System;
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

        public QuitarDespesa()
        {
            InitializeComponent();
            dgvContas.AutoGenerateColumns = false;
            String datal = DateTime.Now.ToString("dd/MM/yyyy");
            selecionaContas(Convert.ToDateTime(datal), Convert.ToDateTime(datal));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if(dtpInicio.Value > dtpFim.Value)
            {
                MessageBox.Show("A data inicial deve ser menor que a final!");
            }
            else
            {
                selecionaContas(dtpInicio.Value, dtpFim.Value);
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
                selecionaContas(dtpInicio.Value, dtpFim.Value);
            }
        }

        private void selecionaContas(DateTime datai, DateTime dataf)
        {
            DataTable dtContas = contcon.retornaPeriodo(datai, dataf);
            if(dtContas!=null && dtContas.Rows.Count > 0)
            {
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

        private void DGVMoeda()
        {
            this.dgvContas.Columns["contpag_valortotal"].DefaultCellStyle.Format = "c";
            this.dgvContas.Columns["contPag_valorParcela"].DefaultCellStyle.Format = "c";
            this.dgvContas.Columns["contpag_valorpago"].DefaultCellStyle.Format = "c";
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
    }
}
