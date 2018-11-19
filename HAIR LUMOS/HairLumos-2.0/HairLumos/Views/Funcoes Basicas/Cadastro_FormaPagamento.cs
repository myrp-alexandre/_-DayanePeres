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
    public partial class Cadastro_FormaPagamento : Form
    {
        int intcodForma = 0;

        public Cadastro_FormaPagamento()
        {
            InitializeComponent();
            _inicializa();
            _limpaCampos();
            dgvFormaPagamento.AutoGenerateColumns = false;
            pesquisaFormaPagamento();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbForma.Enabled = false;
            dgvFormaPagamento.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSair.Enabled = true;

            pesquisaFormaPagamento();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbForma.Text = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbForma.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbForma.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
            ttbForma.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbForma.Focus();

        }

        public void carregaFormaPagamento(string strCod, string StrMarca)
        {
            ttbCodigo.Text = strCod;
            ttbForma.Text = StrMarca;
        }

        public void carregaGrid()
        {
            Controller.PagamentoController _ctlFormaPag = new Controller.PagamentoController();
            DataTable dtRetorno = _ctlFormaPag.retornaFormaPagamento();

            if (dtRetorno != null && dtRetorno.Rows.Count > 0)
            {
                DataRow dr = dtRetorno.Rows[intcodForma];
                this.carregaFormaPagamento(
                    dr["codformapag"].ToString(),
                    dr["formpag_descricao"].ToString());

            }
        }

       
        public void pesquisaFormaPagamento()
        {
            Controller.PagamentoController _ctrlFormaPag= new Controller.PagamentoController();

            DataTable dtRetorno = _ctrlFormaPag.retornaFormaPagamento();

            if (dtRetorno != null)
            {
                dgvFormaPagamento.DataSource = dtRetorno;
                dgvFormaPagamento.ClearSelection();
            }
            else
                dgvFormaPagamento.Rows.Clear();

        }

        public void selecionaFormaPagamento()
        {

            if (dgvFormaPagamento.Rows.Count > 0)
            {
                int intCod = 0;

                intCod = dgvFormaPagamento.CurrentRow.Index + 1;
                if (intCod > 0)
                {
                    this.intcodForma = intCod;
                    ttbCodigo.Text = dgvFormaPagamento.CurrentRow.Cells[0].Value.ToString();
                    ttbForma.Text = dgvFormaPagamento.CurrentRow.Cells[1].Value.ToString();

                    
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.PagamentoController _ctrlFormaPag = new Controller.PagamentoController();

            string strMensagem = string.Empty;

            try
            {
                //validações
                int intCodigo = 0;
                if (intcodForma != 0)
                {
                    if (!int.TryParse(ttbCodigo.Text, out intCodigo))
                        strMensagem += $"Código inválido{Environment.NewLine}";
                }


                if (string.IsNullOrWhiteSpace(ttbForma.Text))
                    strMensagem += $"Informe a Forma de Pagamento.";

                //verificar se houve alguma anormalidade no cadastro
                if (string.IsNullOrEmpty(strMensagem))
                {

                    int intRetorno = _ctrlFormaPag.gravaFormaPagamento(intCodigo, ttbForma.Text);

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _btnAlterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controller.PagamentoController _ctlFormaPag = new Controller.PagamentoController();

            int intCod = 0;

            int.TryParse(ttbCodigo.Text, out intCod);

            if (intCod > 0)
            {
                if (MessageBox.Show("Confirma exclusão da Forma de Pagamento?", "Forma de Pagamento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool blnExcluiu = _ctlFormaPag.excluirFormaPagamento(intCod);
                    if (blnExcluiu)
                    {
                        MessageBox.Show("Forma de Pagamento Excluída");
                        _limpaCampos();
                        pesquisaFormaPagamento();
                        _btnNovo();
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
            pesquisaFormaPagamento();
        }

       
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecionaFormaPagamento();
        }

        private void dgvFormaPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecionaFormaPagamento();
        }
    }
}
