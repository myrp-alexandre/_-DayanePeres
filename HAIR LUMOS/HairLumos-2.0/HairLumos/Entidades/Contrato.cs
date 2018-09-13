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
        private string obs;
        private DateTime data;
        private Pessoa pessoa;
        private Pacote pacote;

        private List<Entidades.PacotesAdicionais> lista;

        public Contrato()
        {
            lista = new List<PacotesAdicionais>();
            pessoa = new Pessoa();
            pacote = new Pacote();
        }

        public int Codigo { get; set; }
        public string Observacao { get; set; }
        public DateTime DataContrato{ get; set;}
        public Pacote Pacote { get; set; }
        public Pessoa Pessoa { get; set; }
        public List<Entidades.PacotesAdicionais> Lista { get; set; }
    }
}
