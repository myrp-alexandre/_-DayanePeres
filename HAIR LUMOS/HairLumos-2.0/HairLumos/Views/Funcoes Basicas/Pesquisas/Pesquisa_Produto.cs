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
    public partial class Pesquisa_Produto : Form
    {
        public int codProduto { get; set; }

        public Pesquisa_Produto()
        {
            InitializeComponent();
            dgvProduto.AutoGenerateColumns = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelecionaProduto()
        {
            if (dgvProduto.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvProduto.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);

                if (intCod > 0)
                {
                    this.codProduto = intCod;
                    this.Close();
                }
            }
        }


        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelecionaProduto();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.SelecionaProduto();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controller.ProdutoController  _prod = new Controller.ProdutoController();
            DataTable dtRetorno = _prod.retornaProduto(ttbDescricao.Text.Trim());

            if (dtRetorno != null)
            {
                dgvProduto.DataSource = dtRetorno;
                dgvProduto.ClearSelection();
            }
            else
                dgvProduto.Rows.Clear();
        }
    }
}
