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
    public partial class FrmComissao : Form
    {
        public FrmComissao()
        {
            InitializeComponent();
            carregaFuncionario();
        }

        private void carregaFuncionario()
        {
            Controller.PessoaController pc = new Controller.PessoaController();
            DataTable dtFuncionario = pc.retornaPessoaJuridica();
            cbbFuncionario.DataSource = dtFuncionario;
            cbbFuncionario.ValueMember = "codpessoa";
            cbbFuncionario.DisplayMember = "pes_nome";
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Controller.ComissaoController cc = new Controller.ComissaoController();
            CRComissao crcomis = new CRComissao();
            DSComissao ds = new DSComissao();
            //fazer busca de acordo com filtros
            int cod = Convert.ToInt32(cbbFuncionario.SelectedValue);
            if(dtpInicio.Value > dtpFim.Value && !dtpInicio.Value.ToString("dd-MM-yyyy").Equals(dtpFim.Value.ToString("dd-MM-yyyy")))
            {
                MessageBox.Show("Selecione uma data de inicio inferior a data final!");
            }
            else
            {
                dt = cc.retornaRelatorio(cod, dtpInicio.Value.ToString("dd-MM-yyyy"), dtpFim.Value.ToString("dd-MM-yyyy"));
                if (dt != null && dt.Rows.Count > 0)
                {
                    ds.DTComissao.Merge(dt);
                }
                else
                {
                    MessageBox.Show("Consulta não retornou dados.");
                }
                //liga cr no ds
                crcomis.SetDataSource(ds);
                FrmRelatorio tela = new FrmRelatorio();
                tela.visualizar(crcomis);

                tela.ShowDialog();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
