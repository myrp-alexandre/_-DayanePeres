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

        public QuitarContasReceber()
        {
            InitializeComponent();
            _inicializa();
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

        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {

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

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            if(dtpDataDe.Value <= dtpDataAte.Value)
            {
                string situacao = "";
                if (cbbPago.Checked)
                    situacao = "Pago";
                if (cbbVencido.Checked)
                    situacao = "Vencido";
                if (cbbEmAberto.Checked)
                    situacao = "Em aberto";
                DataTable dt = crc.retornaContasReceber(dtpDataDe.Value, dtpDataDe.Value, situacao);
                if(dt!=null && dt.Rows.Count > 0)
                {
                    carregaDGV(dt);
                }

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
