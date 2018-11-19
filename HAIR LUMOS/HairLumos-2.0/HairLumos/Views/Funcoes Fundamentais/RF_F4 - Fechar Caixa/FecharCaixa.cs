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
            carregaCbbPagamento();
            inicializa();

            

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

        public void carregaCbbPagamento()
        {
            Controller.PagamentoController _ctrlPgto = new Controller.PagamentoController();

            DataTable dtFPgto = _ctrlPgto.retornaFormaPagamento();
            if (dtFPgto != null && dtFPgto.Rows.Count > 0)
            {
                this.cbbFormaPagamento.ValueMember = "codformapag";
                this.cbbFormaPagamento.DisplayMember = "formpag_descricao";
                this.cbbFormaPagamento.DataSource = dtFPgto;
            }
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
            mskValor.Text = "";
            dgvFechaCaixa.DataSource = new List<FechamentoTabela>();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            PagamentoController pc = new PagamentoController();
            FechamentoTabela fc = new FechamentoTabela();
            int codigo = Convert.ToInt32(cbbFormaPagamento.SelectedValue.ToString());
            DataTable dtForma = pc.retornaObjFormaPagamento(codigo);
            DataRow dr = dtForma.Rows[0];
            FormaPagamento f = new FormaPagamento();
            f.Codigo = Convert.ToInt32(dr["codformapag"].ToString());
            f.Forma = dr["formpag_descricao"].ToString();
            fc.Forma = f.Forma;
            fc.Valor = Convert.ToDouble(mskValor.Text.ToString());
            lista.Add(fc);
            carregaDGV(lista);
            mskValor.Text = "";
            mskTotalRecebido.Text = somalista(lista).ToString();
            double valor = Convert.ToDouble(mskInicialCaixa.Text.ToString());
            mskTotalGasto.Text = ((valor) + somalista(lista)).ToString();
            mskRestante.Text = (valor - somalista(lista)).ToString();
        }

        private void carregaDGV(List<FechamentoTabela> lista)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = lista;
            dgvFechaCaixa.DataSource = bd;
            dgvFechaCaixa.Refresh();
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
    }
}
