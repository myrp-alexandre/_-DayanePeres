using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class FechamentoModels
    {

        private DAO.FechamentoDAO fdao = new DAO.FechamentoDAO();

        public int gravarFechamento(Entidades.Fechamento obj)
        {
            return fdao.gravarFechamento(obj);
        }

        public int retornaMax()
        {
            return fdao.retornaMax();
        }
    }
}
