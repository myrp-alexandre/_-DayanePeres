using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais
{
    public partial class LancarDespesa : Form
    {
        public LancarDespesa()
        {
            InitializeComponent();
            _inicializa();
            _limpaCampos();
        }
        

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            cbbDespesa.Enabled = false;
            rbFixa.Enabled = false;
            rbVariavel.Enabled = false;
            dtpVencimento.Enabled = false;
            mskValor.Enabled = false;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true;
            btnSair.Enabled = true;

            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            cbbDespesa.Text= "";
            dtpVencimento.Value = DateTime.Now;
            mskValor.Text = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            cbbDespesa.Enabled = true;
            dtpVencimento.Enabled = true;
            mskValor.Enabled = true;


            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            cbbDespesa.Focus();
        }

       
        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
