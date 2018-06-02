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
    public partial class Cadastro_Pessoa : Form
    {
        public Cadastro_Pessoa()
        {
            InitializeComponent();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = false;
            ttbRazao.Enabled = false;
            ttbRg.Enabled = false;
            mskCPF.Enabled = false;
            mskCNPJ.Enabled = false;
            dtpDataNascimento.Enabled = false;

            rbAtivo.Enabled = false;
            rbInativo.Enabled = false;
            rbFisica.Enabled = false;
            rbJuridica.Enabled = false;

            dgvEndereço.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnIncluirEndereco.Enabled = false;
            btnSair.Enabled = true;

            //pesquisaMarca();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbNome.Text = "";
            ttbRazao.Text = "";
            ttbRg.Text = "";
            mskCNPJ.Text = "";
            mskCPF.Text = "";
            dtpDataNascimento.Value = DateTime.Now.Date;

            rbAtivo.Checked = true;
            rbFisica.Checked = true;
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = true;
            ttbRazao.Enabled = true;
            ttbRg.Enabled = true;
            mskCPF.Enabled = true;
            mskCNPJ.Enabled = true;
            dtpDataNascimento.Enabled = true;

            rbAtivo.Enabled = true;
            rbAtivo.Checked = true;
            rbInativo.Enabled = true;

            rbFisica.Enabled = true;
            rbFisica.Checked = true;
            rbJuridica.Enabled = true;

            dgvEndereço.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;
            btnIncluirEndereco.Enabled = true;

            ttbNome.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = true;
            ttbRazao.Enabled = true;
            ttbRg.Enabled = true;
            mskCPF.Enabled = true;
            mskCNPJ.Enabled = true;
            dtpDataNascimento.Enabled = true;

            rbAtivo.Enabled = true;
            rbAtivo.Checked = true;
            rbInativo.Enabled = true;

            rbFisica.Enabled = true;
            rbFisica.Checked = true;
            rbJuridica.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbNome.Focus();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Pessoa_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluirEndereco_Click(object sender, EventArgs e)
        {
            pnlEndereco.Visible = true;
            dgvEndereço.Visible = true;
            
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluirContato_Click(object sender, EventArgs e)
        {
            pnlContato.Visible = true;
            dgvContato.Visible = true;
        }

        private void rbPagaSim_Click(object sender, EventArgs e)
        {
            pnlObservacao.Visible = true;
        }
    }
}
