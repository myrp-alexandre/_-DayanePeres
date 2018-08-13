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
        public Cadastro_ServiçosParceiros()
        {
            InitializeComponent();
        }

        public void _btnNovo()
        {
            
            ttbPessoa.Enabled = true;
            mskValor.Enabled = true;
            mskPorcentagem.Enabled = true;
            dgvServico.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true; ;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbPessoa.Focus();
        }

        public void _inicializa()
        {
            // ttb
           
            ttbPessoa.Enabled = false;
            mskPorcentagem.Enabled = false;
            mskValor.Enabled = false;
            
            dgvServico.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true; ;
            btnCancelar.Enabled = false;
            btnSair.Enabled = true;

            //pesquisaServico();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            
            ttbPessoa.Text = "";
            mskPorcentagem.Text = "";
            mskValor.Text = "";
        }

        public void _btnAlterar()
        {
            
            ttbPessoa.Enabled = true;
            mskPorcentagem.Enabled = true;
            mskValor.Enabled = true;
            dgvServico.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbPessoa.Focus();

        }

        private void carregaServicoCbb(int cod)
        {
            DataTable dtCidade = new DataTable();
            Controller.ServicoController servicoController = new Controller.ServicoController();

            dtCidade = servicoController.retornaObjServico(cod);

            if (dtCidade != null && dtCidade.Rows.Count > 0)
            {
                this.cbbTipoServico.ValueMember = "codtiposervico";
                this.cbbTipoServico.DisplayMember = "tiposerv_descricao";
                this.cbbTipoServico.DataSource = dtCidade;
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
                    DataTable dtRetorno = pessoaController.retornaPessoaJuridicaCod(objPessoa.intCodigoPessoa);

                    if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                    {
                        DataRow dr = dtRetorno.Rows[0];
                        ttbPessoa.Text = dr["jur_fantasia"].ToString();

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
    }
}
