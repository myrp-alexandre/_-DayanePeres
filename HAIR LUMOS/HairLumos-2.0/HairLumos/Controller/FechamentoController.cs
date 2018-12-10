using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class FechamentoController
    {
        private Models.FechamentoModels _MdlFechamento = new Models.FechamentoModels();

        public int gravarFechamento(Entidades.Pessoa pessoa, double total)
        {
            Entidades.Fechamento obj = new Entidades.Fechamento();
            obj.Codigo = retornaMax() + 1;
            obj.Valor = total;
            obj.Status = "aberta";
            obj.Pes = pessoa;
            obj.DtAbertura = DateTime.Now;
            obj.DtPagamento = DateTime.MaxValue;

            return _MdlFechamento.gravarFechamento(obj);
        }

        public int retornaMax()
        {
            return _MdlFechamento.retornaMax();
        }
    }
}
