using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F9___Lançar_Despesa
{
    public partial class Pesquisa_LançarDespesa : Form
    {
        public int intCodDespesa { get; set; }
        public DateTime data { get; set; }

        public Pesquisa_LançarDespesa()
        {
            InitializeComponent();
            dgvDespesa.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controller.ContasPagarController contasPagarController = new Controller.ContasPagarController();
            DataTable dt = contasPagarController.retornaDespesaL();

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvDespesa.DataSource = dt;
                dgvDespesa.ClearSelection();
            }
            else
                dgvDespesa.Rows.Clear();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.selecionaDespesa();
        }

        private void selecionaDespesa()
        {
            if (dgvDespesa.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvDespesa.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);
                DateTime datas = Convert.ToDateTime(dgvDespesa.CurrentRow.Cells[2].FormattedValue.ToString());
                if (intCod > 0)
                {
                    this.intCodDespesa = intCod;
                    this.data = datas;
                    this.Close();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDespesa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionaDespesa();
        }
    }
}
