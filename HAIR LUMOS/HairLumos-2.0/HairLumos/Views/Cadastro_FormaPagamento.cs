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
    public partial class Cadastro_FormaPagamento : Form
    {
        int intcodForma = 0;

        public Cadastro_FormaPagamento()
        {
            InitializeComponent();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbForma.Enabled = false;
            dgvMarca.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSair.Enabled = true;

            pesquisaMarca();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbForma.Text = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbForma.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbForma.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
            ttbForma.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbForma.Focus();

        }

        public void carregaMarcaTela(string strCod, string StrMarca)
        {
            ttbCodigo.Text = strCod;
            ttbForma.Text = StrMarca;
        }

        public void carregaGrid()
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();
            DataTable dtRetorno = _ctlProd.retornaMarca();

            if (dtRetorno != null && dtRetorno.Rows.Count > 0)
            {
                DataRow dr = dtRetorno.Rows[intcodForma - 1];
                this.carregaMarcaTela(
                    dr["codmarca"].ToString(),
                    dr["marc_nome"].ToString());

            }
        }

        public void pesquisaMarca()
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();

            DataTable dtRetorno = _ctlProd.retornaMarca();

            if (dtRetorno != null)
            {
                dgvMarca.DataSource = dtRetorno;
                dgvMarca.ClearSelection();
            }
            else
                dgvMarca.Rows.Clear();

            //carregaGrid();

        }

        public void selecinaMarca()
        {

            if (dgvMarca.Rows.Count > 0)
            {
                int intCod = 0;

                intCod = dgvMarca.CurrentRow.Index;


                if (intCod > 0)
                {
                    this.intcodForma = intCod;

                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }
    }
}
