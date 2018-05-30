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
    public partial class Cadastro_MarcaProduto : Form
    {
        private int intCodigoMarca = 0;

        public Cadastro_MarcaProduto()
        {
            InitializeComponent();
            _inicializa();
            _limpaCampos();
            dgvMarca.AutoGenerateColumns = false;
            pesquisaMarca();
        }

        public void _inicializa()
        {
            // ttb
            ttbCodigo.Enabled = false;
            ttbMarca.Enabled = false;
            dgvMarca.Enabled = true;

            //btn
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSair.Enabled = true;

            pesquisaMarca();
            _limpaCampos();

        }

        public void _limpaCampos()
        {
            ttbCodigo.Text = "";
            ttbMarca.Text = "";
        }

        public void _btnNovo()
        {
            ttbCodigo.Text = "0";
            ttbCodigo.Enabled = false;
            ttbMarca.Enabled = true;

            //botões
            btnNovo.Enabled = true;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnSair.Enabled = true;

            ttbMarca.Focus();
        }

        public void _btnAlterar()
        {
            ttbCodigo.Enabled = false;
            ttbMarca.Enabled = true;

            //botões
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;

            ttbMarca.Focus();
                       
        }

        public void carregaMarcaTela(string strCod, string StrMarca)
        {
            ttbCodigo.Text = strCod;
            ttbMarca.Text = StrMarca;
        }
        
        public void carregaGrid()
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();
            DataTable dtRetorno = _ctlProd.retornaMarca();

            if (dtRetorno != null && dtRetorno.Rows.Count > 0)
            {
                DataRow dr = dtRetorno.Rows[intCodigoMarca-1];
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
                    this.intCodigoMarca = intCod;
                    
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _btnNovo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.ProdutoController _ctrlProd = new ProdutoController();

            string strMensagem = string.Empty;

            try
            {
                //validações
                int intCodigo = 0;
                if (intCodigoMarca != 0)
                {
                    if (!int.TryParse(ttbCodigo.Text, out intCodigo))
                        strMensagem += $"Código inválido{Environment.NewLine}";
                }
                

                if (string.IsNullOrWhiteSpace(ttbMarca.Text))
                    strMensagem += $"Informe a Marca do Produto.";

                //verificar se houve alguma anormalidade no cadastro
                if (string.IsNullOrEmpty(strMensagem))
                {
                    
                    int intRetorno = _ctrlProd.gravarMarca(intCodigo, ttbMarca.Text);
                    MessageBox.Show("Gravado com sucesso!");
                    _limpaCampos();
                    _inicializa();
                }
                else
                    MessageBox.Show(strMensagem, "Aviso!!");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex + "");
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _btnAlterar();
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controller.ProdutoController _ctlProd = new ProdutoController();

            int intCod = 0;

            int.TryParse(ttbCodigo.Text, out intCod);

            if (intCod > 0)
            {
                if (MessageBox.Show("Confirma exclusão da Marca?", "Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool blnExcluiu = _ctlProd.excluirMarca(intCod);
                    if (blnExcluiu)
                    {
                        MessageBox.Show("Marca Excluída");
                        _limpaCampos();
                        pesquisaMarca();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMarca_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void dgvMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            selecinaMarca();
            carregaGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _limpaCampos();
            pesquisaMarca();
        }
    }
}
