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
    public partial class Cadastro_Usuario : Form
    {
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        private void btnPesquisaPessoa_Click(object sender, EventArgs e)
        {
            string texto = "";

            if (string.IsNullOrWhiteSpace(ttbPessoa.Text))
            {
                texto = ttbPessoa.Text.Trim();


            }
               
            
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbPessoa.Enabled = false;
            ttbLogin.Enabled = false;
            mskSenha.Enabled = false;
            mskConfirmaSenha.Enabled = false;
            

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;

            
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbPessoa.Text = "";
            ttbLogin.Text = "";
            mskSenha.Text = "";
            mskConfirmaSenha.Text  = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbPessoa.Enabled = true;
            ttbLogin.Enabled = true;
            mskSenha.Enabled = true;
            mskConfirmaSenha.Enabled = true;


            //botões
            btnNovo.Enabled = true;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnSair.Enabled = true;

            ttbPessoa.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;

            ttbPessoa.Enabled = true;
            ttbLogin.Enabled = true;
            mskSenha.Enabled = true;
            mskConfirmaSenha.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;

            ttbPessoa.Focus();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }
    }
}
