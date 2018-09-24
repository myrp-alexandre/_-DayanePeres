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
        public QuitarContasReceber()
        {
            InitializeComponent();
            _inicializa();
        }

        private void _inicializa()
        {
            ttbNomeCliente.Text = "";
            cbbEmAberto.Checked = true;
            cbbPago.Checked = false;
            cbbVencido.Checked = true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
