using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Basicas
{
    public partial class Cadastro_ServiçosParceiros : Form
    {
        int intCodServicoParceiro = 0;

        private List<Entidades.ServicoParceiro> servicoParceirosLista = new List<Entidades.ServicoParceiro>();
        private Controller.PessoaController PessoaController = new Controller.PessoaController();

        int intPessoa { get; set; }
        

        public Cadastro_ServiçosParceiros()
        {
            InitializeComponent();
            _inicializa();
            _limpaCampos();
            dgvServico.AutoGenerateColumns = false;
            carregaServicoCbb();

            mskValorServico.Enabled = false;
        }

        public void _btnNovo()
        {
            
            ttbPessoa.Enabled = true;
            mskValorServico.Enabled = true;
            dgvServico.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true; ;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;
            btnSelecionaPessoa.Enabled = true;

            ttbPessoa.Focus();
            carregaServicoCbb();
        }

        public void _inicializa()
        {
            // ttb
           
            ttbPessoa.Enabled = false;
            mskValorServico.Enabled = false;
            mskValorInformado.Enabled = false;
            mskPercentual.Enabled = false;

            rbPagar.Checked = true;

            dgvServico.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true; ;
            btnCancelar.Enabled = false;
            btnSair.Enabled = true;
            btnSelecionaPessoa.Enabled = false;

            //pesquisaServico();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            
            ttbPessoa.Text = "";
            mskValorServico.Text = "";
        }

        public void _btnAlterar()
        {
            
            ttbPessoa.Enabled = true;
            mskValorServico.Enabled = true;
            dgvServico.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;
            btnSelecionaPessoa.Enabled = true;

            ttbPessoa.Focus();

        }

        private void carregaServicoCbb()
        {
            DataTable dtServicoParceiro = new DataTable();
            Controller.ServicoController servicoController = new Controller.ServicoController();

            dtServicoParceiro = servicoController.retornaServico();
            
            if (dtServicoParceiro != null && dtServicoParceiro.Rows.Count > 0)
            {
                DataRow dr = dtServicoParceiro.Rows[0];
                this.cbbTipoServico.ValueMember = "codtiposervico";
                this.cbbTipoServico.DisplayMember = "tiposerv_descricao";
                this.cbbTipoServico.DataSource = dtServicoParceiro;

                mskValorServico.Text = dr["tiposerv_valor"].ToString();
                
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _btnAlterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.ServicoParceiroController _ctrServParc = new Controller.ServicoParceiroController();

                int intCodPessoa = 0;
                int intCodServico = 0;

                int.TryParse(ttbPessoa.Text, out intCodPessoa);

                intCodServico = Convert.ToInt32(cbbTipoServico.SelectedValue);

                if (intCodPessoa > 0 && intCodServico > 0)
                {
                    if (MessageBox.Show("Confirma exclusão da Despesa?", "Despesa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        bool blnExcluiu = _ctrServParc.excluirServicoParceiro(intCodPessoa, intCodServico);
                        if (blnExcluiu)
                        {
                            MessageBox.Show("Excluído");
                            _limpaCampos();
                            
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
            
        }

        private void btnSelecionaPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                Views.Funcoes_Basicas.Pesquisas.Pesquisa_Fornecedor objPessoa = new Funcoes_Basicas.Pesquisas.Pesquisa_Fornecedor();
                
                objPessoa.ShowDialog();
                if (objPessoa.intCodigoPessoa > 0)
                {
                    Controller.PessoaController pessoaController = new Controller.PessoaController();

                    DataTable dtRetorno = pessoaController.retornaPessoaJuridicaCod(objPessoa.intCodigoPessoa);//intPessoa);
                    
                    if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                    {
                        DataRow dr = dtRetorno.Rows[0];
                        intCodServicoParceiro = Convert.ToInt32(dr["codpessoa"].ToString());
                        intPessoa = intCodServicoParceiro;
                        ttbPessoa.Text = dr["jur_razaosocial"].ToString();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.ServicoParceiroController _ctrlServParceiro = new Controller.ServicoParceiroController();
            string strMensagem = string.Empty;

            try
            {
                //verificar se houve alguma anormalidade no cadastro
                if (string.IsNullOrEmpty(strMensagem))
                {
                    double valorServico = 0;
                    double.TryParse(mskValorServico.Text, out valorServico);

                    string pagamento;
                    if(rbPagar.Checked == true)
                    {
                        pagamento = "PAGAR";
                    }
                    else
                    {
                        pagamento = "RECEBER";

                    }

                    int servico = Convert.ToInt32(cbbTipoServico.SelectedValue);

                    DataTable dtRetorno = _ctrlServParceiro.retornaParceiroServico(intCodServicoParceiro, servico);
                    
                    if (dtRetorno != null && dtRetorno.Rows.Count != 0)
                    {
                        DataRow dr = dtRetorno.Rows[0];
                        intCodServicoParceiro = Convert.ToInt32(dr["codpessoa"].ToString());
                        servico = Convert.ToInt32(dr["codtiposervico"].ToString());

                        if (intCodServicoParceiro != Convert.ToInt32(dr["codpessoa"].ToString()) || servico != Convert.ToInt32(dr["codtiposervico"].ToString()))
                        {
                            int intRetorno = _ctrlServParceiro.gravaServico(intCodServicoParceiro, servico, valorServico, 0, pagamento);
                            if (intRetorno == 1)
                            {
                                MessageBox.Show("Gravado com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Erro ao Gravar.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Já existe Parceiro vinculado a esse tipo de Serviço.");
                        }
                    }
                    else
                    {
                        int intRetorno = _ctrlServParceiro.gravaServico(intCodServicoParceiro, servico, valorServico, 0, pagamento);
                        if (intRetorno == 1)
                        {
                            MessageBox.Show("Gravado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Gravar.");
                        }
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

       

        private void mskPorcentagem_DoubleClick(object sender, EventArgs e)
        {
            
        }

        
        private void btnIncluirServico_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = 0;
                double valorServico = Convert.ToDouble(mskValorServico.Text);
                double result = 0;
                string pagRec = "";

                if (rbPagar.Checked == true)
                    pagRec = "PAGAR";
                if (rbReceber.Checked == true)
                    pagRec = "RECEBER";

                if (!string.IsNullOrWhiteSpace(mskValorInformado.Text))
                {
                    valor = Convert.ToDouble(mskValorInformado.Text);

                    result = (valor * 100) / valorServico;

                    mskPercentual.Text = Convert.ToString(result);
                }
                else
                    if (!string.IsNullOrWhiteSpace(mskPercentual.Text))
                    {
                        valor = Convert.ToDouble(mskPercentual.Text);

                        result = (valorServico * valor) / 100;

                        mskValorInformado.Text = Convert.ToString(result);
                    }

                Controller.ServicoParceiroController servicoParceiroController = new Controller.ServicoParceiroController();
                Controller.ServicoController servicoController = new Controller.ServicoController();
                Controller.PessoaController pessoaController = new Controller.PessoaController();

                Entidades.ServicoParceiro servicoParceiro = new Entidades.ServicoParceiro();
                Entidades.Servico servico = new Entidades.Servico();
                Entidades.PessoaJuridica pessoaJuridica = new Entidades.PessoaJuridica();

                DataTable dtPessoa = pessoaController.retornaPessoaJuridicaCod(intPessoa);
                if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                {
                    DataRow drPessoa = dtPessoa.Rows[0];

                    pessoaJuridica.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                    pessoaJuridica.CNPJ = drPessoa["jur_cnpj"].ToString();
                    pessoaJuridica.RazaoSocial = drPessoa["jur_razaosocial"].ToString();

                    servicoParceiro.PessoaJuridica = pessoaJuridica;

                    int intCodServico = Convert.ToInt32(cbbTipoServico.SelectedValue.ToString());

                    DataTable dtServico = servicoController.retornaObjServico(intCodServico);
                    if (dtServico != null && dtServico.Rows.Count > 0)
                    {
                        DataRow drServico = dtServico.Rows[0];
                        servico.Codigo = Convert.ToInt32(drServico["codtiposervico"].ToString());
                        servico.ServicoNome = drServico["tiposerv_descricao"].ToString();
                        servico.Observacao = drServico["tiposerv_obs"].ToString();
                        servico.Valor = Convert.ToDouble(drServico["tiposerv_valor"].ToString());
                        servico.Tempo = drServico["tiposerv_temposervico"].ToString();

                        servicoParceiro.Servico = servico;

                        servicoParceiro.Valor = Convert.ToDouble(mskValorInformado.Text);
                        servicoParceiro.Percentual = Convert.ToDouble(mskPercentual.Text);
                        servicoParceiro.PagamentoRecebido = pagRec;
                        servicoParceiro.Agenda = null;

                        servicoParceirosLista.Add(servicoParceiro);
                        carregaDGV(servicoParceirosLista);

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void carregaDGV(List<Entidades.ServicoParceiro> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvServico.DataSource = bd;
            dgvServico.Refresh();
        }

        private void cbbTipoServico_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbValorInformado_Click(object sender, EventArgs e)
        {
            mskValorInformado.Enabled = true;
            mskPercentual.Enabled = false;
            mskPercentual.Text = "";
            

        }

        private void rbPOrcentagemInformada_Click(object sender, EventArgs e)
        {
            mskValorInformado.Enabled = false;
            mskPercentual.Enabled = true;
            mskValorServico.Text = "";
        }
    }
}
