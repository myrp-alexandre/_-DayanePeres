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
    public partial class FrmPessoa : Form
    {
        public FrmPessoa()
        {
            InitializeComponent();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Controller.PessoaController pc = new Controller.PessoaController();
            CRPessoarpt crpes = new CRPessoarpt();
            DSCliente ds = new DSCliente();
            dt = pc.retornaPessoa(ttbNome.Text);
            if (dt != null && dt.Rows.Count > 0)
            {
                ds.DTCliente.Merge(dt);
            }
            else
            {
                MessageBox.Show("Consulta não retornou dados.");
            }


            //liga cr no ds
            crpes.SetDataSource(ds);
            FrmRelatorio tela = new FrmRelatorio();
            tela.visualizar(crpes);

            tela.ShowDialog();
        }
    }
}
