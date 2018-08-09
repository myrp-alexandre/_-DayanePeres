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
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
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
            ttbCodigo.Enabled = false;
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
            ttbCodigo.Text = "";
            ttbPessoa.Text = "";
            mskPorcentagem.Text = "";
            mskValor.Text = "";
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
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
    }
}
