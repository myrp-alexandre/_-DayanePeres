using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HairLumos.Views.Funcoes_Fundamentais.RF_F2_Agenda
{
    public partial class Agenda : Form
    {

        private Controller.PessoaController pc = new Controller.PessoaController();
        private Controller.AgendaController ac = new Controller.AgendaController();
        private Controller.ServicoController sc = new Controller.ServicoController();
        private List<Entidades.Agenda> listaAgendamentos = new List<Entidades.Agenda>();
        public string Data { get; set; }
        public int CodFunc { get; set; }
        public string Horas { get; set; }

        public Agenda()
        {
            InitializeComponent();
            dgvAgendamento.AutoGenerateColumns = false;
            criaLista();
            carregaDGV();
            carregaFuncionario();
            atualiza();
        }

        private void carregaFuncionario()
        {
            DataTable dtFuncionario = pc.retornaPessoaJuridica();
            cbbFuncionario.DataSource = dtFuncionario;
            cbbFuncionario.ValueMember = "codpessoa";
            cbbFuncionario.DisplayMember = "pes_nome";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Views.Funcoes_Fundamentais.RF_F2_Agendamento.ControlarAgendamento teste = new RF_F2_Agendamento.ControlarAgendamento();
            teste.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void criaLista()
        {
            int i = 9;
            while (i <= 18)
            {
                string horas = "";
                Entidades.Agenda a = new Entidades.Agenda();
                if (i < 10)
                    horas = "0" + i + ":00";
                else
                    horas = i + ":00";
                a.Hora = Convert.ToDateTime(horas).ToString("HH:mm");
                listaAgendamentos.Add(a);
                if (i < 20)
                {
                    a = new Entidades.Agenda();
                    if (i < 10)
                        horas = "0" + i + ":30";
                    else
                        horas = i + ":30";
                    a.Hora = Convert.ToDateTime(horas).ToString("HH:mm");
                    listaAgendamentos.Add(a);
                }
                i++;
            }
        }

        public void carregaDGV()
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = listaAgendamentos;
            dgvAgendamento.DataSource = bd;
            dgvAgendamento.Refresh();
        }

        private void cbbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entidades.PessoaJuridica pj = new Entidades.PessoaJuridica();
            if (!String.IsNullOrEmpty(Data))
            {
                DataTable dtP = pc.retornaPessoaJuridicaCod(Convert.ToInt32(cbbFuncionario.SelectedValue));
                if (dtP != null && dtP.Rows.Count > 0)
                {

                    DataRow drPJuridica = dtP.Rows[0];
                    pj.Codigo = Convert.ToInt32(drPJuridica["codpessoa"].ToString());
                    pj.RazaoSocial = drPJuridica["jur_razaosocial"].ToString();
                    pj.CNPJ = drPJuridica["jur_cnpj"].ToString();
                }
                atualiza();
            }
        }

        private void mtcData_DateChanged(object sender, DateRangeEventArgs e)
        {
            atualiza();
        }

        private void atualiza()
        {
            listaAgendamentos = new List<Entidades.Agenda>();
            criaLista();
            Data = mtcData.SelectionStart.ToString();
            int codigo = 0;
            codigo = Convert.ToInt32(cbbFuncionario.SelectedValue);
            Data = Convert.ToDateTime(Data).ToString("dd/MM/yyyy");
            Entidades.Pessoa p = new Entidades.Pessoa();
            Entidades.ServicoParceiro s = new Entidades.ServicoParceiro();
            Entidades.PessoaJuridica pj = new Entidades.PessoaJuridica();
            DataTable dtP = pc.retornaPessoaJuridicaCod(Convert.ToInt32(cbbFuncionario.SelectedValue));
            if (dtP != null && dtP.Rows.Count > 0)
            {

                DataRow drPJuridica = dtP.Rows[0];
                pj.Codigo = Convert.ToInt32(drPJuridica["codpessoa"].ToString());
                pj.RazaoSocial = drPJuridica["jur_razaosocial"].ToString();
                pj.CNPJ = drPJuridica["jur_cnpj"].ToString();
            }

            if (cbbFuncionario.ValueMember != null)
            {
                DataTable dtAgenda = ac.buscaAgenda(pj.CNPJ, Data);
                if (dtAgenda != null && dtAgenda.Rows.Count > 0)
                {
                    for (int i = 0; i < dtAgenda.Rows.Count; i++)
                    {
                        DataRow dr = dtAgenda.Rows[i];
                        int j = 0;
                        while (j < listaAgendamentos.Count)
                        {
                            if (Convert.ToDateTime(dr["agen_horaagendamento"].ToString()).ToString("HH:mm").Equals(listaAgendamentos.ElementAt(j).Hora))
                            {
                                listaAgendamentos.ElementAt(j).Codigo = Convert.ToInt32(dr["codagenda"].ToString());
                                DataTable dtPessoa = pc.retornaPessoaCod(dr["codpessoa"].ToString());
                                if (dtPessoa != null && dtPessoa.Rows.Count > 0)
                                {
                                    DataRow drPessoa = dtPessoa.Rows[0];
                                    p.Codigo = Convert.ToInt32(dr["codpessoa"].ToString());
                                    p.Nome = drPessoa["pes_nome"].ToString();
                                    p.DataCadastro = Convert.ToDateTime(drPessoa["pes_datacadastro"].ToString());
                                    p.TipoPessoa = drPessoa["pes_tipopessoa"].ToString();
                                    p.StatusPessoa = Convert.ToBoolean(drPessoa["pes_statuspessoa"].ToString());
                                    p.Observacao = drPessoa["pes_obs"].ToString();
                                    p.Fiado = Convert.ToBoolean(drPessoa["pes_fiado"].ToString());
                                    p.Email = drPessoa["pes_email"].ToString();
                                    p.Telefone = drPessoa["pes_fone"].ToString();
                                    p.Celular = drPessoa["pes_cel"].ToString();
                                }
                                listaAgendamentos.ElementAt(j).Pes = p;
                                listaAgendamentos.ElementAt(j).DtAgendamento = Convert.ToDateTime(dr["agen_dataagendamento"].ToString());
                                listaAgendamentos.ElementAt(j).Status = dr["agen_status"].ToString();
                                listaAgendamentos.ElementAt(j).Valor = Convert.ToDouble(dr["agen_valor"].ToString());
                                listaAgendamentos.ElementAt(j).Comissao = null;
                                DataTable dtServico = sc.retornaServParc(pj.Codigo, Convert.ToInt32(dr["codtiposervico"].ToString()));
                                if (dtServico != null && dtServico.Rows.Count > 0)
                                {

                                    Entidades.Servico sv = new Entidades.Servico();
                                    Entidades.PessoaJuridica pes = new Entidades.PessoaJuridica();
                                    DataRow drServParc = dtServico.Rows[0];
                                    DataTable dtS = sc.retornaServicoCod(Convert.ToInt32(dr["codtiposervico"].ToString()));
                                    if (dtS != null && dtS.Rows.Count > 0)
                                    {

                                        DataRow drS = dtS.Rows[0];
                                        sv.Codigo = Convert.ToInt32(drS["codtiposervico"].ToString());
                                        sv.ServicoNome = drS["tiposerv_descricao"].ToString();
                                        sv.Observacao = drS["tiposerv_obs"].ToString();
                                        sv.Valor = Convert.ToDouble(drS["tiposerv_valor"].ToString());
                                        sv.Tempo = drS["tiposerv_temposervico"].ToString();
                                    }
                                    s.PessoaJuridica = pj;
                                    s.Servico = sv;
                                    s.Valor = Convert.ToInt32(drServParc["prestserv_valor"].ToString());
                                    s.Percentual = Convert.ToDouble(drServParc["prestserv_percentual"].ToString());
                                    s.PagamentoRecebido = drServParc["prestser_pagrec"].ToString();
                                    s.Estado = Convert.ToBoolean(drServParc["estado"].ToString());
                                }
                                listaAgendamentos.ElementAt(j).Servico = s.Servico.ServicoNome;
                                listaAgendamentos.ElementAt(j).Funcionario = s.PessoaJuridica.RazaoSocial;
                                listaAgendamentos.ElementAt(j).ServicoParceiro = s;
                                listaAgendamentos.ElementAt(j).Fechamento = null;
                                listaAgendamentos.ElementAt(j).Codigo = Convert.ToInt32(dr["codagenda"].ToString());
                            }
                            j++;
                        }
                    }
                }
                carregaDGV();
            }
        }

        private void dgvAgendamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cbbFuncionario.SelectedValue!=null)
                this.CodFunc = Convert.ToInt32(cbbFuncionario.SelectedValue);
            this.Data = Convert.ToDateTime(mtcData.SelectionStart.ToString()).ToString("dd/MM/yyyy");
            if (dgvAgendamento.SelectedRows.Count > 0)
                this.Horas = listaAgendamentos.ElementAt(dgvAgendamento.CurrentRow.Index).Hora;

            Views.Funcoes_Fundamentais.RF_F2_Agendamento.ControlarAgendamento agendar = new RF_F2_Agendamento.ControlarAgendamento(this.CodFunc, this.Data, this.Horas);
            agendar.ShowDialog();

            atualiza();
            

        }

        private void dgvAgendamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow r = dgvAgendamento.Rows[e.RowIndex];
            if (listaAgendamentos.ElementAt(e.RowIndex).Status=="Agendado")
                r.DefaultCellStyle.BackColor = Color.DarkCyan;
            if (listaAgendamentos.ElementAt(e.RowIndex).Status == "Confirmado")
                r.DefaultCellStyle.BackColor = Color.SeaGreen;
            if (listaAgendamentos.ElementAt(e.RowIndex).Status == "Cancelado")
                r.DefaultCellStyle.BackColor = Color.IndianRed;
            if (listaAgendamentos.ElementAt(e.RowIndex).Status == "Não Compareceu")
                r.DefaultCellStyle.BackColor = Color.Goldenrod;

        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Controller.AgendaController ac = new Controller.AgendaController();
            Entidades.Agenda a = listaAgendamentos.ElementAt(dgvAgendamento.CurrentRow.Index);
            a.Status = "Confirmado";
            ac.atualizaStatus(a);
            listaAgendamentos.ElementAt(dgvAgendamento.CurrentRow.Index).Status = "Confirmado";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Controller.AgendaController ac = new Controller.AgendaController();
            Controller.ComissaoController cc = new Controller.ComissaoController();
            Entidades.Agenda a = listaAgendamentos.ElementAt(dgvAgendamento.CurrentRow.Index);
            a.Status = "Cancelado";
            Entidades.Comissao com = new Entidades.Comissao();
            com.CodigoComissao = ac.retornaComissao(a);
            cc.excluiComissao(com);
            a.Comissao = new Entidades.Comissao();
            ac.atualizaStatus(a);
            listaAgendamentos.ElementAt(dgvAgendamento.CurrentRow.Index).Status = "Cancelado";
        }

        private void btnNComprareceu_Click(object sender, EventArgs e)
        {
            Controller.AgendaController ac = new Controller.AgendaController();
            Controller.ComissaoController cc = new Controller.ComissaoController();
            Entidades.Agenda a = listaAgendamentos.ElementAt(dgvAgendamento.CurrentRow.Index);
            a.Status = "Não Compareceu";
            cc.excluiComissao(a.Comissao);
            a.Comissao = new Entidades.Comissao();
            ac.atualizaStatus(a);
            listaAgendamentos.ElementAt(dgvAgendamento.CurrentRow.Index).Status = "Não Compareceu";
        }

    }
}
