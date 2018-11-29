using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F8_Fechar_Atendimento
{
    public partial class FecharAtendimento : Form
    {
        //private List<Entidades.TabelaVendaProduto> listaVendaProduto;
        //private List<Entidades.Venda> listaVenda;
        //private List<Entidades.Produto> listaProduto;

        public string quemChamou { get; set; }

        public FecharAtendimento()
        {
            InitializeComponent();
            pesquisaVendaProduto();
            CarregaFormasPagamento();
        }

        private void CarregaFormasPagamento()
        {
            Controller.PagamentoController objForma = new Controller.PagamentoController();

            DataTable dtFormas = objForma.retornaFormaPagamento();
            if (dtFormas != null && dtFormas.Rows.Count > 0)
            {
                this.cbbForma.ValueMember = "codformapag";
                this.cbbForma.DisplayMember = "formpag_descricao";
                this.cbbForma.DataSource = dtFormas;
            }
        }


        private void DGVMoeda()
        {
            if(dgvListaProdutos.Rows.Count > 0)
                this.dgvListaProdutos.Columns["vendprod_valor"].DefaultCellStyle.Format = "c";

        }

        private void carregaGridProduto(DataTable dt)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = dt;
            dgvListaProdutos.DataSource = bd;
            dgvListaProdutos.Refresh();
            //DGVMoeda();
        }

        private void pesquisaVendaProduto()
        {
            try
            {
                Controller.VendaController vendaController = new Controller.VendaController();
                Entidades.VendaProduto vendaProduto = new Entidades.VendaProduto();

                int intCodVendaProd = vendaController.retornaUltimaVendaProduto();

                int codVenda = 0;

                if(intCodVendaProd > 0)
                {
                    DataTable dtVenda = vendaController.retornaVendaCod(intCodVendaProd);


                    if(dtVenda != null && dtVenda.Rows.Count > 0)
                    {
                        DataRow drVenda = dtVenda.Rows[0];
                        codVenda = Convert.ToInt32(drVenda["codvenda"].ToString());

                        DataTable dtVendProd = vendaController.retornaVendaProdutoCod(codVenda);

                        if(dtVendProd != null && dtVendProd.Rows.Count > 0)
                        {
                            DataRow dr = dtVendProd.Rows[0];
                            for (int i = 0; i < dtVendProd.Rows.Count; i++)
                            {
                                
                                //Entidades.Venda venda = new Entidades.Venda();
                                vendaProduto = new Entidades.VendaProduto();
                                //DataRow drVendProd = dtVendProd.Rows[i];
                                carregaGridProduto(dtVendProd);
                                mskTotal.Text = dr["vend_valortotal"].ToString();
                            }
                            mskTotal.Text = dr["vend_valortotal"].ToString();
                            mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");
                        }
                        

                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }
            

        }
       

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void mskAcrescimo_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskAcrescimo);
        }

        private void mskAcrescimo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mskAcrescimo.Text) && mskAcrescimo.Equals("00,00"))
                mskAcrescimo.Text = Convert.ToDouble(mskAcrescimo.Text).ToString("###,###,##0.00");
        }

        private void mskAcrescimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskAcrescimo, e);
        }

        private void mskDesconto_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskDesconto);
        }

        private void mskDesconto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mskDesconto.Text) && mskDesconto.Equals("00,00"))
                mskDesconto.Text = Convert.ToDouble(mskDesconto.Text).ToString("###,###,##0.00"); 
        }

        private void mskDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskDesconto, e);
        }

        private void mskValorPagar_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskValorPagar);
        }

        private void mskValorPagar_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mskValorPagar.Text) && mskValorPagar.Equals("00,00"))
                mskValorPagar.Text = Convert.ToDouble(mskValorPagar.Text).ToString("###,###,##0.00");
        }

        private void mskValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskValorPagar, e);
        }

        private void mskSubtotal_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskSubtotal);
        }

        private void mskSubtotal_Leave(object sender, EventArgs e)
        {
            mskSubtotal.Text = Convert.ToDouble(mskSubtotal.Text).ToString("###,###,##0.00");
        }

        private void mskSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskSubtotal, e);
        }

        private void mskTotal_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotal);
        }

        private void mskTotal_Leave(object sender, EventArgs e)
        {
            mskTotal.Text = Convert.ToDouble(mskTotal.Text).ToString("###,###,##0.00");

        }

        private void mskTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotal, e);
        }

        private void mskRecebido_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskRecebido);
        }

        private void mskRecebido_Leave(object sender, EventArgs e)
        {
            mskRecebido.Text = Convert.ToDouble(mskRecebido.Text).ToString("###,###,##0.00");
        }

        private void mskRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskRecebido, e);
        }

        private void mskRestante_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskRestante);
        }

        private void mskRestante_Leave(object sender, EventArgs e)
        {
            mskRestante.Text = Convert.ToDouble(mskRestante.Text).ToString("###,###,##0.00");
        }

        private void mskRestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskRestante, e);
        }

        private void mskTroco_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTroco);
        }

        private void mskTroco_Leave(object sender, EventArgs e)
        {
            mskTroco.Text = Convert.ToDouble(mskTroco.Text).ToString("###,###,##0.00");
        }

        private void mskTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTroco, e);
        }

        private void btnFecharVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirForma_Click(object sender, EventArgs e)
        {

        }
    }
}
