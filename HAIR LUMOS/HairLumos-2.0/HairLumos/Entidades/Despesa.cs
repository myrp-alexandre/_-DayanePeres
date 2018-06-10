using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Despesa
    {
        private int _cod;
        private string _descricao;
        private string _status;

        private string _erro;

        public Despesa(int cod, string descricao, string status)
        {
            this.carregaDespesa(cod, descricao, status);
        }

        public Despesa()
        {
            this.carregaDespesa(0, string.Empty, string.Empty);
        }

        public int Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }


        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status= value; }
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public void carregaDespesa(int cod, string descricao, string status)
        {
            this.Codigo = cod;
            this.Descricao = descricao;
            this.Status = status;
        }
    }
}
