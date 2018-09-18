using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Contrato
    {
        private int codigo;
        private DateTime data;
        private string obs;
        private Pacote pacote;
        private PessoaFisica pessoaFisica;
        private double _valor;
        

        private List<Entidades.PacotesAdicionais> lista;

        public Contrato()
        {
            lista = new List<PacotesAdicionais>();
            pessoaFisica = new PessoaFisica();
            pacote = new Pacote();
        }

        public int Codigo { get; set; }
        public string Observacao { get; set; }
        public DateTime DataContrato{ get; set;}
        public Pacote Pacote { get; set; }
        public PessoaFisica CodigoPessoa { get; set; }
        public double Valor { get; set; }
        

        public List<Entidades.PacotesAdicionais> Lista { get; set; }
    }
}
