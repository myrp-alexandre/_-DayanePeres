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
        private int intCodigoCategoria = 0;

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
            dgvCatProduto.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;            
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;

            pesquisaCategoria();
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
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;

            ttbCategoria.Focus();
            
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

                    if(intRetorno == 1)
                    {
                        MessageBox.Show("Gravado com sucesso!");
                        _limpaCampos();
                        _inicializa();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar.");
                    }
                    
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
                DataRow dr = dtRetorno.Rows[intCodigoCategoria];
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
                        MessageBox.Show("Categoria Excluída");
                        _limpaCampos();
                        pesquisaCategoria();
                        _inicializa();
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
                intCod = dgvCatProduto.CurrentRow.Index +1;

                if(intCod > 0)
                {
                    this.intCodigoCategoria = intCod;
                    ttbCodigo.Text = dgvCatProduto.CurrentRow.Cells[0].Value.ToString();
                    ttbCategoria.Text = dgvCatProduto.CurrentRow.Cells[1].Value.ToString();
                    ttbObservacao.Text = dgvCatProduto.CurrentRow.Cells[2].Value.ToString();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            pesquisaCategoria();
        }

        private void dgvCatProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecinaCategoria();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecinaCategoria();
        }
    }
}
