using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Entidades
{
    class Categoria
    {
        //TBCategoria
        private int _cod;
        private string _categoria;
        private string _obs;

        public string _erro;

        public Categoria(int cod, string categoria, string obs)
        {
            this.carregaCategoria(cod, categoria, obs);
        }

        public Categoria()
        {
            this.carregaCategoria(0, string.Empty, string.Empty);
        }

        public string Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public int Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }

        public string CategoriaNome
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public string Observacao
        {
            get { return _obs; }
            set { _obs = value; }
        }

        public void carregaCategoria(int cod, string categoria, string obs)
        {
            this.Codigo = cod;
            this.CategoriaNome = categoria;
            this.Observacao = obs;
        }
    }
}
