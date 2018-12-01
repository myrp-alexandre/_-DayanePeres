using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HairLumos.Entidades
{
    class TabelaFormaPagamento
    {
        private FormaPagamento _froma;
        private double _valor;

        public TabelaFormaPagamento() {}

        public FormaPagamento Forma { get; set; }
        public double Valor { get; set; }
    }
}