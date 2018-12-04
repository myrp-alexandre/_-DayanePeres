using System;
using System.Collections.Generic;
using System.Data;
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

        public int excluiComissao(Entidades.Comissao comissao)
        {
            return _DAOComissao.excluiComissao(comissao);
        }

        public int retornaMax()
        {
            return _DAOComissao.retornaMax();
        }

        public DataTable retornaComissao(int cod)
        {
            return _DAOComissao.retornaComissao(cod);
        }

        public DataTable retornaGeral(int cod, string status, string dataI, string dataF)
        {
            return _DAOComissao.retornaGeral(cod, status, dataI, dataF);
        }

        public int atualizaComissao(Entidades.Comissao obj)
        {
            return _DAOComissao.atualizaComissao(obj);
        }
    }
}
