using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Agenda
    {
        private int codigo;
        private Pessoa pes;
        private DateTime dtAgendamento;
        private string hora;
        private string status;
        private double valor;
        private PessoaJuridica funcionario;
        private Comissao comissao;
        private Servico servico;
        private Fechamento fechamento;

        public Agenda()
        {
            pes = new Pessoa();
            funcionario = new PessoaJuridica();
            comissao = new Comissao();
            servico = new Servico();
            fechamento = new Fechamento();
        }

        public int Codigo { get; set; }
        public Pessoa Pes { get; set; }
        public DateTime DtAgendamento { get; set; }
        public string Hora { get; set; }
        public string Status { get; set; }
        public double Valor { get; set; }
        public PessoaJuridica Funcionario { get; set; }
        public Comissao Comissao { get; set; }
        public Servico Servico { get; set; }
        public Fechamento Fechamento { get; set; }

    }
}
