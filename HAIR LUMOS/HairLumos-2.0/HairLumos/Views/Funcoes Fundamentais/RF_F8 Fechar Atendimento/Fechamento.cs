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
    public partial class Fechamento : Form
    {
        public Fechamento()
        {
            InitializeComponent();
        }

        public Fechamento(int codV)
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mskTotalServico_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            int cod = 0;
            Views.Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa pesquisa = new Funcoes_Basicas.Pesquisas.Pesquisa_Pessoa();
            pesquisa.ShowDialog();

            cod = pesquisa.intCodigoPessoa;
            if (cod > 0)
            {
                carregaTela(cod);
            }

        }

        private void carregaTela(int codPessoa)
        {
            Controller.PessoaController pc = new Controller.PessoaController();
            Controller.VendaController vc = new Controller.VendaController();

            Entidades.Pessoa pessoa = new Entidades.Pessoa();
            Entidades.Venda venda = new Entidades.Venda();
            Entidades.VendaProduto vp = new Entidades.VendaProduto();

            List<Entidades.Venda> listaVendas = new List<Entidades.Venda>();
            List<Entidades.VendaProduto> listaItensVenda = new List<Entidades.VendaProduto>();

            DataTable dtPessoa = new DataTable();
            dtPessoa = pc.retornaPessoaCod(codPessoa + "");
            if(dtPessoa!=null && dtPessoa.Rows.Count > 0)
            {
                DataRow drPessoa = dtPessoa.Rows[0];
                pessoa.Codigo = Convert.ToInt32(drPessoa["codpessoa"].ToString());
                pessoa.Nome = drPessoa["pes_nome"].ToString();
                pessoa.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                pessoa.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                pessoa.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                pessoa.Observacao = drPessoa["pes_obs"].ToString();
                pessoa.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                pessoa.Email = drPessoa["pes_email"].ToString();
                pessoa.Telefone = drPessoa["pes_fone"].ToString();
                pessoa.Celular = drPessoa["pes_cel"].ToString();

                ttbCliente.Text = pessoa.Nome;
            }
            //procuro todas as venda abertas do cliente
            DataTable dtVenda = new DataTable();
            dtVenda = vc.retornaVendaPessoa(codPessoa);
            if(dtVenda!=null && dtVenda.Rows.Count > 0)
            {
                for(int i=0; i<dtVenda.Rows.Count; i++)
                {
                    DataRow drVenda = dtVenda.Rows[i];
                    venda = new Entidades.Venda();
                    venda.Codigo = Convert.ToInt32(drVenda["codvenda"].ToString());
                    venda.Data = Convert.ToDateTime(drVenda["vend_datavenda"].ToString());
                    venda.Situacao = drVenda["vend_situacao"].ToString();
                    venda.ValorTotal = Convert.ToDouble(drVenda["vend_valortotal"].ToString());
                    venda.Observacao = drVenda["vend_obs"].ToString();
                    venda.Pessoa = pessoa;

                    DataTable dtItens = vc.retornaProdutos(venda.Codigo);
                    if(dtItens!=null && dtItens.Rows.Count > 0)
                    {
                        for(int k =0; k<dtItens.Rows.Count; k++)
                        {
                            DataRow drItens = dtItens.Rows[i];
                            vp = new Entidades.VendaProduto();
                            vp.Quantidade = Convert.ToInt32(drItens["vendprod_qtde"].ToString());
                            vp.Valor = Convert.ToDouble(drItens["vendprod_valor"].ToString());


                        }
                    }

                }
            }

        }
    }
}
