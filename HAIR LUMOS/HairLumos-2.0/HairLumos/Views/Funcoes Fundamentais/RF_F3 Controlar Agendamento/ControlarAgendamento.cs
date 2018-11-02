using System;
using System.Data;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F2_Agendamento
{
    public partial class Agenda : Form
    {
        private Controller.PessoaController pc = new Controller.PessoaController();
        private Controller.ServicoController sc = new Controller.ServicoController();
        private int codCliente = 0;
        public Agenda()
        {
            InitializeComponent();
            carregaServicos();
        }

       

        private void carregaServicos()
        {
            DataTable dtServicos = sc.retornaServico();
            cbbServicos.DataSource = dtServicos;
            cbbServicos.ValueMember = "codtiposervico";
            cbbServicos.DisplayMember = "tiposerv_descricao";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa pesquisa_Pessoa = new Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa();
            pesquisa_Pessoa.ShowDialog();

            int codigo = pesquisa_Pessoa.intCodigoPessoa;
            if (codigo > 0)
            {
                DataTable dtPessoa = pc.retornaPessoaCod(codigo+"");
                if(dtPessoa!=null && dtPessoa.Rows.Count > 0)
                {
                    DataRow drPessoa = dtPessoa.Rows[0];
                    codCliente = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                    ttbNomeCliente.Text = drPessoa["pes_nome"].ToString();
                    mskTelefone.Text = drPessoa["pes_fone"].ToString();
                }
            }
        }
    }
}
