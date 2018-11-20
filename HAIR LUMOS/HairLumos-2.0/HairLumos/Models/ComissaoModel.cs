using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairLumos.Models
{
    class ComissaoModel
    {

        DAO.ComissaoDAO _DAOComissao = new DAO.ComissaoDAO();

        public int gravarComissao(Entidades.Comissao comissao)
        {
            return _DAOComissao.gravarComissao(comissao);
        }
    }
}
