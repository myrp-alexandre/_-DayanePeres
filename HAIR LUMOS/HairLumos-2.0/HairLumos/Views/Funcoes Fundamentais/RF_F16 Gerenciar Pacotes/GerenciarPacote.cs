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
        private Controller.PacoteController PacoteController = new Controller.PacoteController();

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
            ttbPacote.Enabled = false;
            ttbQtdeServico.Enabled = false;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSair.Enabled = true;
            btnIncluirServico.Enabled = false;
            btnExcuirServico.Enabled = false;

            rbNao.Checked = true;
            dtpDataFim.Enabled = false;
            dtpDataInicio.Enabled = false;

            
            //pesquisaPacote();
            _limpaCampos();
            dgvPacote.AutoGenerateColumns = false;

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            cbbServico.SelectedIndex = -1;
            ttbPeriodo.Text = "";
            ttbObs.Text = "";
            mskValor.Text = "";
            dgvPacote.Rows.Clear();
            mskValor.Text = "";
            ttbPacote.Text = "";
            ttbQtdeServico.Text = "";

            dtpDataInicio.Value = DateTime.Now;
            dtpDataFim.Value = DateTime.Now;

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
            ttbPacote.Enabled = true;
            ttbQtdeServico.Enabled = true;
            dtpDataInicio.Enabled = true;


            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnPesquisa.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;
            btnIncluirServico.Enabled = true;
            btnExcuirServico.Enabled = true;

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
            ttbPacote.Enabled = true;
            ttbQtdeServico.Enabled = true;
            dtpDataInicio.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnPesquisa.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;
            btnIncluirServico.Enabled = true;
            btnExcuirServico.Enabled = true;

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
                if (!verificaContrato())
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

                    if (rbSim.Checked == true)
                    {

                        if (dtpDataInicio.Value > dtpDataFim.Value)
                        {
                            strMensagem += "Data Inicial não pode ser maior que a data final!";
                        }

                        if (dtpDataFim.Value < DateTime.Now)
                        {
                            strMensagem += "Data final não pode ser menor que a Data Atual!";
                        }
                    }
                    DateTime data;
                    if (rbNao.Checked == true)
                    {
                        data = DateTime.MaxValue;
                    }
                    else
                    {
                        data = dtpDataFim.Value.Date;
                    }


                    //verificar se houve alguma anormalidade no cadastro
                    if (string.IsNullOrEmpty(strMensagem))
                    {
                        double valorPacote = 0;
                        double.TryParse(mskValor.Text, out valorPacote);

                        int intRetorno = _ctrlPac.gravarPacote(intCodigo, ttbPacote.Text.Trim(), lista, valorPacote, ttbObs.Text.Trim(),
                            ttbPeriodo.Text.Trim(), dtpDataInicio.Value, data);//dtpDataFim.Value);

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
                else
                {
                    MessageBox.Show("Existe Contrato com este pacote e o mesmo não pode ser alterado!");
                }


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

            if (!verificaContrato())
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
            else
                MessageBox.Show("Existe Contrato com este pacote e o mesmo não pode ser alterado!");

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            _limpaCampos();
            //pesquisaPacote();
        }

        

        private void dgvPacote_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            //selecionaServico();
        }

        private void btnExcuirServico_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificaContrato())
                {
                    if (dgvPacote.Rows.Count > 0)
                    {
                        lista.Remove(lista.ElementAt(dgvPacote.CurrentRow.Index));
                        carregaDGV(lista);
                    }
                }
                else
                {
                    MessageBox.Show("Já existe contrato com este pacote, o mesmo não pode ser alterado!");
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        

        private void btnIncluirServico_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificaContrato())
                {
                    Controller.ServicoController servicoController = new Controller.ServicoController();
                    Entidades.Servico servico = new Entidades.Servico();
                    Entidades.PacoteServico pacoteServico = new Entidades.PacoteServico();

                    int intCod = Convert.ToInt32(cbbServico.SelectedValue.ToString());
                    DataTable dtServico = servicoController.retornaObjServico(intCod);

                    if(dtServico != null && dtServico.Rows.Count > 0)
                    {
                        DataRow drServico = dtServico.Rows[0];
                        servico.Codigo = Convert.ToInt32(drServico["codtiposervico"].ToString());
                        servico.ServicoNome = drServico["tiposerv_descricao"].ToString();
                        servico.Observacao = drServico["tiposerv_obs"].ToString();
                        servico.Valor = Convert.ToDouble(drServico["tiposerv_valor"].ToString());
                        servico.Tempo = drServico["tiposerv_temposervico"].ToString();

                        pacoteServico.Periodicidade = ttbPeriodo.Text.Trim();
                        pacoteServico.Servico = servico;
                        pacoteServico.Quantidade = Convert.ToInt32(ttbQtdeServico.Text.Trim().ToString());
                        pacoteServico.Valor = Convert.ToDouble(drServico["tiposerv_valor"].ToString());
                        lista.Add(pacoteServico);
                        carregaDGV(lista);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Já existe contrato com este pacote o mesmo não pode ser alterado!");
                }

                
            }
            catch (Exception)
            {

                throw;
            }

            

        }

        private void carregaDGV(List<Entidades.PacoteServico> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvPacote.DataSource = bd;
            dgvPacote.Refresh();
        }

        
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            _btnAlterar();
            try
            {
                int codPacote = 0;
                Views.Funcoes_Fundamentais.RF_F16_Gerenciar_Pacotes.Pesquisa_GerenciarPacotes pesquisa_GerenciarPacotes = new Funcoes_Fundamentais.RF_F16_Gerenciar_Pacotes.Pesquisa_GerenciarPacotes();
                pesquisa_GerenciarPacotes.ShowDialog();

                Controller.ServicoController servicoController = new Controller.ServicoController();
                Entidades.PacoteServico pacoteServico = new Entidades.PacoteServico();
                Entidades.Servico servico = new Entidades.Servico();


                if (pesquisa_GerenciarPacotes.intCodPacote > 0)
                {
                    DataTable dtRetorno = PacoteController.retornaObjPacote(pesquisa_GerenciarPacotes.intCodPacote);

                    if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                    {

                        DataRow dr = dtRetorno.Rows[0];
                        ttbCodigo.Text = dr["codpacote"].ToString();
                        codPacote = Convert.ToInt32(ttbCodigo.Text);
                        mskValor.Text = dr["pac_valor"].ToString();
                        ttbObs.Text = dr["pac_obs"].ToString();
                        ttbPacote.Text = dr["pac_pacote"].ToString();
                        dtpDataInicio.Value = Convert.ToDateTime(dr["pac_datainicio"].ToString());


                        //FALTA VERIFICAR A DATA
                        if (Convert.ToDateTime(dr["pac_datafim"].ToString()) != DateTime.MaxValue ||
                                Convert.ToDateTime(dr["pac_datafim"].ToString()) != DateTime.MinValue)
                        {
                            dtpDataFim.Enabled = false;
                        }
                        else
                        {
                            dtpDataInicio.Value = Convert.ToDateTime(dr["pac_datafim"].ToString());
                        }

                        DataTable dtServico = servicoController.retornaPacoteServico(codPacote);

                        if (dtServico != null && dtServico.Rows.Count > 0)
                        {

                            for (int i = 0; i < dtServico.Rows.Count; i++)
                            {
                                servico = new Entidades.Servico();
                                pacoteServico = new Entidades.PacoteServico();
                                DataRow drServico = dtServico.Rows[i];
                                servico.ServicoNome = drServico["tipoServ_descricao"].ToString();
                                pacoteServico.Servico = servico;
                                pacoteServico.Quantidade = Convert.ToInt32(drServico["pacServ_qtde"].ToString());
                                pacoteServico.Periodicidade = drServico["pacServ_periodicidade"].ToString();
                                lista.Add(pacoteServico);
                                

                            }
                            carregaDGV(lista);

                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private Boolean verificaContrato()
        {
            int intCodPacote = 0;
            Boolean retorno;
            try
            {
                if (!string.IsNullOrWhiteSpace(ttbCodigo.Text))
                {
                    intCodPacote = Convert.ToInt32(ttbCodigo.Text);

                    Controller.PacoteController pacoteController = new Controller.PacoteController();

                    if (pacoteController.retornaContrato(intCodPacote))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        private void Cadastro_Pacotes_Load(object sender, EventArgs e)
        {
            if (rbSim.Checked == true)
            {
                dtpDataFim.Enabled = true;
            }
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSim_Click(object sender, EventArgs e)
        {
            if (rbSim.Checked == true)
            {
                dtpDataFim.Enabled = true;
            }
        }

        private void rbNao_Click(object sender, EventArgs e)
        {
            dtpDataFim.Enabled = false;
        }

        private void mskValor_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskValor);
        }

        private void mskValor_Leave(object sender, EventArgs e)
        {
            mskValor.Text = Convert.ToDouble(mskValor.Text).ToString("###,###,##0.00");
        }

        private void mskValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskValor, e);
        }
    }
}
