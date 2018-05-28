using HairLumos.Controller;
using HairLumos.Models;
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
    public partial class Cadastro_CategoriaProduto : Form
    {
        public Cadastro_CategoriaProduto()
        {
            InitializeComponent();
            _inicializa();
            _limpaCampos();
            dgvCatProduto.AutoGenerateColumns = false;
            pesquisaCategoria();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbCategoria.Enabled = false;
            ttbObservacao.Enabled = false;
            dgvCatProduto.Enabled = false;

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
            ttbCategoria.Text = "";
            ttbObservacao.Text = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbCategoria.Enabled = true;
            ttbObservacao.Enabled = true;

            //botões
            btnNovo.Enabled = true;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnSair.Enabled = true;

            ttbCategoria.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;

            ttbCategoria.Enabled = true;
            ttbObservacao.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;

            ttbCategoria.Focus();

            pesquisaCategoria();
            _limpaCampos();
        }



        private void Cadastro_CategoriaProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //ProdutoModels _mdlProd = new ProdutoModels();
            Controller.ProdutoController _ctrlProd = new ProdutoController();

            string strMensagem = string.Empty;

            try
            {
                //validações
                int intCodigo = 0;
                if(!int.TryParse(ttbCodigo.Text, out intCodigo))
                    strMensagem += $"Código inválido{Environment.NewLine}";

                if (string.IsNullOrWhiteSpace(ttbCategoria.Text))
                    strMensagem += $"Informe a categoria do Produto.";

                //verificar se houve alguma anormalidade no cadastro
                if (string.IsNullOrEmpty(strMensagem))
                {
                    //_mdlProd
                    int intRetorno = _ctrlProd.gravaCategoria(intCodigo, ttbCategoria.Text, ttbObservacao.Text);//intCodigo, ttbCategoria.Text, ttbObservacao.Text
                    MessageBox.Show("Gravado com sucesso!");
                    _limpaCampos();
                    _inicializa();
                }
                else
                    MessageBox.Show(strMensagem, "Aviso!!");

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex+"");
            }

        }

        public void carregaGrid()
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();
            DataTable dtRetorno = _ctlProd.retornaCategoria();

            if(dtRetorno != null && dtRetorno.Rows.Count > 0)
            {
                DataRow dr = dtRetorno.Rows[0];
                this.carregaCategoriaTela(
                    dr["codcategoria"].ToString(),
                    dr["cat_categoria"].ToString(),
                    dr["cat_obscategoria"].ToString());

            }
        }

        public void carregaCategoriaTela(string strCod, string strNomeCateg, string strObs)
        {
            ttbCodigo.Text = strCod;
            ttbCategoria.Text = strNomeCateg;
            ttbObservacao.Text = strObs;
        }

        public void pesquisaCategoria()
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();

            DataTable dtRetorno = _ctlProd.retornaCategoria();

            if (dtRetorno != null)
            {
                dgvCatProduto.DataSource = dtRetorno;
                dgvCatProduto.ClearSelection();
            }
            else
                dgvCatProduto.Rows.Clear();

            carregaGrid();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _btnAlterar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();

            int intCod = 0;

            int.TryParse(ttbCodigo.Text, out intCod);

            if (intCod > 0)
            {
                if (MessageBox.Show("Confirma exclusão da Categoria?", "Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool blnExcluiu = _ctlProd.excluirCategoria(intCod);
                    if (blnExcluiu)
                    {
                        MessageBox.Show("Funcionário Excluído");
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

        public void selecinaCategoria()
        {
            
            if (dgvCatProduto.Rows.Count > 0)
            {
                int intCod = 0;
                int.TryParse(dgvCatProduto.CurrentRow.Cells[0].FormattedValue.ToString(), out intCod);

                if(intCod > 0)
                {
                    //this.intCodigoCategoria = intCod;
                    this.Close();
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.selecinaCategoria();
        }

        private void dgvCatProduto_DoubleClick(object sender, EventArgs e)
        {
            this.selecinaCategoria();
        }

        private void dgvCatProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecinaCategoria();
        }

        private void dgvCatProduto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.selecinaCategoria();
        }
    }
}
