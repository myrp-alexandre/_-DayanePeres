using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F5___Gerenciar_Compras
{
    public partial class PesquisarCompras : Form
    {
        public int codCompra { get; set; }

        Controller.CompraController cc = new Controller.CompraController();

        public PesquisarCompras()
        {
            InitializeComponent();
            dgvCompras.AutoGenerateColumns = false;
            //DGVMoeda();
        }

        private void DGVMoeda()
        {
            if(dgvCompras.Rows.Count > 0)
                this.dgvCompras.Columns["comp_valortotal"].DefaultCellStyle.Format = "c";
        }

        private void dgvCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionaCompra();
        }

        private void selecionaCompra()
        {
            if (dgvCompras.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvCompras.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);

                if (intCod > 0)
                {
                    this.codCompra = intCod;
                    this.Close();
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.selecionaCompra();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cc.retornaCompra();
            if (dt != null && dt.Rows.Count > 0)
            {
                BindingSource bd = new BindingSource();
                bd.DataSource = dt;
                dgvCompras.DataSource = bd;
                dgvCompras.Refresh();
                //DGVMoeda();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
