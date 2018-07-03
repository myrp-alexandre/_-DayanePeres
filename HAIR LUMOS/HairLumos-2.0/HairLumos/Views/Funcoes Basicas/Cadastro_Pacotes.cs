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
    public partial class Cadastro_Pacotes : Form
    {
        int intCodPacote = 0;

        public Cadastro_Pacotes()
        {
            InitializeComponent();
            _inicializa();
            _limpaCampos();
            dgvPacote.AutoGenerateColumns = false;
            //pesquisaPacote();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbPacote.Enabled = false;
            mskValor.Enabled = false;
            ttbPeriodo.Enabled = false;
            ttbObs.Enabled = false;
            dgvPacote.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSair.Enabled = true;

            pesquisaPacote();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbPacote.Text = "";
            ttbPeriodo.Text = "";
            ttbObs.Text = "";
            mskValor.Text = "";
            
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbPacote.Enabled = true;
            mskValor.Enabled = true;
            ttbPeriodo.Enabled = true;
            ttbObs.Enabled = true;
            dgvPacote.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbPacote.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
            ttbPacote.Enabled = true;
            ttbPeriodo.Enabled = true;
            mskValor.Enabled = true;
            ttbObs.Enabled = true;
            dgvPacote.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbPacote.Focus();

        }

        public void carregaPacote(string strCod, string strPacote, string strvalor, string strobs, string strPeriodo)
        {
            ttbCodigo.Text = strCod;
            ttbPacote.Text = strPacote;
            ttbPeriodo.Text = strPeriodo;
            mskValor.Text = strvalor;
            ttbObs.Text = strobs;
        }

        public void carregaGrid()
        {
            Controller.PacoteController _CtrlPac = new Controller.PacoteController();
            DataTable dtRetorno = _CtrlPac.retornaPacote();

            if (dtRetorno != null && dtRetorno.Rows.Count > 0)
            {
                DataRow dr = dtRetorno.Rows[intCodPacote];
                this.carregaPacote(
                    dr["codpacote"].ToString(),
                    dr["pac_pacote"].ToString(),
                    dr["pac_valor"].ToString(),
                    dr["pac_obspacote"].ToString(),
                    dr["pac_periodicidade"].ToString());

            }
        }


        public void pesquisaPacote()
        {
            Controller.PacoteController _ctrPac = new Controller.PacoteController();

            DataTable dtRetorno = _ctrPac.retornaPacote();

            if (dtRetorno != null)
            {
                dgvPacote.DataSource = dtRetorno;
                dgvPacote.Columns["pac_obspacote"].Visible = false;
                dgvPacote.ClearSelection();

            }
            else
                dgvPacote.Rows.Clear();

        }

        public void selecionaPacote()
        {

            if (dgvPacote.Rows.Count > 0)
            {
                int intCod = 0;

                intCod = dgvPacote.CurrentRow.Index + 1;
                if (intCod > 0)
                {
                    this.intCodPacote = intCod;
                    ttbCodigo.Text = dgvPacote.CurrentRow.Cells[0].Value.ToString();
                    ttbPacote.Text = dgvPacote.CurrentRow.Cells[1].Value.ToString();
                    mskValor.Text = dgvPacote.CurrentRow.Cells[2].Value.ToString();
                    ttbObs.Text = dgvPacote.CurrentRow.Cells[3].Value.ToString();
                    ttbPeriodo.Text = dgvPacote.CurrentRow.Cells[4].Value.ToString();


                }
            }
        }

        private void Cadastro_Pacotes_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.PacoteController _ctrlPac = new Controller.PacoteController();

            string strMensagem = string.Empty;

            try
            {
                //validações
                int intCodigo = 0;
                if (intCodPacote != 0)
                {
                    if (!int.TryParse(ttbCodigo.Text, out intCodigo))
                        strMensagem += $"Código inválido{Environment.NewLine}";
                }


                if (string.IsNullOrWhiteSpace(ttbPacote.Text))
                    strMensagem += $"Informe o nome do pacote!.";

                if (string.IsNullOrWhiteSpace(mskValor.Text))
                    strMensagem += $"Informe o valor do pacote.";

                if (string.IsNullOrWhiteSpace(ttbPeriodo.Text))
                    strMensagem += $"Informe a periodicidade do pacote.";

                //verificar se houve alguma anormalidade no cadastro
                if (string.IsNullOrEmpty(strMensagem))
                {
                    double valorPacote = 0;
                    double.TryParse(mskValor.Text, out valorPacote);

                    int intRetorno = _ctrlPac.gravarPacote(intCodigo, ttbPacote.Text, valorPacote, ttbObs.Text, ttbPeriodo.Text);

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
            Controller.PacoteController _ctlPac = new Controller.PacoteController();

            int intCod = 0;

            int.TryParse(ttbCodigo.Text, out intCod);

            if (intCod > 0)
            {
                if (MessageBox.Show("Confirma exclusão do Pacote?", "Pacote", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool blnExcluiu = _ctlPac.excluirPacote(intCod);
                    if (blnExcluiu)
                    {
                        MessageBox.Show("Pacote Excluído.");
                        _limpaCampos();
                        pesquisaPacote();
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
            pesquisaPacote();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecionaPacote();
        }

        private void dgvPacote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecionaPacote();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }
    }
}
