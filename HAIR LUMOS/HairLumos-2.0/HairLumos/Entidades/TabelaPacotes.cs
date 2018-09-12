using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class TabelaPacotes
    {
        private int codigo;
        private string descr;
        private int qtde;
        private string tipo;

        public TabelaPacotes()
        {
        }

        public int Codigo { get; set; }

        public string Descr { get; set; }

        public int Qtde { get; set; }

        public string Tipo { get; set; }

		public static explicit operator TabelaPacotes(string v)
		{
			throw new NotImplementedException();
		}
	}
}
