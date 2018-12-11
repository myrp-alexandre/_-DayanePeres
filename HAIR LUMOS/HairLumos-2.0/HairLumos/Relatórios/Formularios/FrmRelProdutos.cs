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
    public partial class FrmRelProdutos : Form
    {
        public FrmRelProdutos()
        {
            InitializeComponent();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Controller.ProdutoController pc = new Controller.ProdutoController();
            CRProdutos cRProdutos = new CRProdutos();
            DSProdutos ds = new DSProdutos();
            dt = pc.retornaEstoque(ttbDescricao.Text);
            if(dt!=null && dt.Rows.Count > 0)
            {
                ds.DTProdutos.Merge(dt);
            }
            else
            {
                MessageBox.Show("Consulta não retornou dados.");
            }
            

            //liga cr no ds
            cRProdutos.SetDataSource(ds);
            FrmRelatorio tela = new FrmRelatorio();
            tela.visualizar(cRProdutos);

            tela.ShowDialog();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
