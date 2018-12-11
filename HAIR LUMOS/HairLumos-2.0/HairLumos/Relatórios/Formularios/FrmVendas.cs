using HairLumos.Relatórios.CrystalReport;
using HairLumos.Relatórios.DataSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Relatórios.Formularios
{
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
            cbTodas.Checked = true;
        }

        private void cbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodas.Checked)
                cbQuitadas.Checked = false;
        }

        private void cbQuitadas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQuitadas.Checked)
                cbTodas.Checked = false;
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Controller.VendaController vc = new Controller.VendaController();
            CRVendas crcompra = new CRVendas();
            DataSet1 ds = new DataSet1();
            //fazer busca de acordo com filtros
            if (dtpInicio.Value > dtpFim.Value && !dtpInicio.Value.ToString("dd-MM-yyyy").Equals(dtpFim.Value.ToString("dd-MM-yyyy")))
            {
                MessageBox.Show("Selecione uma data de inicio inferior a data final!");
            }
            else
            {
                bool estado = false;
                if (cbTodas.Checked)
                    estado = true;
                dt = vc.retornaRelatorio(dtpInicio.Value.ToString("dd-MM-yyyy"), dtpFim.Value.ToString("dd-MM-yyyy"), estado);
                if (dt != null && dt.Rows.Count > 0)
                {
                    ds.DTVendas.Merge(dt);
                }
                else
                {
                    MessageBox.Show("Consulta não retornou dados.");
                }
                //liga cr no ds
                crcompra.SetDataSource(ds);
                FrmRelatorio tela = new FrmRelatorio();
                tela.visualizar(crcompra);

                tela.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
