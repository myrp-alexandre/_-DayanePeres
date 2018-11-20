﻿using System;
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
            if (!String.IsNullOrEmpty(Data))
            {
                DataTable dtAgenda = ac.buscaAgenda(Convert.ToInt32(cbbFuncionario.ValueMember), Data);
            }
        }

        private void mtcData_DateChanged(object sender, DateRangeEventArgs e)
        {
            Data = mtcData.SelectionStart.ToString();
            int codigo = 0;
            codigo = Convert.ToInt32(cbbFuncionario.SelectedValue);
            Data = Convert.ToDateTime(Data).ToString("dd/MM/yyyy");
            Entidades.Pessoa p = new Entidades.Pessoa();
            Entidades.Servico s = new Entidades.Servico();
            Entidades.PessoaJuridica pj = new Entidades.PessoaJuridica();
            if (cbbFuncionario.ValueMember != null)
            {
                DataTable dtAgenda = ac.buscaAgenda(codigo, Data);
                if(dtAgenda!=null && dtAgenda.Rows.Count > 0)
                {
                    for(int i =0; i<dtAgenda.Rows.Count; i++)
                    {
                        DataRow dr = dtAgenda.Rows[i];
                        int j = 0;
                        while (j < listaAgendamentos.Count) {
                            if (Convert.ToDateTime(dr["agen_horaagendamento"].ToString()).ToString("HH:mm").Equals(listaAgendamentos.ElementAt(j).Hora))
                            {
                                listaAgendamentos.ElementAt(j).Codigo = Convert.ToInt32(dr["codagenda"].ToString());
                                DataTable dtPessoa = pc.retornaPessoaCod(dr["codpessoa"].ToString());
                                if (dtPessoa!=null && dtPessoa.Rows.Count>0)
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
                                DataTable dtServico = sc.retornaObjServico(Convert.ToInt32(dr["codtiposervico"].ToString()));
                                if (dtServico!=null && dtServico.Rows.Count>0)
                                {
                                    DataRow drServico = dtServico.Rows[0];
                                    s.Codigo = Convert.ToInt32(drServico["codtiposervico"].ToString());
                                    s.ServicoNome = drServico["tiposerv_descricao"].ToString();
                                    s.Observacao = drServico["tiposerv_obs"].ToString();
                                    s.Valor = Convert.ToDouble(drServico["tiposerv_valor"].ToString());
                                    s.Tempo = drServico["tiposerv_temposervico"].ToString();
                                }
                                listaAgendamentos.ElementAt(j).Servico = s;
                                DataTable dtJuridica = pc.retornaPessoaJuridicaCnpj(dr["jur_cnpj"].ToString());
                                if (dtJuridica!=null && dtJuridica.Rows.Count>0)
                                {
                                    DataRow drJuridica = dtJuridica.Rows[0];
                                    pj.Codigo = Convert.ToInt32(drJuridica["codpessoa"].ToString());
                                    pj.CNPJ = drJuridica["jur_cnpj"].ToString();
                                    pj.Nome = drJuridica["pes_nome"].ToString();
                                    pj.RazaoSocial = drJuridica["jur_razaosocial"].ToString();
                                }
                                listaAgendamentos.ElementAt(j).Funcionario = pj;
                                listaAgendamentos.ElementAt(j).Fechamento = null;
                            }
                            j++;
                        }
                    }
                }
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

        }
    }
}
