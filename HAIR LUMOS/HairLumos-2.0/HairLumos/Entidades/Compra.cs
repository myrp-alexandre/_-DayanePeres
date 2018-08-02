using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Compra
    {
        private int codigo;
        private Despesa despesa;
        private DateTime data;
        private Boolean situacao;
        private Boolean consignado;
        private double valorTotal;
        private string obs;
        private PessoaJuridica pessoa;

        public Compra()
        {
            this.despesa = new Despesa();
            this.pessoa = new PessoaJuridica();
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Despesa Despesa
        {
            get { return despesa; }
            set { despesa = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public Boolean Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public Boolean Consignado
        {
            get { return consignado; }
            set { consignado = value; }
        }

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        public PessoaJuridica PJ
        {
            get { return pessoa; }
            set { pessoa = value; }
        }

        public override string ToString()
        {
            return this.codigo.ToString();
        }
    }
}
