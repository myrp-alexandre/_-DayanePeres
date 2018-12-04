using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class TabelaComissao
    {
        private DateTime data;
        private double valor;
        private string status;
        private string pagamento;
        private string nome;
        private int codComis;

        public TabelaComissao()
        {
        }

        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public string Status { get; set; }
        public string Pagamento { get; set; }
        public string Nome { get; set; }
        public int CodComis { get; set; }
    }
}
