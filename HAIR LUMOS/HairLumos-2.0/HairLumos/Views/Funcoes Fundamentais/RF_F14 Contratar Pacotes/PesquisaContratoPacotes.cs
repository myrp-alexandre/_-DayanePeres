using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F14_Contratar_Pacotes
{
    public partial class PesquisaContratoPacotes : Form
    {
        public int inCodContrato { get; set; }

        public PesquisaContratoPacotes()
        {
            InitializeComponent();
            dgvPacote.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controller.PacoteController pacoteController = new Controller.PacoteController();
            DataTable dtRetorno = pacoteController.retornaContratoServicos();

            if (dtRetorno != null && dtRetorno.Rows.Count > 0)
            {
                dgvPacote.DataSource = dtRetorno;
                dgvPacote.ClearSelection();
            }
            else
                dgvPacote.Rows.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.selecionaPacote();
        }

        private void selecionaPacote()
        {
            if (dgvPacote.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvPacote.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);

                if (intCod > 0)
                {
                    this.inCodContrato = intCod;
                    this.Close();
                }
            }
        }

        private void dgvPacote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionaPacote();
        }
    }
}
