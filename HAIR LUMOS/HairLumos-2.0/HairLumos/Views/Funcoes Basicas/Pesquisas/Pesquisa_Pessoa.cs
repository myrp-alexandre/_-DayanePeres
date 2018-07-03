using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views
{
    public partial class Pesquisa_Pessoa : Form
    {
        public int intCodigoPessoa { get; set; }

        public Pesquisa_Pessoa()
        {
            InitializeComponent();
            dgvPessoa.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controller.PessoaController _pes = new Controller.PessoaController();
            DataTable dtRetorno =  _pes.retornaPessoa(ttbDescricao.Text.Trim());

            if (dtRetorno != null)
            {
                dgvPessoa.DataSource = dtRetorno;
                dgvPessoa.ClearSelection();
            }
            else
                dgvPessoa.Rows.Clear();
        }

        private void SelecionaPessoa()
        {
            if (dgvPessoa.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvPessoa.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);

                if (intCod > 0)
                {
                    this.intCodigoPessoa = intCod;
                    this.Close();
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.SelecionaPessoa();
        }

        private void dgvPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelecionaPessoa();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


