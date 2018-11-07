using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Basicas.Pesquisas
{
    public partial class Pesquisa_ServicoParceiro : Form
    {
        
        public int intCodprestador { get; set; }

        public Pesquisa_ServicoParceiro()
        {
            
            InitializeComponent();
            carregacbb();
            dgvPessoa.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controller.ServicoParceiroController spc = new Controller.ServicoParceiroController();
            int codigo = Convert.ToInt32(cbPrestadorServico.SelectedValue);
            DataTable dt = spc.retornaPrestador();
            dgvPessoa.DataSource = dt;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carregacbb()
        {
            Controller.ServicoParceiroController spc = new Controller.ServicoParceiroController();
            DataTable dt = spc.retornaPrestador();
            cbPrestadorServico.DataSource = dt;
            cbPrestadorServico.ValueMember = "codpessoa";
            cbPrestadorServico.DisplayMember = "pes_nome";
        }

        private void dgvPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _selecionar();
        }

        private void _selecionar()
        {
            if (dgvPessoa.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvPessoa.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);

                if (intCod > 0)
                {
                    this.intCodprestador = intCod;
                    this.Close();
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            _selecionar();
        }
    }
}
