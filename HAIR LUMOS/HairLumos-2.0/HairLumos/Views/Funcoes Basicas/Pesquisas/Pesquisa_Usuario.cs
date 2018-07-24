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
    public partial class Pesquisa_Usuario : Form
    {
        public int intCodigoPessoa { get; set; }

        public Pesquisa_Usuario()
        {
            InitializeComponent();
            dgvUsuário.AutoGenerateColumns = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controller.UsuarioController _user = new Controller.UsuarioController();
            DataTable dtRetorno = _user.retornaPessoa(ttbDescricao.Text.Trim());

            if (dtRetorno != null)
            {
                dgvUsuário.DataSource = dtRetorno;
                dgvUsuário.ClearSelection();
            }
            else
                dgvUsuário.Rows.Clear();
        }

        private void SelecionaPessoa()
        {
            if (dgvUsuário.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvUsuário.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);

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

        private void dgvUsuário_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelecionaPessoa();
        }
    }
}
