using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F13_Baixar_Estoque_Manual
{
    public partial class Pesquisa_BaixaEstoque : Form
    {
        public int intCodBaixa { get; set; }

        public Pesquisa_BaixaEstoque()
        {
            InitializeComponent();
            dgvPacote.AutoGenerateColumns = false;
        }

        private void Pesquisa_BaixaEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = 0; 

                Controller.ProdutoController produtoController = new Controller.ProdutoController();
                DataTable dtRetorno = produtoController.retornabaixaManual(cod);

                if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                {
                    //dgvPacote.DataSource = dtRetorno;
                    //dgvPacote.ClearSelection();

                    BindingSource bd = new BindingSource();
                    bd.DataSource = dtRetorno;
                    dgvPacote.DataSource = bd;
                    dgvPacote.Refresh();
                }
                else
                    dgvPacote.Rows.Clear();
            }
            catch (Exception)
            {

                throw;
            }
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
                    this.intCodBaixa = intCod;
                    this.Close();
                }
            }
        }

        private void dgvPacote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionaPacote();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
