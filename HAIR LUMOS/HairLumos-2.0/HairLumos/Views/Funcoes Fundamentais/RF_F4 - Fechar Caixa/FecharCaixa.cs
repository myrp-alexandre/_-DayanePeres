using HairLumos.Controller;
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
            lista = new List<FechamentoTabela>();
            ttbCodigo.Enabled = false;
            ttbUsuário.Enabled = false;
            UsuarioController uc = new UsuarioController();
            DataTable dt = uc.existeUsuarioLogado();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ttbUsuário.Text = dr["usu_usuario"].ToString();
            }
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
            mskDifereca.Text = "";
            mskFechamentoInformado.Text = "";
            mskFechamentoLancado.Text = "";
            mskLiquido.Text = "";
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
            dgvFechaCaixa.DataSource = lista;
        }
    }
}
