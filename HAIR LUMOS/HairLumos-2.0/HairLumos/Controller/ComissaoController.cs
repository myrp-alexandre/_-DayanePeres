using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Controller
{
    class ComissaoController
    {
        Models.ComissaoModel cm = new Models.ComissaoModel();

        public int gravaComissao(Entidades.Comissao obj)
        {
            return cm.gravarComissao(obj);
        }

        public int excluiComissao(Entidades.Comissao obj)
        {
            return cm.excluiComissao(obj);
        }

        public int retornaMax()
        {
            return cm.retornaMax();
        }

        public DataTable retornaComissao(int cod)
        {
            return cm.retornaComissao(cod);
        }

        public DataTable retornaGeral(int cod, string status, string dataI, string dataF)
        {
            return cm.retornaGeral(cod, status, dataI, dataF);
        }

        public int atualizaComissao(Entidades.Comissao obj)
        {
            return cm.atualizaComissao(obj);
        }
    }
}
