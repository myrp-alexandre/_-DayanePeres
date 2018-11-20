using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F15_Acerto_de_Consignado
{
    public partial class AcertoConsignado : Form
    {
        public AcertoConsignado()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mskTotalPedidos_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotalPedidos);
        }

        private void mskTotalPedidos_Leave(object sender, EventArgs e)
        {
            mskTotalPedidos.Text = Convert.ToDouble(mskTotalPedidos.Text).ToString("###,###,##0.00");
        }

        private void mskTotalPedidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotalPedidos, e);
        }

        private void mskTotalCompradosVendidos_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotalCompradosVendidos);
        }

        private void mskTotalCompradosVendidos_Leave(object sender, EventArgs e)
        {
            mskTotalCompradosVendidos.Text = Convert.ToDouble(mskTotalCompradosVendidos.Text).ToString("###,###,##0.00");
        }

        private void mskTotalCompradosVendidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotalCompradosVendidos, e);
        }


        private void mskTotalDevolvidos_Leave(object sender, EventArgs e)
        {
            mskTotalDevolvidos.Text = Convert.ToDouble(mskTotalDevolvidos.Text).ToString("###,###,##0.00");
        }

        private void mskTotalDevolvidos_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotalDevolvidos);
        }

        private void mskTotalDevolvidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotalDevolvidos, e);
        }
    }
}
