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
    public partial class Cadastro_TipoDespesa : Form
    {
        private int intCodDespesa = 0;

        public Cadastro_TipoDespesa()
        {
            InitializeComponent();

            _inicializa();
            _limpaCampos();
            dgvDespesa.AutoGenerateColumns = false;
            pesquisaDespesa();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbDescricao.Enabled = false;
            dgvDespesa.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSair.Enabled = true;

            pesquisaDespesa();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbDescricao.Text = "";
            rbFixa.Checked = true;
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbDescricao.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbDescricao.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
            ttbDescricao.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbDescricao.Focus();

        }

        public void carregaDespesaTela(string strCod, string Strdescricao, string strStatus)
        {
            ttbCodigo.Text = strCod;
            ttbDescricao.Text = Strdescricao;

            if (strStatus.Equals("FIXA"))
            {
                rbFixa.Checked = true;
            }
            if (strStatus.Equals("VARIAVEL"))
            {
                rbVariavel.Checked = true;
            }
        }

        public void carregaGrid(string texto)
        {
            Controller.DespesaController _ctrlDesp = new Controller.DespesaController();
            DataTable dtRetorno = _ctrlDesp.retronaDespesa();

            if (dtRetorno != null && dtRetorno.Rows.Count > 0)
            {
                DataRow dr = dtRetorno.Rows[intCodDespesa];
                this.carregaDespesaTela(
                    dr["coddespesa"].ToString(),
                    dr["desp_descricao"].ToString(),
                    dr["desp_status"].ToString());
            }
        }

        public void pesquisaDespesa()
        {
            Controller.DespesaController _ctrlDespesa = new Controller.DespesaController();

            DataTable dtRetorno = _ctrlDespesa.retronaDespesa();

            if (dtRetorno != null)
            {
                dgvDespesa.DataSource = dtRetorno;
                dgvDespesa.ClearSelection();
            }
            else
                dgvDespesa.Rows.Clear();

           
        }

        public void selecionaDespesa()
        {

            if (dgvDespesa.Rows.Count > 0)
            {
                int intCod = 0;
                string status = "";
                intCod = dgvDespesa.CurrentRow.Index + 1;


                if (intCod > 0)
                {
                    this.intCodDespesa = intCod;
                    ttbCodigo.Text = dgvDespesa.CurrentRow.Cells[0].Value.ToString();
                    ttbDescricao.Text = dgvDespesa.CurrentRow.Cells[1].Value.ToString();

                    status = dgvDespesa.CurrentRow.Cells[2].Value.ToString();
                    if (status.Equals("FIXA"))
                    {
                        rbFixa.Checked = true;
                    }
                    if (status.Equals("VARIAVEL"))
                    {
                        rbVariavel.Checked = true;
                    }
                }
            }
        }


        private void dgvDespesa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.DespesaController _ctrlDespesa = new Controller.DespesaController();

            string strMensagem = string.Empty;

            try
            {
                //validações
                int intCodigo = 0;
                if (intCodDespesa != 0)
                {
                    if (!int.TryParse(ttbCodigo.Text, out intCodigo))
                        strMensagem += $"Código inválido{Environment.NewLine}";
                }


                if (string.IsNullOrWhiteSpace(ttbDescricao.Text))
                    strMensagem += $"Informe a despesa.";

                string status = "";

                if(rbFixa.Checked == true)
                {
                    status = "FIXA";
                }

                if (rbVariavel.Checked == true)
                {
                    status = "VARIAVEL";
                }
                //verificar se houve alguma anormalidade no cadastro
                if (string.IsNullOrEmpty(strMensagem))
                {

                    int intRetorno = _ctrlDespesa.gravaDespesa(intCodigo, ttbDescricao.Text, status);


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
            try
            {
                Controller.DespesaController _ctlDesp = new Controller.DespesaController();

                int intCod = 0;

                int.TryParse(ttbCodigo.Text, out intCod);

                if (intCod > 0)
                {
                    if (MessageBox.Show("Confirma exclusão da Despesa?", "Despesa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        bool blnExcluiu = _ctlDesp.excluirDespesa(intCod);
                        if (blnExcluiu)
                        {
                            MessageBox.Show("Despesa Excluída");
                            _limpaCampos();
                            pesquisaDespesa();
                            _btnNovo();
                        }
                        else
                            MessageBox.Show("Erro ao excluir!");
                    }
                    else
                    {
                        MessageBox.Show("cancela ?");
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            pesquisaDespesa();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecionaDespesa();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDespesa_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecionaDespesa();
        }
    }
}
