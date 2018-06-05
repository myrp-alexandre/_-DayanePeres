using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views
{
    public partial class Cadastro_Servico : Form
    {
        int intCodServico = 0;

        public Cadastro_Servico()
        {
            InitializeComponent();
            _inicializa();
            _limpaCampos();
            dgvServico.AutoGenerateColumns = false;
            pesquisaServico();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbServico.Enabled = false;
            ttbObservacao.Enabled = false;
            mskTempoServiço.Enabled = false;
            mskValor.Enabled = false;
            dgvServico.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSair.Enabled = true;

            pesquisaServico();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbServico.Text = "";
            ttbObservacao.Text = "";
            mskTempoServiço.Text = "";
            mskValor.Text = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbServico.Enabled = true;
            ttbObservacao.Enabled = true;
            mskTempoServiço.Enabled = true;
            mskValor.Enabled = true;
            dgvServico.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbServico.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
            ttbServico.Enabled = true;
            ttbObservacao.Enabled = true;
            mskTempoServiço.Enabled = true;
            mskValor.Enabled = true;
            dgvServico.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbServico.Focus();

        }

        public void carregaServico(string strCod, string strServico, string strobs, string strvalor, string strtempo)
        {
            ttbCodigo.Text = strCod;
            ttbServico.Text = strServico;
            ttbObservacao.Text = strobs;
            mskTempoServiço.Text = strtempo;
            mskValor.Text = strvalor;
        }

        public void carregaGrid()
        {
            Controller.PagamentoController _ctlFormaPag = new Controller.PagamentoController();
            DataTable dtRetorno = _ctlFormaPag.retornaFormaPagamento();

            if (dtRetorno != null && dtRetorno.Rows.Count > 0)
            {
                DataRow dr = dtRetorno.Rows[intCodServico];
                this.carregaServico(
                    dr["codservico"].ToString(),
                    dr["serv_servico"].ToString(),
                    dr["serv_valorservico"].ToString(),
                    dr["serv_temposervico"].ToString(),
                    dr["serv_obsservico"].ToString());

            }
        }


        public void pesquisaServico()
        {
            Controller.ServicoController _ctrlServ= new Controller.ServicoController();

            DataTable dtRetorno = _ctrlServ.retornaServico();

            if (dtRetorno != null)
            {
                dgvServico.DataSource = dtRetorno;
                dgvServico.Columns["serv_obsservico"].Visible = false;
                dgvServico.ClearSelection();
                
            }
            else
                dgvServico.Rows.Clear();

        }

        public void selecionaServico()
        {

            if (dgvServico.Rows.Count > 0)
            {
                int intCod = 0;

                intCod = dgvServico.CurrentRow.Index + 1;
                if (intCod > 0)
                {
                    this.intCodServico = intCod;
                    ttbCodigo.Text = dgvServico.CurrentRow.Cells[0].Value.ToString();
                    ttbServico.Text = dgvServico.CurrentRow.Cells[1].Value.ToString();
                    mskValor.Text = dgvServico.CurrentRow.Cells[2].Value.ToString();
                    mskTempoServiço.Text = dgvServico.CurrentRow.Cells[3].Value.ToString();
                    ttbObservacao.Text = dgvServico.CurrentRow.Cells[4].Value.ToString();


                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.ServicoController _ctrlServ = new Controller.ServicoController();

            string strMensagem = string.Empty;

            try
            {
                //validações
                int intCodigo = 0;
                if (intCodServico != 0)
                {
                    if (!int.TryParse(ttbCodigo.Text, out intCodigo))
                        strMensagem += $"Código inválido{Environment.NewLine}";
                }


                if (string.IsNullOrWhiteSpace(ttbServico.Text))
                    strMensagem += $"Informe o nome do serviço!.";

                if (string.IsNullOrWhiteSpace(mskValor.Text))
                    strMensagem += $"Informe o tempo estimado do serviço!.";

                //verificar se houve alguma anormalidade no cadastro
                if (string.IsNullOrEmpty(strMensagem))
                {
                    double valorServico = 0;
                    double.TryParse(mskValor.Text, out valorServico);
                    int intRetorno = _ctrlServ.gravaServico(intCodigo, ttbServico.Text, valorServico, mskTempoServiço.Text, ttbObservacao.Text);

                    if (intRetorno == 1)
                    {
                        MessageBox.Show("Gravado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Gravar.");
                    }
                    _limpaCampos();
                    _inicializa();
                }
                else
                    MessageBox.Show(strMensagem, "Aviso!!");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex + "");
            }
        }

        private void dgvServico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecionaServico();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecionaServico();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _btnAlterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controller.ServicoController _ctlServ = new Controller.ServicoController();

            int intCod = 0;

            int.TryParse(ttbCodigo.Text, out intCod);

            if (intCod > 0)
            {
                if (MessageBox.Show("Confirma exclusão da Marca?", "Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool blnExcluiu = _ctlServ.excluirServico(intCod);
                    if (blnExcluiu)
                    {
                        MessageBox.Show("Servico Excluído.");
                        _limpaCampos();
                        pesquisaServico();
                        _inicializa();
                    }
                    else
                        MessageBox.Show("Erro ao excluir!");
                }
                else
                {
                    MessageBox.Show("Cancela ?");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            pesquisaServico();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastro_Servico_Load(object sender, EventArgs e)
        {

        }
    }
}
