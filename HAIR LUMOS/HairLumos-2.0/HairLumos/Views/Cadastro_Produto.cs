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
        private int intCodigoProduto = 0;
        private int _indiceLinha = -1; //Indice da linha do DataGridView(começa de 0)
        private bool _selecionou = false; //Para verificar se clicou em selecionar

        public Cadastro_Produto()
        {
            InitializeComponent();
            _inicializa();
           
            dgvProduto.AutoGenerateColumns = false;
            pesquisaProduto();
            _limpaCampos();
            carregaCbbCategoria();
            carregaCbbMarca();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = false;
            ttbObservacao.Enabled = false;
            mskPrecoCompra.Enabled = false;
            mskPrecoVenda.Enabled = false;
            mskQtdeProd.Enabled = false;
            ttbDescricao.Enabled = false;
            cbbCategoria.Enabled = false;
            cbbMarca.Enabled = false;
            dgvProduto.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSair.Enabled = true;

            pesquisaProduto();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbNome.Text = "";
            ttbDescricao.Text = "";
            ttbObservacao.Text = "";
            mskPrecoCompra.Text = "";
            mskPrecoVenda.Text = "";
            mskQtdeProd.Text = "";
            cbbCategoria.Text = "";
            cbbMarca.Text = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbNome.Enabled = true;
            ttbObservacao.Enabled = true;
            mskPrecoCompra.Enabled = true;
            mskPrecoVenda.Enabled = true;
            mskQtdeProd.Enabled = true;
            ttbDescricao.Enabled = true;
            cbbCategoria.Enabled = true;
            cbbMarca.Enabled = true;
            dgvProduto.Enabled = true;
            

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            _limpaCampos();
            ttbNome.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;

            ttbNome.Enabled = true;
            ttbObservacao.Enabled = true;
            mskPrecoCompra.Enabled = true;
            mskPrecoVenda.Enabled = true;
            mskQtdeProd.Enabled = true;
            ttbDescricao.Enabled = true;
            cbbCategoria.Enabled = true;
            cbbMarca.Enabled = true;
            dgvProduto.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSair.Enabled = true;

            ttbNome.Focus();

        }

        public void carregaCbbCategoria()
        {
            Controller.ProdutoController _ctrlProd = new ProdutoController();

            DataTable dtCategoria = _ctrlProd.retornaCategoria();
            if (dtCategoria != null && dtCategoria.Rows.Count > 0)
            {
                this.cbbCategoria.ValueMember = "codcategoria";
                this.cbbCategoria.DisplayMember = "cat_categoria";
                this.cbbCategoria.DataSource = dtCategoria;
            }
            
        }

        public void carregaCbbMarca()
        {
            Controller.ProdutoController _ctrlProd = new ProdutoController();

            DataTable dtMarca = _ctrlProd.retornaMarca();
            if (dtMarca != null && dtMarca.Rows.Count > 0)
            {
                this.cbbMarca.ValueMember = "codmarca";
                this.cbbMarca.DisplayMember = "marc_nome";
                this.cbbMarca.DataSource = dtMarca;
            }
        }

        public void carregaCbbNomeCategoria(int codCategoria)
        {

            Controller.ProdutoController _ctrlProd = new ProdutoController();

            DataTable dtCategoria = _ctrlProd.retornaObjCategoria(codCategoria);
            if (dtCategoria != null && dtCategoria.Rows.Count > 0)
            {
                this.cbbCategoria.ValueMember = "codcategoria";
                this.cbbCategoria.DisplayMember = "cat_categoria";
                this.cbbCategoria.DataSource = dtCategoria;
            }

        }

        public void carregaCbbNomeMarca(int codMarca)
        {

            Controller.ProdutoController _ctrlProd = new ProdutoController();
            DataTable dtMarca = _ctrlProd.retornaObjMarca(codMarca);

            if (dtMarca != null && dtMarca.Rows.Count > 0)
            {
                this.cbbMarca.ValueMember = "codmarca";
                this.cbbMarca.DisplayMember = "marc_nome";
                this.cbbMarca.DataSource = dtMarca;
            }

        }

        public void carregaComboCategoriaTela(string strcodCategoria)
        {
            Controller.ProdutoController _ctrlProd = new ProdutoController();            

            int codCategoria = 0;
            int.TryParse(strcodCategoria, out codCategoria);
            DataTable dtProd = _ctrlProd.retornaObjCategoria(codCategoria);
            if (dtProd != null && dtProd.Rows.Count > 0)
            {
                this.cbbCategoria.ValueMember = "codcategoria";
                this.cbbCategoria.DisplayMember = "cat_categoria";
                this.cbbCategoria.DataSource = dtProd;
            }
        }

        public void carregaComboMarcaTela(string strcodMarca)
        {
            Controller.ProdutoController _ctrlProd = new ProdutoController();
            
            int codMarca = 0;
            int.TryParse(strcodMarca, out codMarca);
            DataTable dtProd = _ctrlProd.retornaObjMarca(codMarca);
            if (dtProd != null && dtProd.Rows.Count > 0)
            {
                this.cbbMarca.ValueMember = "codmarca";
                this.cbbMarca.DisplayMember = "marc_nome";
                this.cbbMarca.DataSource = dtProd;
            }

        }

        public void carregaProdutoTela(string strCod, string strcodCategoria, string strcodMarca, string strproduto, 
            string strcusto, string strvenda, string strdescricao, string strobs, string strqtde)
        {
            

            ttbCodigo.Text = strCod;
            cbbCategoria.Text = strcodCategoria;
            cbbMarca.Text = strcodMarca;
            ttbNome.Text = strproduto;
            mskPrecoCompra.Text = strcusto;
            mskPrecoVenda.Text = strvenda;
            ttbDescricao.Text = strdescricao;
            ttbObservacao.Text = strobs;
            mskQtdeProd.Text = strqtde;

            //carregaComboCategoriaTela(strcodCategoria);
            //carregaComboMarcaTela(strcodMarca);
        }

        public void carregaGrid()
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();
            DataTable dtRetorno = _ctlProd.retornaProduto();

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
                    dr["prod_obsproduto"].ToString(),
                    dr["prod_qtdeproduto"].ToString());

            }
        }

        public void pesquisaProduto()
        {
            //Inicializo meu índice de linha todas vez que clicar em pesquisar, pois a minha pesquisar pode não retornar linhas
            _indiceLinha = -1;
            Controller.ProdutoController _ctlProd = new ProdutoController();

            DataTable dtRetorno = _ctlProd.retornaProduto();

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
                    this.intCodigoProduto = intCod;
                    
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void ttbCancelar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            pesquisaProduto();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.ProdutoController _ctrlProd = new ProdutoController();

            string strMensagem = string.Empty;

            try
            {
                int intCodigo = 0;
                if(intCodigoProduto != 0)
                {
                    if (!int.TryParse(ttbCodigo.Text, out intCodigo))
                        strMensagem += $"Código Inválido";
                }

                if (string.IsNullOrWhiteSpace(ttbNome.Text))
                    strMensagem += $"Informe Nome do Produto.";

                if (string.IsNullOrWhiteSpace(mskPrecoCompra.Text))
                    strMensagem += $"Informe preço de Custo do Produto";

                if (string.IsNullOrWhiteSpace(mskPrecoVenda.Text))
                    strMensagem += $"Informe Preço de Venda do Produto";

                if (string.IsNullOrWhiteSpace(mskQtdeProd.Text))
                    strMensagem += $"Informe quantidade do Produto.";

               
                double custo = 0; // = Convert.ToDouble(mskPrecoCompra.Text);
                double.TryParse(mskPrecoCompra.Text, out custo);

                double venda = 0; //Convert.ToDouble(mskPrecoVenda.Text);
                double.TryParse(mskPrecoVenda.Text, out venda);
                int qtde = 0; // Convert.ToInt32(mskQtdeProd.Text);
                int.TryParse(mskQtdeProd.Text, out qtde);



                int categoria = Convert.ToInt32(cbbCategoria.SelectedValue.ToString());
                int marca = Convert.ToInt32(cbbMarca.SelectedValue.ToString());


                if (string.IsNullOrEmpty(strMensagem))
                {

                    int intRetorno = _ctrlProd.gravaProduto(intCodigo,categoria , marca, 
                        ttbNome.Text, custo, venda, ttbDescricao.Text, qtde, ttbObservacao.Text);
                    if( intRetorno > 0)
                    {
                        MessageBox.Show("Gravado com Sucesso!");
                        _limpaCampos();
                        _inicializa();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Gravar.");
                    }

                    
                }
                else
                    MessageBox.Show(strMensagem, "Aviso!!");
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex + ""); ;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int codCategoria = 0;
            int codMarca = 0;
                       

            _btnAlterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controller.ProdutoController _ctrlProd = new ProdutoController();

            int intCod = 0;
            int.TryParse(ttbCodigo.Text, out intCod);

            if(intCod > 0)
            {
                if (MessageBox.Show("Confirma exclusão do Produto?", "Produto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool blnExcluiu = _ctrlProd.excluirProduto(intCod);
                    if (blnExcluiu)
                    {
                        MessageBox.Show("Produto Excluído");
                        _limpaCampos();
                        pesquisaProduto();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            pesquisaProduto();
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _indiceLinha = e.RowIndex; //Pega o índice da linha que está selecionada
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecinaProduto();         

            carregaGrid();
            
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (_indiceLinha != -1)//Se selecionou algo no DataGridView
            {
                int intLinha = dgvProduto.CurrentRow.Index;
                if (intLinha >= 0)
                {
                    _selecionou = true;
                    this.Close();
                }
            }
            else//Se não selecionou nada no DataGridView
            {
                MessageBox.Show("Clique em alguma linha e depois em Selecionar ou clique duas vezes em cima da linha");
            }
        }
    }
}
