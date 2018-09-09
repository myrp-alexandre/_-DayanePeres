using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F14_Contratar_Pacotes
{
    public partial class ContratarPacotes : Form
    {
        public ContratarPacotes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            Views.Pesquisa_Pessoa pesquisa_Pessoa = new Pesquisa_Pessoa();

            pesquisa_Pessoa.ShowDialog();

            Controller.PessoaController pessoaController = new Controller.PessoaController();
            DataTable dtRetorno = pessoaController.retornaPessoaFisica();

                if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                {
                    DataRow dr = dtRetorno.Rows[0];
                    ttbCliente.Text = dr["pes_nome"].ToString();

                }
            
        }

       
    }
}
