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
        private Comissao comissao;
        private ServicoParceiro servparc;
        private Fechamento fechamento;
        private string funcionario;
        private string servico;

        public Agenda()
        {
            pes = new Pessoa();
            comissao = new Comissao();
            servparc = new ServicoParceiro();
            fechamento = new Fechamento();
        }

        public int Codigo { get; set; }
        public Pessoa Pes { get; set; }
        public DateTime DtAgendamento { get; set; }
        public string Hora { get; set; }
        public string Status { get; set; }
        public double Valor { get; set; }
        public Comissao Comissao { get; set; }
        public ServicoParceiro ServicoParceiro { get; set; }
        public Fechamento Fechamento { get; set; }
        public string Funcionario { get; set; }
        public string Servico { get; set; }

    }
}
