
using HairLumos.Controller;
using HairLumos.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos
{
    public partial class frmMenu : Form
    {
        DataTable dt = new DataTable();

        public frmMenu(DataTable usuario)
        {
            InitializeComponent();
            if (usuario != null && usuario.Rows.Count>0) {
                dt = usuario;
                DataRow dr = dt.Rows[0];
                if (Convert.ToInt32(dr["usu_nivel"]) == 2)
                {

                    usuárioToolStripMenuItem.Visible = false;
                    cadastroDeFormaDePagamentoToolStripMenuItem.Visible = false;
                    cadastroServiçoToolStripMenuItem.Visible = false;
                    cadastroDeDespesaToolStripMenuItem.Visible = false;
                    //cadastroDeParceiroToolStripMenuItem.Visible = false;
                    cadastroDeUsuárioToolStripMenuItem.Visible = false;
                    rELATÓRIOSToolStripMenuItem.Visible = false;
                    iNFORMAÇÕESToolStripMenuItem.Visible = false;
                    bACKUPToolStripMenuItem.Visible = false;
                }
            }
            else
            {
                usuárioToolStripMenuItem.Visible = false;
                cadastroDeFormaDePagamentoToolStripMenuItem.Visible = false;
                cadastroServiçoToolStripMenuItem.Visible = false;
                cadastroDeDespesaToolStripMenuItem.Visible = false;
                //cadastroDeParceiroToolStripMenuItem.Visible = false;
                rELATÓRIOSToolStripMenuItem.Visible = false;
                iNFORMAÇÕESToolStripMenuItem.Visible = false;
                bACKUPToolStripMenuItem.Visible = false;
            }

        }

        private void cadastroCategoriaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_CategoriaProduto CategoProd = new Views.Cadastro_CategoriaProduto();
            CategoProd.ShowDialog();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroMarcaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_MarcaProduto cadastro_MarcaProduto = new Views.Cadastro_MarcaProduto();
            cadastro_MarcaProduto.ShowDialog();
        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Produto cadastro_Produto = new Views.Cadastro_Produto();
            cadastro_Produto.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UsuarioController uc = new UsuarioController();
            DataTable dt = uc.existeUsuarioLogado();
            if(dt!=null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                uc.usuarioLogado(Convert.ToInt32(dr["codusuario"]), 0);
            }

            this.Close();
            Application.Exit();
        }

        private void cadastrodePessoa_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Pessoa cadastro_Pessoa = new Views.Cadastro_Pessoa();
            cadastro_Pessoa.ShowDialog();
        }

        private void cadastroDeFormaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_FormaPagamento cadastro_FormaPagamento = new Views.Cadastro_FormaPagamento();
            cadastro_FormaPagamento.ShowDialog();
        }

        private void cadastroServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroPacoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Pacotes cadastro_Pacotes = new Views.Cadastro_Pacotes();
            cadastro_Pacotes.ShowDialog();
        }

        private void parametrizaçãoDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Parametro_Sistema parametro_Sistema = new Views.Parametro_Sistema();
            parametro_Sistema.ShowDialog();
        }

        private void tipoDeDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_TipoDespesa cadastro_TipoDespesa = new Views.Cadastro_TipoDespesa();
            cadastro_TipoDespesa.ShowDialog();
        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Usuario cadastro_Usuario = new Views.Cadastro_Usuario();
            cadastro_Usuario.ShowDialog();
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UsuarioController uc = new UsuarioController();
            DataTable dt = uc.existeUsuarioLogado();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                uc.usuarioLogado(Convert.ToInt32(dr["codusuario"]), 0);
            }
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void gerenciarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.GerenciarCompra gerenciar_compra = new Views.Funcoes_Fundamentais.GerenciarCompra();
            gerenciar_compra.ShowDialog();
        }

        private void cadastroDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_TipoServico cadastro_Servico = new Views.Cadastro_TipoServico();
            cadastro_Servico.ShowDialog();
        }

        private void cadastroServiçosDeParceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Basicas.Cadastro_ServiçosParceiros cadastro_ServiçosParceiros = new Views.Funcoes_Basicas.Cadastro_ServiçosParceiros();
            cadastro_ServiçosParceiros.ShowDialog();
        }

        private void lançarDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.LancarDespesa lancarDespesas = new Views.Funcoes_Fundamentais.LancarDespesa();
            lancarDespesas.ShowDialog();
        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAO.CaixaDAO caixaDAO = new DAO.CaixaDAO();
            DataTable dt = caixaDAO.caixaAberto();
            if (dt == null || dt.Rows.Count == 0)
            {
                Views.Funcoes_Fundamentais.RF_F6___Abrir_Caixa.AbrirCaixa abrirCaixa = new Views.Funcoes_Fundamentais.RF_F6___Abrir_Caixa.AbrirCaixa();
                abrirCaixa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ja possui um caixa aberto!");
            }
        }

        private void fecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAO.CaixaDAO caixaDAO = new DAO.CaixaDAO();
            DataTable dt = caixaDAO.caixaAberto();
            if (dt != null && dt.Rows.Count > 0)
            {
                Views.Funcoes_Fundamentais.RF_F4___Fechar_Caixa.FecharCaixa fecharCaixa = new Views.Funcoes_Fundamentais.RF_F4___Fechar_Caixa.FecharCaixa();
                fecharCaixa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não possui um caixa aberto!");
            }
        }

        private void gerenciarPacotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Pacotes cadastro_Pacotes = new Cadastro_Pacotes();
            cadastro_Pacotes.ShowDialog();
        }

        private void baixaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.RF_F13_Baixar_Estoque_Manual.BaixarEstoqueManual baixa = new Views.Funcoes_Fundamentais.RF_F13_Baixar_Estoque_Manual.BaixarEstoqueManual();
            baixa.ShowDialog();
        }

        private void contratarPacoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.RF_F14_Contratar_Pacotes.ContratarPacotes ccp = new Views.Funcoes_Fundamentais.RF_F14_Contratar_Pacotes.ContratarPacotes();
            ccp.ShowDialog();
        }

        private void venderProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.RF_F7_Vender_Produto.VenderProduto venderProduto = new Views.Funcoes_Fundamentais.RF_F7_Vender_Produto.VenderProduto();
            venderProduto.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.RF_F2_Agenda.Agenda agenda = new Views.Funcoes_Fundamentais.RF_F2_Agenda.Agenda();
            agenda.ShowDialog();
        }

        private void agendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.RF_F2_Agenda.Agenda agenda = new Views.Funcoes_Fundamentais.RF_F2_Agenda.Agenda();
            agenda.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.QuitarDespesa quitarDespesa = new Views.Funcoes_Fundamentais.QuitarDespesa();
            quitarDespesa.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.RF_F11_Quitar_Contas_a_Receber.QuitarContasReceber quitarContasReceber = new Views.Funcoes_Fundamentais.RF_F11_Quitar_Contas_a_Receber.QuitarContasReceber();
            quitarContasReceber.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.RF_F12_Gerenciar_Comissao.GerenciarComissao gerenciarComissao = new Views.Funcoes_Fundamentais.RF_F12_Gerenciar_Comissao.GerenciarComissao();
            gerenciarComissao.ShowDialog();
        }
    }
}
