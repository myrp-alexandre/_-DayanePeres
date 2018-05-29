using HairLumos.Controller;
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
    public partial class Cadastro_Produto : Form
    {
        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = false;
            ttbDescricao.Enabled = false;
            dgvProduto.Enabled = false;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;

            //pesquisaCategoria();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbNome.Text = "";
            ttbDescricao.Text = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = true;
            ttbDescricao.Enabled = true;

            //botões
            btnNovo.Enabled = true;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnSair.Enabled = true;

            ttbNome.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;

            ttbNome.Enabled = true;
            ttbDescricao.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;

            ttbNome.Focus();

            pesquisaProduto();
            _limpaCampos();
        }

        public void carregaProdutoTela(string strCod, string strcodCategoria, string strcodMarca, string strproduto, 
            string strcusto, string strvenda, string strdescricao, string strqtde, string strobs)
        {
            ttbCodigo.Text = strCod;
            cbbCategoria.Text = strcodCategoria;
            cbbMarca.Text = strcodMarca;
            ttbNome.Text = strproduto;
            mskPrecoCompra.Text = strcusto;
            mskPrecoVenda.Text = strvenda;
            mskQtdeProd.Text = strqtde;
            ttbObservacao.Text = strobs;

        }

        public void carregaGrid()
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();
            DataTable dtRetorno = _ctlProd.retornaCategoria();

            if (dtRetorno != null && dtRetorno.Rows.Count > 0)
            {
                DataRow dr = dtRetorno.Rows[0];
                this.carregaProdutoTela(
                    dr["codproduto"].ToString(),
                    dr["codcategoria"].ToString(),
                    dr["codmarca"].ToString(),
                    dr["prod_produto"].ToString(),
                    dr["prod_precocustoproduto"].ToString(),
                    dr["prod_precovendaproduto"].ToString(),
                    dr["prod_descricao"].ToString(),
                    dr["prod_qtdeproduto"].ToString(),
                    dr["prod_obsproduto"].ToString());

            }
        }

        public void pesquisaProduto()
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();

            DataTable dtRetorno = _ctlProd.retornaCategoria();

            if (dtRetorno != null)
            {
                dgvProduto.DataSource = dtRetorno;
                dgvProduto.ClearSelection();
            }
            else
                dgvProduto.Rows.Clear();

            carregaGrid();

        }

        public void selecinaProduto()
        {

            if (dgvProduto.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvProduto.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);

                if (intCod > 0)
                {
                    //this.intCodigoCategoria = intCod;
                    this.Close();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }
    }
}
