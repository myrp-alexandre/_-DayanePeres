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
            carregaCbbDespesa();
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
            ttbObservacao.Enabled = false;

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
            ttbObservacao.Text = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            cbbDespesa.Enabled = true;
            dtpVencimento.Enabled = true;
            mskValor.Enabled = true;
            rbFixa.Enabled = true;
            rbVariavel.Enabled = true;
            rbFixa.Checked = true;
            ttbObservacao.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            cbbDespesa.Focus();
        }

        public void carregaCbbDespesa()
        {
            Controller.DespesaController _ctrlDespe = new Controller.DespesaController();

            DataTable dtDespesa = _ctrlDespe.retronaDespesa();
            if (dtDespesa != null && dtDespesa.Rows.Count > 0)
            {
                this.cbbDespesa.ValueMember = "coddespesa";
                this.cbbDespesa.DisplayMember = "desp_descricao";
                this.cbbDespesa.DataSource = dtDespesa;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.ContasPagarController _ctrlContas = new Controller.ContasPagarController();

            int codigo = 0;

            if (!string.IsNullOrWhiteSpace(ttbCodigo.Text))
                codigo = Convert.ToInt32(ttbCodigo.Text);

            string tipo;
            if (rbFixa.Checked)
                tipo = "Fixa";
            else
                tipo = "Variavel";
            double valor = Convert.ToDouble(mskValor.Text);
            //Entidades.Despesa _despesa = new Entidades.Despesa();
            //_despesa = (Entidades.Despesa)cbbDespesa.SelectedValue;

            

            int codDespesa = Convert.ToInt32(cbbDespesa.SelectedValue.ToString());
            //int result = _ctrlContas.insereLancamento(contasPagar);
            //if (result > 0)
            //{
            //    MessageBox.Show("Gravado com sucesso");
            //    _limpaCampos();
            //    _inicializa();
            //}
            //else
            //{
            //    MessageBox.Show("Erro ao gravar!");
            //}
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
