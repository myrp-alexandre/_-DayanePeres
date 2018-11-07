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

            ttbValorServico.Enabled = false;
        }

        public void _btnNovo()
        {
            
            ttbPessoa.Enabled = true;
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
            mskPercentual.Text = "";
            mskValorInformado.Text = "";
            dgvServico.Rows.Clear();
            servicoParceirosLista = new List<Entidades.ServicoParceiro>();
        }

        public void _btnAlterar()
        {
            
            ttbPessoa.Enabled = true;
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

                ttbValorServico.Text = dr["tiposerv_valor"].ToString();
                
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

                    DataTable dtRetorno = pessoaController.retornaPessoaJuridica();//intPessoa);
                    
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
                if (servicoParceirosLista.Count > 0)
                {
                    int i = 0;
                    bool fim = false;
                    while(i< servicoParceirosLista.Count || fim)
                    {
                        int rest = _ctrlServParceiro.gravaServico(servicoParceirosLista.ElementAt(i).PessoaJuridica.Codigo, servicoParceirosLista.ElementAt(i).Servico.Codigo, servicoParceirosLista.ElementAt(i).Valor, servicoParceirosLista.ElementAt(i).Percentual, servicoParceirosLista.ElementAt(i).PagamentoRecebido);
                        if (rest == 0)
                        {
                            MessageBox.Show("Erro ao gravar os dados!");
                            fim = true;
                        }
                        i++;
                    }
                    if(i== servicoParceirosLista.Count)
                    {
                        MessageBox.Show("Serviços atribuidos ao parceiro com sucesso!");
                        _limpaCampos();
                        _inicializa();
                    }

                }
                else
                {
                    MessageBox.Show("Lista de serviços esta vazia!");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex + "");
            }
        }

        
        private void btnIncluirServico_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = 0;
                double valorServico = 0;
                if (!String.IsNullOrWhiteSpace(ttbValorServico.Text))
                    valorServico = Convert.ToDouble(ttbValorServico.Text);
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

                    }
                    servicoParceiro.Valor = Convert.ToDouble(mskValorInformado.Text);
                    servicoParceiro.Percentual = Convert.ToDouble(mskPercentual.Text);
                    servicoParceiro.PagamentoRecebido = pagRec;

                    servicoParceirosLista.Add(servicoParceiro);
                    carregaDGV(servicoParceirosLista);
                    mskPercentual.Text = "";
                    mskValorInformado.Text = "";
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
            mskValorInformado.Text = "";
        }

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvServico.Rows.Count > 0)
                {
                    if (dgvServico.Rows.Count > 0)
                    {
                        servicoParceirosLista.Remove(servicoParceirosLista.ElementAt(dgvServico.CurrentRow.Index));
                        carregaDGV(servicoParceirosLista);
                    }
                    else
                    {
                        MessageBox.Show("Não pode excluit itens do pacote!");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            try
            {
                Controller.ServicoParceiroController servicoController = new Controller.ServicoParceiroController();
                Controller.ServicoController sc = new Controller.ServicoController();
                Controller.PessoaController pc = new Controller.PessoaController();
                
                Views.Funcoes_Basicas.Pesquisas.Pesquisa_ServicoParceiro pesquisa_ServicoParceiro = new Pesquisas.Pesquisa_ServicoParceiro();
                pesquisa_ServicoParceiro.ShowDialog();

                if(pesquisa_ServicoParceiro.intCodprestador > 0)
                {

                    DataTable dtServParc = servicoController.retornaServicos(pesquisa_ServicoParceiro.intCodprestador);

                    if(dtServParc != null && dtServParc.Rows.Count > 0)
                    {
                        for(int i =0; i<dtServParc.Rows.Count; i++)
                        {
                            DataRow drServPac = dtServParc.Rows[i];
                            Entidades.PessoaJuridica pj = new Entidades.PessoaJuridica();
                            DataTable dtPessoa = pc.retornaPessoaJuridicaCnpj(drServPac["jur_cnpj"].ToString());
                            if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                            {
                                
                                DataRow drPessoa = dtPessoa.Rows[0];
                                pj.Codigo = Convert.ToInt32(drServPac["codpessoa"].ToString());
                                pj.CNPJ = drServPac["jur_cnpj"].ToString();
                                pj.Nome = drPessoa["pes_nome"].ToString();
                                pj.RazaoSocial = drPessoa["jur_razaosocial"].ToString();
                                ttbPessoa.Text = drPessoa["pes_nome"].ToString();
                            }
                            
                            DataTable dtServico = sc.retornaObjServico(Convert.ToInt32(drServPac["codtiposervico"].ToString()));
                            Entidades.Servico servico = new Entidades.Servico();
                            if (dtServico != null && dtServico.Rows.Count > 0)
                            {
                                
                                DataRow drServico = dtServico.Rows[0];
                                servico.Codigo = Convert.ToInt32(drServico["codtiposervico"].ToString());
                                servico.ServicoNome = drServico["tiposerv_descricao"].ToString();
                                servico.Observacao = drServico["tiposerv_obs"].ToString();
                                servico.Valor = Convert.ToDouble(drServico["tiposerv_valor"].ToString());
                                servico.Tempo = drServico["tiposerv_temposervico"].ToString();
                            }
                            Entidades.ServicoParceiro servicoParceiro = new Entidades.ServicoParceiro();
                            servicoParceiro.PessoaJuridica = pj;
                            servicoParceiro.Servico = servico;
                            servicoParceiro.Valor = Convert.ToDouble(drServPac["prestserv_valor"].ToString());
                            servicoParceiro.Percentual = Convert.ToDouble(drServPac["prestserv_percentual"].ToString());
                            servicoParceiro.PagamentoRecebido = drServPac["prestser_pagrec"].ToString();
                            servicoParceirosLista.Add(servicoParceiro);
                            carregaDGV(servicoParceirosLista);
                        }

                    }
                }
            }
            catch (Exception E)
            {

                throw;
            }
        }

        private void cbbTipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller.ServicoController servicoController = new Controller.ServicoController();
            int codigo = Convert.ToInt32(cbbTipoServico.SelectedValue);
            DataTable dt = servicoController.retornaObjServico(codigo);
            if(dt!=null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ttbValorServico.Text = dr["tiposerv_valor"].ToString();
            }
        }
    }
}
