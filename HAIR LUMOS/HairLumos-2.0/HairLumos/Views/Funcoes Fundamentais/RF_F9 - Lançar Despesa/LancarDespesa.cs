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
        private string tipoDespesa = "";

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
            dtpVencimento.Enabled = false;
            mskValor.Enabled = false;
            ttbObservacao.Enabled = false;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
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
            
            ttbObservacao.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
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
                DataRow dr = dtDespesa.Rows[0];

                tipoDespesa = dr["desp_status"].ToString();
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
            try
            {
                Controller.ContasPagarController _ctrlContas = new Controller.ContasPagarController();
                Entidades.ContasPagar contasPagar = new Entidades.ContasPagar();

                Controller.DespesaController despesaController = new Controller.DespesaController();
                Entidades.Despesa despesa = new Entidades.Despesa();
                
                Controller.CaixaController caixaController = new Controller.CaixaController();
                Entidades.Caixa caixa = new Entidades.Caixa();

                int codigo = 0;

                if (!string.IsNullOrWhiteSpace(ttbCodigo.Text))
                    codigo = Convert.ToInt32(ttbCodigo.Text);

                if(codigo == 0)
                    codigo= _ctrlContas.retornaMax()+1;


                double valor = 0;
                if (!string.IsNullOrWhiteSpace(mskValor.Text))
                    valor = Convert.ToDouble(mskValor.Text);

                despesa.Codigo = Convert.ToInt32(cbbDespesa.SelectedValue);

                // Preenchendo Campos obj Contas a Pagar
                contasPagar.DataVencimento = dtpVencimento.Value;
                contasPagar.DataPagamento = DateTime.MaxValue;
                contasPagar.ValorTotal = valor;
                contasPagar.ValorPago = 0;
                contasPagar.Observacao = ttbObservacao.Text;
                contasPagar.Status = false;
                contasPagar.Parcela = 1;
                contasPagar.Compra = new Entidades.Compra();
                contasPagar.Despesa = despesa;
                contasPagar.Caixa = new Entidades.Caixa();
                contasPagar.FormaPagamento = new Entidades.FormaPagamento();
                contasPagar.Comissao = new Entidades.Comissao();
                contasPagar.ValorParcela = valor;
                contasPagar.CodigoContasaPagar = codigo;
                contasPagar.CodParcela = 1;
                           

                int result = _ctrlContas.insereLancamento(contasPagar);
                if (result > 0)
                {
                    MessageBox.Show("Gravado com sucesso");
                    _limpaCampos();
                    _inicializa();
                }
                else
                {
                    MessageBox.Show("Erro ao gravar!");
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.ContasPagarController contasPagarController = new Controller.ContasPagarController();

                Views.Funcoes_Fundamentais.RF_F9___Lançar_Despesa.Pesquisa_LançarDespesa pesquisa_LançarDespesa = new RF_F9___Lançar_Despesa.Pesquisa_LançarDespesa();
                pesquisa_LançarDespesa.ShowDialog();
                
                if(pesquisa_LançarDespesa.intCodDespesa > 0)
                {
                    DataTable dt = contasPagarController.retornaDespesaCodData(pesquisa_LançarDespesa.intCodDespesa, pesquisa_LançarDespesa.data);

                    if(dt != null && dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        ttbCodigo.Text = dr["coddespesa"].ToString();
                        cbbDespesa.SelectedIndex = Convert.ToInt32(dr["coddespesa"].ToString())-1;
                        dtpVencimento.Value = Convert.ToDateTime(dr["contpag_datavencimento"].ToString());
                        mskValor.Text = dr["contpag_valortotal"].ToString();
                        ttbObservacao.Text = dr["contpag_obs"].ToString();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
