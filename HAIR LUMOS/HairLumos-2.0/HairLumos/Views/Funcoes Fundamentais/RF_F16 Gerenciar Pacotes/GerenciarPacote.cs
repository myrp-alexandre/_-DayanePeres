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
        private List<Entidades.PacoteServico> lista = new List<Entidades.PacoteServico>();

        int intCodPacote = 0;

        public Cadastro_Pacotes()
        {
            InitializeComponent();
            _inicializa();
            _limpaCampos();
            
            carregaCbbServico();
            
            //pesquisaPacote();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            cbbServico.Enabled = false;
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

            //pesquisaPacote();
            _limpaCampos();
            dgvPacote.AutoGenerateColumns = false;

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            // CBB
            ttbPeriodo.Text = "";
            ttbObs.Text = "";
            mskValor.Text = "";
            
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            cbbServico.Enabled = true;
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

            cbbServico.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
            cbbServico.Enabled = true;
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

            cbbServico.Focus();

        }

        public void carregaPacote(string strCod, string strServico, string strvalor) //, string strobs, DateTime dtIni, DateTime dtFim)
        {
            ttbCodigo.Text = strCod;
            cbbServico.Text = strServico;
            cbbServico.Text = strServico;
            mskValor.Text = strvalor;
            //ttbObs.Text = strobs;
            //dtpDataInicio.Value = dtIni;
            //dtpDataFim.Value = dtFim;
        }

        public void carregaCbbServico()
        {
            Controller.ServicoController servicoController = new Controller.ServicoController();

            DataTable dtServicos = servicoController.retornaServico();
            if (dtServicos != null && dtServicos.Rows.Count > 0)
            {
                this.cbbServico.ValueMember = "codtiposervico";
                this.cbbServico.DisplayMember = "tiposerv_descricao";
                this.cbbServico.DataSource = dtServicos;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            //selecionaServico();
        }
        
        private void btnGravar_Click_1(object sender, EventArgs e)
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


                if (string.IsNullOrWhiteSpace(cbbServico.Text))
                    strMensagem += $"Informe o Serviço!.";

                if (string.IsNullOrWhiteSpace(ttbPacote.Text))
                    strMensagem += $"Informe o Nome do Pacote!.";

                if (string.IsNullOrWhiteSpace(mskValor.Text))
                    strMensagem += $"Informe o valor do pacote.";

                if (string.IsNullOrWhiteSpace(ttbPeriodo.Text))
                    strMensagem += $"Informe a periodicidade do pacote.";

                if(dtpDataInicio.Value > dtpDataFim.Value)
                {
                    strMensagem += "Data Inicial não pode ser maior que a data final!";
                }

                if (dtpDataFim.Value < DateTime.Now)
                {
                    strMensagem += "Data final não pode ser menor que a Data Atual!";
                }

                //verificar se houve alguma anormalidade no cadastro
                if (string.IsNullOrEmpty(strMensagem))
                {
                    double valorPacote = 0;
                    double.TryParse(mskValor.Text, out valorPacote);

                    int intRetorno = _ctrlPac.gravarPacote(intCodigo, ttbPacote.Text.Trim() ,lista, valorPacote, ttbObs.Text.Trim(), ttbPeriodo.Text.Trim(), dtpDataInicio.Value, dtpDataFim.Value);

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

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            _btnAlterar();

        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
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
                        //pesquisaPacote();
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            _limpaCampos();
            //pesquisaPacote();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPacote_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            //selecionaServico();
        }

        private void btnExcuirServico_Click(object sender, EventArgs e)
        {
            if(dgvPacote.Rows.Count > 0)
            {
                lista.Remove(lista.ElementAt(dgvPacote.CurrentRow.Index));
                carregaDGV(lista);
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        

        private void btnIncluirServico_Click(object sender, EventArgs e)
        {
            Controller.ServicoController servicoController = new Controller.ServicoController();
            Entidades.Servico servico = new Entidades.Servico();
            Entidades.PacoteServico pacoteServico = new Entidades.PacoteServico();

            int intCod = Convert.ToInt32(cbbServico.SelectedValue.ToString());
            DataTable dtServico = servicoController.retornaObjServico(intCod);
            DataRow drServico = dtServico.Rows[0];
            servico.Codigo = Convert.ToInt32(drServico["codtiposervico"].ToString());
            servico.ServicoNome = drServico["tiposerv_descricao"].ToString();
            servico.Observacao= drServico["tiposerv_obs"].ToString();
            servico.Valor= Convert.ToDouble(drServico["tiposerv_valor"].ToString());
            servico.Tempo = drServico["tiposerv_temposervico"].ToString();

            pacoteServico.Periodicidade = ttbPeriodo.Text.Trim();
            pacoteServico.Servico = servico;
            pacoteServico.Quantidade = Convert.ToInt32(ttbQtdeServico.Text.Trim().ToString());
            pacoteServico.Valor = Convert.ToDouble(drServico["tiposerv_valor"].ToString());
            lista.Add(pacoteServico);
            carregaDGV(lista);

        }

        private void carregaDGV(List<Entidades.PacoteServico> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvPacote.DataSource = bd;
            dgvPacote.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mskValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
