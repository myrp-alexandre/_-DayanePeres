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
        public GerenciarComissao()
        {
            InitializeComponent();
        }

        // Converte campo da grid em valor moeda
        private void DGVMoeda()
        {
            // 1ª grid
            this.dgvComissaoListadas.Columns["Valor"].DefaultCellStyle.Format = "c";


            //2ª grid
            this.dtvParceirosSelecionados.Columns["Valor"].DefaultCellStyle.Format = "c";
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
    }
}
