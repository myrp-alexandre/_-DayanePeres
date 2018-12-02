using HairLumos.Controller;
using HairLumos.DAO;
using HairLumos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F4___Fechar_Caixa
{
    public partial class FecharCaixa : Form
    {
        List<FechamentoTabela> lista;

        public FecharCaixa()
        {
            InitializeComponent();
            inicializa();

            if(!string.IsNullOrWhiteSpace(mskInicialCaixa.Text))
                mskInicialCaixa.Text = Convert.ToDouble(mskInicialCaixa.Text).ToString("###,###,##0.00");
            if (!string.IsNullOrWhiteSpace(mskTotalRecebido.Text))
                mskTotalRecebido.Text = Convert.ToDouble(mskTotalRecebido.Text).ToString("###,###,##0.00");
            if (!string.IsNullOrWhiteSpace(mskTotalGasto.Text))
                mskTotalGasto.Text = Convert.ToDouble(mskTotalGasto.Text).ToString("###,###,##0.00");
            if (!string.IsNullOrWhiteSpace(mskRestante.Text))
                mskRestante.Text = Convert.ToDouble(mskRestante.Text).ToString("###,###,##0.00");

        }
        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpatela();
            inicializa();
        }

        public void inicializa()
        {
            CaixaController cc = new CaixaController();
            lista = new List<FechamentoTabela>();
            ttbCodigo.Enabled = false;
            ttbUsuário.Enabled = false;
            mskInicialCaixa.Enabled = false;
            mskTotalRecebido.Enabled = false;
            mskRestante.Enabled = false;
            mskTotalGasto.Enabled = false;
            UsuarioController uc = new UsuarioController();
            DataTable dt = uc.existeUsuarioLogado();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ttbUsuário.Text = dr["usu_usuario"].ToString();
            }
            mskInicialCaixa.Text = cc.retornaValCaixaAberto() + "";
            mskTotalRecebido.Text = somaFatura() + "";
            mskTotalGasto.Text = somaCredito() + "";
            mskRestante.Text = ((cc.retornaValCaixaAberto() + somaFatura()) - somaCredito()).ToString();
        }
        

        public void limpatela()
        {
            ttbCodigo.Text = "";
            ttbUsuário.Text = "";
            ttbObservacao.Text = "";
            mskRestante.Text = "";
            mskTotalRecebido.Text = "";
            mskInicialCaixa.Text = "";
            mskTotalGasto.Text = "";
        }

        

        private double somalista(List<FechamentoTabela> lista)
        {
            double valor = 0;
            for(int i = 0; i<lista.Count; i++)
            {
                valor += lista[i].Valor;
            }
            return valor;
        }

        private double somaFatura()
        {
            double total = 0;
            DateTime data = DateTime.Now;
            ContasReceberDAO cr = new ContasReceberDAO();
            DAO.CaixaDAO caixaDAO = new DAO.CaixaDAO();
            DataTable dt = caixaDAO.caixaAberto();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                data = Convert.ToDateTime(dr["caixa_datahoraabertura"].ToString());
            }
            DataTable dtContas = cr.retornaContasPeriodo(data);
            if (dtContas != null && dtContas.Rows.Count > 0)
            {
                for (int i = 0; i < dtContas.Rows.Count; i++) {
                    DataRow dr = dtContas.Rows[i];
                    total += Convert.ToDouble(dr["contrec_valortotal"].ToString());
                }
            }
            return total;
        }

        private double somaCredito()
        {
            double total = 0;
            DateTime data = DateTime.Now;
            ContasPagarDAO cr = new ContasPagarDAO();
            DAO.CaixaDAO caixaDAO = new DAO.CaixaDAO();
            DataTable dt = caixaDAO.caixaAberto();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                data = Convert.ToDateTime(dr["caixa_datahoraabertura"].ToString());
            }
            DataTable dtContas = cr.retornaContasPeriodo(data);
            if (dtContas != null && dtContas.Rows.Count > 0)
            {
                for (int i = 0; i < dtContas.Rows.Count; i++)
                {
                    DataRow dr = dtContas.Rows[i];
                    total += Convert.ToDouble(dr["contpag_valorpago"].ToString());
                }
            }
            return total;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int caixa=0;
            CaixaController cc = new CaixaController();
            DAO.CaixaDAO caixaDAO = new DAO.CaixaDAO();
            DataTable dt = caixaDAO.caixaAberto();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                caixa = Convert.ToInt32(dr["codcaixa"].ToString());
            }
            int result = cc.fechaCaixa(caixa, mskTotalGasto.Text, DateTime.Now);
            if(result > 0)
            {
                MessageBox.Show("Caixa Fechado com Sucesso!");
                limpatela();
                inicializa();
            }
            else
            {
                MessageBox.Show("Erro ao fechar o caixa!");
            }

        }

        private void FecharCaixa_Load(object sender, EventArgs e)
        {

        }

        

        private void mskInicialCaixa_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskInicialCaixa);
        }

        private void mskInicialCaixa_Leave(object sender, EventArgs e)
        {
            mskInicialCaixa.Text = Convert.ToDouble(mskInicialCaixa.Text).ToString("###,###,##0.00");
        }

        private void mskInicialCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskInicialCaixa, e);
        }

        private void mskTotalRecebido_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotalRecebido);
        }

        private void mskTotalRecebido_Leave(object sender, EventArgs e)
        {
            mskTotalRecebido.Text = Convert.ToDouble(mskTotalRecebido.Text).ToString("###,###,##0.00");
        }

        private void mskTotalRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotalRecebido, e);
        }

        private void mskTotalGasto_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotalGasto);
        }

        private void mskTotalGasto_Leave(object sender, EventArgs e)
        {
            mskTotalGasto.Text = Convert.ToDouble(mskTotalGasto.Text).ToString("###,###,##0.00");
        }

        private void mskTotalGasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotalGasto, e);
        }

        private void mskRestante_Enter(object sender, EventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._enterPropriedade(mskTotalGasto);
        }

        private void mskRestante_Leave(object sender, EventArgs e)
        {
            mskTotalGasto.Text = Convert.ToDouble(mskTotalGasto.Text).ToString("###,###,##0.00");
        }

        private void mskRestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Views.Outras_Fundamentais.EnterPropriedades enterPropriedades = new Outras_Fundamentais.EnterPropriedades();
            enterPropriedades._keyPessPropriedade(mskTotalGasto, e);
        }
    }
}
