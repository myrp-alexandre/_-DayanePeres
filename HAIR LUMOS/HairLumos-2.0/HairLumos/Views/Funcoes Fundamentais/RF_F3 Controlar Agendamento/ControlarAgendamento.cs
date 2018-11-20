using System;
using System.Data;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F2_Agendamento
{
    public partial class ControlarAgendamento : Form
    {
        private Controller.PessoaController pc = new Controller.PessoaController();
        private Controller.ServicoController sc = new Controller.ServicoController();
        private Controller.AgendaController ac = new Controller.AgendaController();
        private int codCliente = 0;
        private int codPres = 0;

        public ControlarAgendamento()
        {
            InitializeComponent();
            carregaServicos(0);
            
        }
        
        public ControlarAgendamento(int cod, string data, string hora)
        {
            InitializeComponent();
            carregaServicos(cod);
            dtpData.Value = Convert.ToDateTime(data);
            dtpHora.Value = Convert.ToDateTime(hora);
            DataTable dt = pc.retornaPessoaCod(cod + "");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ttbFuncionario.Text = dr["pes_nome"].ToString();
                codPres = Convert.ToInt32(dr["codpessoa"].ToString());
            }
        }
       

        private void carregaServicos(int cod)
        {
            DataTable dtServicos = sc.retornaServParc(cod);
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int codigo = codCliente;
            string status = "";
            if (rbAgendado.Checked)
                status = "Agendado";
            if (rbCancelado.Checked)
                status = "Cancelado";
            if (rbConfirmado.Checked)
                status = "Confirmado";
            if (rbNCompareceu.Checked)
                status = "Não Compareceu";
            int valor = 0;
            int comissao = 0;
            int fechamento = 0;
            int rest = ac.gravarAgenda(codigo, dtpData.Value, dtpHora.Value, status, valor, comissao, Convert.ToInt32(cbbServicos.SelectedValue), codPres, fechamento);

        }

        private void rbAgendado_CheckedChanged(object sender, EventArgs e)
        {
            rbCancelado.Checked = false;
            rbConfirmado.Checked = false;
            rbNCompareceu.Checked = false;
        }

        private void rbConfirmado_CheckedChanged(object sender, EventArgs e)
        {
            rbCancelado.Checked = false;
            rbAgendado.Checked = false;
            rbNCompareceu.Checked = false;
        }

        private void rbCancelado_CheckedChanged(object sender, EventArgs e)
        {
            rbAgendado.Checked = false;
            rbConfirmado.Checked = false;
            rbNCompareceu.Checked = false;
        }

        private void rbNCompareceu_CheckedChanged(object sender, EventArgs e)
        {
            rbCancelado.Checked = false;
            rbConfirmado.Checked = false;
            rbAgendado.Checked = false;
        }
    }
}
