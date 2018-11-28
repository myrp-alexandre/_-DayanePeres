using System;
using System.Collections.Generic;
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
    }
}
