using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairLumos.Views.Funcoes_Fundamentais.RF_F14_Contratar_Pacotes
{
    public partial class ContratarPacotes : Form
    {
        //private List<Entidades.PacotesAdicionais> listaPacotesAdc;
        private List<Entidades.TabelaPacotes> listaTabela;
        private List<Entidades.PacoteServico> listaPacoteServico;

        public ContratarPacotes()
        {
            InitializeComponent();
            carregaCbbPacote();
            carregaCbbServico();
            dgvPacote.AutoGenerateColumns = false;
            listaTabela = new List<Entidades.TabelaPacotes>();
            listaPacoteServico = new List<Entidades.PacoteServico>();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            Views.Pesquisa_Pessoa pesquisa_Pessoa = new Pesquisa_Pessoa();

            pesquisa_Pessoa.ShowDialog();

            Controller.PessoaController pessoaController = new Controller.PessoaController();
            DataTable dtRetorno = pessoaController.retornaPessoaFisica();

                if (dtRetorno != null && dtRetorno.Rows.Count > 0)
                {
                    DataRow dr = dtRetorno.Rows[0];
                    ttbCliente.Text = dr["pes_nome"].ToString();

                }
            
        }

        public void carregaCbbPacote()
        {
            Controller.PacoteController pacoteController = new Controller.PacoteController();

            DataTable dtPacote = pacoteController.retornaPacote();
            if (dtPacote != null && dtPacote.Rows.Count > 0)
            {
                this.cbbPacote.ValueMember = "codpacote";
                this.cbbPacote.DisplayMember = "pac_pacote";
                this.cbbPacote.DataSource = dtPacote;
            }
        }

        public void carregaCbbServico()
        {
            Controller.ServicoController servicoController = new Controller.ServicoController();

            DataTable dtServico = servicoController.retornaServico();
            if (dtServico != null && dtServico.Rows.Count > 0)
            {
                this.cbbServico.ValueMember = "codtiposervico";
                this.cbbServico.DisplayMember = "tiposerv_descricao";
                this.cbbServico.DataSource = dtServico;
            }
        }

        private void carregaDgvPacotesAdcinais(List<Entidades.TabelaPacotes> listPacoteAdc)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = listPacoteAdc;
            dgvPacote.DataSource = bd;
            dgvPacote.Refresh();

        }
        

        private void btnIncluirPacote_Click(object sender, EventArgs e)
        {
            Controller.PacoteController pacoteController = new Controller.PacoteController();
            Controller.ServicoController sc = new Controller.ServicoController();
            Entidades.Pacote _pacote = new Entidades.Pacote();
            Entidades.PacotesAdicionais _pacotesAdicionais = new Entidades.PacotesAdicionais();

            int intCodPacote = Convert.ToInt32(cbbPacote.SelectedValue.ToString());

            DataTable dtPacote = pacoteController.retornaObjPacote(intCodPacote);
            DataTable dtLista = pacoteController.retornaListaPacote(intCodPacote);
            DataRow drPacote = dtPacote.Rows[0];

            _pacote.carregaPacote(Convert.ToInt32(drPacote["codpacote"].ToString()), drPacote["pac_pacote"].ToString(),
                Convert.ToDouble(drPacote["pac_valor"].ToString()), drPacote["pac_obs"].ToString(), drPacote["pac_periodicidade"].ToString(), listaPacoteServico,
                Convert.ToDateTime(drPacote["pac_datainicio"].ToString()), Convert.ToDateTime(drPacote["pac_datafim"].ToString()));

            if (dtLista!=null && dtLista.Rows.Count > 0)
            {
                for(int i=0; i<dtLista.Rows.Count; i++)
                {
                    DataRow dr = dtLista.Rows[i];
                    Entidades.PacoteServico pac = new Entidades.PacoteServico();
                    Entidades.Servico serv = new Entidades.Servico();
                    DataTable dtServico = sc.retornaObjServico(Convert.ToInt32(dr["codtiposervico"].ToString()));
                    DataRow drServ = dtServico.Rows[0];
                    serv.Codigo = Convert.ToInt32(drServ["codtiposervico"].ToString());
                    serv.ServicoNome = drServ["tiposerv_descricao"].ToString();
                    serv.Observacao = drServ["tiposerv_obs"].ToString();
                    serv.Tempo = drServ["tiposerv_temposervico"].ToString();
                    serv.Valor = Convert.ToDouble(drServ["tiposerv_velor"].ToString());
                    pac.Pacote = _pacote;
                    pac.Servico = serv;
                    pac.Quantidade = Convert.ToInt32(dr["pacserv_qtde"].ToString());
                    pac.Periodicidade = dr["pacserv_periodicidade"].ToString();
                    listaPacoteServico.Add(pac);
                }
            }
            

            addListaTabela(listaPacoteServico);
            carregaDgvPacotesAdcinais(listaTabela);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addListaTabela(List<Entidades.PacoteServico> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {

                Entidades.TabelaPacotes tab = new Entidades.TabelaPacotes();
                tab.Codigo = lista.ElementAt(i).Servico.Codigo;
                tab.Descr = lista.ElementAt(i).Servico.ServicoNome;
                tab.Qtde = lista.ElementAt(i).Quantidade;
                tab.Tipo = lista.ElementAt(i).Pacote.PaccoteNome;
                listaTabela.Add(tab);

                carregaDgvPacotesAdcinais(listaTabela);
            }
        }

        private void btnIncluirServico_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.TabelaPacotes tab = new Entidades.TabelaPacotes();
                tab.Codigo = Convert.ToInt32(cbbServico.SelectedValue);
                tab.Descr = cbbServico.Text.ToString();

                if (string.IsNullOrWhiteSpace(ttbQtde.Text))
                    MessageBox.Show("Informe a quantidade do serviço.");
                else
                {
                    tab.Qtde = Convert.ToInt32(ttbQtde.Text.ToString());
                    tab.Tipo = "Adcional";
					listaTabela.Add(tab);
					carregaDgvPacotesAdcinais(listaTabela);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: "+ex);
                throw;
            }
            
           
            
        }

        private void btnExcluirServicoPac_Click(object sender, EventArgs e)
        {
            if (dgvPacote.Rows.Count > 0)
            {
                if (listaTabela.ElementAt(dgvPacote.CurrentRow.Index).Tipo == "Adcional")
                {
                    listaTabela.Remove(listaTabela.ElementAt(dgvPacote.CurrentRow.Index));
                    carregaDgvPacotesAdcinais(listaTabela);
                }
                else
                {
                    MessageBox.Show("Não pode excluit itens do pacote!");
                }
            }
        }
    }
}
